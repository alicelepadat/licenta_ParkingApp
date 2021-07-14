import React, {useEffect, useState} from 'react';
import {connect} from 'react-redux';
import * as actionCreators from "../../../store/actions";
import {Card, Col, Row} from "react-bootstrap";
import classes from './AdminProfile.module.css';
import LoadingSpinner from "../../UI/Loading/Loading";
import Button from "../../UI/Button/Button";
import {ArrowRight} from "react-feather";
import {Link, useHistory} from "react-router-dom";
import * as dataUtility from '../../../utility/dataUtility';

const AdminProfile = props => {
    const history = useHistory();

    useEffect(() => {
        if (props.userId) {
            if (props.user && props.role === 210) {
                props.onFetchAreaReservations(props.user.parkingArea.id)
            }
        }
    }, [props.userId, props.role, props.user]);

    const activeReservations = props.reservations && dataUtility.getNumberOfReservatiosn(props.reservations, 100);
    const progresReservations = props.reservations && dataUtility.getNumberOfReservatiosn(props.reservations, 110);
    const canceledReservations = props.reservations && dataUtility.getNumberOfReservatiosn(props.reservations, 120);
    const finishedReservations = props.reservations && dataUtility.getNumberOfReservatiosn(props.reservations, 130);

    useEffect(() => {
        if (props.userId) {
            if (props.role && props.role === 210) {
                props.onFetchAdminData(props.userId);
            }
        }
    }, [props.userId, props.role]);

    const handleLogout = () => {
        props.onAdminLogout();
        props.onRemoveUserData();
        history.push('/login');
    }

    const dashboard = (
        <div>
            <Row className="d-flex text-center align-items-center">
                <Col md={3}>
                    <img className="rounded"
                         src="/profile.png"
                         width="155"
                         height="155"
                         alt="poza de profil"
                    />
                </Col>
                <Col>
                    <div className={classes.admin}>
                        <h2>Panou admin</h2>
                        <span className="mt-4">
                            Email: {props.user && props.user.user.email}
                        </span>
                        <span className="mt-2">
                            Telefon: {props.user && props.user.user.phone}
                        </span>
                        <div className="mt-4">
                            <Button onClick={handleLogout}>
                                Iesi din cont <ArrowRight/>
                            </Button>
                        </div>
                    </div>
                </Col>
            </Row>
            <div className={classes["admin-area__note"]}>
                <p>Zona de parcare aflata in administrare:</p>
            </div>
            <Card className={classes["admin-area"]}>
                <Card.Header className="text-center">
                    <h3>{props.user && props.user.parkingArea.emplacement}</h3>
                </Card.Header>
                <Card.Body>
                    <div className={classes["admin-area-info"]}>
                        <div>
                            <strong>Localizare amplasament: </strong>
                            <span>{props.user && props.user.parkingArea.emplacementLocation}</span>
                        </div>
                        <div>
                            <strong>Zona: </strong>
                            <span>{props.user && dataUtility.getAreaZone(props.user.parkingArea.pricePerHour)}</span>
                        </div>
                        <div>
                            <strong>Capacitate totala: </strong>
                            <span>{props.user && props.user.parkingArea.totalSpots} locuri</span>
                        </div>
                        <div>
                            <strong>Locuri disponibile: </strong>
                            <span>{props.user && props.user.parkingArea.availableSpots}</span>
                        </div>
                    </div>
                </Card.Body>
                <Card.Footer>
                    <div className={classes["area-reservations"]}>
                        <p>
                            <Link to="/reservations" title="Vezi rezervari">REZERVARI</Link>
                        </p>
                        <Row className="text-start">
                            <Col sm>
                                <p>active: {activeReservations}</p>
                            </Col>
                            <Col sm>
                                <p>in progres: {progresReservations}</p>
                            </Col>
                            <Col sm>
                                <p>anulate: {canceledReservations}</p>
                            </Col>
                            <Col sm>
                                <p>finalizate: {finishedReservations}</p>
                            </Col>
                        </Row>
                    </div>
                </Card.Footer>
            </Card>
        </div>
    )

    return (
        <React.Fragment>
            {
                props.loading === true ? <LoadingSpinner/> : dashboard
            }
        </React.Fragment>
    );
};

const mapStateToProps = state => {
    return {
        loading: state.driverData.loading,
        error: state.driverData.error,
        user: state.driverData.user,
        userId: state.driverAuth.userId,
        role: state.driverAuth.role,
        reservations: state.reservations.reservations,
    };
};

const mapDispatchToProps = dispatch => {
    return {
        onAdminLogout: () => dispatch(actionCreators.authLogout()),
        onRemoveUserData: () => dispatch(actionCreators.removeUserData()),
        onFetchAdminData: (userId) => dispatch(actionCreators.fetchAdminData(userId)),
        onFetchAreaReservations: (areaId) => dispatch(actionCreators.fetchAreaReservations(areaId)),
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(AdminProfile);
