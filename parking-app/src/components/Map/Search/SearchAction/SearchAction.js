import React from 'react';
import classes from "./SearchAction.module.css";
import {Search} from "react-feather";
import FloatingButton from "../../../UI/FloatingButton/FloatingButton";

const SearchAction = props => {
    return (
        <div className={classes["search-actions"]}>
            <FloatingButton onClick={props.onSearchClick}>
                <Search color='var(--DarkBlue)'/>
            </FloatingButton>
        </div>
    );
};

export default SearchAction;
