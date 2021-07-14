import React from 'react';
import {X} from "react-feather";
import Card from "../Card/Card";

import classes from './InfoMessage.module.css';

const InfoMessage = props => {
    return (
        <Card className={`${classes["info-message"]} ${props.className}`}>
            <div className="text-end">
                <button onClick={props.onClick}><X/></button>
            </div>
            <p>{props.message}</p>
            {props.children}
        </Card>
    );
};

export default InfoMessage;
