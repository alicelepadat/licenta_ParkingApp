import React from 'react';
import classes from "./InfoHeade.module.css";
import {X} from "react-feather";

const InfoHeader = props => {
    return (
        <div className={classes["info-header"]}>
            <button title="Inchide" onClick={props.onCloseClick}>
                <X/>
            </button>
            <h3>{props.title}</h3>
        </div>
    );
};

export default InfoHeader;
