import { Link } from '@material-ui/core';
import React, { Component } from 'react';
import { Form, Button, Card, Spinner, Alert } from 'react-bootstrap';
import Dialog from '@material-ui/core/Dialog';
import Register from './Register';
import * as actionCreators from '../../store/actions/index';
import { connect } from 'react-redux';
import * as validate from '../validate';

class Authenticate extends Component {
    state = {
        email: null,
        password: null,
        errors: {
            email: '',
            password: '',
        },
        rules: {
            email: {
                isEmail: true,
            },
            password: {
                minLength: 8,
            }
        },
        isRegisterOpen: false,
        isErrorNotification: true,
        isSuccessNotification: true,

    };

    handleChange = (event) => {
        event.preventDefault();
        const { name, value } = event.target;
        let errors = this.state.errors;
        let rules = this.state.rules;

        switch (name) {
            case 'email':
                errors.email =
                    validate.checkValidity(value, rules.email)
                        ? '' : 'Introduceti o adresa de e-mail valida.';
                break;
            case 'password':
                errors.password =
                    validate.checkValidity(value, rules.password)
                        ? '' : 'Parola trebuie sa aiba minim 8 caractere.';
                break;
            default:
                break;
        }

        this.setState({ errors, [name]: value });
    }

    handleSubmit = (event) => {
        event.preventDefault();
        if (validate.validateForm(this.state.errors)) {
            this.props.onAuth(this.state.email, this.state.password);
        }
    }

    handleRegisterClicked = () => {
        this.setState({ isRegisterOpen: true });
    }

    handleRegisterClose = () => {
        this.setState({ isRegisterOpen: false });
    }

    handleErrorNotificationClose = () => {
        this.setState({ isErrorNotification: false })
    }

    handleSuccessNotificationClose = () => {
        this.setState({ isSuccessNotification: false })
    }

    render() {
        const { errors } = this.state;

        let loading = null;
        if (this.props.loading) {
            loading = (
                <div className="text-center">
                    <Spinner animation="border" variant="primary" />
                </div>)
        }

        let errorMessage = null;
        if (this.props.error) {
            errorMessage = (
                <div className="text-center">
                    <Alert show={this.state.isErrorNotification} onClose={this.handleErrorNotificationClose} variant="danger" dismissible>
                        <Alert.Heading></Alert.Heading>
                        <p>{this.props.error.data ? this.props.error.data : 'A aparut o eroare la cererea dumneavoastra.'}</p>
                    </Alert>
                </div>

            )
        }

        let successMessage = null;
        if (this.props.userId) {
            successMessage = (
                <div className="text-center">
                    <Alert show={this.state.isSuccessNotification} onClose={this.handleSuccessNotificationClose} variant="success" dismissible>
                        <Alert.Heading></Alert.Heading>
                        <p>Succes</p>
                    </Alert>
                </div>
            )
        }
        return (
            <div className='container'>
                <Card className="m-3">
                    <Card.Header className="text-center">
                        <Card.Title>Autentificare</Card.Title>
                    </Card.Header>
                    <Card.Body>
                        <Form onSubmit={this.handleSubmit}>
                            {successMessage}
                            {errorMessage}
                            {loading}
                            <Form.Group>
                                <Form.Label>Email</Form.Label>
                                <Form.Control
                                    required
                                    type='email'
                                    name='email'
                                    placeholder='Introduceti adresa de e-mail.'
                                    onChange={this.handleChange}
                                    isInvalid={errors.email.length > 0} />
                                <Form.Control.Feedback type="invalid">{errors.email}</Form.Control.Feedback>
                            </Form.Group>
                            <Form.Group>
                                <Form.Label>Parola</Form.Label>
                                <Form.Control
                                    required
                                    type='password'
                                    name='password'
                                    placeholder='Introduceti parola.'
                                    autoComplete='current-password'
                                    onChange={this.handleChange}
                                    isInvalid={errors.password.length > 0} />
                                <Form.Control.Feedback type="invalid">{errors.password}</Form.Control.Feedback>
                            </Form.Group>
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
                <Dialog fullScreen open={this.state.isRegisterOpen}>
                    <Register onClose={this.handleRegisterClose} />
                </Dialog>
            </div >
        );
    }
}

const mapStateToProps = state => {
    return {
        loading: state.auth.loading,
        error: state.auth.error,
        userId: state.auth.userId
    }
}

const mapDispatchToProps = dispatch => {
    return {
        onAuth: (email, password) => dispatch(actionCreators.auth(email, password))
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(Authenticate);