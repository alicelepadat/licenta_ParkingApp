import React, { Component } from 'react';
import { Modal, Button, Row, Col, Card } from 'react-bootstrap';
import { connect } from 'react-redux';
import { FaParking } from 'react-icons/fa';
import { AiFillCar } from 'react-icons/ai';
import { MdAttachMoney, MdLocationOn } from 'react-icons/md';

class ParkingAreaInfo extends Component {
    state = {
        date: new Date(),
        time: {
            hour: new Date().getHours(),
            minutes: new Date().getMinutes()
        },
    };

    render() {
        return (
            <div>
                <Modal show={true} onHide={() => this.props.handleClose()} centered className="text-center" backdrop="static">
                    <Modal.Header closeButton>
                        <Modal.Title>
                            <h4><FaParking color="rgb(1, 48, 90)" /> {this.props.selectedArea.address.street} </h4>
                        </Modal.Title>
                    </Modal.Header>
                    <Modal.Body>
                        <Card>
                            <Card.Body>
                                <Row>
                                    <Col xs={6} md={6}>
                                        <AiFillCar /> Nr. locuri: {this.props.selectedArea.availableSpots}
                                    </Col>
                                    <Col xs={6} md={6}>
                                        <MdAttachMoney /> Pret/ora: {this.props.selectedArea.pricePerHour} lei
                                    </Col>
                                </Row>
                            </Card.Body>
                            <Card.Text>
                                {this.props.selectedArea.address.directions} <br />
                                <MdLocationOn /> {this.props.selectedArea.address.city} - {this.props.selectedArea.address.county}
                            </Card.Text>
                        </Card>
                    </Modal.Body>
                    <Modal.Footer>
                        <Button className="m-2 text-center" variant="danger"
                            onClick={() => { this.props.handleClose() }}>
                            Inchide
                        </Button>
                        <Button className="m-2 text-center" variant="primary"
                            onClick={() => { this.props.onReserve() }}
                        >
                            Parcheaza
                        </Button>
                    </Modal.Footer>
                </Modal >
            </div >
        )
    }
}

const mapStateToProps = state => {
    return {
        selectedArea: state.parkingAreas.selectedArea
    };
}

export default connect(mapStateToProps)(ParkingAreaInfo);