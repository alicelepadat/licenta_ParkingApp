import React, {useState, useRef} from 'react';
import MapGL from 'react-map-gl';

import classes from './MapContainer.module.css';
import "react-map-gl-geocoder/dist/mapbox-gl-geocoder.css";
import {clusterLayer, unclusteredPointLayer} from '../Layers/layersStyle';

const MapContainer = (props) => {

    const [viewport, setViewport] = useState({
        latitude: 44.439663,
        longitude: 26.096306,
        zoom: 11,
    });

    const mapRef = useRef(null);

    const handleClusterClick = event => {
        const feature = event.features[0];
        if (!feature) {
            return;
        }

        const clusterId = feature.properties.cluster_id;

        if (!clusterId) {
            props.onClusterClick(feature.properties);
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
                {props.children}
            </MapGL>
        </div>
    );
};

export default MapContainer;
