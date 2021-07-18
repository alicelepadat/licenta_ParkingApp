import React, { useRef } from 'react';
import MapGL from 'react-map-gl';
import classes from './MapContainer.module.css';
import { clusterLayer, unclusteredPointLayer } from '../Layers/layersStyle';
import mapboxgl from "mapbox-gl";
// eslint-disable-next-line import/no-webpack-loader-syntax
mapboxgl.workerClass = require("worker-loader!mapbox-gl/dist/mapbox-gl-csp-worker").default;

const MapContainer = (props) => {

    const mapRef = useRef(null);

    const handleClusterClick = event => {
        const feature = event.features[0];
        if (!feature) {
            return;
        }

        const clusterId = feature.properties.cluster_id;

        if (!clusterId) {
            props.onAreaClick(feature.properties, feature.geometry.coordinates);
            return;
        }

        const mapboxSource = mapRef.current.getMap().getSource('parkingAreas');

        mapboxSource.getClusterExpansionZoom(clusterId, (err, zoom) => {
            if (err) {
                return;
            }

            props.onClusterExpansion(zoom, feature.geometry.coordinates);
        });

    };

    return (
        <div className={classes["map_container"]}>
            <MapGL
                {...props.viewport}
                width="100%"
                height="100%"
                mapStyle="mapbox://styles/mapbox/dark-v10"
                onViewportChange={props.onViewportChange}
                mapboxApiAccessToken={process.env.REACT_APP_MAPBOX_TOKEN}
                data={process.env.REACT_APP_MAPBOX_DATA}
                interactiveLayerIds={[clusterLayer.id, unclusteredPointLayer.id, unclusteredPointLayer.id]}
                onClick={handleClusterClick}
                ref={mapRef}
            >
                {props.children}
            </MapGL>
        </div>
    );
};

export default MapContainer;
