import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import { Accordion, Card, Alert, Spinner } from 'react-bootstrap';
import Button from '@material-ui/core/Button';
import { connect } from 'react-redux';
import * as actionCreators from '../../store/actions/index';
import { format } from 'date-fns';
import * as validate from '../validate';


class ReservationList extends Component {

    setReservationColor = (state) => {
        switch (state) {
            case 130: return 'rgb(247, 142, 142)';
            case 120: return '#0275d8';
            case 110: return 'rgb(142, 247, 156)';
            default: return '#f0ad4e';
        }
    }

    getReservationState = (state) => {
        switch (state) {
            case 110: return 'activa';
            case 130: return 'anulata';
            case 100: return 'in progres';
            default: return 'terminata';
        }
    }

    handleSort = (a, b) => {
        return a.state - b.state;
    }

    componentDidMount() {
        if (this.props.userId) {
            this.props.onReservationsFetched(this.props.userId);
        }
    }

    render() {

        let loading = null;
        if (this.props.loading) {
            loading = (
                <div className="text-center">
                    <Spinner animation="border" variant="primary" />
                </div>)
        }

        let authMessage = null;
        let reservationList = null;

        if (!this.props.userId) {
            authMessage = (
                <Alert variant='danger'>
                    <Link to="/profile">Autentificati-va</Link> pentru a putea vedea rezervarile.
                </Alert>
            )
        }
        else {
            this.props.reservations.length > 0 ?
                reservationList = this.props.reservations.sort(this.handleSort).map((reservation, index) => (
                    <Accordion key={index}>
                        <Card>
                            <Card.Header className="d-flex">
                                <div style={{ color: this.setReservationColor(reservation.state) }}>
                                    <Card.Title>{reservation.parkingArea.address.street}</Card.Title>
                                    <Card.Subtitle className="mb-2 text-muted">
                                        stare: {this.getReservationState(reservation.state)} ({format(new Date(reservation.reservationDate), "dd/MM/yyyy")})
                                    </Card.Subtitle>
                                </div>
                                <Accordion.Toggle as={Button} color="primary" eventKey="0" className="ml-auto">
                                    Detalii
                                </Accordion.Toggle>
                            </Card.Header>
                            <Accordion.Collapse eventKey="0">
                                <Card.Body>
                                    <Card.Text>Interval:
                                {validate.formatTime(new Date(reservation.startTime))} -
                                {validate.formatTime(new Date(reservation.endTime))}
                                    </Card.Text>
                                    <Card.Text>
                                        Adresa: {reservation.parkingArea.address.directions},
                                    {reservation.parkingArea.address.county},
                                    {reservation.parkingArea.address.city}
                                    </Card.Text>
                                    <div className="d-flex justify-content-around">
                                        {reservation.state === 110 ?
                                            <Button className="mr-3" color="primary"
                                                onClick={() => this.props.onReservationCancelled(this.props.userId, reservation.id)}>
                                                Anuleaza
                                            </Button>
                                            : <Button className="mr-3" color="primary" disabled>Anuleaza</Button>
                                        }
                                        <Button className="mr-3" color="secondary"
                                            onClick={() => this.props.onDeleteReservation(this.props.userId, reservation.id)}>Sterge</Button>
                                    </div>
                                </Card.Body>
                            </Accordion.Collapse>
                        </Card>
                    </Accordion>
                ))
                : reservationList = (<Alert variant='info'>Nu aveti nicio rezervare.</Alert>)
        }
        return (
            <div className="container mt-3">
                {authMessage}
                {this.props.loading ? loading : reservationList}
            </div>
        )
    }
}

const mapStateToProps = state => {
    return {
        userId: state.auth.userId,
        reservations: state.reserve.reservations,
        loading: state.reserve.loading,
    };
}

const mapDispatchToProps = dispatch => {
    return {
        onReservationsFetched: (userId) => dispatch(actionCreators.fetchReservations(userId)),
        onReservationCancelled: (userId, reservationId) => dispatch(actionCreators.cancelReservation(userId, reservationId)),
        onDeleteReservation: (userId, reservationId) => dispatch(actionCreators.deleteReservation(userId, reservationId)),
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(ReservationList);