import React, {useState} from 'react';
import MapContainer from "../../components/Map/MapContainer/MapContainer";
import UserLocation from "../../components/Map/UserLocation/UserLocation";
import Layers from "../../components/Map/Layers/Layers";
import InfoContainer from "../../components/Map/InfoContainer/InfoContainer";
import NewReservation from "../../components/Reservations/NewReservation/NewReservation";

export default function Home() {

    const [showPopup, setShowPopup] = useState(false);
    const [selectedArea, setSelectedArea] = useState(null);
    const[showReserveForm, setShowReserveForm] = useState(false);

    const handleClusterClick = (area) => {
        setSelectedArea(area);
        setShowPopup(true);
    }

    const handleReserveClick = event => {
        setShowPopup(false);
        setShowReserveForm(true);
    };

    const handleCloseClick = event => {
        setShowPopup(false);
        setShowReserveForm(false);
        setSelectedArea(null);
    }

    return (
        <MapContainer onClusterClick={handleClusterClick}>
            <UserLocation/>
            <Layers/>
            {
                showPopup && <InfoContainer
                    area={selectedArea}
                    onReserve={handleReserveClick}
                    onCloseClick={handleCloseClick}
                />
            }
            {showReserveForm && <NewReservation area={selectedArea} onCloseClick={handleCloseClick}/>}
        </MapContainer>
    );
};
