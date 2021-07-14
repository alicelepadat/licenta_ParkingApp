import * as actionTypes from './actionTypes';
import axios from '../axios';

export const fetchUserDataStart = () => {
    return {
        type: actionTypes.FETCH_USER_DATA_START,
    };
};

export const fetchUserDataSuccess = (user) => {
    return {
        type: actionTypes.FETCH_USER_DATA_SUCCESS,
        user: user,
    };
};

export const fetchUserDataFail = (error) => {
    return {
        type: actionTypes.FETCH_USER_DATA_FAIL,
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

export const removeUserDataSuccess = () => {
    return {
        type: actionTypes.REMOVE_USER_DATA_SUCCESS,
    };
};

export const removeUserData = () => {
    return dispatch => {
        dispatch(removeUserDataSuccess());
    };
};

export const fetchDriverData = (userId) => {
    return dispatch => {
        dispatch(fetchUserDataStart());
        axios.get(`/drivers/${userId}?includeVehicles=${true}`)
            .then(response => {
                dispatch(fetchUserDataSuccess(response.data));
            }).catch(error => {
            const response = error.response ? error.response : {data:'Network error'};
            dispatch(fetchUserDataFail(response));
        });
    };
};

export const fetchAdminData = (userId) => {
    return dispatch => {
        dispatch(fetchUserDataStart());
        axios.get(`/admin/${userId}`)
            .then(response => {
                dispatch(fetchUserDataSuccess(response.data));
            }).catch(error => {
            const response = error.response ? error.response : {data:'Network error'};
            dispatch(fetchUserDataFail(response));
        });
    };
};

export const addDriverLicense = (driverId, licenseData) => {
    return dispatch => {
        dispatch(fetchUserDataStart());
        axios.put(`/drivers/license/${driverId}`, licenseData)
            .then(response => {
                console.log(response.data)
                dispatch(addDrivingLicenseSuccess(response.data));
            }).catch(error => {
            const response = error.response ? error.response : {data:'Network error'};
            dispatch(fetchUserDataFail(response));
        });
    };
};

export const updateDriver = (driverId, driverUpdateData) => {
    return dispatch => {
        dispatch(fetchUserDataStart());
        axios.put(`/drivers/${driverId}`, driverUpdateData)
            .then(response => {
                dispatch(updateDriverSuccess(response.data));
            }).catch(error => {
            const response = error.response ? error.response : {data:'Network error'};
            dispatch(fetchUserDataFail(response));
        });
    };
};

