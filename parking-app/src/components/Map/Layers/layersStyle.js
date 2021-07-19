export const clusterLayer = {
    id: 'clusters',
    type: 'circle',
    source: 'parkingAreas',
    filter: ['has', 'point_count'],
    paint: {
        'circle-color': [
            'step',
            ['get', 'point_count'],
            'rgba(77, 168, 218, 0.5)',
            50,
            'rgba(77, 168, 218, 0.75)',
            150,
            'rgb(77, 168, 218)',
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
        'circle-color': 'white',
        'circle-radius': 9,
    },
};
