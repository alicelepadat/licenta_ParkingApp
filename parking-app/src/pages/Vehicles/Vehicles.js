import React, {useEffect, useState} from 'react';
import {Card, CardDeck} from "react-bootstrap";
import Button from "../../components/UI/Button/Button";

import classes from './Vehicles.module.css';
import {BiCar} from "react-icons/bi";
import {Plus} from "react-feather";
import FloatingButton from "../../components/UI/FloatingButton/FloatingButton";
import NewVehicle from "../../components/NewVehicle/NewVehicle";
import {connect} from "react-redux";
import * as actionCreators from "../../store/actions";

const Vehicles = (props) => {

    const [showAddVehicle, setShowAddVehicle] = useState(false);

    useEffect(() => {
        if (props.userId) {
            props.onDriverVehiclesFetch(props.userId);
        }
    }, []);

    const handleAddVehicleClick = () => {
        setShowAddVehicle(true);
    };

    const handleCloseClick = () => {
        setShowAddVehicle(false);
    };

    return (
        <div className={classes["vehicles-container"]}>
            <CardDeck>
                {
                    props.vehicles.length > 0 && props.vehicles.map((vehicle, index) => (
                        <Card key={index} className={classes["vehicle-card"]}>
                            <Card.Body className="text-center">
                                <Card.Title>
                                    <BiCar size={25} color='white'/>
                                </Card.Title>
                                <Card.Text className={classes["vehicle-card__text"]}>
                                    {vehicle.licensePlate}
                                </Card.Text>
                                <Button>Sterge</Button>
                            </Card.Body>
                        </Card>
                    ))
                }
            </CardDeck>

            <div className={classes["vehicles-actions"]}>
                <FloatingButton onClick={handleAddVehicleClick}>
                    <Plus color='var(--DarkBlue)'/>
                </FloatingButton>
            </div>

            {showAddVehicle && <NewVehicle onCloseClick={handleCloseClick}/>}
        </div>
    );
};

const mapStateToProps = state => {
    return {
        userId: state.driverAuth.userId,
        loading: state.driverVehicles.loading,
        error: state.driverVehicles.error,
        vehicles: state.driverVehicles.vehicles,
    }
}

const mapDispatchToProps = dispatch => {
    return {
        onDriverVehiclesFetch: (userId) => dispatch(actionCreators.fetchDriverVehicles(userId)),
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(Vehicles);
