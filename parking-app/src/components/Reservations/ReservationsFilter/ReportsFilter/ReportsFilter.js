import React from 'react';

import classes from './ReportsFilter.module.css';

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
            </div>
            {/*{*/}
            {/*    props.download &&*/}
            {/*    <div className={classes["reports-action"]}>*/}
            {/*        <button title="Descarca"><Download/></button>*/}
            {/*    </div>*/}

            {/*}*/}
        </div>
    );
};

export default ReportsFilter;
