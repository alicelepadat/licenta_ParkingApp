import React, { Component } from 'react';
import { connect } from 'react-redux';
import { Card, Form, Col, Button } from 'react-bootstrap';
import { format } from 'date-fns';
import { AppBar, Toolbar, IconButton } from '@material-ui/core';
import CloseIcon from '@material-ui/icons/Close';

class Reservation extends Component {
    state = {
        date: new Date(),
        time: {
            hour: new Date().getHours(),
            minutes: new Date().getMinutes()
        },
    };

    render() {
        const todayDate = format(this.state.date, "dd.MM.yyyy");
        return (
            <div>
                <AppBar style={{ position: 'relative', backgroundColor: 'rgb(1, 48, 90)' }}>
                    <Toolbar>
                        <IconButton edge="start" color="inherit" onClick={this.props.onClose} aria-label="close">
                            <CloseIcon />
                        </IconButton>
                    </Toolbar>
                </AppBar>
                <div className="container mt-3">
                    <Card>
                        <Card.Header>
                            <Card.Title className="text-center m-2">Rezerva</Card.Title>
                            <Card.Subtitle className="text-center">{this.props.selectedArea.address.street}</Card.Subtitle>
                        </Card.Header>
                        <Card.Body>
                            <Form>
                                <Form.Row>
                                    <Form.Group as={Col} md="4">
                                        <Form.Label htmlFor="inputReservationDate">Data</Form.Label>
                                        <Form.Control type="text" id="inputReservationDate" defaultValue={todayDate} disabled />
                                    </Form.Group>
                                    <Form.Group as={Col} md="4">
                                        <Form.Label htmlFor="inputReservationStartTime">De la</Form.Label>
                                        <Form.Control type="time" id="inputReservationStartTime" defaultValue={this.state.time.hour + ':' + this.state.time.minutes} />
                                    </Form.Group>
                                    <Form.Group as={Col} md="4">
                                        <Form.Label htmlFor="inputReservationEndTime">Pana la</Form.Label>
                                        <Form.Control type="time" id="inputReservationEndTime" defaultValue={this.state.time.hour + ':' + this.state.time.minutes} />
                                    </Form.Group>
                                </Form.Row>
                                <Form.Group>
                                    <Form.Label htmlFor="inputReservationVehicle">Numar de inmatriculare</Form.Label>
                                    <Form.Row id="inputReservationVehicle">
                                        <Form.Group as={Col} md="4">
                                            <Form.Control type="text" placeholder="B" />
                                        </Form.Group>
                                        <Form.Group as={Col} md="4">
                                            <Form.Control type="text" min={0} className="form-control" placeholder="00" />
                                        </Form.Group>
                                        <Form.Group as={Col} md="4">
                                            <Form.Control type="text" placeholder="BBB" />
                                        </Form.Group>
                                    </Form.Row>
                                </Form.Group>
                                <Form.Group>
                                    <Form.Label htmlFor="inputDriverName">Nume</Form.Label>
                                    <Form.Control type="text" id="inputDriverName" placeholder="Introduceti numele si prenumele dvs." />
                                </Form.Group>
                                <Form.Group>
                                    <Form.Label htmlFor="inputDriverPhone">Telefon</Form.Label>
                                    <Form.Control type="phone" id="inputDriverPhone" placeholder="Introduceti numarul de telefon" />
                                </Form.Group>
                                <div className="text-center mt-2">
                                    <Button type="submit" variant="primary">Rezerva</Button>
                                </div>
                            </Form>
                        </Card.Body>
                    </Card>
                </div>
            </div >
        )
    }
}

const mapStateToProps = state => {
    return {
        selectedArea: state.parkingAreas.selectedArea,
    };
}

export default connect(mapStateToProps)(Reservation);