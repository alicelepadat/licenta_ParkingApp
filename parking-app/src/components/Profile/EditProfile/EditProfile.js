import React, {useState} from 'react';
import Input from "../../UI/Input/Input";
import {Check, Edit, Eye, EyeOff} from "react-feather";

import classes from './EditProfile.module.css';
import {Col, Row} from "react-bootstrap";
import InfoHeader from "../../UI/InfoHeader/InfoHeader";

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
                        <button onClick={handleShowPassword}>
                            {
                                showPassword ? <EyeOff/> : <Eye/>
                            }
                        </button>
                        <button onClick={handleModifyPassword}>
                            {
                                enableModifyPassword ? <Check/> : <Edit/>
                            }
                        </button>
                    </Col>
                </Row>

            </form>
        </React.Fragment>
    );
};

export default EditProfile;
