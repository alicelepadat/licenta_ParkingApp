import React from 'react';

import classes from './InfoContainer.module.css';
import Card from "../../UI/Card/Card";
import Button from "../../UI/Button/Button";
import InfoHeader from "../../UI/InfoHeader/InfoHeader";
import {Col, Row} from "react-bootstrap";
import {FaDirections} from "react-icons/all";
import LoadingSpinner from "../../UI/Loading/Loading";

const InfoContainer = props => {

    const areaInfo = (
        <Card className={classes["area_info"]}>
            <InfoHeader title={props.area.emplacement} onCloseClick={props.onCloseClick}/>
            <ul>
                <li>
                    <label>Locuri disponibile: </label>
                    <strong> {props.area.availableSpots}</strong>
                </li>
                <li>
                    <label>Pret/ora: </label>
                    <strong> {props.area.pricePerHour} RON</strong>
                </li>
                <li>
                    <label>Localizare amplasament: </label>
                    <strong> {props.area.emplacementLocation !== '' ? props.area.emplacementLocation : '-'}</strong>
                </li>
            </ul>
            <Row>
                <Col>
                    <Button className={classes["area-info__directions"]} title="Vezi ruta">
                        <FaDirections/>
                    </Button>
                </Col>
                <Col className="text-end">
                    <Button onClick={props.onReserve} disabled={props.area.availableSpots === 0}>Rezerva</Button>
                </Col>
            </Row>
        </Card>
    );

    return (
        <React.Fragment>
            {
                props.loading ? <LoadingSpinner/> : props.area && areaInfo
            }
        </React.Fragment>
    );
}

export default InfoContainer;
