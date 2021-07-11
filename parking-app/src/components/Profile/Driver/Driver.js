import React, {useState} from 'react';

import classes from './Driver.module.css';
import {Col, Row} from "react-bootstrap";
import {ArrowRight, Edit} from "react-feather";
import {Link} from "react-router-dom";
import DrivingLicense from "../DrivingLicense/DrivingLicense";
import Button from "../../UI/Button/Button";
import EditProfile from "../EditProfile/EditProfile";

const DriverProfile = props => {

    const [showNewDrivingLicense, setShowNewDrivingLicense] = useState(false);

    const reservationNumber = props.user ? props.user.vehicles.map((vehicle) => {
        return vehicle.driverReservations.length
    }) : 0;

    const handleAddDrivingLicenseClick = () => {
        setShowNewDrivingLicense(true);
    };

    const handleAddClose = () => {
        setShowNewDrivingLicense(false);
    };

    const handleAddSuccess = () => {
        setShowNewDrivingLicense(false);
    }

    return (
        <React.Fragment>
            <Row className="d-flex align-items-center">
                <Col md={3} className="text-center">
                    <img className="rounded"
                         src="/profile.png"
                         width="155"
                         height="155"
                         alt="poza de profil"
                    />
                </Col>
                <Col>
                    <div className={classes.username}>
                        <div className="d-flex flex-column">
                            <h4 className="mb-2">
                                {props.user && props.user.user.name}
                            </h4>
                            <span className="mt-2">
                                {props.user && props.user.user.email}
                            </span>
                            <span className="mt-2">
                                {props.user && props.user.user.phone}
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
                                {props.user ? props.user.vehicles.length : 0}
                            </Link>
                        </Col>
                        <Col className={`d-flex flex-column ${classes["user-reservations"]}`}>
                                <span>
                                    Rezervari
                                </span>
                            <Link to="/reservations"
                                  title="Vezi rezervari"
                            >
                                {reservationNumber}
                            </Link>
                        </Col>
                    </Row>
                </Col>
            </Row>
            {
                !props.hasDrivingLicense && !showNewDrivingLicense ?
                    <div className={classes["user-license__action"]}>
                        <Button onClick={handleAddDrivingLicenseClick}>Adauga permis de conducere</Button>
                    </div>
                    :
                    <div className={classes["user-license"]}>
                        <DrivingLicense
                            user={props.user}
                            showEdit={showNewDrivingLicense}
                            showAddActions={showNewDrivingLicense}
                            onAddClose={handleAddClose}
                            onAddSuccess={handleAddSuccess}
                            licenseField={props.licenseField}
                            onLicenseChange={props.onLicenseChange}
                        />
                    </div>
            }
            <div className={classes["user-logout"]}>
                <Button onClick={props.onDriverLogout}>
                    Iesi din cont <ArrowRight/>
                </Button>
            </div>
        </React.Fragment>
    );
};

export default DriverProfile;
