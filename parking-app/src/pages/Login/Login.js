import React, {useState} from 'react';

import Card from "../../components/UI/Card/Card";
import Input from "../../components/UI/Input/Input";
import Button from "../../components/UI/Button/Button";

import classes from './Login.module.css';

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
            <form onSubmit={submitHandler}>
                <Input
                    id="email"
                    label="E-mail"
                    type="email"
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
                <div className={classes.actions}>
                    <Button type="submit">
                        Login
                    </Button>
                </div>
            </form>
        </Card>
    );
};
