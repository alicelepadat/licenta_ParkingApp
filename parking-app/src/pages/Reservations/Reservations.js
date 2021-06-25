import React, {useState} from 'react';

import Card from "../../components/UI/Card/Card";
import ReservationsFilter from "../../components/Reservations/ReservationsFilter/ReservationsFilter";
import ReservationsList from "../../components/Reservations/ReservationsList/ReservationsList";

import classes from './Reservations.module.css';

const DUMMY_RESERVATIONS = [
    {
        id: 'r1',
        parkingArea: 'Aleea Cauzasi',
        date: new Date(2021, 5, 14),
        startTime: '10:20',
        endTime: '11:30',
        licensePlate: 'DB99ALI',
        status: 'terminata',
        price: 5.66
    },
    {
        id: 'r2',
        parkingArea: 'Academiei',
        date: new Date(2021, 5, 15),
        startTime: '16:40',
        endTime: '17:55',
        licensePlate: 'DB99ALI',
        status: 'terminata',
        price: 7.99
    },
    {
        id: 'r3',
        parkingArea: 'Academiei',
        date: new Date(2021, 5, 16),
        startTime: '08:10',
        endTime: '11:30',
        licensePlate: 'DB99ALI',
        status: 'activa',
        price: 12
    },
]

const Reservations = () => {

    const [filteredStatus, setFilteredStatus] = useState('activa');

    const filterChangeHandler = selectedStatus => {
        setFilteredStatus(selectedStatus);
    }

    const filteredReservations = DUMMY_RESERVATIONS.filter(reservation => {
        return reservation.status === filteredStatus;
    });

    return (
        <div className={classes.reservations}>
            <Card className={classes["reservations__filter"]}>
                <ReservationsFilter selectedStatus={filteredStatus} onChangeFilter={filterChangeHandler}/>
            </Card>
            <ReservationsList reservations={filteredReservations}/>
        </div>
    );
};

export default Reservations;
