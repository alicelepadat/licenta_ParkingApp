import React, {useEffect, useState} from 'react';
import Card from "../../UI/Card/Card";
import classes from "./Profile.module.css";
import DriverProfile from "../Driver/Driver";
import EditProfile from "../EditProfile/EditProfile";
import * as actionCreators from "../../../store/actions";
import {connect} from "react-redux";
import LoadingSpinner from "../../UI/Loading/Loading";

const ProfileContainer = props => {

    const [showEditFields, setShowEditFields] = useState(false);

    const [userLicenseInput, setUserLicenseInput] = useState({
        enteredLicenseNumber: props.driver ?  props.driver.license && props.driver.license.number : '',
        enteredExpirationDate: props.driver ? props.driver.license &&  props.driver.license.expirationDate : '',
    });

    useEffect(() => {
        if (props.driverId) {
            props.onFetchDriverData(props.driverId);
        }
    }, []);

    const handleInputChange = (event) => {
        setUserLicenseInput((prevState) => {
            return {
                ...prevState,
                [event.target.name]: event.target.value
            };
        });
    };

    const hasDrivingLicense = props.driver ? (!!props.driver.license) : false;

    const handleEditClick = () => {
        setShowEditFields(true);
    };

    const handleEditClose = () => {
        setShowEditFields(false);
    };

    const profile = (
        <DriverProfile
            user={props.driver}
            hasDrivingLicense={hasDrivingLicense}
            licenseField={userLicenseInput}
            onEdit={handleEditClick}
            onLicenseChange={handleInputChange}
            onDriverLogout={props.onDriverLogout}
        />
    );

    const editProfile = (
        <EditProfile
            user={props.driver}
            hasDrivingLicense={hasDrivingLicense}
            onClose={handleEditClose}
            showEdit={showEditFields}
            licenseField={userLicenseInput}
            onLicenseChange={handleInputChange}
        />
    );

    return (
        <div className="container mt-4 mb-4 d-flex justify-content-center">
            {
                props.loading ?
                    <LoadingSpinner/>
                    :
                    <Card className={classes["user-card"]}>
                        {
                            showEditFields ? editProfile : profile
                        }
                    </Card>
            }
        </div>
    );
};

const mapStateToProps = state => {
    return {
        loading: state.driverData.loading,
        error: state.driverData.error,
        driver: state.driverData.driver,
        driverId: state.driverAuth.userId,
    };
};

const mapDispatchToProps = dispatch => {
    return {
        onDriverLogout: () => dispatch(actionCreators.driverLogout()),
        onFetchDriverData: (driverId) => dispatch(actionCreators.fetchDriverData(driverId)),
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(ProfileContainer);
