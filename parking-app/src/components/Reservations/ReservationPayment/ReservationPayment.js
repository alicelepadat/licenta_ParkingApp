import React, {useState} from 'react';
import {CardElement, useElements, useStripe} from '@stripe/react-stripe-js';
import classes from './ReservationPayment.module.css';
import {DollarSign} from "react-feather";
import Button from "../../UI/Button/Button";
import LoadingSpinner from "../../UI/Loading/Loading";
import axios from '../../../store/axios';
import ErrorModal from "../../UI/ErrorModal/ErrorModal";

const CARD_OPTIONS = {
    style: {
        base: {
            color: "#12232e",
            fontFamily: '"Helvetica Neue", Helvetica, sans-serif',
            fontSmoothing: "antialiased",
            fontSize: "16px",
            "::placeholder": {
                color: "#305f72",
            },
        },
        invalid: {
            color: "rgba(239, 71, 111, 0.8)",
            iconColor: "#ef476f",
        },
    },
    hidePostalCode: true,
};

const ReservationPayment = (props) => {

    const stripe = useStripe();
    const elements = useElements();

    const [isPaymentProcessing, setIsPaymentProcessing] = useState(false);
    const [checkoutError, setCheckoutError] = useState();

    const handleCardDetailsChange = ev => {
        ev.error ? setCheckoutError(ev.error.message) : setCheckoutError();
    };

    const handleReservationPay = async event => {
        event.preventDefault();

        setIsPaymentProcessing(true);

        const cardElement = elements.getElement(CardElement);

        try {
            const {data: clientSecret} = await axios.post('/charges', {
                amount: props.details[1] * 100,
            });

            const paymentMethodRequest = await stripe.createPaymentMethod({
                type: "card",
                card: cardElement,
            });

            if (paymentMethodRequest.error) {
                setCheckoutError(paymentMethodRequest.error.message);
                setIsPaymentProcessing(false);
                return;
            }

            await stripe.confirmCardPayment(clientSecret, {
                payment_method: paymentMethodRequest.paymentMethod.id,
            });

            props.onPay();
        } catch (error) {
            setIsPaymentProcessing(false);
            setCheckoutError(error.message);
        }
    }

    return (
        <React.Fragment>
            {
                props.loading ? <LoadingSpinner/> :
                    <div className={classes.payment}>
                        <p>Efectueaza plata pentru rezervarea la {props.area.emplacement}</p>
                        <div className={classes["reservation-details"]}>
                            <p>Durata: {props.details[0]}</p>
                            <p>Total de plata: {props.details[1]} RON</p>
                        </div>
                        <label>Introduceti informatiile cardului</label>
                        <div className={classes["payment-details"]}>
                            <CardElement options={CARD_OPTIONS} onChange={handleCardDetailsChange}/>
                        </div>
                        <div className={classes["payment-actions"]}>
                            <Button type="submit" onClick={handleReservationPay}
                                    disabled={isPaymentProcessing || !stripe}>
                                {
                                    isPaymentProcessing ? 'Procesare...' :
                                        <div><DollarSign/> Plateste {props.details[1]} RON</div>
                                }
                            </Button>
                        </div>
                    </div>
            }
            {
                checkoutError && <ErrorModal title="Eroare la procesarea platii" message={checkoutError}
                                             onConfirm={() => setCheckoutError(null)}/>
            }
        </React.Fragment>
    );
}
;

export default ReservationPayment;
