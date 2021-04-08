import * as actionTypes from './actionTypes';
import axios from '../../axios';

export const authStart = () => {
    return {
        type: actionTypes.AUTHENTICATION_START
    };
};

export const authSuccess = (userId, name, email, expireDate, number) => {
    return {
        type: actionTypes.AUTHENTICATION_SUCCESS,
        userId: userId,
        name: name,
        email: email,
        expireDate: expireDate,
        number: number
    };
};

export const authFailed = (error) => {
    return {
        type: actionTypes.AUTHENTICATION_FAILED,
        error: error
    }
}

export const checkAuthTimeout = (expirationTime) => {
    return dispatch => {
        setTimeout(() => {
            dispatch(logOut());
        }, expirationTime * 1000)
    }
}

export const logOut = () => {
    localStorage.removeItem('userId');
    localStorage.removeItem('email');
    localStorage.removeItem('name');
    localStorage.removeItem('expirationDate');
    localStorage.removeItem('licenseNo');
    localStorage.removeItem('licenseExp');
    return {
        type: actionTypes.AUTHENTICATION_LOGOUT
    }
}

export const auth = (email, password) => {
    return dispatch => {
        dispatch(authStart());
        axios.post('/drivers/authenticate', {
            email: email,
            password: password
        }).then(response => {
            const expirationTime = 7200;
            const expirationDate = new Date(new Date().getTime() + expirationTime * 1000);
            localStorage.setItem('userId', response.data.id);
            localStorage.setItem('email', response.data.user.email);
            localStorage.setItem('name', response.data.user.name);
            localStorage.setItem('licenseNo', response.data.license.number);
            localStorage.setItem('licenseExp', response.data.license.expirationDate);
            localStorage.setItem('expirationDate', expirationDate);
            dispatch(authSuccess(response.data.id, response.data.user.name, response.data.user.email, response.data.license.number, response.data.license.expirationDate))
            dispatch(checkAuthTimeout(expirationTime))
        }).catch(error => {
            dispatch(authFailed(error.response));
        })
    }
}

export const authCheckState = () => {
    return dispatch => {
        const userId = localStorage.getItem('userId');
        const name = localStorage.getItem('name');
        const email = localStorage.getItem('email');
        const licenseNo = localStorage.getItem('licenseNo');
        const licenseExp = localStorage.getItem('licenseExp');
        if (!userId) {
            dispatch(logOut());
        }
        else {
            const expirationDate = new Date(localStorage.getItem('expirationDate'));
            if (expirationDate <= new Date()) {
                dispatch(logOut())
            } else {
                dispatch(authSuccess(userId, name, email, licenseExp, licenseNo));
                dispatch(checkAuthTimeout((expirationDate.getTime() - new Date().getTime()) / 1000));
            }
        }
    }
}

export const register = (name, password, email, phone, license, expDate, issuer) => {
    return dispatch => {
        dispatch(authStart());
        axios.post('/drivers/register', {
            user: {
                name: name,
                email: email,
                phone: phone,
                password: password
            },
            license: {
                number: license,
                expirationDate: new Date(expDate),
                issuer: {
                    name: issuer
                }
            }
        }).then(response => {
            dispatch(authSuccess(response.data))
        })
            .catch(error => {
                dispatch(authFailed('A aparut o eroare la cererea dumneavoastra.'));
            })
    }
}