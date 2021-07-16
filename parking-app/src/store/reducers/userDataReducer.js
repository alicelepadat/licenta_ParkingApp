import * as actionTypes from '../actions/actionTypes';
import {updateObject} from "../utility";

const initialState = {
    user: null,
    error: null,
    loading: false,
};

const fetchUserDataStart = (state, action) => {
    return updateObject(state, {
        error: null,
        loading: true,
    });
};

const fetchUserDataSuccess = (state, action) => {
    return updateObject(state, {
        user: action.user,
        error: null,
        loading: false,
    });
};

const fetchUserDataFail = (state, action) => {
    return updateObject(state, {
        error: action.error,
        loading: false,
    });
};

const addDriverLicenseSuccess = (state, action) => {
    return updateObject(state, {
        error: null,
        loading: false,
        user: updateObject(state.user, {
            license: action.license,
        }),
    });
};

const driverUpdateSuccess = (state, action) => {
    return updateObject(state, {
        error: null,
        loading: false,
        user: action.driver,
    });
};

const removeUserDataSucces = (state, action) => {
    return updateObject(state, {
            user: null,
        }
    );
};

const updateError = (state, action) => {
    return updateObject(state, {
        error: null,
    });
}

const userDataReducer = (state = initialState, action) => {
    switch (action.type) {
        case actionTypes.FETCH_USER_DATA_START:
            return fetchUserDataStart(state, action);
        case actionTypes.FETCH_USER_DATA_SUCCESS:
            return fetchUserDataSuccess(state, action);
        case actionTypes.FETCH_USER_DATA_FAIL:
            return fetchUserDataFail(state, action);
        case actionTypes.ADD_DRIVER_LICENSE_SUCCESS:
            return addDriverLicenseSuccess(state, action);
        case actionTypes.UPDATE_DRIVER_SUCCESS:
            return driverUpdateSuccess(state, action);
        case actionTypes.REMOVE_USER_DATA_SUCCESS:
            return removeUserDataSucces(state, action);
        case actionTypes.UPDATE_ERROR_SUCCESS:
            return updateError(state, action);
        default:
            return state;
    }
};

export default userDataReducer;
