export const clusterLayer = {
    id: 'clusters',
    type: 'circle',
    source: 'parkingAreas',
    filter: ['has', 'point_count'],
    paint: {
        'circle-color': [
            'step',
            ['get', 'point_count'],
            '#06D6A0',
            50,
            '#FFD166',
            150,
            '#EF476F',
        ],
        'circle-radius': [
            'step',
            ['get', 'point_count'],
            20,
            50,
            35,
            150,
            50,
        ]
    },
};

export const clusterCountLayer = {
    id: 'cluster-count',
    type: 'symbol',
    source: 'parkingAreas',
    filter: ['has', 'point_count'],
    layout: {
        'text-field': '{point_count_abbreviated}',
        'text-font': ['DIN Offc Pro Medium', 'Arial Unicode MS Bold'],
        'text-size': 12,
    },
};

export const unclusteredPointLayer = {
    id: 'unclustered-point',
    type: 'circle',
    source: 'parkingAreas',
    filter: ['!', ['has', 'point_count']],
    paint: {
        'circle-color': '#118AB2',
        'circle-radius': 7,
        'circle-stroke-width': 1,
        'circle-stroke-color': '#203647'
    },
};
