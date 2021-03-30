import * as actionTypes from './actionTypes';
import axios from '../../axios';

export const authStart = () => {
    return {
        type: actionTypes.AUTHENTICATION_START
    };
};

export const authSuccess = (userId) => {
    return {
        type: actionTypes.AUTHENTICATION_SUCCESS,
        userId: userId
    };
};

export const authFailed = (error) => {
    return {
        type: actionTypes.AUTHENTICATION_FAILED,
        error: error
    }
}

export const auth = (email, password) => {
    return dispatch => {
        dispatch(authStart());
        axios.post('/drivers/authenticate', {
            email: email,
            password: password
        }).then(response => {
            dispatch(authSuccess(response.data.id))
        }).catch(error => {
            dispatch(authFailed('Incercati din nou.'));
        })
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
                console.log(error.response)
                dispatch(authFailed());
            })
    }
}