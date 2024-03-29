import * as actionTypes from './actionTypes';
import axios from '../axios';

export const fetchAreaStart = () => {
    return {
        type: actionTypes.FETCH_AREA_START,
    };
};

export const fetchAreaSuccess = (area) => {
    return {
        type: actionTypes.FETCH_AREA_SUCCESS,
        area: area,
    };
};

export const fetchAllAreasSuccess = (areas) => {
    return {
        type: actionTypes.FETCH_AREAS_SUCCESS,
        parkingAreas: areas,
    };
};

export const fetchAreaFail = (error) => {
    return {
        type: actionTypes.FETCH_AREA_FAIL,
        error: error,
    };
};

export const deleteAdminAccountStart = (adminId) => {
    return {
        type: actionTypes.DELETE_ADMIN_ACCOUNT_SUCCESS,
        adminId: adminId
    };
};

export const deleteAdminAccountSuccess = (adminId) => {
    return {
        type: actionTypes.DELETE_ADMIN_ACCOUNT_SUCCESS,
        adminId: adminId
    };
};

export const deleteAdminAccountFailed = (error) => {
    return {
        type: actionTypes.DELETE_ADMIN_ACCOUNT_FAIL,
        error: error,
    };
};

export const fetchParkingArea = (name) => {
    return dispatch => {
        dispatch(fetchAreaStart());
        axios.get(`/areas/${name}`)
            .then(response => {
                dispatch(fetchAreaSuccess(response.data));
            }).catch(error => {
                const response = error.response ? error.response : { data: 'Network error' };
                dispatch(fetchAreaFail(response));
            });
    };
};

export const closeAreaSelection = () => {
    return {
        type: actionTypes.CLOSE_AREA_SELECTION,
    };
};


export const fetchParkingAreas = () => {
    return dispatch => {
        dispatch(fetchAreaStart());
        axios.get(`/areas`)
            .then(response => {
                dispatch(fetchAllAreasSuccess(response.data));
            }).catch(error => {
                const response = error.response ? error.response : { data: 'Network error' };
                dispatch(fetchAreaFail(response));
            });
    };
};

export const deleteAdminAccount = (adminId) => {
    return dispatch => {
        dispatch(deleteAdminAccountStart(adminId));
        axios.delete(`/admin/${adminId}`)
            .then(response => {
                dispatch(deleteAdminAccountSuccess(adminId));
            }).catch(error => {
                const response = error.response ? error.response : { data: 'Network error' };
                dispatch(deleteAdminAccountFailed(response));
            });
    };
};
