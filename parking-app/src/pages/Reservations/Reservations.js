import React, { useEffect, useState } from 'react';

import Card from "../../components/UI/Card/Card";
import ReservationsFilter from "../../components/Reservations/ReservationsFilter/ReservationsFilter";
import ReservationsList from "../../components/Reservations/ReservationsList/ReservationsList";

import classes from './Reservations.module.css';
import { connect } from "react-redux";
import * as actionCreators from "../../store/actions";
import { Link } from "react-router-dom";
import { BarChart2, X } from "react-feather";
import InfoMessage from "../../components/UI/InfoMessage/InfoMessage";
import FloatingButton from "../../components/UI/FloatingButton/FloatingButton";
import ReservationsReports from "../../components/Reservations/ReservationsReports/ReservationsReports";
import VehicleFilter from "../../components/Reservations/ReservationsFilter/VehicleFilter/VehicleFilter";

const Reservations = (props) => {

    const identifier = localStorage.getItem('identifier');
    const [filteredStatus, setFilteredStatus] = useState('toate');
    const [showAnonimMessage, setShowAnonimMessage] = useState(props.userId === null);
    const [showReports, setShowReports] = useState(false);
    const [filteredInput, setFilteredInput] = useState('');

    useEffect(() => {
        if (props.userId && props.role === 210 && props.user) {
            props.onFetchAreaReservations(props.user.parkingArea.id);
        }
    }, [props.userId, props.role, props.user])

    useEffect(() => {
        if (props.userId && props.role) {
            switch (props.role) {
                case 210:
                    props.onFetchAdminData(props.userId);
                    break;
                case 200:
                    props.onfetchDriverReservations(props.userId);
                    break;
                case 220:
                    props.onFetchAllReservations();
                    break
                default:
                    break
            }
        }
    }, [props.userId, props.role]);


    useEffect(() => {
        if (!props.userId) {
            if (identifier) {
                props.onFetchAnonimReservations(identifier);
            }
        }
    }, [props.userId]);

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

    const handleAnonimMessageClose = () => {
        setShowAnonimMessage(false);
    };

    const filterChangeHandler = selectedStatus => {
        setFilteredInput('');
        setFilteredStatus(selectedStatus);
    };

    const filterInputChangeHandler = (event) => {
        setFilteredInput(event.target.value)
    }

    const filteredReservations = (filteredStatus !== 'toate' || filteredInput !== '') ?
        props.reservations.filter(reservation => {
            if (props.role === 220) {
                return reservation.parkingArea.emplacement === filteredStatus
            } else {
                if (filteredInput.length > 0) {
                    return reservation.vehicle && reservation.vehicle.licensePlate.includes(filteredInput.toUpperCase());
                } else {
                    return getReservationState(reservation.state) === filteredStatus;
                }
            }
        }) : props.reservations;

    const handleShowReportsClick = () => {
        setShowReports(!showReports);
    }

    const reservationsData = (
        <div>
            {
                props.reservations && props.role === 210 &&
                <Card className={classes["reservations__filter"]}>
                    <VehicleFilter value={filteredInput} onChange={filterInputChangeHandler} />
                </Card>
            }
            <Card className={classes["reservations__filter"]}>
                <ReservationsFilter selectedStatus={filteredStatus}
                    onChangeFilter={filterChangeHandler} />
            </Card>
            <ReservationsList
                loading={props.loading}
                getStatus={getReservationState}
                reservations={filteredReservations}
            />
        </div>
    );

    const noReservationFoundInfo = (
        <Card className={classes["noReservation-card"]}>
            <h3>
                Nu exista rezervari.
            </h3>
            {
                props.userId === null && props.reservations.length === 0 &&
                <div className={classes["noReservation-actions"]}>
                    <p><Link to="/login">Autentificati-va</Link> sau <Link to="/">realizati o rezervare anonima</Link>.
                    </p>
                </div>
            }
        </Card>
    );

    const anonimMessage = identifier !== null && (
        <InfoMessage className={classes["anonim-message"]}
            onClick={handleAnonimMessageClose}
            message="Puteti vedea rezervarile pentru ultimul vehicul adaugat deoarece folositi aplicatia in mod anonim."
        >
            <p><Link to="/login">Autentificati-va</Link> sau <Link to="/register">inregistrati-va</Link> pentru a vedea
                toate rezervarile.</p>
        </InfoMessage>
    );

    return (
        <div className={classes.reservations}>
            {
                (!props.loading && showAnonimMessage) && anonimMessage
            }
            {
                (props.userId || identifier) && props.reservations.length > 0 ?
                    (props.role !== 220 ? reservationsData :
                        (showReports ? <ReservationsReports reservations={filteredReservations}
                            area={filteredStatus} /> : reservationsData))
                    :
                    noReservationFoundInfo
            }
            {
                props.role === 220 &&
                <div className={classes["reservations-reports"]}>
                    <FloatingButton onClick={handleShowReportsClick}>
                        {showReports ? <X color='var(--DarkBlue)' /> : <BarChart2 color='var(--DarkBlue)' />}

                    </FloatingButton>
                </div>
            }
        </div>
    );
};

const mapStateToProps = state => {
    return {
        loading: state.reservations.loading,
        error: state.reservations.error,
        userId: state.driverAuth.userId,
        role: state.driverAuth.role,
        user: state.driverData.user,
        reservations: state.reservations.reservations,
        vehicles: state.driverVehicles.vehicles,
    };
};

const mapDispatchToProps = dispatch => {
    return {
        onfetchDriverReservations: (userId) => dispatch(actionCreators.fetchDriverReservations(userId)),
        onCancelReservation: (userId, reservationId) => dispatch(actionCreators.cancelReservation(userId, reservationId)),
        onFetchAnonimReservations: (vehicleId) => dispatch(actionCreators.fetchAnonimDriverReservations(vehicleId)),
        onFetchAreaReservations: (areaId) => dispatch(actionCreators.fetchAreaReservations(areaId)),
        onFetchAdminData: (userId) => dispatch(actionCreators.fetchAdminData(userId)),
        onFetchAllReservations: () => dispatch(actionCreators.fetchAllReservations()),
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(Reservations);
