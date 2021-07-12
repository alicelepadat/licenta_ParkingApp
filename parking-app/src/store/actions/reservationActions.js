import * as actionTypes from './actionTypes';
import axios from '../axios';

export const fetchReservationsStart = () => {
    return {
        type: actionTypes.FETCH_RESERVATIONS_START,
    };
};

export const fetchReservationsSuccess = (reservations) => {
    return {
        type: actionTypes.FETCH_RESERVATIONS_SUCCESS,
        driverReservations: reservations,
    };
};

export const fetchReservationsFail = (error) => {
    return {
        type: actionTypes.FETCH_RESERVATIONS_FAIL,
        error: error,
    };
};

export const cancelReservationsSuccess = (reservation) => {
    return {
        type: actionTypes.CANCEL_RESERVATION_SUCCESS,
        reservation: reservation
    };
};

export const deleteReservationsSuccess = (reservationId) => {
    return {
        type: actionTypes.DELETE_RESERVATION_SUCCESS,
        reservationId: reservationId
    };
};

export const addReservationSuccess = () => {
    return {
        type: actionTypes.ADD_RESERVATION_SUCCESS,
    };
}

export const fetchDriverReservations = (userId) => {
    return dispatch => {
        dispatch(fetchReservationsStart());
        axios.get(`/reservations/${userId}`)
            .then(response => {
                dispatch(fetchReservationsSuccess(response.data));
            }).catch(error => {
            dispatch(fetchReservationsFail(error.response));
        });
    };
};

export const cancelReservation = (userId, reservationId) => {
    return dispatch => {
        dispatch(fetchReservationsStart());
        axios.patch(`/reservations/${reservationId}/driver/${userId}`)
            .then(response => {
                dispatch(cancelReservationsSuccess(response.data));
            }).catch(error => {
            dispatch(fetchReservationsFail(error.response));
        })
    };
};

export const deleteReservation = (userId, reservationId) => {
    return dispatch => {
        dispatch(fetchReservationsStart());
        axios.delete(`/reservations/${reservationId}/driver/${userId}`)
            .then(() => {
                dispatch(deleteReservationsSuccess(reservationId));
            }).catch(error => {
            dispatch(fetchReservationsFail(error.response));
        });
    };
};

export const addDriverReservation = (reservationData, userId, areaId) => {
    return dispatch => {
        dispatch(fetchReservationsStart());
        axios.post(`/reservations/${areaId}?driverId=${userId}`,
            reservationData)
            .then(response => {
                dispatch(addReservationSuccess());
            }).catch(error => {
            dispatch(fetchReservationsFail(error.response.data))
        });
    };
};

export const addAnonimReservation = (reservationData, areaId) => {
    return dispatch => {
        dispatch(fetchReservationsStart());
        axios.post(`/reservations/${areaId}`,
            reservationData)
            .then(response => {
                localStorage.setItem(`identifier_${response.data}`, response.data)
                dispatch(addReservationSuccess());
            }).catch(error => {
            dispatch(fetchReservationsFail(error.response.data))
        });
    };
};

export const getAnonimDriverReservation = (vehicleId) => {
    return dispatch => {
        dispatch(fetchReservationsStart());
        //  TODO: get reservation dupa vehicleId pentru sofer anonim --- backend + call in frontend
    }
}
