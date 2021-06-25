import React, {useState, useRef} from 'react';
import MapGL from 'react-map-gl';

import classes from './MapContainer.module.css';
import "react-map-gl-geocoder/dist/mapbox-gl-geocoder.css";
import {clusterLayer, unclusteredPointLayer} from '../Layers/layersStyle';
import InfoContainer from "../InfoContainer/InfoContainer";
import Layers from '../Layers/Layers';
import UserLocation from '../UserLocation/UserLocation';
import NewReservation from "../../Reservations/NewReservation/NewReservation";

const MapContainer = () => {

    const [viewport, setViewport] = useState({
        latitude: 44.439663,
        longitude: 26.096306,
        zoom: 11,
    });

    const [showPopup, setShowPopup] = useState(false);
    const [selectedArea, setSelectedArea] = useState(null);
    const[showReserveForm, setShowReserveForm] = useState(false);

    const mapRef = useRef(null);

    const handleClusterClick = event => {
        const feature = event.features[0];
        if (!feature) {
            return;
        }

        const clusterId = feature.properties.cluster_id;

        if (!clusterId) {
            setSelectedArea(feature.properties);
            setShowPopup(true);
            return;
        }

        const mapboxSource = mapRef.current.getMap().getSource('parkingAreas');

        mapboxSource.getClusterExpansionZoom(clusterId, (err, zoom) => {
            if (err) {
                return;
            }

            setViewport({
                ...viewport,
                longitude: feature.geometry.coordinates[0],
                latitude: feature.geometry.coordinates[1],
                zoom,
                transitionDuration: 500
            });
        });
    };

    const handleReserveClick = event => {
        setShowPopup(false);
        setShowReserveForm(true);
    };

    const handleCloseClick = event => {
        setShowPopup(false);
        setShowReserveForm(false);
        setSelectedArea(false);
    }

    return (
        <div className={classes["map_container"]}>
            <MapGL
                {...viewport}
                width="100%"
                height="100%"
                mapStyle="mapbox://styles/mapbox/dark-v10"
                onViewportChange={setViewport}
                mapboxApiAccessToken={process.env.REACT_APP_MAPBOX_TOKEN}
                interactiveLayerIds={[clusterLayer.id, unclusteredPointLayer.id]}
                onClick={handleClusterClick}
                ref={mapRef}
            >
                <UserLocation/>
                <Layers/>
                {
                    showPopup && <InfoContainer
                        area={selectedArea}
                        onReserve={handleReserveClick}
                        onCloseClick={handleCloseClick}
                    />
                }
                {showReserveForm && <NewReservation area={selectedArea} onCloseClick={handleCloseClick}/>}
            </MapGL>
        </div>
    );
};

export default MapContainer;
