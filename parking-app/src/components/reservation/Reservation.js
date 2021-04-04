import React, { Component } from 'react';
import { connect } from 'react-redux';
import { Card, Form, Col, Button } from 'react-bootstrap';
import { format } from 'date-fns';
import { AppBar, Toolbar, IconButton, RadioGroup, Radio, FormControlLabel } from '@material-ui/core';
import { Spinner, Alert } from 'react-bootstrap';
import CloseIcon from '@material-ui/icons/Close';
import * as validate from '../validate';
import './Reservation.css';
import * as actionCreators from '../../store/actions/index';

class Reservation extends Component {
    state = {
        date: null,
        startTime: null,
        endTime: null,
        licensePlate: null,
        errors: {
            date: '',
            startTime: '',
            endTime: '',
            licensePlate: '',
        },
        rules: {
            date: {
                isRequired: true
            },
            startTime: {
                isRequired: true,
                isTime: true,
            },
            endTime: {
                isRequired: true,
                isTime: true,
            },
            licensePlate: {
                isLicensePlate: true
            },
        },
        isErrorNotification: true,
        isSuccessNotification: true,
    };

    initDateTime = () => {
        const todayDate = format(new Date(), "yyyy-MM-dd");
        const currentTime = validate.formatTime(new Date())
        const nextHourTime = validate.formatTime(validate.addHoursToDate(new Date(), 1))
        this.setState({
            date: todayDate,
            startTime: currentTime,
            endTime: nextHourTime,
        })
    }

    handleErrorNotificationClose = () => {
        this.setState({ isErrorNotification: false })
    }

    handleSuccessNotificationClose = () => {
        this.setState({ isSuccessNotification: false })
    }

    handleChange = (event) => {
        event.preventDefault();
        const { name, value } = event.target;
        let errors = this.state.errors;
        let rules = this.state.rules;

        switch (name) {
            case 'startTime':
                if (!validate.checkValidity(value, rules.startTime)) {
                    errors.startTime = 'Nu puteti selecta o ora anterioara.';
                }
                else if (!validate.verifyReservationTime(this.state.endTime, value)) {
                    errors.startTime = 'Interval nevalid. Puteti rezerva minim o ora.';
                }
                else {
                    errors.startTime = '';
                }
                break;
            case 'endTime':
                errors.endTime =
                    (validate.checkValidity(value, rules.endTime) &&
                        validate.verifyReservationTime(value, this.state.startTime))
                        ? '' : 'Interval nevalid. Puteti rezerva minim o ora.'
                break;
            case 'licensePlate':
                errors.licensePlate =
                    validate.checkValidity(value, rules.licensePlate)
                        ? '' : 'Numar de inmatriculare nevalid.';
                break;
            default:
                break;
        }

        this.setState({ errors, [name]: value });
    }

    handleSubmit = (event) => {
        event.preventDefault();

        const reservationData = {
            reservationDate: this.state.date,
            startTime: this.state.startTime,
            endTime: this.state.endTime,
            vehicle: {
                licensePlate: this.state.licensePlate
            }
        }

        if (validate.validateForm(this.state.errors)) {
            this.props.onReserve(reservationData, this.props.userId, 4)
        }
    }

    componentDidMount() {
        this.initDateTime();
    }

