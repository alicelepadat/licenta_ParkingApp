import * as actionTypes from '../actions/actionTypes';
import {updateObject} from "../utility";

const initialState = {
    vehicles: [],
    error: null,
    loading: false,
}

const fetchDriverVehiclesStart = (state, action) => {
    return updateObject(state, { loading: true });
};

const fetchDriverVehiclesSuccess = (state, action) => {
    return updateObject(state, {
        vehicles: action.vehicles,
        loading: false
    });
};

const fetchDriverVehiclesFail = (state, action) => {
    return updateObject(state, { loading: false, error: action.error });
};

const driverVehiclesReducer = (state = initialState, action) => {
    switch (action.type) {
        case actionTypes.FETCH_DRIVER_VEHICLES_START:
            return fetchDriverVehiclesStart(state, action);
        case actionTypes.FETCH_DRIVER_VEHICLES_SUCCESS:
            return fetchDriverVehiclesSuccess(state, action);
        case actionTypes.FETCH_DRIVER_VEHICLES_FAIL:
            return fetchDriverVehiclesFail(state, action);
        default:
            return state;
    }
};

export default driverVehiclesReducer;
