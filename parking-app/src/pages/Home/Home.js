import React, {useState} from 'react';
import MapContainer from "../../components/Map/MapContainer/MapContainer";
import UserLocation from "../../components/Map/UserLocation/UserLocation";
import Layers from "../../components/Map/Layers/Layers";
import InfoContainer from "../../components/Map/InfoContainer/InfoContainer";
import NewReservation from "../../components/Reservations/NewReservation/NewReservation";
import Search from "../../components/Map/Search/Search";

import data from '../../data/parcari.json';

export default function Home() {

    const [showPopup, setShowPopup] = useState(false);
    const [selectedArea, setSelectedArea] = useState(null);
    const [showReserveForm, setShowReserveForm] = useState(false);
    const [showSearchContainer, setShowSearchContainer] = useState(false);

    const handleSearchClick = () => {
        setShowSearchContainer(true);
    }

    const handleAreaClick = (area) => {
        setSelectedArea(area);
        setShowPopup(true);
        setShowSearchContainer(false);
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

            <MapContainer onClusterClick={handleAreaClick}>
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
