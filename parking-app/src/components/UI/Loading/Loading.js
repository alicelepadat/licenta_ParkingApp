import React from 'react';
import {Spinner} from "react-bootstrap";

import classes from './Loading.module.css';

const LoadingSpinner = () => {
    return (
        <div className={classes["loading-container"]}>
            <div>
                <Spinner animation="border" variant="dark"/>
            </div>
        </div>
    );
};

export default LoadingSpinner;
