import React, {useEffect, useState} from 'react';

import Card from "../../UI/Card/Card";
import Input from "../../UI/Input/Input";
import Button from "../../UI/Button/Button";

import classes from './Login.module.css';
import {Link, useHistory} from 'react-router-dom';
import {connect} from "react-redux";
import * as actionCreators from '../../../store/actions/index';
import Loading from "../../UI/Loading/Loading";
import {Eye, EyeOff} from "react-feather";
import Modal from "../../UI/Modal/Modal";

const Login = props => {
    const history = useHistory();

    useEffect(() => {
        if (props.userId) {
            if (props.role) {
                switch (props.role) {
                    case 210:
                        history.push("/admin-dashboard");
                        break;
                    case 220:
                        history.push("/administrator-dashboard");
                        break;
                    case 200:
                        history.push("/profile");
                        break;
                    default:
                        break;
                }
            }
        }
    });

    const [enteredEmail, setEnteredEmail] = useState(props.email ? props.email : '');
    const [emailIsValid, setEmailIsValid] = useState();

    const [enteredPassword, setEnteredPassword] = useState('');
    const [showPassword, setShowPassword] = useState(false);
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
            props.onAuth(enteredEmail, enteredPassword);
        }
    };

    const handleShowPassword = (event) => {
        event.preventDefault();
        setShowPassword(!showPassword);
    };

    const authForm = (
        <form onSubmit={handleLoginSubmit}>
            <Input
                id="email"
                label="E-mail"
                type="email"
                placeholder="johndoe@example.com"
                autocomplete="current-email"
                value={enteredEmail}
                isValid={emailIsValid}
                onChange={handleEmailChange}
                onBlur={handleValidateEmail}
            />
            <div className={classes["user-password"]}>
                <Input
                    id="password"
                    label="Password"
                    type={showPassword ? "text" : "password"}
                    placeholder="Introduceti parola"
                    autocomplete="current-password"
                    value={enteredPassword}
                    isValid={passwordIsValid}
                    onChange={handlePasswordChange}
                    onBlur={handleValidatePassword}
                >
                    <button onClick={handleShowPassword} title="Arata parola">
                        {
                            showPassword ? <EyeOff/> : <Eye/>
                        }
                    </button>
                </Input>
            </div>

            <div className={`${classes["login-footer"]} text-center`}>
                <p>Utilizator nou? <Link to="/register">Inregistrati-va aici.</Link></p>
            </div>
            <div className="text-center">
                <Button type="submit" onClick={handleLoginSubmit}>
                    Autentificare
                </Button>
            </div>
        </form>
    );

    return (
        <Card className={classes.login}>
            {
                props.loading ? <Loading/>
                    : <div className={classes["login-header"]}>
                        <div>
                            <img
                                src="/logo.png"
                                alt="parking-logo"
                                width="100"
                                height="100"
                            />
                        </div>
                        <h2>Autentificare</h2>
                    </div>
            }
            {authForm}
            {props.error && <Modal title="A aparut o eroare" message={props.error.data} onConfirm={props.onErrorClose}/>}
        </Card>
    );
};

const mapStateToProps = state => {
    return {
        loading: state.driverAuth.loading,
        error: state.driverAuth.error,
        userId: state.driverAuth.userId,
        role: state.driverAuth.role,
    };
};

const mapDispatchToProps = dispatch => {
    return {
        onAuth: (email, password) => dispatch(actionCreators.userAuth(email, password)),
        getUserRole: (userId) => dispatch(actionCreators.getUserRole(userId)),
        onErrorClose: () => dispatch(actionCreators.updateError()),
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(Login);
