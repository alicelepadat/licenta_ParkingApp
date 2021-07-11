import * as actionTypes from '../actions/actionTypes';
import {updateObject} from "../utility";

const initialState = {
    driver: null,
    error: null,
    loading: false,
};

const fetchDriverDataStart = (state, action) => {
    return updateObject(state, {
        error: null,
        loading: true,
    });
};

const fetchDriverDataSuccess = (state, action) => {
    return updateObject(state, {
        driver: action.driver,
        error: null,
        loading: false,
    });
};

const fetchDriverDataFail = (state, action) => {
    return updateObject(state, {
        error: action.error,
        loading: false,
    });
};

const addDriverLicenseSuccess = (state, action) => {
    return updateObject(state, {
        error: null,
        loading: false,
        driver: updateObject(state.driver, {
            license: action.license,
        }),
    });
};

const driverUpdateSuccess = (state, action) => {
    return updateObject(state, {
        error: null,
        loading: false,
        driver: action.driver,
    });
};

const driverDataReducer = (state = initialState, action) => {
    switch (action.type) {
        case actionTypes.FETCH_DRIVER_DATA_START:
            return fetchDriverDataStart(state, action);
        case actionTypes.FETCH_DRIVER_DATA_SUCCESS:
            return fetchDriverDataSuccess(state, action);
        case actionTypes.FETCH_DRIVER_DATA_FAIL:
            return fetchDriverDataFail(state, action);
        case actionTypes.ADD_DRIVER_LICENSE_SUCCESS:
            return addDriverLicenseSuccess(state, action);
        case actionTypes.UPDATE_DRIVER_SUCCESS:
            return driverUpdateSuccess(state, action);
        default:
            return state;
    }
};

export default driverDataReducer;
