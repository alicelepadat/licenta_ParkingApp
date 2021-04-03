import React from "react";
import { Map, GoogleApiWrapper, Marker } from "google-maps-react";
import Geocode from 'react-geocode';

import Dialog from '@material-ui/core/Dialog';
import IconButton from '@material-ui/core/IconButton';
import DialogActions from '@material-ui/core/DialogActions';
import { Button, InputGroup, FormControl } from 'react-bootstrap';
import CloseIcon from '@material-ui/icons/Close';
import { RiUserLocationFill } from 'react-icons/ri';

import mapStyles from './mapStyles';
import './HomePage.css';

import ParkingAreaInfo from "../info/ParkingAreaInfo";
import Reservation from '../reservation/Reservation';
import Authenticate from "../authentication/Authenticate";

import * as actionCreators from '../../store/actions/index';
import { connect } from 'react-redux';

Geocode.setApiKey(process.env.REACT_APP_GOOGLE_MAPS_API_KEY);

class HomeContainer extends React.Component {

    state = {
        markers: [],
        initialCenter: { lat: 44.439663, lng: 26.096306 },
        center: {},
        userLocation: { lat: null, lng: null },
        zoom: 12,
        search: '',
        isSuggestionDisplay: false,
        isInfoClicked: false,
        isReservationClicked: false,
        isAuthRequired: true,
    }

    constructor(props) {
        super(props);

        this.getUserLocation = this.getUserLocation.bind(this);
        this.handleChange = this.handleChange.bind(this);
        this.handleInfoClose = this.handleInfoClose.bind(this);
    }

    handleChange(event) {
        this.setState({ search: event.target.value, isSuggestionDisplay: true, zoom: 12, isInfoClicked: false });
    }

    getUserLocation = () => {
        navigator.geolocation.getCurrentPosition(({ coords: { latitude: lat, longitude: lng } }) => {
            this.setState({ center: { lat, lng }, userLocation: { lat, lng } })
        })
    }

    async getCoordinates(address) {
        try {
            const response = await Geocode.fromAddress(address);
            return response.results[0].geometry.location;
        }
        catch (error) {
            console.error(error);
        }
    }

    locateUser(address) {
        this.setState({ center: address, zoom: 12 });
    }

    setCenter(address) {
        this.getCoordinates(address).then((result) => {
            this.setState({
                zoom: 16,
                center: result,
                search: address,
                isSuggestionDisplay: false,
                isInfoClicked: true
            })
        })
    }

    handleInfoClose() { this.setState({ isInfoClicked: false, zoom: 12, search: '' }); }

    handleReserve = () => { this.setState({ isReservationClicked: true, isInfoClicked: false, isAuthRequired: true }) }

    closeReserve = () => { this.setState({ isReservationClicked: false, zoom: 12, search: '' }) }

    closeAuth = () => { this.setState({ isAuthRequired: false, isInfoClicked: true }) }

    componentDidMount() {
        this.getUserLocation();
        this.props.onInitParkingAreas();
    }


    render() {
        return (
            <div className="home-container">
                <div className="container">
                    <InputGroup className="m-2">
                        <FormControl
                            placeholder="Introduceti adresa."
                            aria-label="Introduceti adresa"
                            value={this.state.search}
                            className="form-control-underlined"
                            onChange={this.handleChange}
                        />
                        <InputGroup.Append className="ml-2">
                            <Button type="button" className="btn btn-danger rounded-circle"
                                onClick={() => { this.locateUser(this.state.userLocation) }}>
                                <RiUserLocationFill />
                            </Button>
                        </InputGroup.Append>
                    </InputGroup>
                </div>
                {
                    this.state.isSuggestionDisplay && this.state.search !== '' && (
                        <div className="container">
                            <ul className="list-group list-group-flush">
                                {
                                    !this.props.isError && this.props.parkingAreas
                                        .filter((area) => (area.address.street.toLowerCase()).includes(this.state.search.toLowerCase()))
                                        .map((area, index) => {
                                            return (
                                                <li className="search-area list-group-item"
                                                    key={index}
                                                    onClick={() => {
                                                        this.setCenter(area.address.street);
                                                        this.props.onSelectedParkingArea(area);
                                                    }}
                                                >
                                                    {area.address.street}
                                                </li>
                                            );
                                        })
                                }
                            </ul>
                        </div>
                    )
                }
                <section className="map-container">
                    <Map
                        google={this.props.google}
                        zoom={this.state.zoom}
                        initialCenter={this.state.initialCenter}
                        center={this.state.center}
                        styles={mapStyles}
                        disableDefaultUI={true}
                        zoomControl={true}
                        ref={this.mapRef}
                    >
                        {
                            this.state.userLocation.lat && this.state.userLocation.lng &&
                            <Marker position={this.state.userLocation} />
                        }
                        {
                            this.props.parkingAreas !== null && (
                                this.props.parkingAreas.map((area, index) => {
                                    return <Marker key={index}
                                        position={{ lat: area.address.coordinates.latitude, lng: area.address.coordinates.longitude, }}
                                        onClick={() => {
                                            this.setCenter(area.address.street);
                                            this.props.onSelectedParkingArea(area);
                                        }} />
                                })
                            )
                        }
                    </Map>
                </section>
                {
                    this.state.isInfoClicked && (
                        <ParkingAreaInfo handleClose={() => { this.handleInfoClose(); this.props.onCancelParkinArea(); }} onReserve={this.handleReserve} />
                    )
                }
                {
                    this.state.isReservationClicked && (
                        this.props.isLoggedIn ?
                            <Dialog fullWidth={true} maxWidth={'md'} open={this.state.isReservationClicked} scroll='body'>
                                <Reservation onClose={() => { this.props.onCancelParkinArea(); this.closeReserve() }} />
                            </Dialog>
                            : <Dialog open={this.state.isAuthRequired}>
                                <DialogActions>
                                    <IconButton size="small" aria-label="close" color="inherit" onClick={this.closeAuth}>
                                        <CloseIcon fontSize="small" />
                                    </IconButton>
                                </DialogActions>
                                <Authenticate />
                            </Dialog>
                    )
                }
            </div >
        )
    }
}

const mapStateToProps = state => {
    return {
        selectedArea: state.parkingAreas.selectedArea,
        parkingAreas: state.parkingAreas.parkingAreas,
        isError: state.parkingAreas.isError,
        isLoggedIn: state.auth.isLoggedIn,
    };
}

const mapDispatchToProps = dispatch => {
    return {
        onInitParkingAreas: () => dispatch(actionCreators.initParkingAreas()),
        onSelectedParkingArea: (selectedArea) => dispatch(actionCreators.selectArea(selectedArea)),
        onCancelParkinArea: () => dispatch(actionCreators.unselectArea()),
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(GoogleApiWrapper({
    apiKey: process.env.REACT_APP_GOOGLE_MAPS_API_KEY,
    libraries: ["places"]
})(HomeContainer));