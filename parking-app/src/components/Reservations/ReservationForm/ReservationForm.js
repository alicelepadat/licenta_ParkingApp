import React, {Fragment, useState} from 'react';

import classes from './ReservationForm.module.css';
import Input from "../../UI/Input/Input";
import Button from "../../UI/Button/Button";

const ReservationForm = (props) => {

    console.log(props)

    const [userInput, setUserInput] = useState({
        enteredDate: '',
        enteredStartTime: '',
        enteredEndTime: '',
        enteredLicensePlate: '',
    });
    const [error, setError] = useState();

    const handleInputChange = (event) => {
        setUserInput((prevState) => {
            return {
                ...prevState,
                [event.target.name]: event.target.value
            };
        })
    }

    const errorHandler = () => {
        setError(null);
    }

    console.log(userInput);

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
                    <div className={classes["new-reservation__time"]}>
                        <Input
                            id="startTime"
                            label="De la"
                            type="time"
                            name="enteredStartTime"
                            value={userInput.enteredStartTime}
                            onChange={handleInputChange}/>
                        <Input
                            id="endTime"
                            label="Pana la"
                            type="time"
                            name="enteredEndTime"
                            value={userInput.enteredEndTime}
                            onChange={handleInputChange}/>
                    </div>
                    <Input
                        id="licensePlate"
                        label="Numar inmatriculare"
                        type="text"
                        name="enteredLicensePlate"
                        value={userInput.enteredLicensePlate}
                        onChange={handleInputChange}/>
                </div>
                <div className={classes["new-reservation__actions"]}>
                    <Button type="submit">Rezerva</Button>
                </div>
            </form>
        </Fragment>
    );
}

export default ReservationForm;
