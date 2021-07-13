import * as actionTypes from './actionTypes';
import axios from '../axios';

export const fetchDriverDataStart = () => {
    return {
        type: actionTypes.FETCH_DRIVER_DATA_START,
    };
};

export const fetchDriverDataSuccess = (driver) => {
    return {
        type: actionTypes.FETCH_DRIVER_DATA_SUCCESS,
        driver: driver,
    };
};

export const fetchDriverDataFail = (error) => {
    return {
        type: actionTypes.FETCH_DRIVER_DATA_FAIL,
        error: error,
    };
};

export const addDrivingLicenseSuccess = (license) => {
    return {
        type: actionTypes.ADD_DRIVER_LICENSE_SUCCESS,
        license: license,
    };
};

export const updateDriverSuccess = (driver) => {
    return {
        type: actionTypes.UPDATE_DRIVER_SUCCESS,
        driver: driver,
    };
};

export const fetchDriverData = (userId) => {
    return dispatch => {
        dispatch(fetchDriverDataStart());
        axios.get(`/drivers/${userId}?includeVehicles=${true}`)
            .then(response => {
                dispatch(fetchDriverDataSuccess(response.data));
            }).catch(error => {
            const response = error.response ? error.response : 'Network error';
            dispatch(fetchDriverDataFail(response));
        });
    };
};

export const addDriverLicense = (driverId, licenseData) => {
    return dispatch => {
        dispatch(fetchDriverDataStart());
        axios.put(`/drivers/license/${driverId}`, licenseData)
            .then(response => {
                console.log(response.data)
                dispatch(addDrivingLicenseSuccess(response.data));
            }).catch(error => {
            dispatch(fetchDriverDataFail(error.response));
        });
    };
};

export const updateDriver = (driverId, driverUpdateData) => {
    return dispatch => {
        dispatch(fetchDriverDataStart());
        axios.put(`/drivers/${driverId}`, driverUpdateData)
            .then(response => {
                console.log(response.data)
                dispatch(updateDriverSuccess(response.data));
            }).catch(error => {
            dispatch(fetchDriverDataFail(error.response));
        });
    };
};

