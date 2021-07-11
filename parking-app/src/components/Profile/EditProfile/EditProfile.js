import React, {useState} from 'react';
import Input from "../../UI/Input/Input";
import {Check, Edit, Eye, EyeOff} from "react-feather";

import classes from './EditProfile.module.css';
import {Col, Row} from "react-bootstrap";
import InfoHeader from "../../UI/InfoHeader/InfoHeader";
import DrivingLicense from "../DrivingLicense/DrivingLicense";
import * as validate from "../../../utility/validateHandler";
import * as actionCreators from "../../../store/actions";
import {connect} from "react-redux";

const EditProfile = props => {

    const [userInput, setUserInput] = useState({
        email: props.user.user.email,
        phone: props.user.user.phone,
        newPassword: '',
    });

    const [inputIsValid, setInputIsValid] = useState({
        email: true,
        phone: true,
        newPassword: true,
    });

    const validateRules = {
        email: {
            isRequired: true,
            isEmail: true,
        },
        phone: {
            isRequired: true,
            isPhoneNumber: true,
        },
    };

    const [enableModifyPassword, setEnableModifyPassword] = useState(false);
    const [showPassword, setShowPassword] = useState(false);

    const handleShowPassword = (event) => {
        event.preventDefault();
        setShowPassword(!showPassword);
    };

    const handleModifyPassword = (event) => {
        event.preventDefault();
        setEnableModifyPassword(!enableModifyPassword);
    };

    const handleInputChange = (event) => {
        setUserInput((prevState) => {
            return {
                ...prevState,
                [event.target.name]: event.target.value
            };
        });
    };

    const handleValidateUserInput = (event) => {
        setInputIsValid((prevState => {
            return {
                ...prevState,
                [event.target.name]:
                    validate.checkValidity(event.target.value,
                        validateRules[event.target.name]),
            };
        }));
    };

    const handleEditSubmit = (event) => {
        event.preventDefault();

        const driverUpdateData = {
            id: props.userId,
            user: {
                id: props.user.user.id,
                name: props.user.user.name,
                email: userInput.email,
                phone: userInput.phone,
                password: userInput.newPassword ? userInput.newPassword : props.user.user.password,
            },
            license: {
                id: props.user.license.id,
                number: props.licenseField.enteredLicenseNumber ? props.licenseField.enteredLicenseNumber : props.driver.license.number,
                expirationDate: props.licenseField.enteredExpirationDate ? props.licenseField.enteredExpirationDate : props.driver.license.expirationDate,
            },
        };

        if (inputIsValid.email && inputIsValid.phone && inputIsValid.newPassword) {
            props.onDriverUpdate(props.userId, driverUpdateData);

            props.onClose();
        }
    }

    return (
        <React.Fragment>
            <InfoHeader title={`Editeaza profilul pentru ${props.user.user.name}`} onCloseClick={props.onClose}/>
            <form>
                <Input
                    id="enteredEmail"
                    label="E-mail"
                    type="email"
                    name="email"
                    placeholde="Introduceti noua adresa de e-mail"
                    isValid={inputIsValid.email}
                    value={userInput.email}
                    onChange={handleInputChange}
                    onBlur={handleValidateUserInput}
                />
                <Input
                    id="enteredPhone"
                    label="Numar de telefon"
                    type="text"
                    name="phone"
                    placeholde="Introduceti noul numar de telefon"
                    isValid={inputIsValid.phone}
                    value={userInput.phone}
                    onChange={handleInputChange}
                    onBlur={handleValidateUserInput}
                />
                <Row className={classes["modify-profile__controls"]}>
                    <Col md={10} sm={8} xs={8}>
                        <Input
                            id="enteredPassword"
                            label="Parola"
                            type={showPassword ? "text" : "password"}
                            name="newPassword"
                            placeholder="Introduceti noua parola"
                            disabled={!enableModifyPassword}
                            isValid={inputIsValid.newPassword}
                            value={userInput.newPassword}
                            onChange={handleInputChange}
                        />
                    </Col>
                    <Col className={classes["modify-profile__actions"]}>
                        <button onClick={handleShowPassword} title="Arata parola">
                            {
                                showPassword ? <EyeOff/> : <Eye/>
                            }
                        </button>
                        <button onClick={handleModifyPassword} title="Modifica parola">
                            {
                                enableModifyPassword ? <Check/> : <Edit/>
                            }
                        </button>
                    </Col>
                </Row>
                {
                    props.hasDrivingLicense &&
                    <div className={classes["user-license"]}>
                        <DrivingLicense
                            showEdit={props.showEdit}
                            user={props.user}
                            licenseField={props.licenseField}
                            onLicenseChange={props.onLicenseChange}
                        />
                    </div>
                }
            </form>
            <div className={classes["edit-profile__actions"]}>
                <button onClick={handleEditSubmit} title="Salveaza modificarile">
                    <Check/>
                </button>
            </div>
        </React.Fragment>
    );
};

const mapStateToProps = state => {
    return {
        loading: state.driverAuth.loading,
        error: state.driverAuth.error,
        userId: state.driverAuth.userId,
        driver: state.driverData.user,
    }
}

const mapDispatchToProps = dispatch => {
    return {
        onDriverUpdate: (driverId, driverUpdateData) => dispatch(actionCreators.updateDriver(driverId, driverUpdateData)),
        onFetchDriverData: (driverId) => dispatch(actionCreators.fetchDriverData(driverId)),
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(EditProfile);
