import React, {useEffect, useRef, useState} from 'react';
import {Bar} from 'react-chartjs-2';

import * as reports from '../../../utility/reports';
import ReportsFilter from "../ReservationsFilter/ReportsFilter/ReportsFilter";

import classes from './ReservationsReports.module.css';
import Card from "../../UI/Card/Card";
import html2canvas from "html2canvas";
import jsPDF from "jspdf";

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
                '#4da8da',
            ],
            borderColor: [
                '#000',
            ],
            borderWidth: 0.5,
        },
    ],
};

const options = {
    scales: {
        yAxes: [
            {
                ticks: {
                    beginAtZero: true,
                    color: '#000',
                },

            },
        ],
    },
};

const ReservationsReports = props => {

    const docRef = useRef();

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
            chartRef.data.datasets[0].data = datasets;
            chartRef.update()
        }
    }, [filteredReservations, chartRef]);


    const saveDocument = (print) => {
        const document = docRef.current;

        html2canvas(document)
            .then((canvas) => {
                const imgData = canvas.toDataURL('image/png');
                const pdf = new jsPDF('p','px','a4');

                const ratio = canvas.height/canvas.width;
                const width = pdf.internal.pageSize.getWidth();
                const height = width * ratio;

                pdf.setTextColor(0, 0, 0);
                pdf.text('Raport rezervari lunare', 20, 20);
                pdf.text(`${filteredStatus}`, 20, 35);
                pdf.text(`Zona de parcare: ${props.area}`, 20, 50);

                pdf.addImage(imgData, 'JPEG', 20, 70, width - 40, height + 70);

                if (print === true) {
                    pdf.autoPrint();
                    window.open(pdf.output('bloburl'), '_blank');
                } else {
                    pdf.save(`raport_zona_${props.area}.pdf`);
                }
            });
    };

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
                        save={filteredReservations.length > 0}
                        onChangeFilter={filterChangeHandler}
                        onDownload={() => saveDocument(false)}
                        onPrint={() => saveDocument(true)}
                    />
                </div>
                {
                    filteredReservations.length > 0 ?
                        <div ref={docRef}>
                            <Bar
                                ref={(ref) => {
                                    setChartRef(ref)
                                }}
                                data={data}
                                options={options}
                                title="Raport rezervari lunare"
                            />
                        </div>
                        : <h4>Nu s-au realizat rezervari</h4>
                }

            </div>
        </Card>
    );
};

export default ReservationsReports;
