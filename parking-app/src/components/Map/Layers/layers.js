import React from 'react';

import { Source, Layer } from 'react-map-gl';
import { clusterLayer, clusterCountLayer, unclusteredPointLayer } from './layersStyle';

const Layers = () => {
    return (
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
    );
};

export default Layers;
