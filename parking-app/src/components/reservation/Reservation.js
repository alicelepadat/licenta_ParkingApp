import React, { Component } from 'react';
import { connect } from 'react-redux';
import { Card } from 'react-bootstrap';
import { format } from 'date-fns';

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
            <div className="container mt-md-5 mt-4">
                <Card>
                    <Card.Title className="text-center m-2">Rezerva</Card.Title>
                    {this.props.selectedArea !== '' && (<hr></hr>)}
                    <Card.Subtitle className="text-center">{this.props.selectedArea}</Card.Subtitle>
                    <hr></hr>
                    <Card.Body>
                        <form>
                            <div className="form-row">
                                <div className="form-group col-md-4">
                                    <label htmlFor="inputReservationDate">Data</label>
                                    <input type="text" className="form-control" id="inputReservationDate" defaultValue={todayDate} disabled></input>
                                </div>
                                <div className="form-group col-md-4">
                                    <label htmlFor="inputReservationTime">Ora</label>
                                    <input type="time" className="form-control" id="inputReservationTime" defaultValue={this.state.time.hour + ':' + this.state.time.minutes}></input>
                                </div>
                                <div className="form-group col-md-4">
                                    <label htmlFor="inputReservationDuration">Durata</label>
                                    <input type="number" className="form-control" id="inputReservationDuration" placeholder="Durata" defaultValue={30} min={30}></input>
                                </div>
                            </div>
                            <div>
                                <label htmlFor="inputReservationVehicle">Numar de inmatriculare</label>
                            </div>
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
                            <div className="form-group">
                                <label htmlFor="inputDriverName">Nume</label>
                                <input type="text" className="form-control" id="inputDriverName" placeholder="Introduceti numele si prenumele dvs."></input>
                            </div>
                            <div className="form-group">
                                <label htmlFor="inputDriverPhone">Telefon</label>
                                <input type="phone" className="form-control" id="inputDriverPhone" placeholder="Introduceti numarul de telefon"></input>
                            </div>
                            <div className="text-center">
                                <button type="submit" className="btn btn-outline-primary">Rezerva</button>
                            </div>
                        </form>
                    </Card.Body>
                </Card>
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