/* eslint-disable */

import React, { useEffect } from 'react';
import { connect } from "react-redux";
import * as actionCreators from "../../../store/actions";
import LoadingSpinner from "../../UI/Loading/Loading";
import Header from "../Header/Header";

import classes from './Administrator.module.css';
import { Col, Row } from "react-bootstrap";
import { Link } from "react-router-dom";

const AdministratorProfile = (props) => {
    useEffect(() => {
        if (props.userId) {
            if (props.role && props.role === 220) {
                props.onFetchAdministratorData(props.userId);
            }
        }
    }, [props.userId, props.role]);

    useEffect(() => {
        if (props.userId) {
            if (props.user && props.role === 220) {
                props.onFetchAllAreas();
            }
        }
    }, [props.userId, props.role, props.user]);

    const dashboard = (
        <div>
            <Row>
                <Col>
                    <Header profilePicture="/administrator.png" user={props.user} header="Panou administrator" />
                </Col>
                <Col md={3} className="m-auto">

                    <div className={classes["administrator-areas__no"]}>
                        <Link to="/parking-areas">
                            <p>{props.parkingAreas && props.parkingAreas.length}</p>
                        </Link>
                        <div>zone administrate</div>
                    </div>

                </Col>
            </Row>
        </div>
    );

    return (
        <React.Fragment>
            {
                props.loading === true ? <LoadingSpinner /> : dashboard
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
        parkingAreas: state.parkingArea.parkingAreas,
    };
};

const mapDispatchToProps = dispatch => {
    return {
        onFetchAdministratorData: (userId) => dispatch(actionCreators.fetchAdministratorData(userId)),
        onFetchAllAreas: () => dispatch(actionCreators.fetchParkingAreas()),
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(AdministratorProfile);
