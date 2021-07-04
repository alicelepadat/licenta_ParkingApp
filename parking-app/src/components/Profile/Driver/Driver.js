import React from 'react';

import classes from './Driver.module.css';
import {Col, Row} from "react-bootstrap";
import {Edit} from "react-feather";
import {Link} from "react-router-dom";
import DrivingLicense from "../DrivingLicense/DrivingLicense";


const DriverProfile = props => {

    return (
        <React.Fragment>
            <Row className="d-flex align-items-center">
                <Col md={3} className="text-center">
                    <img className="rounded"
                         src="https://upload.wikimedia.org/wikipedia/commons/9/99/Sample_User_Icon.png"
                         width="155"
                         height="155"
                         alt="poza de profil"
                    />
                </Col>
                <Col>
                    <div className={classes.username}>
                        <div className="d-flex flex-column">
                            <h4 className="mb-2">
                                {props.user.userName}
                            </h4>
                            <span className="mt-2">
                                {props.user.userEmail}
                            </span>
                        </div>
                        <button onClick={props.onEdit} title="Editeaza profilul">
                            <Edit/>
                        </button>
                    </div>
                    <Row className="mt-4 text-white">
                        <Col className={`d-flex flex-column ${classes["user-vehicles"]}`}>
                                <span>
                                    Vehicule
                                </span>
                            <Link to="/cars"
                                  title="Vezi vehicule"
                            >
                                2
                            </Link>
                        </Col>
                        <Col className={`d-flex flex-column ${classes["user-reservations"]}`}>
                                <span>
                                    Rezervari
                                </span>
                            <Link to="/reservations"
                                  title="Vezi rezervari"
                            >
                                3
                            </Link>
                        </Col>
                    </Row>
                </Col>
            </Row>
            <div className={classes["user-license"]}>
                <DrivingLicense user={props.user}/>
            </div>

        </React.Fragment>
    );
};

export default DriverProfile;
