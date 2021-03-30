import { Link } from '@material-ui/core';
import React, { Component } from 'react';
import { Form, Button, Card, Spinner, Toast } from 'react-bootstrap';
import Dialog from '@material-ui/core/Dialog';
import Register from './Register';
import * as actionCreators from '../../store/actions/index';
import { connect } from 'react-redux';
import * as validate from '../validate';

class Authenticate extends Component {
    state = {
        controls: {
            email: {
                elementType: 'email',
                placeholder: 'Introduceti adresa de e-mail',
                value: '',
                label: 'Email',
                autoComplete: '',
                validation: {
                    isEmail: true,
                    required: true,
                    message: 'Introduceti o adresa valida.'
                },
                valid: false,
            },
            password: {
                elementType: 'password',
                placeholder: 'Introduceti parola',
                value: '',
                label: 'Password',
                autoComplete: 'current-password',
                validation: {
                    minLength: 8,
                    required: true,
                    message: 'Parola trebuie sa aiba minim 8 caractere.'
                },
                valid: false,
            }
        },
        isRegisterOpen: false,
        isErrorToastShown: true,
        isValidated: false
    }

    inputChangedHandler = (event, controlName) => {
        const updatedControls = {
            ...this.state.controls,
            [controlName]: {
                ...this.state.controls[controlName],
                value: event.target.value,
                valid: validate.checkValidity(event.target.value, this.state.controls[controlName].validation),
            }
        };
        this.setState({ controls: updatedControls });
    }

    handleSubmit = (ev) => {
        ev.preventDefault();
        this.props.onAuth(this.state.controls.email.value, this.state.controls.password.value);
    }

    handleRegisterClicked = () => {
        this.setState({ isRegisterOpen: true });
    }

    handleClose = () => {
        this.setState({ isRegisterOpen: false });
    }

    handleToastClose = () => { this.setState({ isErrorToastShown: !this.state.isErrorToastShown }) }

    render() {
        const formElementsArray = [];
        for (let key in this.state.controls) {
            formElementsArray.push({
                id: key,
                config: this.state.controls[key]
            });
        }

        let form = formElementsArray.map(element => (
            <Form.Group key={element.id} controlId={element.id} >
                <Form.Label>{element.config.label}</Form.Label>
                <Form.Control
                    // required
                    type={element.config.elementType}
                    placeholder={element.config.placeholder}
                    autoComplete={element.config.autoComplete}
                    isValid={element.config.valid}
                    isInvalid={element.config.value !== '' && !element.config.valid}
                    onChange={(ev) => this.inputChangedHandler(ev, element.id)} />
                <Form.Control.Feedback type="invalid">{element.config.validation.message}</Form.Control.Feedback>
            </Form.Group >
        ));

        let loading = null;
        if (this.props.loading) {
            loading = (<Spinner animation="border" variant="primary" />)
        }

        let authMessage = null;
        if (this.props.error) {
            authMessage = (
                <Toast show={this.state.isErrorToastShown} onClose={this.handleToastClose} className="text-center" style={{ backgroundColor: "rgba(223,71,89, 0.7)" }}>
                    <Toast.Header />
                    <Toast.Body>{this.props.error}</Toast.Body>
                </Toast>
            )
        }

        return (
            < div className="container" >
                <Card className="m-3">
                    <Card.Header className="text-center">
                        <Card.Title>Autentificare</Card.Title>
                    </Card.Header>
                    <Card.Body>
                        <div className="text-center justify-content-center">
                            {loading}
                            {authMessage}
                        </div>

                        <Form onSubmit={this.handleSubmit}>
                            {form}
                            <div className="text-center">
                                <Button variant="primary" type="submit">
                                    Autentificare
                                </Button>
                            </div>
                        </Form>
                    </Card.Body>
                    <Card.Footer className="text-center">
                        <Card.Text>Nu aveti cont? Inregistrati-va <Link onClick={this.handleRegisterClicked} color="primary">aici</Link>.</Card.Text>
                    </Card.Footer>
                </Card>
                <Dialog fullScreen open={this.state.isRegisterOpen} onClose={this.handleClose}>
                    <Register onClose={this.handleClose} />
                </Dialog>
            </div >
        )
    }
}

const mapStateToProps = state => {
    return {
        loading: state.auth.loading,
        error: state.auth.error,
    }
}

const mapDispatchToProps = dispatch => {
    return {
        onAuth: (email, password) => dispatch(actionCreators.auth(email, password))
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(Authenticate);