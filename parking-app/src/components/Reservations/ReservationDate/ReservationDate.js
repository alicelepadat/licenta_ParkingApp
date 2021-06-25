import classes from './ReservationDate.module.css';

const ReservationDate = props => {
    const month = props.date.toLocaleString('en-US', {month: 'long'});
    const day = props.date.toLocaleString('en-US', {day: '2-digit'});
    const year = props.date.getFullYear();

    return (
        <div className={classes["reservation-date"]}>
            <div className={classes["reservation-date__month__year"]}>
                {month} {year}
            </div>
            <div className={classes["reservation-date__day"]}>{day}</div>
        </div>
    );
}

export default ReservationDate;
