import React, {useState} from 'react';
import Card from "../UI/Card/Card";
import classes from "./Profile.module.css";
import DriverProfile from "./Driver/Driver";
import EditProfile from "./EditProfile/EditProfile";

const Profile = props => {

    const [userData, setUserData] = useState({
        userName: 'Alice',
        userEmail: 'alice22@gmail.com',
        userPassword: 'alicethebest',
    });

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
        <div className="container mt-5 d-flex justify-content-center">
            <Card className={classes["user-card"]}>
                {
                    showEditFields ?
                        <EditProfile
                            user={userData}
                            onInputChange={handleInputChange}
                            onClose={handleEditClose}
                        />
                        :
                        <DriverProfile user={userData} onEdit={handleEditClick}/>
                }

            </Card>
        </div>
    );
};

export default Profile;
