import React from 'react';
import classes from "./Header.module.css";
import {X} from "react-feather";

const Header = props => {
    return (
        <div className={classes["info-header"]}>
            <h3>{props.title}</h3>
            <button title="Inchide" onClick={props.onCloseClick}>
                <X/>
            </button>
        </div>
    );
};

export default Header;
