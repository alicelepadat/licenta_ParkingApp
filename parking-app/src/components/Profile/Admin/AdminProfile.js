import React, {useEffect} from 'react';
import {connect} from 'react-redux';
import * as actionCreators from "../../../store/actions";
import {Card, Col, Row} from "react-bootstrap";
import classes from './AdminProfile.module.css';
import LoadingSpinner from "../../UI/Loading/Loading";
import {Link} from "react-router-dom";
import * as dataUtility from '../../../utility/dataUtility';
import Header from "../Header/Header";

const AdminProfile = props => {

    useEffect(() => {
        if (props.userId) {
            if (props.role && props.role === 210) {
                props.onFetchAdminData(props.userId);
            }
        }
    }, [props.userId, props.role]);

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


    const dashboard = (
        <div>
            <Header profilePicture="/profile.png" user={props.user && props.user.user} header="Panou admin"/>

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
                (props.loading === true && props.loadingReservations === true) ? <LoadingSpinner/> : dashboard
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
        loadingReservations: state.reservations.loading
    };
};

const mapDispatchToProps = dispatch => {
    return {
        onFetchAdminData: (userId) => dispatch(actionCreators.fetchAdminData(userId)),
        onFetchAreaReservations: (areaId) => dispatch(actionCreators.fetchAreaReservations(areaId)),
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(AdminProfile);
