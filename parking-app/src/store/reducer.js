import initialState from './initialState';
import * as actionTypes from './actions';

const reducer = (state = initialState, action) => {
    switch (action.type) {
        case actionTypes.SET_SELECTED_PARKING_AREA:
            return {
                ...state,
                parkingAreas: state.parkingAreas,
                selectedArea: action.selectedArea
            }
        default:
            return state;
    }
}

export default reducer;