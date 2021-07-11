import React, {useState} from 'react';
import Card from "../UI/Card/Card";
import classes from "./NewVehicle.module.css";
import InfoHeader from "../UI/InfoHeader/InfoHeader";
import Input from "../UI/Input/Input";
import Button from "../UI/Button/Button";
import * as validate from '../../utility/validateHandler';

const NewVehicle = props => {

    const [isLicensePlateValid, setIsLicensePlateValid] = useState();

    const rules = {
        enteredLicensePlate: {
            isRequired: true,
            isLicensePlate: true,
        },
    };

    const validateLicensePlate = (event) => {
        setIsLicensePlateValid(
            validate.checkValidity(event.target.value, rules.enteredLicensePlate)
        );
    }

    const handleSubmit = () => {
        if (isLicensePlateValid) {
            props.onAdd();
        }
    }

    return (
        <Card className={classes["new-vehicle"]}>
            <InfoHeader title="Masina noua" onCloseClick={props.onCloseClick}/>
            <form>
                <Input
                    id="licensePlate"
                    label="Numar inmatriculare"
                    type="text"
                    placeholder="B99BBB"
                    name="enteredLicensePlate"
                    isValid={isLicensePlateValid}
                    value={props.data}
                    onChange={props.onChange}
                    onBlur={validateLicensePlate}
                />
                <div className={classes["new-vehicle__actions"]}>
                    <Button type="submit" onClick={handleSubmit}>Adauga</Button>
                </div>
            </form>
        </Card>
    );
};

export default NewVehicle;
