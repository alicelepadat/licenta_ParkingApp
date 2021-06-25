import React from 'react';
import Reservation from "../Reservation/Reservation";

import classes from './ReservationsList.module.css';

const ReservationsList = props => {
    if(props.reservations.length === 0){
        return <h2 className={classes["reservations-list__fallback"]}>
            Nicio rezervare gasita.
        </h2>
    }

    return (
        <ul className={classes["reservations-list"]}>
            {
                props.reservations.map((reservation) => (
                    <Reservation
                        key={reservation.id}
                        parkingArea={reservation.parkingArea}
                        startTime={reservation.startTime}
                        endTime={reservation.endTime}
                        price={reservation.price}
                        date={reservation.date}
                        status={reservation.status}/>
                ))
            }
        </ul>
    );
};

export default ReservationsList;
