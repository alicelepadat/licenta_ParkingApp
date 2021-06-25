import React from 'react';

import { GeolocateControl } from 'react-map-gl';

const UserLocation = () => {
    return (
        <GeolocateControl
            // className={classes["user__location"]}
            positionOptions={{ enableHighAccuracy: true }}
            trackUserLocation={true}
            auto
        />
    );
};

export default UserLocation;
