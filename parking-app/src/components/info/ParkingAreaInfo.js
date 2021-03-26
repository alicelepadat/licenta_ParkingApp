import React, { Component } from 'react';
import { Modal, Button } from 'react-bootstrap';
import { connect } from 'react-redux';
import * as actionTypes from '../../store/actions';
import Dialog from '@material-ui/core/Dialog';
import Reservation from '../reservation/Reservation';
import { FaParking } from 'react-icons/fa';

class ParkingAreaInfo extends Component {
    state = {
        date: new Date(),
        time: {
            hour: new Date().getHours(),
            minutes: new Date().getMinutes()
        },
        open: false
    };

    onChange = (ev) => this.setState({ value: ev.target.value });
    handleClickOpen = () => { this.setState({ open: true }) }
    handleClose = () => this.setState({ open: false });

    render() {
        return (
            <div>
                <Modal show={true} onHide={() => this.props.handleClose()} centered className="text-center">
                    <Modal.Header closeButton>
                        <Modal.Title><FaParking color="rgb(1, 48, 90)" /> {this.props.parkingArea}</Modal.Title>
                    </Modal.Header>
                    <Modal.Footer>
                        <Button className="m-2 text-center" onClick={() => this.props.handleClose()} variant="danger">
                            Inchide
                    </Button>
                        <Button className="m-2 text-center" variant="primary"
                            onClick={() => {
                                this.props.onSelectedParkingArea(this.props.parkingArea);
                                this.handleClickOpen();
                            }}
                        >
                            Parcheaza
                    </Button>
                    </Modal.Footer>
                </Modal >
                <Dialog fullScreen open={this.state.open} onClose={() => { this.handleClose(); this.props.handleClose() }}>
                    <Reservation onClose={() => { this.handleClose(); this.props.handleClose() }} />
                </Dialog>
            </div>
        )
    }
}

const mapStateToProps = state => {
    return {
        selectedArea: state.selectedArea
    };
}

const mapDispatchToProps = dispatch => {
    return {
        onSelectedParkingArea: (selectedArea) => dispatch({ type: actionTypes.SET_SELECTED_PARKING_AREA, selectedArea: selectedArea })
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(ParkingAreaInfo);