import * as actionTypes from '../actions/actionTypes';
import {updateObject} from "../utility";

const initialState = {
    userId: localStorage.getItem("userId"),
    email: null,
    error: null,
    loading: false,
    role: null,
};

const authStart = (state, action) => {
    return updateObject(state, {
        error: null,
        loading: true
    });
};

const authSuccess = (state, action) => {
    return updateObject(state, {
        userId: action.userId,
        error: null,
        loading: false,
    });
};

const authFail = (state, action) => {
    return updateObject(state, {
        error: action.error,
        loading: false,
    });
};

const authLogout = (state, action) => {
    return updateObject(state, {
        userId: null,
        role: null,
    });
};

const registerSuccess = (state, action) => {
    return updateObject(state, {
        email: action.email,
        error: null,
        loading: false,
    });
};

const userRoleSuccess = (state, action) => {
    return updateObject(state, {
        role: action.role,
        error: null,
        loading: false,
    });
};

const driverAuthReducer = (state = initialState, action) => {
    switch (action.type) {
        case actionTypes.AUTH_START:
            return authStart(state, action);
        case actionTypes.AUTH_SUCCESS:
            return authSuccess(state, action);
        case actionTypes.REGISTER_SUCCESS:
            return registerSuccess(state, action);
        case actionTypes.AUTH_FAIL:
            return authFail(state, action);
        case actionTypes.AUTH_LOGOUT:
            return authLogout(state, action);
        case actionTypes.USER_ROLE_SUCCESS:
            return userRoleSuccess(state, action);
        default:
            return state;
    }
};

export default driverAuthReducer;
