import React from 'react';
import { Spinner } from "react-bootstrap";

import classes from './Loading.module.css';

const LoadingSpinner = () => {
    return (
        <div className={classes.Loader}>Loading...</div>
    );
};

export default LoadingSpinner;
