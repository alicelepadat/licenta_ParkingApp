import { updateObject } from "../utility";
import * as actionTypes from "../actions/actionTypes";

const initialState = {
    reservations: [],
    error: null,
    loading: false,
};

const fetchReservationsStart = (state, action) => {
    return updateObject(state, {
        error: null,
        loading: true,
    });
};

const fetchReservationsSuccess = (state, action) => {
    return updateObject(state, {
        reservations: action.driverReservations,
        error: null,
        loading: false,
    });
};

const fetchReservationsFail = (state, action) => {
    return updateObject(state, {
        error: action.error,
        loading: false,
    });
};

const cancelReservationSuccess = (state, action) => {
    const updatedList = state.reservations.map(item => {
        if (item.id === action.reservation.id) {
            return Object.assign({}, item, { state: action.reservation.state })
        }
        return item;
    });
    return updateObject(state, {
        reservations: updatedList,
        error: null,
        loading: false,
    });
};

const deleteReservationSuccess = (state, action) => {
    const updatedList = state.reservations.filter(item => {
        return item.id !== action.reservationId
    });
    return updateObject(state, {
        reservations: updatedList,
        error: null,
        loading: false
    });
};

const addReservationSuccese = (state, action) => {
    return updateObject(state, {
        loading: false,
        error: null,
    });
}

const reservationsReducer = (state = initialState, action) => {
    switch (action.type) {
        case actionTypes.FETCH_RESERVATIONS_START:
            return fetchReservationsStart(state, action);
        case actionTypes.FETCH_RESERVATIONS_SUCCESS:
            return fetchReservationsSuccess(state, action);
        case actionTypes.FETCH_RESERVATIONS_FAIL:
            return fetchReservationsFail(state, action);
        case actionTypes.CANCEL_RESERVATION_SUCCESS:
            return cancelReservationSuccess(state, action);
        case actionTypes.DELETE_RESERVATION_SUCCESS:
            return deleteReservationSuccess(state, action);
        case actionTypes.ADD_RESERVATION_SUCCESS:
            return addReservationSuccese(state, action);
        default:
            return state;
    }
};

export default reservationsReducer;
