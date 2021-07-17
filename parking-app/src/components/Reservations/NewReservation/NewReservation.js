import React from 'react';
import ReservationForm from "../ReservationForm/ReservationForm";
import classes from './NewReservation.module.css';
import Header from "../../UI/Header/Header";
import {connect} from "react-redux";
import * as actionCreators from "../../../store/actions";
import LoadingSpinner from "../../UI/Loading/Loading";
import Modal from "../../UI/Modal/Modal";

const NewReservation = (props) => {

    return (
        <div className={classes["new-reservation"]}>
            <Header title="Rezervare noua" onCloseClick={props.onCloseClick}/>
            {props.loading ? <LoadingSpinner/> :
                <ReservationForm
                    userId={props.userId}
                    area={props.selectedArea}
                    vehicles={props.vehicles}
                    onDriverAdd={props.onDriverReservationAdd}
                    onAnonimAdd={props.onAnonimReservationAdd}
                    onSuccess={props.onSuccess}
                    onPay={props.onPay}
                />
            }
            {
                props.error && <Modal title="Date incorecte" message={props.error.data} onConfirm={props.onErrorClose}/>
            }
        </div>
    );
};

const mapStateToProps = state => {
    return {
        vehicles: state.driverVehicles.vehicles,
        selectedArea: state.parkingArea.selectedArea,
        userId: state.driverAuth.userId,
        loading: state.reservations.loading,
        error: state.reservations.error,
    };
};

const mapDispatchToProps = dispatch => {
    return {
        onDriverReservationAdd: (data, userId, areaId) => dispatch(actionCreators.addDriverReservation(data, userId, areaId)),
        onAnonimReservationAdd: (data, areaId) => dispatch(actionCreators.addAnonimReservation(data, areaId)),
        onPay: (reservationId) => dispatch(actionCreators.updateReservationPayment(reservationId)),
        onErrorClose: () => dispatch(actionCreators.updateError()),
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(NewReservation);
