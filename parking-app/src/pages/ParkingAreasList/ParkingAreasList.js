import React from 'react';
import ParkingAreasContainer from "../../components/ParkingAreasList/ParkingAreasList";
import Card from "../../components/UI/Card/Card";
import classes from "./ParkingAreasList.module.css";

const ParkingAreasList = () => {

    return (
        <div className="container mt-4 mb-4 justify-content-center">
            <Card className={classes["areas-card"]}>
                <ParkingAreasContainer />
            </Card>
        </div>
    );
};


export default ParkingAreasList;
