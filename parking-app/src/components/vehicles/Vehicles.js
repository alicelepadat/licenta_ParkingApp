import React, { Component } from 'react';
import { Card, CardDeck, Button } from 'react-bootstrap';
import { FaCarSide } from "react-icons/fa";
import AddIcon from '@material-ui/icons/Add';
import Fab from '@material-ui/core/Fab';
import Tooltip from '@material-ui/core/Tooltip';
import Dialog from '@material-ui/core/Dialog';
import DialogActions from '@material-ui/core/DialogActions';
import DialogContent from '@material-ui/core/DialogContent';
import DialogContentText from '@material-ui/core/DialogContentText';
import DialogTitle from '@material-ui/core/DialogTitle';

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

    render() {
        return (
            <div className="container mt-3">
                <CardDeck>
                    <Card border="primary">
                        <Card.Body className="text-center">
                            <Card.Title><FaCarSide /></Card.Title>
                            <Card.Text>
                                DB99ALI
                            </Card.Text>
                            <Button variant="danger">Sterge</Button>
                        </Card.Body>
                    </Card>
                    <Card border="primary">
                        <Card.Body className="text-center">
                            <Card.Title><FaCarSide /></Card.Title>
                            <Card.Text>
                                DB99ALI
                            </Card.Text>
                            <Button variant="danger">Sterge</Button>
                        </Card.Body>
                    </Card>
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
                        <Button onClick={this.handleClose} variant="danger">
                            Anuleaza
                        </Button>
                        <Button onClick={this.handleClose} variant="primary">
                            Adauga
                        </Button>
                    </DialogActions>
                </Dialog>
            </div>
        )
    }
}

export default Vehicles;