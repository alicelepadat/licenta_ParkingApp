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

export const addReservationSuccess = (reservationId) => {
    return {
        type: actionTypes.ADD_RESERVATION_SUCCESS,
        reservationId: reservationId,
    };
}

export const fetchDriverReservations = (userId) => {
    return dispatch => {
        dispatch(fetchReservationsStart());
        axios.get(`/reservations/${userId}`)
            .then(response => {
                dispatch(fetchReservationsSuccess(response.data));
            }).catch(error => {
            const response = error.response ? error.response : {data:'Network error'};
            dispatch(fetchReservationsFail(response));
            });
    };
};

export const fetchAnonimDriverReservations = (vehicleId) => {
    return dispatch => {
        dispatch(fetchReservationsStart());
        axios.get(`/reservations/${vehicleId}/vehicle`)
            .then(response => {
                dispatch(fetchReservationsSuccess(response.data));
            }).catch(error => {
            const response = error.response ? error.response : {data:'Network error'};
            dispatch(fetchReservationsFail(response));
            });
    };
};

export const fetchAreaReservations = (areaId) => {
    return dispatch => {
        dispatch(fetchReservationsStart());
        axios.get(`/reservations/${areaId}/area`)
            .then(response => {
                dispatch(fetchReservationsSuccess(response.data));
            }).catch(error => {
            const response = error.response ? error.response : {data:'Network error'};
            dispatch(fetchReservationsFail(response));
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
            const response = error.response ? error.response : {data:'Network error'};
            dispatch(fetchReservationsFail(response));
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
            const response = error.response ? error.response : {data:'Network error'};
            dispatch(fetchReservationsFail(response));
            });
    };
};

export const addDriverReservation = (reservationData, userId, areaId) => {
    return dispatch => {
        dispatch(fetchReservationsStart());
        axios.post(`/reservations/${areaId}?driverId=${userId}`,
            reservationData)
            .then(response => {
                dispatch(addReservationSuccess(response.data));
            }).catch(error => {
            const response = error.response ? error.response : {data:'Network error'};
            dispatch(fetchReservationsFail(response))
            });
    };
};

export const addAnonimReservation = (reservationData, areaId) => {
    return dispatch => {
        dispatch(fetchReservationsStart());
        axios.post(`/reservations/${areaId}`,
            reservationData)
            .then(response => {
                localStorage.setItem(`identifier`, response.data)
                dispatch(addReservationSuccess());
            }).catch(error => {
            const response = error.response ? error.response : {data:'Network error'};
            dispatch(fetchReservationsFail(response))
            });
    };
};

export const fetchAllReservations = () => {
    return dispatch => {
        dispatch(fetchReservationsStart());
        axios.get(`/reservations`)
            .then(response => {
                dispatch(fetchReservationsSuccess(response.data));
            }).catch(error => {
            const response = error.response ? error.response : {data:'Network error'};
            dispatch(fetchReservationsFail(response));
        });
    };
};
