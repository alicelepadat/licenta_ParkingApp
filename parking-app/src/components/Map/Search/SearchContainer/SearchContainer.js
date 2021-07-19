import React, {useState} from 'react';

import classes from './SearchContainer.module.css';
import Header from "../../../UI/Header/Header";
import {Form} from "react-bootstrap";

const SearchContainer = props => {

    const [userInputSearch, setUserInputSearch] = useState('');

    const handleUserInputChange = event => {
        setUserInputSearch(event.target.value);
    }

    const filteredAreas = props.data.filter(
        area => (
            area.properties["AMPLASAMENT"].toLowerCase().includes(userInputSearch.toLowerCase()) ||
            area.properties["LOCALIZARE AMPLASAMENT"].toLowerCase().includes(userInputSearch.toLowerCase()) ||
            area.properties["ORAS"].toLowerCase().includes(userInputSearch.toLowerCase())
        ));

    return (
        <div className={classes["search-container"]}>
            <Header title="Cautati o zona de parcare" onCloseClick={props.onCloseClick}/>
            <Form>
                <Form.Control
                    type="text"
                    placeholder="Introduceti o locatie"
                    value={userInputSearch}
                    onChange={handleUserInputChange}
                />
            </Form>
            <ul className="scroll">
                {
                    filteredAreas.length > 0 ?
                    filteredAreas.map((area, index) => {
                        return (
                            <li key={index}
                                className={classes["search-result"]}
                                onClick={() => props.onSelectLocation(area.properties, area.geometry.coordinates)}
                            >
                                {area.properties["AMPLASAMENT"]}
                            </li>
                        )
                    }) :
                        <h2 className={classes["search-container__fallback"]}>
                            Nicio zona de parcare gasita.
                        </h2>
                }
            </ul>
        </div>
    );
};

export default SearchContainer;
