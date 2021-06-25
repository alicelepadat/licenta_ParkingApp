import React from 'react';

import Card from "../../UI/Card/Card";
import ReservationForm from "../ReservationForm/ReservationForm";

import classes from './NewReservation.module.css';
import {X} from "react-feather";


const NewReservation = (props) => {

    return (
        <Card className={classes["new-reservation"]}>
            <div className={classes["new-reservation__header"]}>
                <button title="Inchide" onClick={props.onCloseClick}><X/></button>
                <h2>Rezervare noua</h2>
            </div>

            <ReservationForm area={props.area}/>
        </Card>
    )
}

export default NewReservation;
