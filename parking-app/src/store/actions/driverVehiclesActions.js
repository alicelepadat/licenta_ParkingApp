import * as actionTypes from './actionTypes';
import axios from '../axios';

export const fetchDriverVehiclesStart = () => {
    return {
        type: actionTypes.FETCH_DRIVER_VEHICLES_START
    };
};

export const fetchDriverVehiclesSuccess = (vehicles) => {
    return {
        type: actionTypes.FETCH_DRIVER_VEHICLES_SUCCESS,
        vehicles: vehicles
    };
};

export const fetchDriverVehiclesFailed = (error) => {
    return {
        type: actionTypes.FETCH_DRIVER_VEHICLES_FAIL,
        error: error
    }
}

export const fetchDriverVehicles = (userId) => {
    return dispatch => {
        dispatch(fetchDriverVehiclesStart());
        axios.get(`/drivers/${userId}/vehicles`)
            .then(response => {
                dispatch(fetchDriverVehiclesSuccess(response.data))
            }).catch(error => {
            fetchDriverVehiclesFailed(error.response)
        });
    };
};
