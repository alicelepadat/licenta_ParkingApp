import React, {Fragment, useEffect, useState} from 'react';

import classes from './ReservationForm.module.css';
import Input from "../../UI/Input/Input";
import Button from "../../UI/Button/Button";
import {Col, Row} from "react-bootstrap";
import {ArrowRight, Plus} from 'react-feather';
import ReservationPayment from "../ReservationPayment/ReservationPayment";
import {format} from 'date-fns';
import * as formatData from '../../../utility/dateFormat';
import * as validate from "../../../utility/validateHandler";
import {Link} from "react-router-dom";
import LoadingSpinner from "../../UI/Loading/Loading";
import * as actionCreators from "../../../store/actions";
import {connect} from "react-redux";

const ReservationForm = (props) => {

    const today = format(new Date(), "yyyy-MM-dd");
    const startTime = formatData.timeFormat(new Date().setMinutes(new Date().getMinutes() + 30)).toString();
    const endTime = formatData.timeFormat(new Date().setMinutes(new Date().getMinutes() + 90)).toString();

    const [userInput, setUserInput] = useState({
        enteredDate: today,
        enteredStartTime: startTime,
        enteredEndTime: endTime,
        enteredLicensePlate: '',
    });

    const [isUserInputValid, setIsUserInputValid] = useState({
        enteredDate: true,
        enteredStartTime: true,
        enteredEndTime: true,
        enteredLicensePlate: null,
    });

    const [formIsValid, setFormIsValid] = useState(null);

    const rules = {
        enteredDate: {
            isRequired: true,
        },
        enteredStartTime: {
            isRequired: true,
        },
        enteredEndTime: {
            isRequired: true,
        },
        enteredLicensePlate: {
            isRequired: true,
            isLicensePlate: true,
        },
    };

    useEffect(() => {
        const identifier = setTimeout(() => {
            setFormIsValid(
                isUserInputValid.enteredDate && isUserInputValid.enteredStartTime && isUserInputValid.enteredEndTime && isUserInputValid.enteredLicensePlate
            );
        }, 500);

        return () => {
            clearTimeout(identifier);
        };
    }, [isUserInputValid]);

    const validateUserInput = (event) => {
        setIsUserInputValid((prevState => {
            return {
                ...prevState,
                [event.target.name]:
                    validate.checkValidity(event.target.value,
                        rules[event.target.name]),
            };
        }));
    };

    const [showLicensePlateInput, setShowLicensePlateInput] = useState(false);

    const [goToPayment, setGoToPayment] = useState(false);

    const handleGoToPayment = (event) => {
        event.preventDefault();

        if (formIsValid) {

            const reservationData = {
                reservationDate: userInput.enteredDate,
                startTime: userInput.enteredStartTime,
                endTime: userInput.enteredEndTime,
                vehicle: {
                    licensePlate: userInput.enteredLicensePlate,
                },
            };

            if (props.userId) {
                props.onDriverAdd(reservationData, props.userId, props.area.id);
            } else {
                props.onAnonimAdd(reservationData, props.area.id);
            }

            console.log(props.error)

            if (props.error === null) {
                setGoToPayment(true);
            }
        }
    };

    const handleInputChange = (event) => {
        setUserInput((prevState) => {
            return {
                ...prevState,
                [event.target.name]: event.target.value
            };
        });
    };

    const handleAddLicensePlate = () => {
        setShowLicensePlateInput(true);
    };

    const reservationForm = (
        <div className={classes["new-reservation__controls"]}>
            <Input
                id="date"
                label="Data rezervarii"
                type="date"
                name="enteredDate"
                value={userInput.enteredDate}
                isValid={isUserInputValid.enteredDate}
                onChange={handleInputChange}
                onBlur={validateUserInput}
            />
            <Row>
                <Col>
                    <Input
                        id="startTime"
                        label="De la"
                        type="time"
                        name="enteredStartTime"
                        min={startTime}
                        isValid={isUserInputValid.enteredStartTime}
                        value={userInput.enteredStartTime}
                        onChange={handleInputChange}/>
                </Col>
                <Col>
                    <Input
                        id="endTime"
                        label="Pana la"
                        type="time"
                        name="enteredEndTime"
                        value={userInput.enteredEndTime}
                        isValid={isUserInputValid.enteredEndTime}
                        onChange={handleInputChange}
                        onBlur={validateUserInput}
                    />
                </Col>
            </Row>
            <div
                className={`${classes.control} ${isUserInputValid.enteredLicensePlate === false ? classes.invalid : ''}`}>
                <label htmlFor="enteredLicensePlate">Numar inmatriculare</label>
                {
                    props.vehicles.length > 0 && !showLicensePlateInput ?
                        <div>
                            <select
                                name="enteredLicensePlate"
                                value={userInput.enteredLicensePlate.length > 0 ? userInput.enteredLicensePlate : "Selecteaza"}
                                aria-invalid={!isUserInputValid.enteredLicensePlate}
                                onChange={handleInputChange}
                                onBlur={validateUserInput}
                            >
                                <option value="Selecteaza" disabled={true}>Selecteaza</option>
                                {
                                    props.vehicles.map((vehicle, index) => (
                                        <option key={index}
                                        >
                                            {vehicle.licensePlate}
                                        </option>
                                    ))
                                }
                            </select>
                            <Button onClick={handleAddLicensePlate}>
                                <Plus/>
                            </Button>
                        </div> :
                        <input
                            placeholder="B99BBB"
                            required={true}
                            type="text"
                            id="enteredLicensePlate"
                            name="enteredLicensePlate"
                            value={userInput.enteredLicensePlate}
                            aria-invalid={!isUserInputValid.enteredLicensePlate}
                            onChange={handleInputChange}
                            onBlur={validateUserInput}
                        />
                }
            </div>
        </div>
    );

    return (
        <Fragment>
            {
                !goToPayment && !props.userId && <div className={classes["anonim-info"]}>
                    <p>Rezervati in mod anonim. Aveti un cont? Autentificati-va <Link to="/profile"> aici</Link>.</p>
                </div>
            }
            {props.loading && <LoadingSpinner/>}
            {!props.loading &&
            <form>
                {
                    goToPayment ?
                        <h5>Efectueaza plata pentru rezervarea la {props.area.emplacement}</h5>
                        :
                        <h3>{props.area.emplacement}</h3>
                }
                {!goToPayment && reservationForm}
                {goToPayment &&
                        <div>
                            <ReservationPayment loading={props.loading}/>
                        </div>
                }
                <div className={classes["new-reservation__actions"]}>
                    {
                        !goToPayment &&
                        <Button type="submit" onClick={handleGoToPayment}>
                            Spre plata <ArrowRight/>
                        </Button>
                    }
                </div>
            </form>
            }
        </Fragment>
    );
}

const mapStateToProps = state => {
    return {
        error: state.reservations.error,
        loading: state.reservations.loading
    };
};

export default connect(mapStateToProps, null)(ReservationForm);
