import React, {useState} from 'react';
import {Card, CardDeck} from "react-bootstrap";
import Button from "../../components/UI/Button/Button";

import classes from './Vehicles.module.css';
import {BiCar} from "react-icons/bi";
import {Plus} from "react-feather";
import FloatingButton from "../../components/UI/FloatingButton/FloatingButton";
import NewVehicle from "../../components/NewVehicle/NewVehicle";

const DUMMY_VEHICLES = [
    {
        licensePlate: 'DB99ALI',
    },
    {
        licensePlate: 'DB05LPY',
    }
]

export default function Vehicles() {

    const [showAddVehicle, setShowAddVehicle] = useState(false);

    const handleAddVehicleClick = () => {
        setShowAddVehicle(true);
    }

    const handleCloseClick = () => {
        setShowAddVehicle(false);
    }

    return (
        <div>
            <CardDeck>
                {
                    DUMMY_VEHICLES.map((vehicle, index) => (
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
