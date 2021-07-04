import React from 'react';

import {GeolocateControl} from 'react-map-gl';

import classes from './UserLocation.module.css';

const geolocateControlStyle = {
    bottom: '7rem',
    right: '1rem',
};

const UserLocation = () => {
    return (
        <GeolocateControl
            className={classes["user-location"]}
            style={geolocateControlStyle}
            positionOptions={{enableHighAccuracy: true}}
            trackUserLocation={true}
            auto
        />
    );
};

export default UserLocation;
