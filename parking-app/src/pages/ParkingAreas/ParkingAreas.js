import React from 'react';
import ParkingAreasContainer from "../../components/ParkingAreas/ParkingAreas";
import Card from "../../components/UI/Card/Card";
import classes from "./ParkingAreas.module.css";

const ParkingAreas = () => {

    return (
        <div className="container mt-4 mb-4 justify-content-center">
            <Card className={classes["areas-card"]}>
                <ParkingAreasContainer/>
            </Card>
        </div>
    );
};


export default ParkingAreas;
