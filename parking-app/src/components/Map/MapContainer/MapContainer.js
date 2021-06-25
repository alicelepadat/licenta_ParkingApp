import React, {useState, useRef} from 'react';
import MapGL, {Source, Layer} from 'react-map-gl';

import {clusterLayer, clusterCountLayer, unclusteredPointLayer} from '../Layers/layers';

import classes from './MapContainer.module.css'
import InfoContainer from "../InfoContainer/InfoContainer";

const MapContainer = () => {

    const [viewport, setViewport] = useState({
        latitude: 44.439663,
        longitude: 26.096306,
        zoom: 11,
    });

    const [showPopup, setShowPopup] = useState(false);
    const [selectedArea, setSelectedArea] = useState(null);

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

    const handleCloseClick = event => {
        setShowPopup(false);
        setSelectedArea(false);
    }

    return (
        <div className={classes["map_container"]}>
            <MapGL
                {...viewport}
                width="100vw"
                height="600px"
                mapStyle="mapbox://styles/mapbox/dark-v10"
                onViewportChange={setViewport}
                mapboxApiAccessToken={process.env.REACT_APP_MAPBOX_TOKEN}
                interactiveLayerIds={[clusterLayer.id, unclusteredPointLayer.id]}
                onClick={handleClusterClick}
                ref={mapRef}
            >
                <Source
                    id="parkingAreas"
                    type="geojson"
                    data={process.env.REACT_APP_MAPBOX_DATA}
                    cluster={true}
                    clusterMaxZoom={14}
                    clusterRadius={50}
                >
                    <Layer {...clusterLayer} />
                    <Layer {...clusterCountLayer} />
                    <Layer {...unclusteredPointLayer} />
                </Source>
                {
                    showPopup && <InfoContainer area={selectedArea} onCloseClick={handleCloseClick}/>
                }
            </MapGL>
        </div>
    );
};

export default MapContainer;
