import React from 'react';

import Card from "../../UI/Card/Card";
import ReservationDate from "../ReservationDate/ReservationDate";

import {Info, Trash2, X} from 'react-feather';

import classes from './Reservation.module.css';
import {Accordion, Col, Row} from "react-bootstrap";
import * as format from "../../../utility/dateFormat";
import * as actionCreators from "../../../store/actions";
import {connect} from "react-redux";

const Reservation = props => {

    const showActions = props.role !== 220;

    const handleCancelReservation = () => {
        props.onCancelReservation(props.id);
    }

    const handleDeleteReservation = () => {
        props.onDeleteReservation(props.id);
    }

    return (
        <li>
            <Accordion>
                <Card className={classes["reservation"]}>
                    <ReservationDate date={props.date}/>
                    <div className="d-flex flex-column">
                        <h2>{props.parkingArea.emplacement}</h2>
                        <p>
                            {format.timeFormat(props.startTime)} - {format.timeFormat(props.endTime)}
                        </p>
                    </div>

                    <Accordion.Toggle as="button" title="Informatii rezervare" eventKey="0">
                        <Info/>
                    </Accordion.Toggle>
                </Card>

                <Accordion.Collapse eventKey="0" className={classes["reservation__info-collapse"]}>
                    <div>
                        <Row className={classes["reservation__info"]}>
                            {
                                props.role !== 220 &&
                                <Col sm>
                                    <p>Vehicul: {props.vehicle}</p>
                                </Col>
                            }
                            <Col sm>
                                <p>Status: {props.status}</p>
                            </Col>
                            <Col sm>
                                <p>Pret total rezervare: {props.price} RON</p>
                            </Col>
                            <Col md={12} lg={12} sm={12} xs={12}>
                                <p>Amplasament parcare: {props.parkingArea.emplacementLocation}</p>
                            </Col>
                        </Row>
                        {
                            showActions &&
                            <div className={classes["reservation__actions"]}>
                                <button
                                    title="Anuleaza"
                                    onClick={handleCancelReservation}
                                    disabled={props.status === 'terminata' || props.status === 'anulata' || (((props.role === 200 || props.role === null) && props.status === 'progres') || (props.role === 210 && props.status !== 'progres'))}
                                >
                                    <X/>
                                </button>
                                {
                                    (props.role === null || props.role === 200) &&
                                    <button
                                        title="Sterge"
                                        onClick={handleDeleteReservation}
                                        disabled={props.status === 'activa' || props.status === 'progres'}
                                    >
                                        <Trash2/>
                                    </button>
                                }
                            </div>
                        }
                    </div>
                </Accordion.Collapse>
            </Accordion>
        </li>
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
        onCancelReservation: (reservationId) => dispatch(actionCreators.cancelReservation(reservationId)),
        onDeleteReservation: (reservationId) => dispatch(actionCreators.deleteReservation(reservationId)),
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(Reservation);
