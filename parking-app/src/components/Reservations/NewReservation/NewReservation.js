import React from 'react';

import ReservationForm from "../ReservationForm/ReservationForm";

import classes from './NewReservation.module.css';
import InfoHeader from "../../UI/InfoHeader/InfoHeader";

const DUMMY_VEHICLES = [
    {
        licensePlate: 'DB99ALI',
    },
    {
        licensePlate: 'DB05LPY',
    }
]

const NewReservation = (props) => {

    return (
        <div className={classes["new-reservation"]}>c
            <InfoHeader title="Rezervare noua" onCloseClick={props.onCloseClick}/>

            <ReservationForm area={props.area} vehicles={DUMMY_VEHICLES}/>
        </div>
    )
}

export default NewReservation;
