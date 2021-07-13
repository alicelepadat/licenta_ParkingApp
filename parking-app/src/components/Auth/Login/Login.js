import React, {useEffect, useState} from 'react';

import Card from "../../UI/Card/Card";
import Input from "../../UI/Input/Input";
import Button from "../../UI/Button/Button";

import classes from './Login.module.css';
import {Link, useHistory} from 'react-router-dom';
import {connect} from "react-redux";
import * as actionCreators from '../../../store/actions/index';
import Loading from "../../UI/Loading/Loading";
import {Col, Row} from "react-bootstrap";
import {Eye, EyeOff} from "react-feather";

const Login = props => {
    const history = useHistory();

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

    useEffect(()=>{
        if(props.userId){
            props.getUserRole(props.userId);
        }
    }, [props])

    useEffect(()=>{
        if(props.role){
            switch (props.role){
                case 210:
                    history.push("/reservations");
                    break;
                default:
                    history.push("/profile");
            }
        }
    }, [props]);

    const handleShowPassword = (event) => {
        event.preventDefault();
        setShowPassword(!showPassword);
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
                <Row>
                    <Col md={10} sm={10} xs={9}>
                        <Input
                            id="password"
                            label="Password"
                            type={showPassword ? "text" : "password"}
                            value={enteredPassword}
                            isValid={passwordIsValid}
                            onChange={handlePasswordChange}
                            onBlur={handleValidatePassword}
                        />
                    </Col>
                    <Col className={classes["show-password"]}>
                        <button onClick={handleShowPassword} title="Arata parola">
                            {
                                showPassword ? <EyeOff/> : <Eye/>
                            }
                        </button>
                    </Col>
                </Row>

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
        role: state.driverAuth.role,
    };
};

const mapDispatchToProps = dispatch => {
    return {
        onAuth: (email, password) => dispatch(actionCreators.userAuth(email, password)),
        getUserRole: (userId) => dispatch(actionCreators.getUserRole(userId)),
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(Login);
