import React from 'react';

import classes from './SearchContainer.module.css';
import InfoHeader from "../../../UI/InfoHeader/InfoHeader";
import {Form} from "react-bootstrap";

const SearchContainer = props => {
    return (
        <div className={classes["search-container"]}>
            <InfoHeader title="Cautati o zona de parcare" onCloseClick={props.onCloseClick}/>
            <Form>
                <Form.Control type="text" placeholder="Introduceti o locatie"/>
            </Form>
            <div>

            </div>
        </div>
    );
};

export default SearchContainer;
