import React from 'react';

import classes from './ReservationsFilter.module.css';

const ReservationsFilter = props => {

    const filterChangeHandler = (event) => {
        props.onChangeFilter(event.target.value);
    }

    return (
        <div className={classes['reservations-filter']}>
            <div className={classes['reservations-filter__control']}>
                <label>Filtreaza dupa status</label>
                <select value={props.selectedStatus} onChange={filterChangeHandler}>
                    <option value='activa'>activa</option>
                    <option value='progres'>in progres</option>
                    <option value='anulata'>anulata</option>
                    <option value='terminata'>terminata</option>
                </select>
            </div>
        </div>
    );
};

export default ReservationsFilter;
