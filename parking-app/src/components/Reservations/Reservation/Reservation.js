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
                            <Col sm>
                                <p>Status: {props.status}</p>
                            </Col>
                            <Col sm>
                                <p>Pret total: {props.price} RON</p>
                            </Col>
                            <Col md={12} lg={12} sm={12} xs={12}>
                                <p>Amplasament parcare: {props.parkingArea.emplacementLocation}</p>
                            </Col>
                        </Row>
                        <div className={classes["reservation__actions"]}>
                            <button
                                title="Anuleaza"
                                onClick={() => {
                                    props.onCancelReservation(props.userId, props.id)
                                }}
                                disabled={props.status === 'anulata'}
                            >
                                <X/>
                            </button>
                            <button
                                title="Sterge"
                                onClick={() => {
                                    props.onDeleteReservation(props.userId, props.id)
                                }}
                            >
                                <Trash2/>
                            </button>
                        </div>
                    </div>
                </Accordion.Collapse>
            </Accordion>
        </li>
    );
};

const mapStateToProps = state => {
    return {
        userId: state.driverAuth.userId,
    };
};

const mapDispatchToProps = dispatch => {
    return {
        onCancelReservation: (userId, reservationId) => dispatch(actionCreators.cancelReservation(userId, reservationId)),
        onDeleteReservation: (userId, reservationId) => dispatch(actionCreators.deleteReservation(userId, reservationId)),
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(Reservation);
