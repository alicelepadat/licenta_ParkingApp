import React from 'react';

import classes from './InfoContainer.module.css';
import Card from "../../UI/Card/Card";
import Button from "../../UI/Button/Button";
import InfoHeader from "../../UI/InfoHeader/InfoHeader";

const InfoContainer = props => {
    return (
        <Card className={classes["area_info"]} >
            <InfoHeader title={props.area["AMPLASAMENT"]} onCloseClick={props.onCloseClick}/>
            <ul>
                <li>
                    <label>Locuri disponibile: </label>
                    <strong> {props.area["NR. LOCURI"]}</strong></li>
                <li>
                    <label>Pret/ora: </label>
                    <strong> {props.area["PRET"]}</strong></li>
                <li>
                    <label>Localizare amplasament: </label>
                    <strong> {props.area["LOCALIZARE AMPLASAMENT"].length>0 ? props.area["LOCALIZARE AMPLASAMENT"] : '-'}</strong></li>
            </ul>
            <Button onClick={props.onReserve}>Rezerva</Button>
        </Card>
    );
}

export default InfoContainer;
