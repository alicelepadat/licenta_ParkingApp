import React from 'react';

import classes from './FloatingButton.module.css';

const FloatingButton = props => {
    return (
        <div className={classes["floating-button"]} onClick={props.onClick}>
            {props.children}
        </div>
    );
};

export default FloatingButton;
