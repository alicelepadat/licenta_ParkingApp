import React, {useState} from 'react';
import Input from "../../UI/Input/Input";
import {Check, Edit, Eye, EyeOff} from "react-feather";

import classes from './EditProfile.module.css';
import {Col, Row} from "react-bootstrap";
import InfoHeader from "../../UI/InfoHeader/InfoHeader";
import DrivingLicense from "../DrivingLicense/DrivingLicense";

const EditProfile = props => {

    const [enableModifyPassword, setEnableModifyPassword] = useState(false);
    const [showPassword, setShowPassword] = useState(false);

    const handleShowPassword = (event) => {
        event.preventDefault();
        setShowPassword(!showPassword);
    }

    const handleModifyPassword = (event) => {
        event.preventDefault();
        setEnableModifyPassword(!enableModifyPassword);
    }

    return (
        <React.Fragment>
            <InfoHeader title={`Editeaza profilul pentru ${props.user.userName}`} onCloseClick={props.onClose}/>
            <form>
                <Input
                    id="enteredEmail"
                    label="E-mail"
                    type="email"
                    name="userEmail"
                    value={props.user.userEmail}
                    onChange={props.onInputChange}
                />
                <Row className={classes["modify-profile__controls"]}>
                    <Col md={10} sm={10} xs={8}>
                        <Input
                            id="enteredPassword"
                            label="Parola"
                            type={showPassword ? "text" : "password"}
                            name="userPassword"
                            value={props.user.userPassword}
                            disabled={!enableModifyPassword}
                            onChange={props.onInputChange}
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
                <div className={classes["user-license"]}>
                    <DrivingLicense showEdit={props.showEdit} user={props.user} onInputChange={props.onInputChange}/>
                </div>
            </form>
            <div className={classes["edit-profile__actions"]}>
                <button onClick={props.onClose} title="Salveaza modificarile">
                    <Check/>
                </button>
            </div>
        </React.Fragment>
    );
};

export default EditProfile;
