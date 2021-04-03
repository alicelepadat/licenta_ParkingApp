import React, { Component } from 'react';
import { Form, Button, Card, Col, Alert, Spinner } from 'react-bootstrap';
import { AppBar, Toolbar, IconButton } from '@material-ui/core';
import CloseIcon from '@material-ui/icons/Close';
import { format } from 'date-fns';
import * as validate from '../validate';
import * as actionCreators from '../../store/actions/index';
import { connect } from 'react-redux';

class Register extends Component {
    state = {
        name: null,
        email: null,
        password: null,
        verifyPassword: null,
        phone: null,
        licenseNumber: null,
        expirationDate: null,
        issuer: null,
        errors: {
            name: '',
            email: '',
            password: '',
            verifyPassword: '',
            phone: '',
            licenseNumber: '',
            expirationDate: '',
            issuer: '',
        },
        rules: {
            name: {
                maxLength: 50,
            },
            password: {
                minLength: 8,
            },
            verifyPassword: {
                minLength: 8,
            },
            email: {
                isEmail: true,
            },
            phone: {
                isPhoneNo: true,
            },
            licenseNumber: {
                isLicenseNo: true,
            },
            expirationDate: {
                isExpirationDate: true,
            },
        },
        isErrorNotification: true,
    }

    handleChange = (event) => {
        event.preventDefault();
        const { name, value } = event.target;
        let errors = this.state.errors;
        let rules = this.state.rules;

        switch (name) {
            case 'name':
                errors.name =
                    validate.checkValidity(value, rules.name)
                        ? '' : 'Numele si prenumele au maxim 50 de caractere.';
                break;
            case 'password':
                errors.password =
                    validate.checkValidity(value, rules.password)
                        ? '' : 'Parola trebuie sa aiba minim 8 caractere.';
                break;
            case 'verifyPassword':
                errors.verifyPassword =
                    validate.checkValidity(value, rules.verifyPassword) &&
                        validate.verifyPassword(value, this.state.password)
                        ? '' : 'Parola nu corespunde cu cea anterioara.';
                break;
            case 'email':
                errors.email =
                    validate.checkValidity(value, rules.email)
                        ? '' : 'Introduceti o adresa de e-mail valida.';
                break;
            case 'phone':
                errors.phone =
                    validate.checkValidity(value, rules.phone)
                        ? '' : 'Introduceti un numar de telefon valid.';
                break;
            case 'licenseNumber':
                errors.licenseNumber =
                    validate.checkValidity(value, rules.licenseNumber)
                        ? '' : 'Numar de permis nevalid.';
                break;
            case 'expirationDate':
                errors.expirationDate =
                    validate.checkValidity(value, rules.expirationDate)
                        ? '' : 'Data de expirare nu poate fi o data anterioara';
                break;
            default:
                break;
        }

        this.setState({ errors, [name]: value });
    }

    handleSubmit = (event) => {
        event.preventDefault();
        if (validate.validateForm(this.state.errors)) {
            this.props.onRegister(this.state.name, this.state.password, this.state.email, this.state.phone, this.state.licenseNumber, this.state.expirationDate, this.state.issuer);
        }
    }

    handleErrorNotificationClose = () => {
        this.setState({ isErrorNotification: false })
    }

