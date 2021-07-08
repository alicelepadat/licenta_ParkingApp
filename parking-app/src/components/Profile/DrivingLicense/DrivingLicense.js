import React from 'react';
import {Card, Col, Row} from "react-bootstrap";

import classes from './DrivingLicense.module.css';
import Input from "../../UI/Input/Input";
import {Check, X} from "react-feather";

const DrivingLicense = props => {

    return (
        <Card className={classes["license"]}>
            <Card.Header>
                <Row>
                    <Col md={2} xs={2}>
                        <img
                            src="https://image.flaticon.com/icons/png/512/330/330426.png"
                            alt="EU"
                            width="30"
                            height="30"
                        />
                    </Col>
                    <Col>
                        <span>PERMIS DE CONDUCERE</span>
                    </Col>
                    <Col md={2} xs={2} className="text-end">
                        <span>RO</span>
                    </Col>
                </Row>
            </Card.Header>
            <Card.Body className={classes["license__body"]}>
                <div>
                    {
                        props.showEdit ?
                            <Input
                                id="enteredLicensePlate"
                                label="Numar:"
                                type="text"
                                name="number"
                                value={props.user.userDrivingLicense.number}
                                onChange={props.onInputChange}
                            />
                            :
                            <Card.Text>Numar: <span> {props.user.userDrivingLicense.number}</span></Card.Text>
                    }
                </div>
                <div className={classes["license__valability"]}>
                    {
                        props.showEdit ?
                            <Input
                                id="enteredExpirationDate"
                                label="Expira la:"
                                type="date"
                                name="expirationDate"
                                value={props.user.userDrivingLicense.expirationDate}
                                onChange={props.onInputChange}
                            />
                            :
                            <Card.Text>Expira
                                la: <span> {props.user.userDrivingLicense.expirationDate}</span></Card.Text>
                    }
                </div>
            </Card.Body>
            {
                props.showAddActions &&
                <Card.Footer className={classes["license-add_actions"]}>
                    <button title="Anuleaza" onClick={props.onAddClose}><X/></button>
                    <button title="Salveaza permis"><Check/></button>
                </Card.Footer>
            }
        </Card>
    )
};

export default DrivingLicense;
