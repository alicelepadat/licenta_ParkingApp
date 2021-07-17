import React, {Fragment, useEffect, useState} from 'react';

import classes from './ReservationForm.module.css';
import Input from "../../UI/Input/Input";
import Button from "../../UI/Button/Button";
import {Col, Row} from "react-bootstrap";
import {Check, Plus} from 'react-feather';
import ReservationPayment from "../ReservationPayment/ReservationPayment";
import {format} from 'date-fns';
import * as formatData from '../../../utility/dateFormat';
import * as validate from "../../../utility/validateHandler";
import * as data from "../../../utility/dataUtility";
import {Link} from "react-router-dom";
import {connect} from "react-redux";
import Modal from "../../UI/Modal/Modal";
import {loadStripe} from "@stripe/stripe-js";
import {Elements} from "@stripe/react-stripe-js";
import Card from "../../UI/Card/Card";
import LoadingSpinner from "../../UI/Loading/Loading";

const stripePromise = loadStripe(process.env.REACT_APP_STRIPE_PUBLIC_TOKEN);

const today = format(new Date(), "yyyy-MM-dd");
const tomorrowDate = new Date(today)
tomorrowDate.setDate(new Date().getDate() + 1);
tomorrowDate.toLocaleDateString();
const tomorrow = formatData.dateFormat(tomorrowDate);

const startTime = formatData.timeFormat(new Date().setMinutes(new Date().getMinutes() + 30)).toString();
const endTime = formatData.timeFormat(new Date().setMinutes(new Date().getMinutes() + 90)).toString();

const ReservationForm = (props) => {

    const [showLicensePlateInput, setShowLicensePlateInput] = useState(false);
    const [goToPayment, setGoToPayment] = useState(false);

    const [details, setDetails] = useState(0);

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

    const handleReserve = (event) => {
        event.preventDefault();

        const reservationData = {
            reservationDate: userInput.enteredDate,
            startTime: userInput.enteredStartTime,
            endTime: userInput.enteredEndTime,
            vehicle: {
                licensePlate: userInput.enteredLicensePlate,
            },
        };

        if (formIsValid) {
            if (props.userId) {
                props.onDriverAdd(reservationData, props.userId, props.area.id);
            } else {
                props.onAnonimAdd(reservationData, props.area.id);
            }
        }

    }

    const handlePay = () => {
        props.onPay(props.reservation.id);

        setUserInput({
            enteredDate: today,
            enteredStartTime: startTime,
            enteredEndTime: endTime,
            enteredLicensePlate: '',
        })
        setGoToPayment(false);
        props.onSuccess();
    };

    useEffect(()=>{
        if(props.reservation && props.reservation.id) {
            setDetails(data.getPrice(userInput.enteredStartTime, userInput.enteredEndTime, props.selectedArea.pricePerHour));
            setGoToPayment(true);
        }
    }, [props.reservation])

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
        <div className={classes["reservation-form"]}>
            <h3>{props.area.emplacement}</h3>
            <label>*puteti rezerva cu minim 30 de minute inainte pentru o perioada de cel putin o ora</label>
            <form className={classes["new-reservation__controls"]}>
                <Input
                    id="date"
                    label="Data rezervarii"
                    type="date"
                    name="enteredDate"
                    min={today}
                    max={tomorrow}
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
                <div className={classes["new-reservation__actions"]}>
                    <Button type="submit" onClick={handleReserve}>
                        Rezerva <Check/>
                    </Button>
                </div>
            </form>
        </div>
    );

    return (
        <Fragment>
            {
                !goToPayment && !props.userId && <div className={classes["anonim-info"]}>
                    <p>Rezervati in mod anonim. Aveti un cont? Autentificati-va <Link to="/profile"> aici</Link>.</p>
                </div>
            }
            {
                !props.loading && goToPayment &&
                <Elements stripe={stripePromise}>
                    <ReservationPayment details={details} area={props.area} loading={props.loading}
                                        onPay={handlePay}/>
                </Elements>
            }
            {!goToPayment && reservationForm}
        </Fragment>
    );
}

const mapStateToProps = state => {
        return {
            reservation: state.reservations.reservation,
            selectedArea: state.parkingArea.selectedArea,
        };
    }
;

export default connect(mapStateToProps, null)(ReservationForm);
