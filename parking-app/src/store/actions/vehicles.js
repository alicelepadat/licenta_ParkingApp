import * as actionTypes from './actionTypes';
import axios from '../../axios';


export const actionVehiclesStart = () => {
    return {
        type: actionTypes.ACTION_VEHICLE_START
    };
}

export const fetchVehiclesSuccess = (vehicles) => {
    return {
        type: actionTypes.FETCH_VEHICLE_SUCCESS,
        vehicles: vehicles
    };
};

export const actionVehiclesFailed = (error) => {
    return {
        type: actionTypes.ACTION_VEHICLE_FAILED,
        error: error
    }
}

export const fetchVehicles = (userId) => {
    return dispatch => {
        dispatch(actionVehiclesStart());
        axios.get('/drivers/' + userId + '/vehicles')
            .then(response => {
                dispatch(fetchVehiclesSuccess(response.data))
            }).catch(error => {
                actionVehiclesFailed(error.response)
            });
    }
}

export const deleteVehicleSuccess = (vehicleId) => {
    return {
        type: actionTypes.DELETE_VEHICLE_SUCCESS,
        vehicleId: vehicleId
    };
};

export const deleteVehicle = (userId, vehicleId) => {
    return dispatch => {
        dispatch(actionVehiclesStart());
        axios.delete('/drivers/' + userId + '/vehicles?vehicleId=' + vehicleId)
            .then(() => {
                dispatch(deleteVehicleSuccess(vehicleId))
            }).catch(error => { dispatch(actionVehiclesFailed(error.response)) })
    }
}