import React, { Component } from 'react';
import { Accordion, Card, Button } from 'react-bootstrap';

class ReservationList extends Component {
    render() {
        return (
            <div className="container mt-3">
                <Accordion>
                    <Card>
                        <Card.Header className="d-flex">
                            <Card.Title>Rezervare</Card.Title>
                            <Accordion.Toggle as={Button} color="primary" eventKey="0" className="ml-auto">
                                Detalii
                            </Accordion.Toggle>
                        </Card.Header>
                        <Accordion.Collapse eventKey="0">
                            <Card.Body>Info Rezervare</Card.Body>
                        </Accordion.Collapse>
                    </Card>
                </Accordion>
            </div>
        )
    }
}

export default ReservationList;