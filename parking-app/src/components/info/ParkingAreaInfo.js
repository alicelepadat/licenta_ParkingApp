import React, { Component } from 'react';
import Modal from 'react-bootstrap/Modal';
import { Link } from 'react-router-dom';
import Button from '@material-ui/core/Button';
import { connect } from 'react-redux';
import * as actionTypes from '../../store/actions';

class ParkingAreaInfo extends Component {
    state = {
        show: true,
    }

    handleClose = () => {
        this.setState({ show: false });
    }

    render() {
        return (
            <Modal show={this.state.show} onHide={this.handleClose} centered className="text-center">
                <Modal.Header closeButton>
                    <Modal.Title>{this.props.parkingArea}</Modal.Title>
                </Modal.Header>
                <Modal.Footer>
                    <Button className="m-2 text-center" onClick={this.handleClose}>
                        Inchide
                    </Button>
                    <Button className="m-2 text-center" color="primary"
                        onClick={() => this.props.onSelectedParkingArea(this.props.parkingArea)}
                        component={Link} to='/reservation'
                    >
                        Parcheaza
                    </Button>
                </Modal.Footer>

            </Modal>
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