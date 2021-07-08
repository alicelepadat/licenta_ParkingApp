import React from 'react';

import Card from "../../UI/Card/Card";
import ReservationDate from "../ReservationDate/ReservationDate";

import {Info} from 'react-feather';

import classes from './Reservation.module.css';
import {Accordion, Col, Row} from "react-bootstrap";

const Reservation = props => {
    return (
        <li>
            <Accordion>
                <Card className={classes["reservation"]}>
                    <ReservationDate date={props.date}/>
                    <div className="d-flex flex-column">
                        <h2>{props.parkingArea}</h2>
                        <p>{props.startTime} - {props.endTime}</p>
                    </div>

                    <Accordion.Toggle as="button" title="Informatii rezervare" eventKey="0">
                        <Info/>
                    </Accordion.Toggle>
                </Card>

                <Accordion.Collapse eventKey="0" className={classes["reservation__info-collapse"]}>
                    <div>
                        <Row className={classes["reservation__info"]}>
                            <Col sm>
                                <p>Status:</p>
                            </Col>
                            <Col sm>
                                <p>Pret total: </p>
                            </Col>
                            <Col md={12} lg={12} sm={12} xs={12}>
                                <p>Amplasament parcare: </p>
                            </Col>
                        </Row>
                    </div>
                </Accordion.Collapse>

            </Accordion>
        </li>
    );
};

export default Reservation;
