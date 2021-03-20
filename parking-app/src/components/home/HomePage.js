import React from 'react';
import MapContainer from '../map/MapContainer';
import Search from "../map/Search";

class HomePage extends React.Component {

    render() {
        return (
            <div className="home-container">
                <Search />
                <MapContainer />
            </div>
        );
    }
}

export default HomePage;