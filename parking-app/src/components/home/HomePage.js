import React from "react";
import { Map, GoogleApiWrapper, Marker } from "google-maps-react";
import mapStyles from './mapStyles';
import Geocode from 'react-geocode';
import { connect } from 'react-redux';
import { FaSearch } from 'react-icons/fa';
import ParkingAreaInfo from "../info/ParkingAreaInfo";
import * as actionCreators from '../../store/actions/index';
import Dialog from '@material-ui/core/Dialog';
import Reservation from '../reservation/Reservation';
import { Modal } from "react-bootstrap";
import { Link } from 'react-router-dom';
import './HomePage.css';

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

    handleReserve = () => { this.setState({ isReservationClicked: true, isInfoClicked: false }) }

    closeReserve = () => { this.setState({ isReservationClicked: false, zoom: 12, search: '' }) }

    handleAuthClose = () => { this.setState({ isAuthRequired: false }) }

    componentDidMount() {
        this.getUserLocation();
        this.props.onInitParkingAreas();
    }

    render() {
        return (
            <div className="home-container">
                <section className="container">
                    <form className="form-inline justify-content-center m-2">
                        <div className="input-group w-100">
                            <div className="input-group-prepend">
                                <div className="form-icon input-group-text">
                                    <FaSearch color='cornflowerblue' />
                                </div>
                            </div>
                            <input
                                type="text"
                                className="form-control form-control-underlined form-control-sm"
                                onChange={this.handleChange}
                                placeholder="Introduceti adresa"
                                value={this.state.search}
                            />
                        </div>
                    </form>
                </section>
                {this.state.isSuggestionDisplay && this.state.search !== '' && (
                    <section>
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
                    </section>
                )}
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
                        // this.props.isLoggedIn ?
                        <Dialog open={this.state.isReservationClicked} scroll='body'>
                            <Reservation onClose={() => { this.props.onCancelParkinArea(); this.closeReserve() }} />
                        </Dialog>
                        // : <Modal show={this.state.isAuthRequired} centered onHide={this.handleAuthClose}>
                        //     <Modal.Header closeButton>
                        //         <Modal.Title>Autentificare necesara</Modal.Title>
                        //     </Modal.Header>
                        //     <Modal.Body><Link to="/profile">Autentificati-va</Link> pentru a rezerva un loc de parcare.</Modal.Body>
                        // </Modal>
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
        isLoggedIn: state.user.isLoggedIn,
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