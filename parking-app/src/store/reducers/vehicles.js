import * as actionTypes from '../actions/actionTypes';
import { updateObject } from '../utility';

const initialState = {
    vehicles: [],
    error: null,
    loading: false,
}

const actionVehiclesStart = (state, action) => {
    return updateObject(state, { loading: true });
};

const fetchVehiclesSuccess = (state, action) => {
    return updateObject(state, {
        vehicles: action.vehicles,
        loading: false
    });
};

const actionVehiclesFail = (state, action) => {
    return updateObject(state, { loading: false, error: action.error });
};

const deleteVehicleSuccess = (state, action) => {
    const updatedList = state.vehicles.filter(item => {
        return item.id !== action.vehicleId
    })
    console.log(updatedList)
    return updateObject(state, {
        vehicles: updatedList,
        loading: false
    })
}

const reducer = (state = initialState, action) => {
    switch (action.type) {
        case actionTypes.ACTION_RESERVATIONS_START:
            return actionVehiclesStart(state, action);
        case actionTypes.FETCH_VEHICLE_SUCCESS:
            return fetchVehiclesSuccess(state, action);
        case actionTypes.DELETE_VEHICLE_SUCCESS:
            return deleteVehicleSuccess(state, action);
        case actionTypes.ACTION_VEHICLE_FAILED:
            return actionVehiclesFail(state, action);
        default:
            return state;
    }
}

export default reducer;