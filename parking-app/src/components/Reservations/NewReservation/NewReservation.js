import React, { useState } from 'react';

import Card from "../../components/UI/Card/Card";
import ReservationForm from "../../components/Reservations/ReservationForm/ReservationForm";

import classes from './NewReservation.module.css';


const NewReservation = (props) => {

    return (
        <Card className={classes["new-reservation"]}>
            <ReservationForm area={props.area}/>
        </Card>
    )
}

export default NewReservation;
