import React, { useState } from 'react';
import MapContainer from "../../components/Map/MapContainer/MapContainer";
import UserLocation from "../../components/Map/UserLocation/UserLocation";
import Layers from "../../components/Map/Layers/layers";
import InfoContainer from "../../components/Map/InfoContainer/InfoContainer";
import NewReservation from "../../components/Reservations/NewReservation/NewReservation";
import Search from "../../components/Map/Search/Search";

import data from '../../data/parcari.json';
import * as actionCreators from "../../store/actions";
import { connect } from "react-redux";
import ErrorModal from "../../components/UI/ErrorModal/ErrorModal";

function Home(props) {

    const [viewport, setViewport] = useState({
        latitude: 44.439663,
        longitude: 26.096306,
        zoom: 11,
    });

    const [showPopup, setShowPopup] = useState(false);
    const [showReserveForm, setShowReserveForm] = useState(false);
    const [showSearchContainer, setShowSearchContainer] = useState(false);
    const [reservationSuccess, setReservationSuccess] = useState(false);

    const handleViewportChange = (event) => {
        setViewport(event);
    };

    const handleAreaClick = (area, coords) => {
        setViewport({
            ...viewport,
            longitude: coords[0],
            latitude: coords[1],
            zoom: 19,
            transitionDuration: 1000
        });

        if (props.driverId) {
            props.onFetchVehicles(props.driverId);
        }
        else {
            const vehicleId = localStorage.getItem(`identifier`);
            if (vehicleId) {
                props.onFetchVechicle(vehicleId)
            }
        }

        props.onFetchParkingArea(area["AMPLASAMENT"]);

        setShowPopup(true);
        setShowSearchContainer(false);
    };

    const handleClusterExpansion = (zoom, coords) => {
        setViewport({
            ...viewport,
            longitude: coords[0],
            latitude: coords[1],
            zoom,
            transitionDuration: 500
        });
    }

    const handleSearchClick = () => {
        setShowSearchContainer(true);
    }

    const handleReserveClick = event => {
        setShowPopup(false);
        setShowReserveForm(true);
    };

    const handleCloseClick = event => {
        setShowPopup(false);
        setShowReserveForm(false);
        props.onCloseAreaSelection();
        setShowSearchContainer(false);
        props.selectedArea && setViewport({
            ...viewport,
            zoom: 12,
            transitionDuration: 2000
        });
    }

    const handleReservationSuccess = event => {
        handleCloseClick();
        setReservationSuccess(true);
    }

    return (
        <React.Fragment>
            <Search
                show={showSearchContainer}
                data={data.features}
                onSearchClick={handleSearchClick}
                onClickResult={handleAreaClick}
                onCloseClick={handleCloseClick}
            />

            <MapContainer
                viewport={viewport}
                onViewportChange={handleViewportChange}
                onAreaClick={handleAreaClick}
                onClusterExpansion={handleClusterExpansion}
            >
                <Layers />
                <UserLocation />
            </MapContainer>

            {
                showPopup && <InfoContainer
                    loading={props.loading}
                    area={props.selectedArea}
                    onReserve={handleReserveClick}
                    onCloseClick={handleCloseClick}
                />
            }

            {showReserveForm && <NewReservation area={props.selectedArea} onCloseClick={handleCloseClick} onSuccess={handleReservationSuccess} />}
            {reservationSuccess && <ErrorModal title="Rezervare" message="Rezervarea s-a realizat cu success!" onConfirm={()=>setReservationSuccess(false)}/>}

        </React.Fragment>

    );
};

const mapStateToProps = state => {
    return {
        loading: state.parkingArea.loading,
        error: state.parkingArea.error,
        selectedArea: state.parkingArea.selectedArea,
        driverId: state.driverAuth.userId,
    };
};

const mapDispatchToProps = dispatch => {
    return {
        onFetchParkingArea: (name) => dispatch(actionCreators.fetchParkingArea(name)),
        onFetchVehicles: (driverId) => dispatch(actionCreators.fetchDriverVehicles(driverId)),
        onFetchVechicle: (vehicleId) => dispatch(actionCreators.fetchVehicle(vehicleId)),
        onCloseAreaSelection: () => dispatch(actionCreators.closeAreaSelection()),
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(Home);
