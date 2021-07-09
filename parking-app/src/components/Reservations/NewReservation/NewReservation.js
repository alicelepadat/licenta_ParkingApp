import React from 'react';
import {loadStripe} from "@stripe/stripe-js";

import ReservationForm from "../ReservationForm/ReservationForm";

import classes from './NewReservation.module.css';
import InfoHeader from "../../UI/InfoHeader/InfoHeader";
import {Elements} from "@stripe/react-stripe-js";

const DUMMY_VEHICLES = [
    {
        licensePlate: 'DB99ALI',
    },
    {
        licensePlate: 'DB05LPY',
    }
]

const stripePromise = loadStripe("pk_test_6pRNASCoBOKtIshFeQd4XMUh")

const NewReservation = (props) => {

    return (
        <div className={classes["new-reservation"]}>c
            <InfoHeader title="Rezervare noua" onCloseClick={props.onCloseClick}/>

            <Elements stripe={stripePromise}>
                <ReservationForm area={props.area} vehicles={DUMMY_VEHICLES} />
            </Elements>
        </div>
    )
}

export default NewReservation;
