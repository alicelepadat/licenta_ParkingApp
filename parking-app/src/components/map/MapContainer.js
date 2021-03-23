import React from "react";
import { Map, GoogleApiWrapper, Marker, InfoWindow } from "google-maps-react";
import mapStyles from './mapStyles';
import Geocode from 'react-geocode';
import { FaSadTear } from 'react-icons/fa';
import { connect } from 'react-redux';

Geocode.setApiKey(process.env.REACT_APP_GOOGLE_MAPS_API_KEY);

class MapContainer extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            currentLocation: { lat: 0, lng: 0 },
            markers: [],
            isParkingArea: false
        }

        this.getLocation = this.getLocation.bind(this);
        this.getCurrentLocation = this.getCurrentLocation.bind(this);
        this.getCoordinates = this.getCoordinates.bind(this);
        this.getAddress = this.getAddress.bind(this);

    }

    getLocation = () => {
        if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(this.getCurrentLocation);
        }
        else {
            alert("Geolocation is not supported in this browser.")
        }
    }

    getCurrentLocation(position) {
        this.setState({
            currentLocation: {
                lat: position.coords.latitude,
                lng: position.coords.longitude,
            }
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

    async getAddress(coordinates) {
        if (coordinates.lat && coordinates.lng) {
            const response = await Geocode.fromLatLng(coordinates.lat.toString(), coordinates.lng.toString())
            const address = await response.results[0].formatted_address;
            address.includes('București') ? this.setState({ isParkingArea: true }) : this.setState({ isParkingArea: false })
        }
    }

    setMarkers() {
        this.props.parkingAreas.map((area) => this.getCoordinates(area.address).then(result => {
            this.setState({
                markers: [...this.state.markers, result]
            })
        }));
    }

    componentDidMount() {
        this.getLocation();
        this.setMarkers();
    }

    render() {
        return (
            <div className="map-container">
                <Map
                    google={this.props.google}
                    zoom={12}
                    center={this.state.currentLocation}
                    styles={mapStyles}
                    disableDefaultUI={true}
                    zoomControl={true}
                >
                    {
                        this.state.currentLocation.lat !== 0 && this.state.currentLocation.lng !== 0 &&
                        <Marker position={this.state.currentLocation} />
                    }
                    {
                        this.state.isParkingArea ? null :
                            <InfoWindow position={this.state.currentLocation} visible={true}>
                                <div className="outside-card card text-center">
                                    <div className="card-body">
                                        <h5 className="card-title"><FaSadTear /></h5>
                                        <p className="card-text">Nu sunt zone de parcare in apropierea dvs.</p>
                                    </div>
                                </div>
                            </InfoWindow>
                    }
                    {
                        this.state.markers.map((marker, index) => {
                            return <Marker key={index} position={marker}
                                icon={{
                                    url: 'https://www.aligned-assets.co.uk/site/wp-content/uploads/2019/12/Commercial_Parking_CT03.png',
                                    anchor: new window.google.maps.Point(17, 46),
                                    scaledSize: new window.google.maps.Size(30, 36)
                                }} />
                        })
                    }
                </Map>
            </div>
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
})(MapContainer));