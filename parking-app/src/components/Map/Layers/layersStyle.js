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
            30,
            50,
            50,
            150,
            70,
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
        'circle-color': '#4DA8DA',
        'circle-radius': 8,
    },
};
