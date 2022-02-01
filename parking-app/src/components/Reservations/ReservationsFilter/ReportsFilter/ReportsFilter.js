import React from 'react';

import classes from './ReportsFilter.module.css';
import { Download, Printer } from "react-feather";

const ReportsFilter = props => {

    const filterChangeHandler = (event) => {
        props.onChangeFilter(event.target.value);
    }

    const createYearSelectionOptions = () => {
        let options = [];
        for (let i = 2020; i <= new Date().getFullYear(); i++) {
            options.push(<option value={i}>{i}</option>)
        }
        return options;
    }

    return (
        <div className={classes['reports-filter']}>
            <div className={` ${classes['reports-filter__control']}`}>
                <label>Selectati anul</label>
                <select value={props.selectedStatus} onChange={filterChangeHandler}>
                    {createYearSelectionOptions()}
                </select>
                {
                    props.save &&
                    <div className={classes["reportsFilter__actions"]}>
                        <button aria-label="Descarca" title="Descarca" onClick={props.onDownload}><Download /></button>
                        <button aria-label="Printeaza" title="Printeaza" onClick={props.onPrint}><Printer /></button>
                    </div>

                }
            </div>
        </div>
    );
};

export default ReportsFilter;
