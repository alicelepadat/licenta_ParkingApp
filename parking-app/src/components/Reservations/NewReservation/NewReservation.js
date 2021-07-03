import React from 'react';

import Card from "../../UI/Card/Card";
import ReservationForm from "../ReservationForm/ReservationForm";

import classes from './NewReservation.module.css';
import InfoHeader from "../../UI/InfoHeader/InfoHeader";


const NewReservation = (props) => {

    return (
        <Card className={classes["new-reservation"]}>c
            <InfoHeader title="Rezervare noua" onCloseClick={props.onCloseClick}/>

            <ReservationForm area={props.area}/>
        </Card>
    )
}

export default NewReservation;
