import React, { Component } from 'react';
import { Card, CardDeck, Button, Spinner, Alert } from 'react-bootstrap';
import { FaCarSide } from "react-icons/fa";
import AddIcon from '@material-ui/icons/Add';
import { Fab, Tooltip, Dialog, DialogActions, DialogContent, DialogContentText, DialogTitle } from '@material-ui/core';
import { connect } from 'react-redux';
import * as actionCreators from '../../store/actions/index';

class Vehicles extends Component {
    state = {
        isOpen: false
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

    componentDidMount() {
        if (this.props.userId) {
            this.props.onVehiclesFetched(this.props.userId);
        }
    }

    render() {
        console.log(this.props.vehicles)
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
                <Alert variant='danger'>Autentificati-va pentru a putea vedea rezervarile.</Alert>
            )
        }
        else {
            vehicleList = this.props.vehicles.map((vehicle, index) => (
                <Card key={index} border="primary">
                    <Card.Body className="text-center">
                        <Card.Title><FaCarSide /></Card.Title>
                        <Card.Text>
                            {vehicle.licensePlate}
                        </Card.Text>
                        <Button variant="danger" onClick={() => this.props.onDeleteVehicle(this.props.userId, vehicle.id)}>Sterge</Button>
                    </Card.Body>
                </Card>
            ));
        }

        return (
            <div className="container mt-3">
                {authMessage}
                <CardDeck>
                    {this.props.loading ? loading : vehicleList}
                </CardDeck>
                <div className="position-fixed mt-5">
                    <Tooltip title="Adauga masina" aria-label="add" onClick={this.handleAddVehicle}>
                        <Fab color="primary">
                            <AddIcon />
                        </Fab>
                    </Tooltip>
                </div>
                <Dialog open={this.state.isOpen} onClose={this.handleClose} aria-labelledby="form-dialog-title">
                    <DialogTitle id="form-dialog-title">Adauga masina</DialogTitle>
                    <DialogContent>
                        <DialogContentText>
                            Introduceti numarul de inmatriculare
                        </DialogContentText>
                        <div className="form-row" id="inputReservationVehicle">
                            <div className="col-md-4 col-4">
                                <input type="text" className="form-control" placeholder="B"></input>
                            </div>
                            <div className="col-md-4 col-4">
                                <input type="text" min={0} className="form-control" placeholder="00"></input>
                            </div>
                            <div className="col-md-4 col-4">
                                <input type="text" className="form-control" placeholder="BBB"></input>
                            </div>
                        </div>
                    </DialogContent>
                    <DialogActions>
                        <Button onClick={this.handleClose} variant="primary">
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
    };
}

const mapDispatchToProps = dispatch => {
    return {
        onVehiclesFetched: (userId) => dispatch(actionCreators.fetchVehicles(userId)),
        onDeleteVehicle: (userId, vehicleId) => dispatch(actionCreators.deleteVehicle(userId, vehicleId)),
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(Vehicles);