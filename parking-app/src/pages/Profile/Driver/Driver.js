import React, { useEffect, useState } from 'react';
import Card from "../../../components/UI/Card/Card";
import DriverProfile from "../../../components/Profile/Driver/DriverProfile";
import EditProfile from "../../../components/Profile/Driver/EditProfile/EditProfile";
import * as actionCreators from "../../../store/actions";
import { connect } from "react-redux";
import LoadingSpinner from "../../../components/UI/Loading/Loading";
import classes from "../Profile.module.css";

const Driver = props => {

    useEffect(() => {
        if (props.userId) {
            switch (props.role) {
                case 210:
                    props.onFetchAdminData(props.userId);
                    break;
                case 200:
                    props.onFetchDriverData(props.userId);
                    break;
                default:
                    break;
            }
        }
    }, [props.userId, props.role]);

    const [showEditFields, setShowEditFields] = useState(false);

    const [userLicenseInput, setUserLicenseInput] = useState({
        enteredLicenseNumber: props.user ? props.user.license && props.user.license.number : '',
        enteredExpirationDate: props.user ? props.user.license && props.user.license.expirationDate : '',
    });

    const handleInputChange = (event) => {
        setUserLicenseInput((prevState) => {
            return {
                ...prevState,
                [event.target.name]: event.target.value
            };
        });
    };

    const hasDrivingLicense = props.user ? (!!props.user.license) : false;

    const handleEditClick = () => {
        setShowEditFields(true);
    };

    const handleEditClose = () => {
        setShowEditFields(false);
    };

    const handleResetLicenseInput = () => {
        setUserLicenseInput(prevState => {
            return {
                ...prevState,
                enteredLicenseNumber: '',
                enteredExpirationDate: '',
            };
        });
    };

    const profile = (
        <DriverProfile
            user={props.user}
            hasDrivingLicense={hasDrivingLicense}
            licenseField={userLicenseInput}
            onEdit={handleEditClick}
            onLicenseChange={handleInputChange}
            onDriverLogout={props.onDriverLogout}
            onReset={handleResetLicenseInput}
        />
    );

    const editProfile = (
        <EditProfile
            user={props.user}
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
                    <LoadingSpinner />
                    :
                    <Card className={classes["user-card"]}>
                        {
                            props.userId && (showEditFields ? editProfile : profile)
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
        user: state.driverData.user,
        userId: state.driverAuth.userId,
        role: state.driverAuth.role,
    };
};

const mapDispatchToProps = dispatch => {
    return {
        onDriverLogout: () => dispatch(actionCreators.authLogout()),
        onFetchDriverData: (userId) => dispatch(actionCreators.fetchDriverData(userId)),
        onFetchAdminData: (userId) => dispatch(actionCreators.fetchAdminData(userId)),
        getUserRole: (userId) => dispatch(actionCreators.getUserRole(userId)),
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(Driver);
