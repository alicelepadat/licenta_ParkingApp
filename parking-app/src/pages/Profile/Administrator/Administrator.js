import React from 'react';
import Card from "../../../components/UI/Card/Card";
import classes from "../WrapperCard.module.css";
import AdministratorProfile from "../../../components/Profile/Administrator/Administrator";

const Administrator = () => {

    return (
        <div className="container mt-4 mb-4 justify-content-center">
            <Card className={classes["user-card"]}>
                <AdministratorProfile/>
            </Card>
        </div>
    );
};

export default Administrator;
