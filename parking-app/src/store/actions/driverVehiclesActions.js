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

export const fetchDriverVehiclesFail = (error) => {
    return {
        type: actionTypes.FETCH_DRIVER_VEHICLES_FAIL,
        error: error
    };
};

export const deleteDriverVehicleSuccess = (vehicleId) => {
    return {
        type: actionTypes.DELETE_DRIVER_VEHICLE_SUCCESS,
        vehicleId: vehicleId,
    };
};

export const addDriverVehicleSuccess = (vehicle) => {
    return {
        type: actionTypes.ADD_DRIVER_VEHICLE_SUCCESS,
        vehicle: vehicle
    };
};

export const fetchVehicleSuccess = (vehicle) => {
    return {
        type: actionTypes.FETCH_VEHICLE_SUCCESS,
        vehicle: vehicle,
    };
};

export const fetchDriverVehicles = (userId) => {
    return dispatch => {
        dispatch(fetchDriverVehiclesStart());
        axios.get(`/drivers/${userId}/vehicles`)
            .then(response => {
                dispatch(fetchDriverVehiclesSuccess(response.data))
            }).catch(error => {
            fetchDriverVehiclesFail(error.response)
        });
    };
};

export const fetchVehicle = (vehicleId) => {
    return dispatch => {
        dispatch(fetchDriverVehiclesStart());
        axios.get(`/vehicle/${vehicleId}`)
            .then(response => {
                dispatch(fetchVehicleSuccess(response.data));
            }).catch(error => {
            dispatch(fetchDriverVehiclesFail(error.response))
        });
    };
};

export const deleteDriverVehicle = (userId, vehicleId) => {
    return dispatch => {
        dispatch(fetchDriverVehiclesStart());
        axios.delete('/drivers/' + userId + '/vehicles?vehicleId=' + vehicleId)
            .then(() => {
                dispatch(deleteDriverVehicleSuccess(vehicleId));
            }).catch(error => {
            dispatch(fetchDriverVehiclesFail((error.response)));
        });
    };
};

export const addDriverVehicle = (userId, vehicle) => {
    return dispatch => {
        dispatch(fetchDriverVehiclesStart());
        axios.post('/drivers/' + userId + '/vehicles', vehicle)
            .then((response) => {
                dispatch(addDriverVehicleSuccess(response.data));
            }).catch(error => {
            dispatch(fetchDriverVehiclesFail(error.response));
        });
    };
};
