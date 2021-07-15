import React, {useEffect, useState} from 'react';
import {Bar} from 'react-chartjs-2';

import * as reports from '../../../utility/reports';
import ReportsFilter from "../ReservationsFilter/ReportsFilter/ReportsFilter";

import classes from './ReservationsReports.module.css';
import Card from "../../UI/Card/Card";

const months = [];
for (let i = 0; i < 12; i++) {
    months[i] = i;
}

const labels = months.map(month => reports.getMonth(month));

let datasets = [];

let data = {
    labels: labels,
    datasets: [
        {
            label: 'rezervari',
            data: datasets,
            backgroundColor: [
                'rgba(48, 95, 114, 0.3)',
                'rgba(77, 168, 218, 0.2)',
                'rgba(32, 54, 71, 0.3)',
            ],
            borderColor: [
                '#203647',
                '#305f72',
                '#12232e',
            ],
            borderWidth: 1,
        },
    ],
};

const options = {
    scales: {
        yAxes: [
            {
                ticks: {
                    beginAtZero: true,
                },
            },
        ],
    },
};

const ReservationsReports = props => {

    const [chartRef, setChartRef] = useState();

    const [filteredStatus, setFilteredStatus] = useState('2021');

    const filteredReservations = props.reservations.filter(reservation => {
        return new Date(reservation.reservationDate).getFullYear().toString() === filteredStatus
    });

    const filterChangeHandler = selectedStatus => {
        setFilteredStatus(selectedStatus);
    };

    useEffect(() => {
        for (let i = 0; i < months.length; i++) {
            datasets[i] = reports.getReservationsPerMonth(filteredReservations, months[i]);
        }
        if (chartRef) {
            console.log(chartRef.data.datasets[0].data)
            chartRef.data.datasets[0].data = datasets;
            chartRef.update()
        }
    }, [filteredReservations, chartRef]);


    console.log(datasets)

    return (
        <Card className={classes['reports']}>
            <div>
                <div>
                    <h2>Raport rezervari lunare</h2>
                    <p>Zona de parcare: {props.area}</p>
                </div>
                <div>
                    <ReportsFilter
                        selectedStatus={filteredStatus}
                        download={filteredReservations.length > 0}
                        onChangeFilter={filterChangeHandler}
                    />
                </div>
                {
                    filteredReservations.length > 0 ?
                        <Bar ref={(ref) => {
                            setChartRef(ref)
                        }} data={data} options={options}/>
                        : <h4>Nu s-au realizat rezervari</h4>
                }

            </div>
        </Card>
    );
};

export default ReservationsReports;
