import * as actionTypes from '../actions/actionTypes';
import { updateObject } from '../utility';

const initialState = {
    selectedArea: {},
    parkingAreas: null,
    isError: false,
    loading: false,
}

const reducer = (state = initialState, action) => {
    switch (action.type) {
        case actionTypes.SELECT_PARKING_AREA:
            return updateObject(state, { selectedArea: action.selectedArea });
        case actionTypes.UNSELECT_PARKING_AREA:
            return updateObject(state, { selectedArea: {} });
        case actionTypes.START_FETCH_PARKING_AREAS:
            return updateObject(state, { isError: false, loading: true });
        case actionTypes.INIT_PARKING_AREAS:
            return updateObject(state, { parkingAreas: action.parkingAreas, isError: false, loading: false });
        case actionTypes.FETCH_PARKING_AREAS_FAILED:
            return updateObject(state, { isError: true });
        default:
            return state;
    }
}

export default reducer;