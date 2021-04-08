import * as actionTypes from './actionTypes';
import axios from '../../axios';

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

export const fetchStart = () => {
    return {
        type: actionTypes.START_FETCH_PARKING_AREAS
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
        dispatch(fetchStart());
        axios.get('/areas')
            .then(response => {
                dispatch(setParkingAreas(response.data));
            })
            .catch(error => {
                dispatch(fetchParkingAreasFailed());
            })
    };
};