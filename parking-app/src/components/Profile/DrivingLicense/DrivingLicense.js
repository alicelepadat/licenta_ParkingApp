import React from 'react';
import {Card, Col, Row} from "react-bootstrap";

import classes from './DrivingLicense.module.css';
import {Edit} from "react-feather";

const DrivingLicense = props => {

    return (
        <Card className={classes["license"]}>
            <Card.Header>
                <Row>
                    <Col md={2} xs={2}>
                        <img
                            src="https://image.flaticon.com/icons/png/512/330/330426.png"
                            alt="EU"
                            width={30}
                        />
                    </Col>
                    <Col>
                        <span>PERMIS DE CONDUCERE</span>
                    </Col>
                    <Col md={2} xs={2} className="text-end">
                        <span>RO</span>
                    </Col>
                </Row>
            </Card.Header>
            <Card.Body className={classes["license__body"]}>
                <div>
                    <Card.Text>Numar: <span> BF768GHHJN</span></Card.Text>
                </div>
                <div className={classes["license__valability"]}>
                    <Card.Text>Expira la: <span> 2024/05/23</span></Card.Text>
                </div>
            </Card.Body>
        </Card>
    )
};

export default DrivingLicense;
