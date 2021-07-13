import * as actionTypes from './actionTypes';
import axios from '../axios';

export const authStart = () => {
    return {
        type: actionTypes.AUTH_START,
    };
};

export const authSucces = (userId) => {
    return {
        type: actionTypes.AUTH_SUCCESS,
        userId: userId,
    };
};

export const registerSucces = (email) => {
    return {
        type: actionTypes.REGISTER_SUCCESS,
        email: email,
    };
};

export const userRoleSucces = (role) => {
    return {
        type: actionTypes.USER_ROLE_SUCCESS,
        role: role,
    };
};

export const authFail = (error) => {
    return {
        type: actionTypes.AUTH_FAIL,
        error: error,
    };
};

export const authLogout = () => {
    localStorage.removeItem('userId');
    return {
        type: actionTypes.AUTH_LOGOUT
    };
};

export const checkAuthTimeout = (expirationTime) => {
    return dispatch => {
        setTimeout(() => {
            dispatch(authLogout());
        }, expirationTime * 1000);
    };
};

export const authCheckState = () => {
    return dispatch => {
        const driverId = localStorage.getItem('userId');
        if (!driverId) {
            dispatch(authLogout());
        } else {
            const expirationDate = new Date(localStorage.getItem('expirationDate'));
            if (expirationDate <= new Date()) {
                dispatch(authLogout());
            } else {
                dispatch(authSucces(driverId));
                dispatch(checkAuthTimeout((expirationDate.getTime() - new Date().getTime()) / 1000));
            }
        }
    };
};

export const userAuth = (email, password) => {
    return dispatch => {
        dispatch(authStart());
        axios.post('/user/authenticate', {
            email: email,
            password: password
        }).then(response => {
            const expirationTime = 7200;
            const expirationDate = new Date(new Date().getTime() + expirationTime * 1000);
            localStorage.setItem('userId', response.data);
            localStorage.setItem('expirationDate', expirationDate);
            dispatch(authSucces(response.data));
            dispatch(checkAuthTimeout(expirationTime));
        }).catch(error => {
            dispatch(authFail(error.response));
        });
    };
};


export const driverRegister = (registerData) => {
    return dispatch => {
        axios.post('/user/driver-register', registerData)
            .then(response => {
                dispatch(registerSucces(response.data));
            }).catch(error => {
            dispatch(authFail(error.response))
        });
    };
};

export const adminRegister = (registerData) => {
    return dispatch => {
        axios.post('/user/admin-register', registerData)
            .then(response => {
                dispatch(registerSucces(response.data));
            }).catch(error => {
            dispatch(authFail(error.response))
        });
    };
};

export const getUserRole = (userId) => {
    return dispatch => {
        axios.get(`/user/${userId}/role`)
            .then(response => {
                dispatch(userRoleSucces(response.data));
            }).catch(error => {
            dispatch(authFail(error.response))
        });
    };
};
