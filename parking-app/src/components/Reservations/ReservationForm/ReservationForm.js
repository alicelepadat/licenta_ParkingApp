import React, {Fragment, useState} from 'react';

import classes from './ReservationForm.module.css';
import Input from "../../UI/Input/Input";
import Button from "../../UI/Button/Button";
import {Col, Row} from "react-bootstrap";
import {Plus} from 'react-feather';

const ReservationForm = (props) => {
    const [userInput, setUserInput] = useState({
        enteredDate: '',
        enteredStartTime: '',
        enteredEndTime: '',
        enteredLicensePlate: '',
    });

    const [showLicensePlateInput, setShowLicensePlateInput] = useState(false);

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

    return (
        <Fragment>
            <form>
                <h3>{props.area["AMPLASAMENT"]}</h3>
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
                <div className={classes["new-reservation__actions"]}>
                    <Button type="submit">Rezerva</Button>
                </div>
            </form>
        </Fragment>
    );
}

export default ReservationForm;
