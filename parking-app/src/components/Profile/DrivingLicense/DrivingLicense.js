import React, { useState } from 'react';
import { Card, Col, Row } from "react-bootstrap";

import classes from './DrivingLicense.module.css';
import Input from "../../UI/Input/Input";
import { Check, X } from "react-feather";
import * as validate from '../../../utility/validateHandler';
import { connect } from "react-redux";
import * as actionCreators from "../../../store/actions";
import * as date from '../../../utility/dateFormat';

const DrivingLicense = props => {

    const [isLicenseNumberValid, setIsLicenseNumberValid] = useState();
    const [isLicenseDateValid, setIsLicenseDateValid] = useState();

    const validateRules = {
        enteredLicenseNumber: {
            isRequired: true,
            isLicenseNumber: true,
        },
        enteredExpirationDate: {
            isRequired: true,
            isExpirationDate: true,
        }
    }

    const handleValidateNumber = (event) => {
        setIsLicenseNumberValid(validate.checkValidity(
            event.target.value,
            validateRules.enteredLicenseNumber)
        );
    };

    const handleValidateDate = (event) => {
        setIsLicenseDateValid(validate.checkValidity(
            event.target.value,
            validateRules.enteredExpirationDate)
        );
    };

    console.log(props.user.user.id)

    const handleSubmitLicense = (event) => {
        event.preventDefault();

        const license = {
            number: props.licenseField.enteredLicenseNumber,
            expirationDate: props.licenseField.enteredExpirationDate,
        }

        if (isLicenseNumberValid && isLicenseDateValid) {
            props.onLicenseAdd(props.user.user.id, license);

            props.onAddSuccess();
        }
    };

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
                                placeholder="Numarul permisului de conducere"
                                name="enteredLicenseNumber"
                                isValid={isLicenseNumberValid}
                                value={props.licenseField.enteredLicenseNumber}
                                onChange={props.onLicenseChange}
                                onBlur={handleValidateNumber}
                            />
                            :
                            <Card.Text>Numar: <span> {props.user.license.number}</span></Card.Text>
                    }
                </div>
                <div className={classes["license__valability"]}>
                    {
                        props.showEdit ?
                            <Input
                                id="enteredExpirationDate"
                                label="Expira la:"
                                type="date"
                                name="enteredExpirationDate"
                                isValid={isLicenseDateValid}
                                value={props.licenseField.enteredExpirationDate}
                                onChange={props.onLicenseChange}
                                onBlur={handleValidateDate}
                            />
                            :
                            <Card.Text>Expira
                                la: <span> {date.dateFormat(props.user.license.expirationDate)}</span></Card.Text>
                    }
                </div>
            </Card.Body>
            {
                props.showAddActions &&
                <Card.Footer className={classes["license-add_actions"]}>
                    <button title="Anuleaza" onClick={props.onAddClose}><X /></button>
                    <button title="Salveaza permis" onClick={handleSubmitLicense}><Check /></button>
                </Card.Footer>
            }
        </Card>
    )
};

const mapStateToProps = state => {
    return {
        loading: state.driverData.loading,
        error: state.driverData.error,
    }
}

const mapDispatchToProps = dispatch => {
    return {
        onLicenseAdd: (driverId, license) => dispatch(actionCreators.addDriverLicense(driverId, license)),
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(DrivingLicense);
