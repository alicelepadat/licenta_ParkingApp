import React from 'react';

import {CardElement} from '@stripe/react-stripe-js';

import classes from './ReservationPayment.module.css';
import {Check} from "react-feather";
import Button from "../../UI/Button/Button";

const CARD_OPTIONS = {
    iconStyle: "solid",
    style: {
        base: {
            iconColor: "#12232E",
            color: "#12232E",
            fontSmoothing: "antialiased",
            ":-webkit-autofill": {
                color: "#fce883"
            },
            "::placeholder": {
                color: "#12232E"
            }
        },
        invalid: {
            iconColor: "#ffc7ee",
            color: "#ffc7ee"
        }
    }
};

const ReservationPayment = () => {

    return (
        <div>
            <div className={classes.payment}>
                <div className={classes["payment-details"]}>
                    <CardElement options={CARD_OPTIONS}/>
                </div>
            </div>
            <div className={classes["payment-actions"]}>
                <Button type="submit">
                    Rezerva <Check/>
                </Button>
            </div>

        </div>

    );
};

export default ReservationPayment;
