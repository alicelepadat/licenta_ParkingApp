import React, {useState} from 'react';
import Card from "../../components/UI/Card/Card";
import classes from "./Profile.module.css";
import DriverProfile from "../../components/Profile/Driver/Driver";
import EditProfile from "../../components/Profile/EditProfile/EditProfile";

const Profile = props => {

    const [userData, setUserData] = useState({
        userName: 'Alice',
        userEmail: 'alice22@gmail.com',
        userPassword: 'alicethebest',
        userDrivingLicense: {
            number: 'BF768GHHJN',
            expirationDate: '2024-05-23',
        },
    });

    const hasDrivingLicense = Object.keys(userData.userDrivingLicense).length > 0;

    const handleInputChange = (event) => {
        setUserData((prevState) => {
            return {
                ...prevState,
                [event.target.name]: event.target.value
            };
        })
    }

    const [showEditFields, setShowEditFields] = useState(false);

    const handleEditClick = () => {
        setShowEditFields(true);
    }

    const handleEditClose = () => {
        setShowEditFields(false);
    }

    return (
        <div className="container mt-4 mb-4 d-flex justify-content-center">
            <Card className={classes["user-card"]}>
                {
                    showEditFields ?
                        <EditProfile
                            user={userData}
                            hasDrivingLicense={hasDrivingLicense}
                            onInputChange={handleInputChange}
                            onClose={handleEditClose}
                            showEdit={showEditFields}
                        />
                        :
                        <DriverProfile user={userData} hasDrivingLicense={hasDrivingLicense} onEdit={handleEditClick}/>
                }

            </Card>
        </div>
    );
};

export default Profile;
