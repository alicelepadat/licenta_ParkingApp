import React from 'react';

import Card from '../Card/Card';
import Button from '../Button/Button';
import classes from './Modal.module.css';

const Modal = props => {
    return (
        <div>
            <div className={classes.backdrop} />
            <Card className={classes.modal}>
                <header className={classes.header}>
                    <h2>{props.title}</h2>
                </header>
                <div className={classes.content}>
                    <p>{props.message}</p>
                    {props.children}
                </div>

                <footer className={classes.actions}>
                    {props.cancel && <Button className={classes.cancel} onClick={props.onCancel}>Anuleaza</Button>}
                    <Button onClick={props.onConfirm}>Ok</Button>
                </footer>
            </Card>
        </div>
    );
};

export default Modal;
