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
import LoadingSpinner from "../../components/UI/Loading/Loading";

const Vehicles = (props) => {

    const [showAddVehicle, setShowAddVehicle] = useState(false);
    const [enteredLicensePlate, setEnteredLicensePlate] = useState('');

    const handleInputChange = (event) => {
        setEnteredLicensePlate(event.target.value);
    };

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

    const handleVehicleAdd = () => {
        props.onDriverVehicleAdd(props.userId, {
            licensePlate: enteredLicensePlate,
        });

        setShowAddVehicle(false);
        setEnteredLicensePlate('');
    };

    const vehicleList = (
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
                            <Button
                                onClick={() => {
                                    props.onDriverVehicleDelete(props.userId, vehicle.id)
                                }}
                            >
                                Sterge
                            </Button>
                        </Card.Body>
                    </Card>
                ))
            }
        </CardDeck>
    );

    const noVehicleFoundInfo = (
        <Card className={classes["noVehicle-card"]}>
            <h3>
                Nu ati adaugat niciun vehicul.
            </h3>
        </Card>
    );

    return (
        <div className={classes["vehicles-container"]}>
            {
                props.loading ? <LoadingSpinner/>
                    :
                    props.vehicles.length > 0 ? vehicleList : noVehicleFoundInfo
            }

            <div className={classes["vehicles-actions"]}>
                <FloatingButton onClick={handleAddVehicleClick}>
                    <Plus color='var(--DarkBlue)'/>
                </FloatingButton>
            </div>

            {
                showAddVehicle &&
                <NewVehicle
                    data={enteredLicensePlate}
                    onChange={handleInputChange}
                    onCloseClick={handleCloseClick}
                    onAdd={handleVehicleAdd}/>
            }
        </div>
    );
};

const mapStateToProps = state => {
    return {
        userId: state.driverAuth.userId,
        loading: state.driverVehicles.loading,
        error: state.driverVehicles.error,
        vehicles: state.driverVehicles.vehicles,
    };
};

const mapDispatchToProps = dispatch => {
    return {
        onDriverVehiclesFetch: (userId) => dispatch(actionCreators.fetchDriverVehicles(userId)),
        onDriverVehicleDelete: (userId, vehicleId) => dispatch(actionCreators.deleteDriverVehicle(userId, vehicleId)),
        onDriverVehicleAdd: (userId, vehicle) => dispatch(actionCreators.addDriverVehicle(userId, vehicle)),
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(Vehicles);
