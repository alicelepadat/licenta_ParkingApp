import React from 'react';

import classes from './ReportsFilter.module.css';
import {Download, Printer} from "react-feather";

const ReportsFilter = props => {

    const filterChangeHandler = (event) => {
        props.onChangeFilter(event.target.value);
    }

    return (
        <div className={classes['reports-filter']}>
            <div className={` ${classes['reports-filter__control']}`}>
                <label>Selectati anul</label>
                <select value={props.selectedStatus} onChange={filterChangeHandler}>
                    <option value='2020'>2020</option>
                    <option value='2021'>2021</option>
                </select>
                {
                    props.save &&
                    <div className={classes["reportsFilter__actions"]}>
                        <button aria-label="Descarca" title="Descarca" onClick={props.onDownload}><Download/></button>
                        <button aria-label="Printeaza" title="Printeaza" onClick={props.onPrint}><Printer/></button>
                    </div>

                }
            </div>
        </div>
    );
};

export default ReportsFilter;
