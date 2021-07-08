import React, { useState } from 'react';

import Card from "../../UI/Card/Card";
import Input from "../../UI/Input/Input";
import Button from "../../UI/Button/Button";

import classes from './Login.module.css';
import { Link } from 'react-router-dom/cjs/react-router-dom.min';

export default function Login() {
    const [enteredEmail, setEnteredEmail] = useState('');
    const [enteredPassword, setEnteredPassword] = useState('');
    const [formIsValid, setFormIsValid] = useState(false);

    const emailChangeHandler = event => {
        setEnteredEmail(event.target.value);

        setFormIsValid(
            event.target.value.includes('@') && enteredPassword.trim().length > 6
        );
    }

    const passwordChangeHandler = event => {
        setEnteredPassword(event.target.value);

        setFormIsValid(
            enteredEmail.includes('@') && event.target.value.trim().length > 6
        );
    }

    const submitHandler = (event) => {
        event.preventDefault();
        if (formIsValid) {
            console.log(enteredEmail, enteredPassword)
            setEnteredEmail('');
            setEnteredPassword('');
        } else {
            console.log('Form is not valid');
        }
    };

    return (
        <Card className={classes.login}>
            <div className={`${classes["login-header"]} d-flex flex-column text-center`}>
                <div>
                    <img
                        src="https://www.iconpacks.net/icons/2/free-parking-sign-icon-1641-thumb.png"
                        alt="parking-logo"
                        width="100"
                        height="100"
                    />
                </div>
                <h2>Autentificare</h2>
            </div>

            <form onSubmit={submitHandler}>
                <Input
                    id="email"
                    label="E-mail"
                    type="email"
                    placeholder="johndoe@example.com"
                    value={enteredEmail}
                    onChange={emailChangeHandler}
                />
                <Input
                    id="password"
                    label="Password"
                    type="password"
                    value={enteredPassword}
                    onChange={passwordChangeHandler}
                />
                <div className={`${classes["login-footer"]} text-center`}>
                    <p>Utilizator nou? <Link to="/register">Inregistrati-va aici.</Link></p>
                </div>
                <div className="text-center">
                    <Button type="submit">
                        Autentificare
                    </Button>
                </div>
            </form>
        </Card>
    );
};
