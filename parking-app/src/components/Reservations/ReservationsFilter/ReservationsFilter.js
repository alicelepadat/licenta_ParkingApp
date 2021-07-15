import React, {useEffect} from 'react';

import classes from './ReservationsFilter.module.css';
import {connect} from "react-redux";
import * as actionCreators from "../../../store/actions";

const ReservationsFilter = props => {

    const status = ['activa', 'progres', 'anulata', 'terminata']

    const filterChangeHandler = (event) => {
        props.onChangeFilter(event.target.value);
    }

    useEffect(() => {
        if (props.role && props.role === 220) {
            props.onFetchAllAreas();
        }
    }, [props.onFetchAllAreas]);

    return (
        <div className={classes['reservations-filter']}>
            <div className={classes['reservations-filter__control']}>
                <label>{props.role === 220 ? 'Zona de parcare' : 'Filtreaza dupa status'}</label>
                <select value={props.selectedStatus} onChange={filterChangeHandler}>
                    <option value='toate'>toate</option>
                    {
                        props.role === 220 && props.parkingAreas.length > 0 ?
                            props.parkingAreas.map(area => (
                                <option key={area.id} value={area.emplacement}>{area.emplacement}</option>
                            )) :
                            status.map((state, index) => (<option key={index}>{state}</option>))
                    }
                </select>
            </div>
        </div>
    );
};

const mapStateToProps = state => {
    return {
        role: state.driverAuth.role,
        parkingAreas: state.parkingArea.parkingAreas,
    };
};

const mapDispatchToProps = dispatch => {
    return {
        onFetchAllAreas: () => dispatch(actionCreators.fetchParkingAreas()),
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(ReservationsFilter);
