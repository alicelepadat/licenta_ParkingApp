import React, {useEffect, useState} from 'react';

import Card from "../../UI/Card/Card";
import Input from "../../UI/Input/Input";
import Button from "../../UI/Button/Button";

import classes from './Login.module.css';
import {Link} from 'react-router-dom/cjs/react-router-dom.min';
import {connect} from "react-redux";
import * as actionCreators from '../../../store/actions/index';
import Loading from "../../UI/Loading/Loading";

const Login = props => {
    const [enteredEmail, setEnteredEmail] = useState(props.email ? props.email : '');
    const [emailIsValid, setEmailIsValid] = useState();
    const [enteredPassword, setEnteredPassword] = useState('');
    const [passwordIsValid, setPasswordIsValid] = useState();
    const [formIsValid, setFormIsValid] = useState(false);

    useEffect(() => {
        const identifier = setTimeout(() => {
            setFormIsValid(
                emailIsValid && passwordIsValid
            );
        }, 500);

        return () => {
            clearTimeout(identifier);
        };
    }, [emailIsValid, passwordIsValid]);


    const handleEmailChange = event => {
        setEnteredEmail(event.target.value);
    };

    const handlePasswordChange = event => {
        setEnteredPassword(event.target.value);
    };

    const handleValidateEmail = () => {
        setEmailIsValid(enteredEmail.length > 0 && enteredEmail.includes('@'));
    };

    const handleValidatePassword = () => {
        setPasswordIsValid(enteredPassword.length > 0 && enteredPassword.trim().length > 8);
    };

    const handleLoginSubmit = (event) => {
        event.preventDefault();
        if (formIsValid) {
            props.onDriverAuth(enteredEmail, enteredPassword);
        }
    };

    return (
        <Card className={classes.login}>
            <div className={classes["login-header"]}>
                <div>
                    {
                        props.loading ? props.loading && <Loading/>
                            :
                            <img
                                src="https://www.iconpacks.net/icons/2/free-parking-sign-icon-1641-thumb.png"
                                alt="parking-logo"
                                width="100"
                                height="100"
                            />
                    }

                </div>
                <h2>Autentificare</h2>
            </div>

            <form onSubmit={handleLoginSubmit}>
                <Input
                    id="email"
                    label="E-mail"
                    type="email"
                    placeholder="johndoe@example.com"
                    value={enteredEmail}
                    isValid={emailIsValid}
                    onChange={handleEmailChange}
                    onBlur={handleValidateEmail}
                />
                <Input
                    id="password"
                    label="Password"
                    type="password"
                    value={enteredPassword}
                    isValid={passwordIsValid}
                    onChange={handlePasswordChange}
                    onBlur={handleValidatePassword}
                />
                <div className={`${classes["login-footer"]} text-center`}>
                    <p>Utilizator nou? <Link to="/register">Inregistrati-va aici.</Link></p>
                </div>
                <div className="text-center">
                    <Button type="submit" onClick={handleLoginSubmit}>
                        Autentificare
                    </Button>
                </div>
            </form>
        </Card>
    );
};

const mapStateToProps = state => {
    return {
        loading: state.driverAuth.loading,
        error: state.driverAuth.error,
        userId: state.driverAuth.userId,
        email: state.driverAuth.driverEmail,
    }
}

const mapDispatchToProps = dispatch => {
    return {
        onDriverAuth: (email, password) => dispatch(actionCreators.driverAuth(email, password)),
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(Login);
