import {updateObject} from "../utility";
import * as actionTypes from "../actions/actionTypes";

const initialState = {
    selectedArea: {},
    error: null,
    loading: false,
};

const fetchAreaStart = (state, action) => {
    return updateObject(state, {
        error: null,
        loading: true,
    });
};

const fetchAreaSuccess = (state, action) => {
    return updateObject(state, {
        selectedArea: action.area,
        error: null,
        loading: false,
    });
};

const fetchAreaFail = (state, action) => {
    return updateObject(state, {
        error: action.error,
        loading: false,
    });
};

const closeAreaSelectionSuccess = (state, action) => {
    return updateObject(state, {
        selectedArea: {},
    });
};

const parkingAreaReducer = (state = initialState, action) => {
    switch (action.type) {
        case actionTypes.FETCH_AREA_START:
            return fetchAreaStart(state, action);
        case actionTypes.FETCH_AREA_SUCCESS:
            return fetchAreaSuccess(state, action);
        case actionTypes.FETCH_AREA_FAIL:
            return fetchAreaFail(state, action);
        case actionTypes.CLOSE_AREA_SELECTION:
            return closeAreaSelectionSuccess(state, action);
        default:
            return state;
    }
};

export default parkingAreaReducer;
