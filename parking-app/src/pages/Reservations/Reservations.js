import React, {useEffect, useState} from 'react';

import Card from "../../components/UI/Card/Card";
import ReservationsFilter from "../../components/Reservations/ReservationsFilter/ReservationsFilter";
import ReservationsList from "../../components/Reservations/ReservationsList/ReservationsList";

import classes from './Reservations.module.css';
import {connect} from "react-redux";
import * as actionCreators from "../../store/actions";
import LoadingSpinner from "../../components/UI/Loading/Loading";

const Reservations = (props) => {

    const [filteredStatus, setFilteredStatus] = useState('activa');

    useEffect(() => {
        if (props.userId) {
            props.onfetchDriverReservations(props.userId);
        }
    }, []);

    const getReservationState = (state) => {
        switch (state) {
            case 100:
                return 'activa';
            case 110:
                return 'progres';
            case 120:
                return 'anulata';
            default:
                return 'terminata';
        }
    };

    console.log(props.loading)

    const filterChangeHandler = selectedStatus => {
        setFilteredStatus(selectedStatus);
    };

    const filteredReservations = props.reservations && props.reservations.filter(reservation => {
        return getReservationState(reservation.state) === filteredStatus;
    });

    const reservationsData = (
        <div>
            <Card className={classes["reservations__filter"]}>
                <ReservationsFilter selectedStatus={filteredStatus}
                                    onChangeFilter={filterChangeHandler}/>
            </Card>
            <ReservationsList
                getStatus={getReservationState}
                reservations={filteredReservations}
            />
        </div>
    );

    const noReservationFoundInfo = (
        <Card className={classes["noReservation-card"]}>
            <h3>
                Nu ati efectuat nicio rezervare.
            </h3>
        </Card>
    );

    return (
        <div className={classes.reservations}>
            {
                props.loading ? <LoadingSpinner/> :
                    props.reservations.length > 0 ? reservationsData : noReservationFoundInfo
            }
        </div>
    );
};

const mapStateToProps = state => {
    return {
        loading: state.reservations.loading,
        error: state.reservations.error,
        userId: state.driverAuth.userId,
        reservations: state.reservations.driverReservations,
    };
};

const mapDispatchToProps = dispatch => {
    return {
        onfetchDriverReservations: (userId) => dispatch(actionCreators.fetchDriverReservations(userId)),
        onCancelReservation: (userId, reservationId) => dispatch(actionCreators.cancelReservation(userId, reservationId)),
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(Reservations);
