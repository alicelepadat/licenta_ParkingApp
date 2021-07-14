import React from 'react';
import Reservation from "../Reservation/Reservation";

import classes from './ReservationsList.module.css';
import LoadingSpinner from "../../UI/Loading/Loading";

const ReservationsList = props => {
    if (props.reservations.length === 0) {
        return <h2 className={classes["reservations-list__fallback"]}>
            Nicio rezervare gasita.
        </h2>
    }
    ;

    return (
        <React.Fragment>
            {
                props.loading ? <LoadingSpinner/> :

                    <ul className={classes["reservations-list"]}>
                        {
                            props.reservations.map((reservation) => (
                                <Reservation
                                    key={reservation.id}
                                    id={reservation.id}
                                    parkingArea={reservation.parkingArea}
                                    startTime={reservation.startTime}
                                    endTime={reservation.endTime}
                                    date={reservation.reservationDate}
                                    vehicle={reservation.vehicle && reservation.vehicle.licensePlate}
                                    price={reservation.price}
                                    status={props.getStatus(reservation.state)}
                                />
                            ))
                        }
                    </ul>
            }
        </React.Fragment>
    );
};

export default ReservationsList;
