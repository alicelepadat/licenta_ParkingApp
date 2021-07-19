import React from 'react';
import Card from "../../../components/UI/Card/Card";
import classes from "../WrapperCard.module.css";
import AdminProfile from "../../../components/Profile/Admin/AdminProfile";

const Admin = () => {

    return (
        <div className="container mt-4 mb-4 justify-content-center">
            <Card className={classes["user-card"]}>
                <AdminProfile/>
            </Card>
        </div>
    );
};


export default Admin;
