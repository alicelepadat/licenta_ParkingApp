import React, {useState} from 'react';
import Card from "../UI/Card/Card";
import classes from "./NewVehicle.module.css";
import InfoHeader from "../UI/InfoHeader/InfoHeader";
import Input from "../UI/Input/Input";
import Button from "../UI/Button/Button";

const NewVehicle = props => {

    const [enteredLicensePlate, setEnteredLicensePlate] = useState('');

    const handleInputChange = (event) => {
        setEnteredLicensePlate(event.target.value);
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
                    value={enteredLicensePlate}
                    onChange={handleInputChange}/>
                <div className={classes["new-vehicle__actions"]}>
                    <Button type="submit">Adauga</Button>
                </div>
            </form>
        </Card>
    );
};

export default NewVehicle;
