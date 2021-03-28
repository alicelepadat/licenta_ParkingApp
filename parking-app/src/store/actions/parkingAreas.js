import * as actionTypes from './actionTypes';
import axios from '../../axios';
import Geocode from 'react-geocode';

const getCoordinates = async (address) => {
    try {
        const response = await Geocode.fromAddress(address);
        return response.results[0].geometry.location;
    }
    catch (error) {
        console.error(error);
    }
}

export const selectArea = (area) => {
    return {
        type: actionTypes.SELECT_PARKING_AREA,
        selectedArea: area
    };
};

export const unselectArea = () => {
    return {
        type: actionTypes.UNSELECT_PARKING_AREA
    };
};

export const setParkingAreas = (parkingAreas) => {
    return {
        type: actionTypes.INIT_PARKING_AREAS,
        parkingAreas: parkingAreas
    };
};

export const fetchParkingAreasFailed = () => {
    return {
        type: actionTypes.FETCH_PARKING_AREAS_FAILED
    };
};

export const initParkingAreas = () => {
    return dispatch => {
        axios.get('/areas')
            .then(response => {
                // let coordinates = 'coordinates'
                // let areas = [];
                // response.data.map(area => {
                //     getCoordinates(area.address.street).then(result => {
                //         area[coordinates] = result;
                //     })
                //     areas.push(area);
                // })
                dispatch(setParkingAreas(response.data));
            })
            .catch(error => {
                dispatch(fetchParkingAreasFailed());
            })
    };
};