import React from 'react';

import classes from './InfoContainer.module.css';
import Card from "../../UI/Card/Card";
import Button from "../../UI/Button/Button";
import {X} from "react-feather";

const InfoContainer = props => {
    return (
        <Card className={classes["area_info"]}>
            <div className={classes["area_info__header"]}>
                <button title="Inchide" onClick={props.onCloseClick}><X/></button>
                <h2>{props.area["AMPLASAMENT"]}</h2>
            </div>
            <ul>
                <li>
                    <label>Locuri disponibile: </label>
                    <strong>{props.area["NR. LOCURI"]}</strong></li>
                <li>
                    <label>Pret/ora: </label>
                    <strong>{props.area["PRET"]}</strong></li>
                <li>
                    <label>Localizare amplasament: </label>
                    <strong>{props.area["LOCALIZARE AMPLASAMENT"]}</strong></li>
            </ul>
            <Button>Rezerva</Button>
        </Card>
    );
}

export default InfoContainer;
