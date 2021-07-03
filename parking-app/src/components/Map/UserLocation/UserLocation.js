import React from 'react';

import {GeolocateControl} from 'react-map-gl';

const geolocateControlStyle = {
    bottom: '7rem',
    right: '1.5rem',
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
