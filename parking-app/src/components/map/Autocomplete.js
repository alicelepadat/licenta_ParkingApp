import React, { Component } from 'react';
import { connect } from 'react-redux';
import * as actionTypes from '../../store/actions';

class Autocomplete extends Component {
    render() {
        return (
            <div className="container">
                {
                    this.props.parkingAreas
                        .filter(({ address }) => (address.toLowerCase()).includes(this.props.searchAddress.toLowerCase()))
                        .map((area, index) => {
                            return <div
                                className="search-area row m-4 text-md-left text-sm-center text-xs-center"
                                key={index}
                            >
                                <div className="col-md-10"
                                    onClick={() => this.props.onSelectedParkingArea(area.address)}>
                                    {area.address}
                                </div>
                                <div className="col-md-2 pt-sm-2">
                                    <button className="btn btn-outline-primary">Parcheaza</button>
                                </div>
                            </div>
                        })
                }
            </div>
        )
    }
}

const mapStateToProps = state => {
    return {
        parkingAreas: state.parkingAreas,
        selectedArea: state.selectedArea
    };
}

const mapDispatchToProps = dispatch => {
    return {
        onSelectedParkingArea: (selectedArea) => dispatch({ type: actionTypes.SET_SELECTED_PARKING_AREA, selectedArea: selectedArea })
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(Autocomplete)