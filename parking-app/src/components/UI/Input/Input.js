import React from 'react';

import classes from './Input.module.css';

const Input = props => {
    return (
        <div className={`${classes.control} ${props.isValid === false ? classes.invalid : ''}`}>
            <label htmlFor={props.id}>
                {props.label}
            </label>
            <input
                required={true}
                type={props.type}
                placeholder={props.placeholder ? props.placeholder : ''}
                id={props.id}
                name={props.name ? props.name : ''}
                value={props.value}
                onChange={props.onChange}
                onBlur={props.onBlur}
                disabled={props.disabled ? props.disabled : false}
            />
        </div>
    );
};

export default Input;
