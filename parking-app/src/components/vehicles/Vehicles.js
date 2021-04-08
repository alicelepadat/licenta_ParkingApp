import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import { Card, CardDeck, Button, Spinner, Alert } from 'react-bootstrap';
import { FaCarSide } from "react-icons/fa";
import AddIcon from '@material-ui/icons/Add';
import { Fab, Tooltip, Dialog, DialogActions, DialogContent, DialogContentText, DialogTitle, TextField } from '@material-ui/core';
import { connect } from 'react-redux';
import * as actionCreators from '../../store/actions/index';
import * as validate from '../validate';

class Vehicles extends Component {
    state = {
        isOpen: false,
        licensePlate: null,
        errors: {
            licensePlate: ''
        }, rules: {
            licensePlate: {
                isLicensePlate: true
            }
        },
        isErrorNotification: true
    }

    handleChange = (event) => {
        event.preventDefault();
        const { name, value } = event.target;
        let errors = this.state.errors;
        let rules = this.state.rules;

        switch (name) {
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

    handleAddSubmit = (event) => {
        event.preventDefault();

        const vehicle = {
            licensePlate: this.state.licensePlate
        }

        if (validate.validateForm(this.state.errors)) {
            this.props.onAddVehicle(vehicle, this.props.userId);
        }

        if (this.props.error == null) {
            this.handleClose();
        }
    }

    handleAddVehicle = () => {
        this.setState({
            isOpen: true
        })
    }

    handleClose = () => {
        this.setState({
            isOpen: false
        })
    }

    handleErrorNotificationClose = () => {
        this.setState({ isErrorNotification: false })
    }

    componentDidMount() {
        if (this.props.userId) {
            this.props.onVehiclesFetched(this.props.userId);
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
        let vehicleList = null;

        if (!this.props.userId) {
            authMessage = (
                <Alert variant='danger'><Link to='/profile'>Autentificati-va</Link> pentru a putea vedea masinile dvs.</Alert>
            )
        }
        else {
            this.props.vehicles.length > 0 ? vehicleList = this.props.vehicles.map((vehicle, index) => (
                <Card key={index} border="primary">
                    <Card.Body className="text-center">
                        <Card.Title><FaCarSide /></Card.Title>
                        <Card.Text>
                            {vehicle.licensePlate}
                        </Card.Text>
                        <Button variant="danger" onClick={() => this.props.onDeleteVehicle(this.props.userId, vehicle.id)}>Sterge</Button>
                    </Card.Body>
                </Card>
            )) : vehicleList = (<Alert variant='info'>Nu aveti niciun vehicul.</Alert>)
        }

        let errorMessage = null;
        if (this.props.error) {
            errorMessage = (
                <div className="text-center">
                    <Alert show={this.state.isErrorNotification} onClose={this.handleErrorNotificationClose} variant="danger" dismissible>
                        <Alert.Heading></Alert.Heading>
                        <p>{this.props.error.data ? this.props.error.data : 'A aparut o eroare la cererea dumneavoastra.'}</p>
                    </Alert>
                </div>

            )
        }

        return (
            <div className="container mt-3">
                {authMessage}
                <CardDeck>
                    {this.props.loading ? loading : vehicleList}
                </CardDeck>
                {this.props.userId && <div className="position-fixed mt-5">
                    <Tooltip title="Adauga masina" aria-label="add" onClick={this.handleAddVehicle}>
                        <Fab color="primary">
                            <AddIcon />
                        </Fab>
                    </Tooltip>
                </div>}
                <Dialog open={this.state.isOpen} onClose={this.handleClose} aria-labelledby="form-dialog-title">
                    {loading}
                    {errorMessage}
                    <DialogTitle id="form-dialog-title">Adauga masina</DialogTitle>
                    <DialogContent>
                        <DialogContentText>
                            Introduceti numarul de inmatriculare
                        </DialogContentText>
                        <TextField
                            required
                            autoFocus
                            margin="dense"
                            name="licensePlate"
                            label="Numar inmatriculare"
                            type="text"
                            fullWidth
                            onChange={this.handleChange}
                            error={this.state.errors.licensePlate ? true : false}
                        />
                    </DialogContent>
                    <DialogActions>
                        <Button onClick={this.handleAddSubmit} variant="primary">
                            Adauga
                        </Button>
                        <Button onClick={this.handleClose} variant="danger">
                            Anuleaza
                        </Button>
                    </DialogActions>
                </Dialog>
            </div>
        )
    }
}

const mapStateToProps = state => {
    return {
        userId: state.auth.userId,
        vehicles: state.vehicles.vehicles,
        loading: state.vehicles.loading,
        error: state.vehicles.error,
    };
}

const mapDispatchToProps = dispatch => {
    return {
        onVehiclesFetched: (userId) => dispatch(actionCreators.fetchVehicles(userId)),
        onAddVehicle: (vehicle, userId) => dispatch(actionCreators.addVehicle(vehicle, userId)),
        onDeleteVehicle: (userId, vehicleId) => dispatch(actionCreators.deleteVehicle(userId, vehicleId)),
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(Vehicles);