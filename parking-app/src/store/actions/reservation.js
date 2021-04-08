import * as actionTypes from './actionTypes';
import axios from '../../axios';

export const reservationStart = () => {
    return {
        type: actionTypes.RESERVE_SPOT_START
    };
}

export const reservationSuccess = (reservationId) => {
    return {
        type: actionTypes.RESERVE_SPOT_SUCCESS,
        reservationId: reservationId
    };
};

export const reservationFailed = (error) => {
    return {
        type: actionTypes.RESERVE_SPOT_FAILED,
        error: error
    }
}

export const reserve = (reservationData, userId, areaId) => {
    return dispatch => {
        dispatch(reservationStart());
        axios.post('/drivers/' + userId + '/reservations?parkingAreaId=' + areaId,
            reservationData)
            .then(response => {
                dispatch(reservationSuccess(response.data));
            }).catch(error => {
                dispatch(reservationFailed(error.response.data))
            });
    };
};


export const actionReservationsStart = () => {
    return {
        type: actionTypes.ACTION_RESERVATIONS_START
    };
}

export const fetchReservationsSuccess = (reservations) => {
    return {
        type: actionTypes.FETCH_RESERVATIONS_SUCCESS,
        reservations: reservations
    };
};

export const actionReservationsFailed = (error) => {
    return {
        type: actionTypes.ACTION_RESERVATIONS_FAILED,
        error: error
    }
}

export const deleteReservationsSuccess = (reservationId) => {
    return {
        type: actionTypes.DELETE_RESERVATION_SUCCESS,
        reservationId: reservationId
    };
};

export const deleteReservation = (userId, reservationId) => {
    return dispatch => {
        dispatch(actionReservationsStart());
        axios.delete('/drivers/' + userId + '/reservations?reservationId=' + reservationId)
            .then(() => {
                dispatch(deleteReservationsSuccess(reservationId))
            }).catch(error => { dispatch(actionReservationsFailed(error.response)) })
    }
}

export const cancelReservationsSuccess = (reservationState, reservationId) => {
    return {
        type: actionTypes.CANCEL_RESERVATION_SUCCESS,
        reservationState: reservationState,
        reservationId: reservationId
    };
};

export const cancelReservation = (userId, reservationId) => {
    return dispatch => {
        dispatch(actionReservationsStart());
        axios.patch('/drivers/' + userId + '/reservations/' + reservationId)
            .then(response => {
                dispatch(cancelReservationsSuccess(response.data, reservationId))
            }).catch(error => { dispatch(actionReservationsFailed(error.response)) })
    }
}

export const fetchReservations = (userId) => {
    return dispatch => {
        dispatch(actionReservationsStart());
        axios.get('/drivers/' + userId + '/reservations')
            .then(response => {
                dispatch(fetchReservationsSuccess(response.data));
            }).catch(error => {
                dispatch(actionReservationsFailed(error.response));
            });
    }
}
