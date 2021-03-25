import React from "react";
import { Map, GoogleApiWrapper, Marker } from "google-maps-react";
import mapStyles from '../../styles/mapStyles';
import Geocode from 'react-geocode';
import { connect } from 'react-redux';
import { FaSearch } from 'react-icons/fa';
import ParkingAreaInfo from "../info/ParkingAreaInfo";

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
    }

    constructor(props) {
        super(props);

        this.mapRef = React.createRef();

        this.getUserLocation = this.getUserLocation.bind(this);
        this.handleChange = this.handleChange.bind(this);
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

    setMarkers() {
        this.props.parkingAreas.map((area) => this.getCoordinates(area.address).then((result) => {
            this.setState({
                markers: [...this.state.markers, result]
            })
        }));
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

    componentDidMount() {
        this.getUserLocation();
        this.setMarkers();
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
                                    this.props.parkingAreas
                                        .filter(({ address }) => (address.toLowerCase()).includes(this.state.search.toLowerCase()))
                                        .map((area, index) => {
                                            return (
                                                <li className="search-area list-group-item"
                                                    key={index}
                                                    onClick={() => this.setCenter(area.address)}
                                                >
                                                    {area.address}
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
                            this.state.markers.map((marker, index) => {
                                return <Marker key={index} position={marker} />
                            })
                        }
                        {
                            this.state.isInfoClicked && (
                                <ParkingAreaInfo parkingArea={this.state.search} />
                            )
                        }
                    </Map>
                </section>
            </div >
        )
    }
}

const mapStateToProps = state => {
    return {
        parkingAreas: state.parkingAreas
    };
}

export default connect(mapStateToProps)(GoogleApiWrapper({
    apiKey: process.env.REACT_APP_GOOGLE_MAPS_API_KEY,
    libraries: ["places"]
})(HomeContainer));