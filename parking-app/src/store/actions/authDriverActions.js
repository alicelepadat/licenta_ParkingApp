import * as actionTypes from './actionTypes';
import axios from '../axios';

export const driverAuthStart = () => {
    return {
        type: actionTypes.AUTH_DRIVER_START,
    };
};

export const driverAuthSucces = (userId) => {
    return {
        type: actionTypes.AUTH_DRIVER_SUCCESS,
        userId: userId,
    };
};

export const driverAuthFail = (error) => {
    return {
        type: actionTypes.AUTH_DRIVER_FAIL,
        error: error,
    };
};

export const driverLogout = () => {
    localStorage.removeItem('driverId');
    return {
        type: actionTypes.AUTH_DRIVER_LOGOUT
    };
};

export const checkAuthTimeout = (expirationTime) => {
    return dispatch => {
        setTimeout(() => {
            dispatch(driverLogout());
        }, expirationTime * 1000);
    };
};

export const driverAuth = (email, password) => {
    return dispatch => {
        dispatch(driverAuthStart());
        axios.post('/drivers/authenticate', {
            email: email,
            password: password
        }).then(response => {
            const expirationTime = 7200;
            const expirationDate = new Date(new Date().getTime() + expirationTime * 1000);
            localStorage.setItem('driverId', response.data);
            localStorage.setItem('expirationDate', expirationDate);
            dispatch(driverAuthSucces(response.data));
            dispatch(checkAuthTimeout(expirationTime));
        }).catch(error => {
            dispatch(driverAuthFail(error.response));
        });
    };
};

export const driverAuthCheckState = () => {
    return dispatch => {
        const driverId = localStorage.getItem('driverId');
        if (!driverId) {
            dispatch(driverLogout());
        } else {
            const expirationDate = new Date(localStorage.getItem('expirationDate'));
            if (expirationDate <= new Date()) {
                dispatch(driverLogout());
            } else {
                dispatch(driverAuthSucces(driverId));
                dispatch(checkAuthTimeout((expirationDate.getTime() - new Date().getTime()) / 1000));
            }
        }
    };
};

export const driverRegister = (registerData) => {
    return dispatch => {
        axios.post('/drivers/register', registerData)
            .then(response => {
                dispatch(driverAuthSucces(response.data));
            }).catch(error => {
            dispatch(driverAuthFail(error.response))
        });
    };
};
