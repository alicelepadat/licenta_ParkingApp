import React from 'react';

import {CardElement} from '@stripe/react-stripe-js';

import classes from './ReservationPayment.module.css';
import {Check} from "react-feather";
import Button from "../../UI/Button/Button";
import LoadingSpinner from "../../UI/Loading/Loading";

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
            iconColor: "rgb(243, 206, 214)",
            color: "#ef476f"
        }
    }
};

const ReservationPayment = (props) => {

    return (
        <React.Fragment>
            {
                props.loading ? <LoadingSpinner/> :
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
            }
        </React.Fragment>
    );
};

export default ReservationPayment;
