import React from 'react';

import Card from "../../UI/Card/Card";
import ReservationDate from "../ReservationDate/ReservationDate";

import { Info } from 'react-feather';

import classes from './Reservation.module.css';

const Reservation = props => {
    return (
        <li>
            <Card className={classes["reservation"]}>
                <ReservationDate date={props.date} />
                <div className={classes["reservation__description"]}>
                    <h2>{props.parkingArea}</h2>
                    <div className={classes["reservation__time"]}>
                        {props.startTime} - {props.endTime}
                    </div>
                </div>
                <div className={classes["reservation__info"]}>
                    <button>
                        <Info />
                    </button>
                </div>
            </Card>
        </li>
    );
};

export default Reservation;
