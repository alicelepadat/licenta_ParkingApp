import React from 'react';
import ReservationForm from "../ReservationForm/ReservationForm";
import classes from './NewReservation.module.css';
import Header from "../../UI/Header/Header";
import {connect} from "react-redux";
import * as actionCreators from "../../../store/actions";

const NewReservation = (props) => {

    return (
        <div className={classes["new-reservation"]}>
            <Header title="Rezervare noua" onCloseClick={props.onCloseClick}/>
             <ReservationForm
                    userId={props.userId}
                    area={props.selectedArea}
                    vehicles={props.vehicles}
                    onDriverAdd={props.onDriverReservationAdd}
                    onAnonimAdd={props.onAnonimReservationAdd}
                    onSuccess={props.onSuccess}
                />
        </div>
    );
};

const mapStateToProps = state => {
    return {
        vehicles: state.driverVehicles.vehicles,
        selectedArea: state.parkingArea.selectedArea,
        userId: state.driverAuth.userId,
    };
};

const mapDispatchToProps = dispatch => {
    return {
        onDriverReservationAdd: (data, userId, areaId) => dispatch(actionCreators.addDriverReservation(data, userId, areaId)),
        onAnonimReservationAdd: (data, areaId) => dispatch(actionCreators.addAnonimReservation(data, areaId)),
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(NewReservation);
