import React, {useState} from 'react';
import MapContainer from "../../components/Map/MapContainer/MapContainer";
import UserLocation from "../../components/Map/UserLocation/UserLocation";
import Layers from "../../components/Map/Layers/layers";
import InfoContainer from "../../components/Map/InfoContainer/InfoContainer";
import NewReservation from "../../components/Reservations/NewReservation/NewReservation";
import Search from "../../components/Map/Search/Search";

import data from '../../data/parcari.json';

export default function Home() {

    const [viewport, setViewport] = useState({
        latitude: 44.439663,
        longitude: 26.096306,
        zoom: 11,
    });

    const [showPopup, setShowPopup] = useState(false);
    const [selectedArea, setSelectedArea] = useState(null);
    const [showReserveForm, setShowReserveForm] = useState(false);
    const [showSearchContainer, setShowSearchContainer] = useState(false);

    const handleViewportChange = (event) => {
        setViewport(event);
    }

    const handleAreaClick = (area, coords) => {
        setViewport({
            ...viewport,
            longitude: coords[0],
            latitude: coords[1],
            zoom: 19,
            transitionDuration: 1000
        });
        setSelectedArea(area);
        setShowPopup(true);
        setShowSearchContainer(false);
    }

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
        setSelectedArea(null);
        setShowSearchContainer(false);
        setViewport({
            ...viewport,
            zoom: 11,
            transitionDuration: 2000
        });
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
                <Layers/>
                <UserLocation/>
            </MapContainer>

            {
                showPopup && <InfoContainer
                    area={selectedArea}
                    onReserve={handleReserveClick}
                    onCloseClick={handleCloseClick}
                />
            }

            {showReserveForm && <NewReservation area={selectedArea} onCloseClick={handleCloseClick}/>}

        </React.Fragment>

    );
};