    render() {
        const { errors } = this.state;
        const todayDate = format(new Date(), "yyyy-MM-dd");

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
                        <p>{this.props.error}</p>
                    </Alert>
                </div>

            )
        }

        return (
            <div>
                <AppBar style={{ position: 'relative', backgroundColor: 'rgb(1, 48, 90)' }}>
                    <Toolbar>
                        <IconButton edge="start" color="inherit" onClick={this.props.onClose} aria-label="close">
                            <CloseIcon />
                        </IconButton>
                    </Toolbar>
                </AppBar>
                <div className="container mt-3">
                    <Card className="m-3">
                        <Card.Header className="text-center">
                            <Card.Title>Creare cont</Card.Title>
                        </Card.Header>
                        <Card.Body>
                            <Form onSubmit={this.handleSubmit}>
                                {errorMessage}
                                {loading}
                                <Form.Group>
                                    <Form.Label>Nume</Form.Label>
                                    <Form.Control
                                        required
                                        type='text'
                                        name='name'
                                        placeholder='Introduceti numele si prenumele dvs.'
                                        onChange={this.handleChange}
                                        isInvalid={errors.name.length > 0} />
                                    <Form.Control.Feedback type="invalid">{errors.name}</Form.Control.Feedback>
                                </Form.Group>

                                <Form.Row>
                                    <Form.Group as={Col} md="6">
                                        <Form.Label>Parola</Form.Label>
                                        <Form.Control
                                            required
                                            type='password'
                                            name='password'
                                            placeholder='Introduceti parola.'
                                            autoComplete='new-password'
                                            onChange={this.handleChange}
                                            isInvalid={errors.password.length > 0} />
                                        <Form.Control.Feedback type="invalid">{errors.password}</Form.Control.Feedback>
                                    </Form.Group>
                                    <Form.Group as={Col} md="6">
                                        <Form.Label>Verificare parola</Form.Label>
                                        <Form.Control
                                            required
                                            type='password'
                                            name='verifyPassword'
                                            placeholder='Reintroduceti parola.'
                                            autoComplete='new-password'
                                            onChange={this.handleChange}
                                            isInvalid={errors.verifyPassword.length > 0} />
                                        <Form.Control.Feedback type="invalid">{errors.verifyPassword}</Form.Control.Feedback>
                                    </Form.Group>
                                </Form.Row>

                                <Form.Row>
                                    <Form.Group as={Col} md="6">
                                        <Form.Label>Email</Form.Label>
                                        <Form.Control
                                            required
                                            type='email'
                                            name='email'
                                            placeholder='Introduceti adresa de email.'
                                            onChange={this.handleChange}
                                            isInvalid={errors.email.length > 0} />
                                        <Form.Control.Feedback type="invalid">{errors.email}</Form.Control.Feedback>
                                    </Form.Group>
                                    <Form.Group as={Col} md="6">
                                        <Form.Label>Telefon</Form.Label>
                                        <Form.Control
                                            required
                                            type='phone'
                                            name='phone'
                                            placeholder='Reintroduceti parola.'
                                            autoComplete='phone'
                                            onChange={this.handleChange}
                                            isInvalid={errors.phone.length > 0} />
                                        <Form.Control.Feedback type="invalid">{errors.phone}</Form.Control.Feedback>
                                    </Form.Group>
                                </Form.Row>

                                <Form.Text className="mt-4 mb-3"><h5>Informatii permis de conducere</h5></Form.Text>

                                <Form.Row>
                                    <Form.Group as={Col} md="4">
                                        <Form.Label>Numar permis</Form.Label>
                                        <Form.Control
                                            required
                                            type='text'
                                            name='licenseNumber'
                                            placeholder='Numar permis.'
                                            onChange={this.handleChange}
                                            isInvalid={errors.licenseNumber.length > 0} />
                                        <Form.Control.Feedback type="invalid">{errors.licenseNumber}</Form.Control.Feedback>
                                    </Form.Group>
                                    <Form.Group as={Col} md="4">
                                        <Form.Label>Data expirarii</Form.Label>
                                        <Form.Control
                                            required
                                            type='date'
                                            name='expirationDate'
                                            defaultValue={todayDate}
                                            onChange={this.handleChange}
                                            isInvalid={errors.expirationDate.length > 0} />
                                        <Form.Control.Feedback type="invalid">{errors.expirationDate}</Form.Control.Feedback>
                                    </Form.Group>
                                    <Form.Group as={Col} md="4">
                                        <Form.Label>Emitent</Form.Label>
                                        <Form.Control
                                            as="select"
                                            defaultValue="Emitent"
                                            required
                                            name='issuer'
                                            onChange={this.handleChange}
                                            isInvalid={errors.issuer.length > 0}>
                                            <option>Emitent</option>
                                            <option>Emitent1...</option>
                                        </Form.Control>
                                        <Form.Control.Feedback type="invalid">{errors.issuer}</Form.Control.Feedback>
                                    </Form.Group>
                                </Form.Row>

                                <div className="text-center mt-4">
                                    <Button variant="primary" type="submit">
                                        Inregistrare
                                    </Button>
                                </div>
                            </Form>
                        </Card.Body>
                    </Card>
                </div>
            </div>
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
        onRegister: (name, password, email, phone, license, expDate, issuer) => dispatch(actionCreators.register(name, password, email, phone, license, expDate, issuer))
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(Register);