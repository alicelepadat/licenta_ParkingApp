import * as actionTypes from '../actions/actionTypes';
import { updateObject } from '../utility';

const initialState = {
    reservations: [],
    reservationId: null,
    error: null,
    loading: false,
}

const reservationStart = (state, action) => {
    return updateObject(state, { error: null, loading: true });
}

const reservationSuccess = (state, action) => {
    return updateObject(state, {
        reservationId: action.reservationId,
        error: null,
        loading: false
    });
};

const reservationFailed = (state, action) => {
    return updateObject(state, {
        error: action.error,
        loading: false
    })
}

const actionReservationsStart = (state, action) => {
    return updateObject(state, { loading: true });
};

const fetchReservationsSuccess = (state, action) => {
    return updateObject(state, {
        reservations: action.reservations,
        loading: false
    });
};

const actionReservationsFail = (state, action) => {
    return updateObject(state, { loading: false, error: action.error });
};

const deleteReservationSuccess = (state, action) => {
    const updatedList = state.reservations.filter(item => {
        return item.id != action.reservationId
    })
    return updateObject(state, {
        reservations: updatedList,
        loading: false
    })
}

const reducer = (state = initialState, action) => {
    switch (action.type) {
        case actionTypes.RESERVE_SPOT_START:
            return reservationStart(state, action);
        case actionTypes.RESERVE_SPOT_SUCCESS:
            return reservationSuccess(state, action);
        case actionTypes.RESERVE_SPOT_FAILED:
            return reservationFailed(state, action);
        case actionTypes.ACTION_RESERVATIONS_START:
            return actionReservationsStart(state, action);
        case actionTypes.FETCH_RESERVATIONS_SUCCESS:
            return fetchReservationsSuccess(state, action);
        case actionTypes.DELETE_RESERVATION_SUCCESS:
            return deleteReservationSuccess(state, action);
        case actionTypes.ACTION_RESERVATIONS_FAILED:
            return actionReservationsFail(state, action);
        default:
            return state;
    }
}

export default reducer;