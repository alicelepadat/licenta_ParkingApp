import React from 'react';
import {loadStripe} from "@stripe/stripe-js";

import ReservationForm from "../ReservationForm/ReservationForm";

import classes from './NewReservation.module.css';
import Header from "../../UI/Header/Header";
import {Elements} from "@stripe/react-stripe-js";
import {connect} from "react-redux";
import * as actionCreators from "../../../store/actions";

const stripePromise = loadStripe("pk_test_6pRNASCoBOKtIshFeQd4XMUh")

const NewReservation = (props) => {

    return (
        <div className={classes["new-reservation"]}>c
            <Header title="Rezervare noua" onCloseClick={props.onCloseClick}/>

            <Elements stripe={stripePromise}>
                <ReservationForm
                    userId={props.userId}
                    area={props.selectedArea}
                    vehicles={props.vehicles}
                    onDriverAdd={props.onDriverReservationAdd}
                    onAnonimAdd={props.onAnonimReservationAdd}
                />
            </Elements>
        </div>
    );
};

const mapStateToProps = state => {
    return {
        vehicles: state.driverVehicles.vehicles,
        selectedArea: state.parkingArea.selectedArea,
        userId: state.driverAuth.userId,
    };
};

const mapDispatchToProps = dispatch => {
    return {
        onDriverReservationAdd: (data, userId, areaId) => dispatch(actionCreators.addDriverReservation(data, userId, areaId)),
        onAnonimReservationAdd: (data, areaId) => dispatch(actionCreators.addAnonimReservation(data, areaId)),
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(NewReservation);
