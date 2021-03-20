import React from "react";
import { Map, GoogleApiWrapper, Marker, InfoWindow } from "google-maps-react";
import mapStyles from './mapStyles';

class MapContainer extends React.Component {
    constructor() {
        super();

        this.state = {
            currentLocation: { lat: null, lng: null },
        }

        this.getLocation = this.getLocation.bind(this);
        this.getCoordinates = this.getCoordinates.bind(this);
    }

    getLocation() {
        if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(this.getCoordinates);
        }
        else {
            alert("Geolocation is not supported in this browser.")
        }
    }

    getCoordinates(position) {
        this.setState({
            currentLocation: {
                lat: position.coords.latitude,
                lng: position.coords.longitude,
            }
        })
    }

    componentDidMount() {
        this.getLocation();
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
                    <Marker
                        position={this.state.currentLocation}
                    />
                </Map>
            </div>
        )
    }
}

export default GoogleApiWrapper({
    apiKey: process.env.REACT_APP_GOOGLE_MAPS_API_KEY,
    libraries: ["places"]
})(MapContainer);