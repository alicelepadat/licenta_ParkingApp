import React from 'react';

import {GeolocateControl} from 'react-map-gl';

const geolocateControlStyle = {
    right: 10,
    top: '90vh',
};

const UserLocation = () => {
    return (
        <GeolocateControl
            style={geolocateControlStyle}
            positionOptions={{enableHighAccuracy: true}}
            trackUserLocation={true}
            auto
        />
    );
};

export default UserLocation;
