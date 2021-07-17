import React, {useState} from 'react';
import {Col, Row} from "react-bootstrap";
import Button from "../../UI/Button/Button";
import {ArrowRight, Eye, EyeOff, Key} from "react-feather";

import classes from './Header.module.css';
import {useHistory} from "react-router-dom";
import * as actionCreators from "../../../store/actions";
import {connect} from "react-redux";
import Modal from "../../UI/Modal/Modal";
import Input from "../../UI/Input/Input";
import * as validate from "../../../utility/validateHandler";

function ProfileHeader(props) {

    const history = useHistory();

    const [changePassword, setChangePassword] = useState(false);
    const [showPassword, setShowPassword] = useState(false);
    const [enteredPassword, setEnteredPassword] = useState('');
    const [passwordIsValid, setPasswordIsValid] = useState();

    const validateRules = {
        enteredPassword: {
            isRequired: true,
            minLength: 8,
        },
    }

    const handleChangePasswordClick = () => {
        setChangePassword(true);
    }

    const handleChangePasswordClose = () => {
        setChangePassword(false);
    }

    const handleShowPassword = (event) => {
        event.preventDefault();
        setShowPassword(!showPassword);
    };

    const handleInputChange = (event) => {
        setEnteredPassword(event.target.value);
    }

    const handleLogout = () => {
        props.onLogout();
        props.onRemoveUserData();
        history.push('/login');
    }

    const handleValidateUserInput = (event) => {
        setPasswordIsValid(validate.checkValidity(event.target.value, validateRules["enteredPassword"]));
    };

    const handleUpdateUserPassword = () => {

        const data = {
            id: props.user.id,
            name: props.user.name,
            email: props.user.email,
            phone: props.user.phone,
            role: props.user.role,
            password: enteredPassword,
        }

        props.onUpdatePassword(props.user.id, data);
        handleLogout();
    }

    console.log(props.user)

    return (
        <Row className="d-flex text-center align-items-center">
            <Col md={3}>
                <img className="rounded"
                     src={props.profilePicture}
                     width="155"
                     height="155"
                     alt="poza de profil"
                />
            </Col>
            <Col>
                <div className={classes["profile-header"]}>
                    <h2>{props.header}</h2>
                    <span className="mt-4">
                        Email: {props.user && props.user.email}
                    </span>
                    <span className="mt-2">
                        Telefon: {props.user && props.user.phone}
                    </span>
                    <button aria-label="Modifica parola" title="Modifica parola" onClick={handleChangePasswordClick}>
                        <Key/></button>
                    <div className="mt-4">
                        <Button onClick={handleLogout}>
                            Iesi din cont <ArrowRight/>
                        </Button>
                    </div>
                </div>
            </Col>
            {
                changePassword &&
                <Modal title="Modifica parola"
                       message="Introduceti noua parola"
                       cancel={true}
                       onCancel={handleChangePasswordClose}
                       onConfirm={handleUpdateUserPassword}
                >
                    <div className={classes["user-password"]}>
                        <Input
                            id="password"
                            label="Parola"
                            type={showPassword ? "text" : "password"}
                            placeholder="Introduceti noua parola"
                            name="enteredPassword"
                            value={enteredPassword}
                            isValid={passwordIsValid}
                            onChange={handleInputChange}
                            onBlur={handleValidateUserInput}
                        >
                            <button onClick={handleShowPassword} title="Arata parola">
                                {
                                    showPassword ? <EyeOff/> : <Eye/>
                                }
                            </button>
                        </Input>
                    </div>
                </Modal>
            }
        </Row>
    );
}

const mapDispatchToProps = dispatch => {
    return {
        onLogout: () => dispatch(actionCreators.authLogout()),
        onRemoveUserData: () => dispatch(actionCreators.removeUserData()),
        onUpdatePassword: (userId, data) => dispatch(actionCreators.updateUserPassword(userId, data)),
    };
};

export default connect(null, mapDispatchToProps)(ProfileHeader);
