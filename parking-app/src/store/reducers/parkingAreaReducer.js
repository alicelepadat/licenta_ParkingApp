import { updateObject } from "../utility";
import * as actionTypes from "../actions/actionTypes";

const initialState = {
    parkingAreas: [],
    selectedArea: {},
    error: null,
    loading: false,
};

const actionStart = (state, action) => {
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

const fetchAllAreasSuccess = (state, action) => {
    return updateObject(state, {
        parkingAreas: action.parkingAreas,
        error: null,
        loading: false,
    });
};

const deleteAdminAccountSuccess = (state, action) => {
    const updatedList = state.parkingAreas.filter(item => {
        return item.id !== action.adminId
    });
    return updateObject(state, {
        parkingAreas: updatedList,
        error: null,
        loading: false,
    });
};

const actionFail = (state, action) => {
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
            return actionStart(state, action);
        case actionTypes.FETCH_AREA_SUCCESS:
            return fetchAreaSuccess(state, action);
        case actionTypes.FETCH_AREAS_SUCCESS:
            return fetchAllAreasSuccess(state, action);
        case actionTypes.FETCH_AREA_FAIL:
            return actionFail(state, action);
        case actionTypes.DELETE_ADMIN_ACCOUNT_FAIL:
            return actionFail(state, action);
        case actionTypes.DELETE_ADMIN_ACCOUNT_START:
            return actionStart(state, action);
        case actionTypes.DELETE_ADMIN_ACCOUNT_SUCCESS:
            return deleteAdminAccountSuccess(state, action);
        case actionTypes.CLOSE_AREA_SELECTION:
            return closeAreaSelectionSuccess(state, action);
        default:
            return state;
    }
};

export default parkingAreaReducer;