    render() {
        const { errors } = this.state;

        const todayDate = format(new Date(), "yyyy-MM-dd");
        const tomDate = new Date();
        tomDate.setDate(tomDate.getDate() + 1);
        const tomorrowDate = format(tomDate, "yyyy-MM-dd");

        console.log(this.state)

        let loading = null;
        if (this.props.loading) {
            loading = (
                <div className="text-center">
                    <Spinner animation="border" variant="primary" />
                </div>)
        }

        let errorMessage = null;

        if (this.props.error) {
            errorMessage = (
                <div className="text-center">
                    <Alert show={this.state.isErrorNotification} onClose={this.handleErrorNotificationClose} variant="danger" dismissible>
                        <Alert.Heading></Alert.Heading>
                        <p>{this.props.error ? this.props.error : 'A aparut o eroare la cererea dumneavoastra.'}</p>
                    </Alert>
                </div>
            )
        }
        let successMessage = null;
        if (this.props.reservationId) {
            successMessage = (
                <div className="text-center">
                    <Alert show={this.state.isSuccessNotification} onClose={this.handleSuccessNotificationClose} variant="success" dismissible>
                        <Alert.Heading></Alert.Heading>
                        <p>Succes</p>
                    </Alert>
                </div>
            )
        }

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
                            <Card.Subtitle className="text-center">
                                {/* {this.props.selectedArea.address.street} */}
                            </Card.Subtitle>
                        </Card.Header>
                        <Card.Body>
                            {loading}
                            {errorMessage}
                            {successMessage}
                            <Form onSubmit={this.handleSubmit}>
                                <Form.Group>
                                    <Form.Label>Data</Form.Label>
                                    <Form.Row>
                                        <Col md="6">
                                            <RadioGroup required row name="date" value={this.state.date} onChange={this.handleChange}>
                                                <FormControlLabel value={todayDate} control={<Radio />} label="astazi" />
                                                <FormControlLabel value={tomorrowDate} control={<Radio />} label="maine" />
                                            </RadioGroup>
                                        </Col>
                                        <Col md="6">
                                            <Form.Control
                                                required
                                                name="date"
                                                type="text"
                                                placeholder="Selectati data"
                                                value={this.state.date === null ? '' : this.state.date}
                                                readOnly={true} />
                                        </Col>
                                    </Form.Row>
                                </Form.Group>
                                <Form.Row>
                                    <Form.Group as={Col} md="6">
                                        <Form.Label>De la</Form.Label>
                                        <Form.Control
                                            className={errors.startTime ? "time-nevalid" : "time-valid"}
                                            required
                                            name='startTime'
                                            type="time"
                                            defaultValue={this.state.startTime}
                                            onChange={this.handleChange}
                                            isInvalid={errors.startTime.length > 0} />
                                        <Form.Control.Feedback type="invalid">{errors.startTime}</Form.Control.Feedback>
                                    </Form.Group>
                                    <Form.Group as={Col} md="6">
                                        <Form.Label>Pana la</Form.Label>
                                        <Form.Control
                                            className={errors.endTime ? "time-nevalid" : "time-valid"}
                                            required
                                            name='endTime'
                                            type="time"
                                            defaultValue={this.state.endTime}
                                            onChange={this.handleChange}
                                            isInvalid={errors.endTime.length > 0} />
                                        <Form.Control.Feedback type="invalid">{errors.endTime}</Form.Control.Feedback>
                                    </Form.Group>
                                </Form.Row>
                                <Form.Group>
                                    <Form.Label>Numar de inmatriculare</Form.Label>
                                    <Form.Control
                                        required
                                        placeholder="B00BBB"
                                        name='licensePlate'
                                        type="text"
                                        onChange={this.handleChange}
                                        isInvalid={errors.licensePlate.length > 0} />
                                    <Form.Control.Feedback type="invalid">{errors.licensePlate}</Form.Control.Feedback>
                                    <Form.Check type='checkbox'>
                                        <Form.Check.Input type='checkbox' checked readOnly />
                                        <Form.Check.Label>Adauga la masinile mele</Form.Check.Label>
                                    </Form.Check>
                                </Form.Group>
                                <div className="text-center mt-2">
                                    <Button type="submit" variant="primary">
                                        Rezerva
                                    </Button>
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
        userId: state.auth.userId,
        reservationId: state.reserve.reservationId,
        loading: state.reserve.loading,
        error: state.reserve.error
    };
}

const mapDispatchToProps = dispatch => {
    return {
        onReserve: (reservationData, userId, areaId) => dispatch(actionCreators.reserve(reservationData, userId, areaId))
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(Reservation);