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

export const addDrivingLicenseSuccess = () => {
    return {
        type: actionTypes.ADD_DRIVER_LICENSE_SUCCESS,
    };
};

export const updateDriverSuccess = () => {
    return {
        type: actionTypes.UPDATE_DRIVER_SUCCESS,
    };
};

export const fetchDriverData = (driverId) => {
    return dispatch => {
        dispatch(fetchDriverDataStart());
        axios.get(`/drivers?driverId=${driverId}`)
            .then(response => {
                dispatch(fetchDriverDataSuccess(response.data));
            }).catch(error=>{
                dispatch(fetchDriverDataFail(error.response));
        });
    };
};

export const addDriverLicense = (driverId, licenseData) => {
    return dispatch => {
        dispatch(fetchDriverDataStart());
        axios.put(`/drivers/license/${driverId}`, licenseData)
            .then(response => {
                dispatch(addDrivingLicenseSuccess());
            }).catch(error=>{
            dispatch(fetchDriverDataFail(error.response));
        });
    };
};

export const updateDriver = (driverId, driverUpdateData) => {
    return dispatch => {
        dispatch(fetchDriverDataStart());
        axios.put(`/drivers/${driverId}`, driverUpdateData)
            .then(response => {
                dispatch(updateDriverSuccess());
            }).catch(error=>{
            dispatch(fetchDriverDataFail(error.response));
        });
    };
};

