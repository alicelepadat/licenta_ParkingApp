import React from 'react';
import {Col, Row} from "react-bootstrap";
import Button from "../../UI/Button/Button";
import {ArrowRight} from "react-feather";

import classes from './Header.module.css';
import {useHistory} from "react-router-dom";
import * as actionCreators from "../../../store/actions";
import {connect} from "react-redux";

function ProfileHeader(props) {

    const history = useHistory();

    const handleLogout = () => {
        props.onLogout();
        props.onRemoveUserData();
        history.push('/login');
    }

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
                    <div className="mt-4">
                        <Button onClick={handleLogout}>
                            Iesi din cont <ArrowRight/>
                        </Button>
                    </div>
                </div>
            </Col>
        </Row>
    );
}

const mapDispatchToProps = dispatch => {
    return {
        onLogout: () => dispatch(actionCreators.authLogout()),
        onRemoveUserData: () => dispatch(actionCreators.removeUserData()),
    };
};

export default connect(null, mapDispatchToProps)(ProfileHeader);
