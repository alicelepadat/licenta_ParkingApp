import * as actionTypes from '../actions/actionTypes';
import {updateObject} from "../utility";

const initialState = {
    isDriverLoggedIn: false,
    userId: localStorage.getItem("driverId"),
    driverEmail: null,
    error: null,
    loading: false,
};

const driverAuthStart = (state, action) => {
    return updateObject(state, {
        error: null,
        loading: true
    });
};

const driverAuthSuccess = (state, action) => {
    return updateObject(state, {
        isDriverLoggedIn: true,
        userId: action.userId,
        error: null,
        loading: false,
    });
};

const driverRegisterSuccess = (state, action) => {
    return updateObject(state, {
        isDriverLoggedIn: true,
        driverEmail: action.email,
        error: null,
        loading: false,
    });
};

const driverAuthFail = (state, action) => {
    return updateObject(state, {
        error: action.error,
        loading: false,
        isDriverLoggedIn: false,
    });
};

const driverAuthLogout = (state, action) => {
    return updateObject(state, {
        userId: null,
        isDriverLoggedIn: false,
    });
};

const driverAuthReducer = (state = initialState, action) => {
    switch (action.type) {
        case actionTypes.AUTH_DRIVER_START:
            return driverAuthStart(state, action);
        case actionTypes.AUTH_DRIVER_SUCCESS:
            return driverAuthSuccess(state, action);
        case actionTypes.AUTH_REGISTER_DRIVER_SUCCESS:
            return driverRegisterSuccess(state, action);
        case actionTypes.AUTH_DRIVER_FAIL:
            return driverAuthFail(state, action);
        case actionTypes.AUTH_DRIVER_LOGOUT:
            return driverAuthLogout(state, action);
        default:
            return state;
    }
};

export default driverAuthReducer;


