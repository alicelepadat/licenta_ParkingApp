import React from 'react';
import {Card, Col, Row} from "react-bootstrap";

import classes from './DrivingLicense.module.css';
import Input from "../../UI/Input/Input";

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
                                label="Numar inmatriculare"
                                type="text"
                                name="licensePlate"
                                value={props.user.userLicensePlate.licensePlate}
                                onChange={props.onInputChange}
                            />
                            :
                            <Card.Text>Numar: <span> {props.user.userLicensePlate.licensePlate}</span></Card.Text>
                    }
                </div>
                <div className={classes["license__valability"]}>
                    {
                        props.showEdit ?
                            <Input
                                id="enteredExpirationDate"
                                label="Expira la"
                                type="date"
                                name="expirationDate"
                                value={props.user.userLicensePlate.expirationDate}
                                onChange={props.onInputChange}
                            />
                            :
                            <Card.Text>Expira la: <span> {props.user.userLicensePlate.expirationDate}</span></Card.Text>
                    }
                </div>
            </Card.Body>
        </Card>
    )
};

export default DrivingLicense;
