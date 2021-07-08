import React from 'react';
import classes from "./InfoHeade.module.css";
import {X} from "react-feather";

const InfoHeader = props => {
    return (
        <div className={classes["info-header"]}>
            <h3>{props.title}</h3>
            <button title="Inchide" onClick={props.onCloseClick}>
                <X/>
            </button>
        </div>
    );
};

export default InfoHeader;
