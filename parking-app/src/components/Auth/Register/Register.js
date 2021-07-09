import React, {useState} from "react";

import Card from '../../UI/Card/Card';
import Input from '../../UI/Input/Input';
import Button from '../../UI/Button/Button';
import {Row, Col} from 'react-bootstrap';

import {Eye, EyeOff} from "react-feather";

import classes from "./Register.module.css";
import * as actionCreators from "../../../store/actions";
import {connect} from "react-redux";

const Register = (props) => {
    const [userInput, setUserInput] = useState({
        enteredName: "",
        enteredEmail: "",
        enteredPhone: "",
        enteredPassword: "",
        enteredVerifyPassword: "",
    });

    const [showPassword, setShowPassword] = useState(false);
    const [showVerifyPassword, setShowVerifyPassword] = useState(false);

    const handleInputChange = (event) => {
        setUserInput((prevState) => {
            return {
                ...prevState,
                [event.target.name]: event.target.value
            };
        })
    }

    const handleShowPassword = (event) => {
        event.preventDefault();
        setShowPassword(!showPassword);
    }

    const handleShowVerifyPassword = (event) => {
        event.preventDefault();
        setShowVerifyPassword(!showVerifyPassword);
    }

    const handleRegisterSubmit = (event) => {
        event.preventDefault();

        const data = {
            user: {
                name: userInput.enteredName,
                email: userInput.enteredEmail,
                phone: userInput.enteredPhone,
                password: userInput.enteredPassword,
            }
        }

        props.onDriverRegister(data);

        setUserInput((prevState) => {
            return {
                ...prevState,
                enteredName: '',
                enteredEmail: '',
                enteredPhone: '',
                enteredPassword: '',
            };
        });
    }

    return (
        <Card className={classes.register}>
            <div className={`${classes["register-header"]} d-flex flex-column text-center`}>
                <div>
                    <img src="https://www.iconpacks.net/icons/2/free-parking-sign-icon-1641-thumb.png"
                         alt="parking-logo"
                         width="100"
                         height="100"/>
                </div>
                <h2> Inregistrare </h2>
            </div>

            <form>
                <Input
                    id="name"
                    label="Nume"
                    type="text"
                    placeholder="Introduceti numele"
                    name="enteredName"
                    value={userInput.enteredName}
                    onChange={handleInputChange}
                />
                <Input
                    id="email"
                    label="E-mail"
                    type="email"
                    placeholder="Introduceti adresa de e-mail"
                    name="enteredEmail"
                    value={userInput.enteredEmail}
                    onChange={handleInputChange}
                />
                <Row>
                    <Col md={10} sm={10} xs={8}>
                        <Input
                            id="password"
                            label="Parola"
                            type={showPassword ? "text" : "password"}
                            placeholder="Introduceti parola"
                            name="enteredPassword"
                            value={userInput.enteredPassword}
                            onChange={handleInputChange}
                        />
                    </Col>
                    <Col className={classes["register__actions"]}>
                        <button onClick={handleShowPassword} title="Arata parola">
                            {
                                showPassword ? <EyeOff/> : <Eye/>
                            }
                        </button>
                    </Col>
                </Row>
                <Row>
                    <Col md={10} sm={10} xs={8}>
                        <Input
                            id="verifyPassword"
                            label="Verificare parola"
                            type={showVerifyPassword ? "text" : "password"}
                            placeholder="Reintroduceti parola"
                            name="enteredVerifyPassword"
                            value={userInput.enteredVerifyPassword}
                            onChange={handleInputChange}
                        />
                    </Col>
                    <Col className={classes["register__actions"]}>
                        <button onClick={handleShowVerifyPassword} title="Arata parola">
                            {
                                showVerifyPassword ? <EyeOff/> : <Eye/>
                            }
                        </button>
                    </Col>
                </Row>
                <div className="text-center">
                    <Button className="mt-3" type="submit" onClick={handleRegisterSubmit}>
                        Inregistrare
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
    }
}

const mapDispatchToProps = dispatch => {
    return {
        onDriverRegister: (data) => dispatch(actionCreators.driverRegister(data)),
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(Register);
