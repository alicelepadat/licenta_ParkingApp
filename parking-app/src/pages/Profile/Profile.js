import React from 'react';
import ProfileContainer from "../../components/Profile/Profile/ProfileContainer";
import Login from "../../components/Auth/Login/Login";
import {connect} from "react-redux";

const Profile = (props) => {

    return (
        <React.Fragment>
            {
                props.isDriverLoggedIn ?
                    <ProfileContainer />
                    :
                    <Login />
            }
        </React.Fragment>
    );
};

const mapStateToProps = state => {
    return {
        isDriverLoggedIn: state.driverAuth.isDriverLoggedIn,
    }
}

export default connect(mapStateToProps, null)(Profile);
