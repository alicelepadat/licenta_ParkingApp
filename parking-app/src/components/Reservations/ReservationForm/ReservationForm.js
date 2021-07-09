import React, {Fragment, useState} from 'react';

import classes from './ReservationForm.module.css';
import Input from "../../UI/Input/Input";
import Button from "../../UI/Button/Button";
import {Col, Row} from "react-bootstrap";
import {ArrowRight, Plus} from 'react-feather';
import ReservationPayment from "../ReservationPayment/ReservationPayment";

const ReservationForm = (props) => {
    const [userInput, setUserInput] = useState({
        enteredDate: '',
        enteredStartTime: '',
        enteredEndTime: '',
        enteredLicensePlate: '',
    });

    const [showLicensePlateInput, setShowLicensePlateInput] = useState(false);

    const [goToPayment, setGoToPayment] = useState(false);

    const handleGoToPayment = () => {
        setGoToPayment(true);
    }

    const handleInputChange = (event) => {
        setUserInput((prevState) => {
            return {
                ...prevState,
                [event.target.name]: event.target.value
            };
        })
    }

    const handleAddLicensePlate = () => {
        setShowLicensePlateInput(true);
    }

    console.log(goToPayment)

    return (
        <Fragment>
            <form>
                {
                    goToPayment ?
                        <h5>Efectueaza plata pentru rezervarea la {props.area["AMPLASAMENT"]}</h5>
                        :
                        <h3>{props.area["AMPLASAMENT"]}</h3>
                }
                {
                    !goToPayment ?
                        <div className={classes["new-reservation__controls"]}>
                            <Input
                                id="date"
                                label="Data rezervarii"
                                type="date"
                                name="enteredDate"
                                value={userInput.enteredDate}
                                onChange={handleInputChange}/>
                            <Row>
                                <Col>
                                    <Input
                                        id="startTime"
                                        label="De la"
                                        type="time"
                                        name="enteredStartTime"
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
                                        onChange={handleInputChange}/>
                                </Col>
                            </Row>
                            <div className={classes.control}>
                                <label htmlFor="enteredLicensePlate">Numar inmatriculare</label>
                                {
                                    props.vehicles.length > 0 && !showLicensePlateInput ?
                                        <div>
                                            <select defaultValue="Selecteaza">
                                                <option value="Selecteaza" disabled={true}>Selecteaza</option>
                                                {
                                                    props.vehicles.map((vehicle, index) => (
                                                        <option key={index}
                                                                value={vehicle.licensePlate}>{vehicle.licensePlate}</option>
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
                                            onChange={handleInputChange}
                                        />
                                }
                            </div>
                        </div>
                        :
                        <div>
                            <ReservationPayment/>
                        </div>
                }
                <div className={classes["new-reservation__actions"]}>
                    {
                        !goToPayment &&
                        <Button onClick={handleGoToPayment}>
                            Spre plata <ArrowRight/>
                        </Button>
                    }
                </div>
            </form>
        </Fragment>
    );
}

export default ReservationForm;
