import React, {useEffect, useState} from 'react';
import * as actionCreators from "../../store/actions";
import {connect} from "react-redux";
import LoadingSpinner from "../UI/Loading/Loading";
import * as utility from '../../utility/dataUtility';

import classes from './ParkingAreas.module.css'
import {Plus} from "react-feather";
import Input from "../UI/Input/Input";
import {useHistory} from "react-router-dom";

const ParkingAreasContainer = (props) => {
    const history = useHistory();

    const [userInputSearch, setUserInputSearch] = useState('');

    const handleUserInputChange = event => {
        setUserInputSearch(event.target.value);
    }

    const handleAddAdminClick = (area) => {
        props.onSelectArea(area);
        history.push('/register')
    }

    useEffect(() => {
        props.onFetchAllAreas();
    }, [props.onFetchAllAreas]);

    const filteredAreas = props.parkingAreas.length > 0 && props.parkingAreas.filter(
        area => (
            area.emplacement.toLowerCase().includes(userInputSearch.toLowerCase()) ||
            area.emplacementLocation.toLowerCase().includes(userInputSearch.toLowerCase()) ||
            area.city.toLowerCase().includes(userInputSearch.toLowerCase())
        ));

    const searchArea = (
        <Input
            id="search"
            className={classes.control}
            label="Cautati o zona de parcare"
            type="text"
            placeholder="Introduceti o adresa"
            value={userInputSearch}
            onChange={handleUserInputChange}
        />
    );

    const parkingAreasData = (
        <table>
            <thead>
            <tr>
                <th>Amplasament</th>
                <th>Zona</th>
                <th>Responsabil</th>
            </tr>
            </thead>
            <tbody className={classes["area-info"]}>
            {
                filteredAreas.length > 0 && filteredAreas.map(area => (
                    <tr key={area.id}>
                        <td>{area.emplacement}</td>
                        <td>{utility.getAreaZone(area.pricePerHour)}</td>
                        <td>
                            {
                                area.admin !== null ? area.admin.user.name :
                                    <button title="Adauga admin"
                                            onClick={() => {
                                                handleAddAdminClick(area)
                                            }}
                                    >
                                        Adauga <Plus/>
                                    </button>
                            }
                        </td>
                    </tr>
                ))
            }
            </tbody>
        </table>
    );

    return (
        <React.Fragment>
            {
                props.loading ? <LoadingSpinner/> :
                    <div className={classes.areas}>
                        <h2 className="text-center">Zone de parcare de utilitate publica (cu plata) - Bucuresti</h2>
                        {searchArea}
                        {parkingAreasData}
                    </div>
            }
        </React.Fragment>
    );

}

const mapStateToProps = state => {
    return {
        loading: state.parkingArea.loading,
        error: state.parkingArea.error,
        parkingAreas: state.parkingArea.parkingAreas,
    };
};

const mapDispatchToProps = dispatch => {
    return {
        onFetchAdministratorData: (userId) => dispatch(actionCreators.fetchAdministratorData(userId)),
        onFetchAllAreas: () => dispatch(actionCreators.fetchParkingAreas()),
        onSelectArea: (area) => dispatch(actionCreators.fetchAreaSuccess(area)),
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(ParkingAreasContainer);
