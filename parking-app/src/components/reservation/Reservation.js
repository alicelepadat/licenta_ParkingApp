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
        }
    };

    onChange = (ev) => this.setState({ value: ev.target.value });

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
                        <Card.Title className="text-center m-2">Rezerva</Card.Title>
                        {this.props.selectedArea !== '' && (<hr></hr>)}
                        <Card.Subtitle className="text-center">{this.props.selectedArea}</Card.Subtitle>
                        <hr></hr>
                        <Card.Body>
                            <Form>
                                <Form.Row>
                                    <Form.Group as={Col} md="4">
                                        <Form.Label htmlFor="inputReservationDate">Data</Form.Label>
                                        <Form.Control type="text" className="form-control" id="inputReservationDate" defaultValue={todayDate} disabled />
                                    </Form.Group>
                                    <Form.Group as={Col} md="4">
                                        <Form.Label htmlFor="inputReservationStartTime">De la</Form.Label>
                                        <Form.Control type="time" className="form-control" id="inputReservationStartTime" defaultValue={this.state.time.hour + ':' + this.state.time.minutes} />
                                    </Form.Group>
                                    <Form.Group as={Col} md="4">
                                        <Form.Label htmlFor="inputReservationEndTime">Pana la</Form.Label>
                                        <Form.Control type="time" className="form-control" id="inputReservationEndTime" defaultValue={this.state.time.hour + ':' + this.state.time.minutes} />
                                    </Form.Group>
                                </Form.Row>
                                <Form.Group>
                                    <Form.Label htmlFor="inputReservationVehicle">Numar de inmatriculare</Form.Label>
                                    <Form.Row id="inputReservationVehicle">
                                        <Form.Group as={Col} md="4">
                                            <Form.Control type="text" className="form-control" placeholder="B" />
                                        </Form.Group>
                                        <Form.Group as={Col} md="4">
                                            <Form.Control type="text" min={0} className="form-control" placeholder="00" />
                                        </Form.Group>
                                        <Form.Group as={Col} md="4">
                                            <Form.Control type="text" className="form-control" placeholder="BBB" />
                                        </Form.Group>
                                    </Form.Row>
                                </Form.Group>
                                <Form.Group>
                                    <Form.Label htmlFor="inputDriverName">Nume</Form.Label>
                                    <Form.Control type="text" className="form-control" id="inputDriverName" placeholder="Introduceti numele si prenumele dvs." />
                                </Form.Group>
                                <Form.Group>
                                    <Form.Label htmlFor="inputDriverPhone">Telefon</Form.Label>
                                    <Form.Control type="phone" className="form-control" id="inputDriverPhone" placeholder="Introduceti numarul de telefon" />
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
        selectedArea: state.selectedArea,
    };
}

export default connect(mapStateToProps)(Reservation);