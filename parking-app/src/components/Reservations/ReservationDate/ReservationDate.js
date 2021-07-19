import classes from './ReservationDate.module.css';
import * as format from '../../../utility/dateFormat';

const ReservationDate = props => {
    const date = format.dateFormat(props.date).split('-');
    const day = date[2];
    const month = date[1];
    const year = date[0];

    return (
        <div className={classes["reservation-date"]}>
            <div>{year}</div>
            <div>{month}</div>
            <div className={classes["reservation-date__day"]}>{day}</div>
        </div>
    );
}

export default ReservationDate;
