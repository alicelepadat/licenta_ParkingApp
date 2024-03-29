import React, {useEffect} from 'react';

import classes from './InfoContainer.module.css';
import Card from "../../UI/Card/Card";
import Button from "../../UI/Button/Button";
import Header from "../../UI/Header/Header";
import LoadingSpinner from "../../UI/Loading/Loading";
import {connect} from 'react-redux';
import * as actionCreators from '../../../store/actions/index';

const InfoContainer = props => {

    useEffect(() => {
        if (props.userId) {
            props.getUserRole(props.userId);
        }
    }, [props]);

    const areaInfo = (
        <div>
            <Header title={props.area.emplacement} onCloseClick={props.onCloseClick}/>
            <ul>
                <li>
                    <label>Locuri disponibile: </label>
                    <strong> {props.area.availableSpots}</strong>
                </li>
                <li>
                    <label>Pret/ora: </label>
                    <strong> {props.area.pricePerHour} RON</strong>
                </li>
                <li>
                    <label>Localizare amplasament: </label>
                    <strong> {props.area.emplacementLocation !== '' ? props.area.emplacementLocation : '-'}</strong>
                </li>
            </ul>
            {
                (props.role ===200 || props.role === null) &&
                <div className="text-end">
                    <Button onClick={props.onReserve} disabled={props.area.availableSpots === 0}>Rezerva</Button>
                </div>
            }
        </div>
    );

    return (
        <Card className={classes["area_info"]}>
            {
                props.loading ? <LoadingSpinner/> : props.area && areaInfo
            }
        </Card>
    );
};

const mapStateToProps = state => {
    return {
        userId: state.driverAuth.userId,
        role: state.driverAuth.role,
    };
};

const mapDispatchToProps = dispatch => {
    return {
        getUserRole: (userId) => dispatch(actionCreators.getUserRole(userId)),
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(InfoContainer);
