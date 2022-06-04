import React from 'react';

import { GeolocateControl } from 'react-map-gl';

import classes from './UserLocation.module.css';

const geolocateControlStyle = {
    position: 'fixed',
    bottom: '7rem',
    right: '1rem',
};

const UserLocation = () => {
    return (
        <GeolocateControl
            className={classes["user-location"]}
            style={geolocateControlStyle}
            positionOptions={{ enableHighAccuracy: true }}
            trackUserLocation={true}
            showAccuracyCircle={false}

        />
    );
};

export default UserLocation;
