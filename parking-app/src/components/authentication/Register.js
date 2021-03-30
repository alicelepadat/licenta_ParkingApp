import React, { Component } from 'react';
import { Form, Button, Card, Col } from 'react-bootstrap';
import { AppBar, Toolbar, IconButton } from '@material-ui/core';
import CloseIcon from '@material-ui/icons/Close';
import { format } from 'date-fns';
import * as validate from '../validate';
import * as actionCreators from '../../store/actions/index';
import { connect } from 'react-redux';

class Register extends Component {
    state = {
        controls: {
            name: {
                name: 'name',
                autoComplete: 'name',
                value: '',
                validation: {
                    required: true,
                    maxLength: 50,
                    message: 'Introduceti numele si prenumele.',
                },
                valid: false,
            },
            password: {
                name: 'password',
                value: '',
                autoComplete: 'new-password',
                validation: {
                    required: true,
                    minLength: 8,
                    message: 'Parola trebuie sa aiba minim 8 caractere.'
                },
                valid: false,
            },
            passwordVerify: {
                name: 'passwordVerify',
                value: '',
                autoComplete: 'verify-password',
                validation: {
                    required: true,
                    minLength: 8,
                    message: 'Parola nu corespunde cu cea anterioara.'
                },
                valid: false
            },
            email: {
                name: 'email',
                value: '',
                autoComplete: '',
                validation: {
                    required: true,
                    isEmail: true,
                    maxLength: 50,
                    message: 'Introduceti o adresa valida.'
                },
                valid: false,
            },
            phone: {
                name: 'phone',
                value: '',
                validation: {
                    required: true,
                    isPhoneNo: true,
                    message: 'Introduceti o adresa valida.'
                },
                valid: false,
            },
            licenseNumber: {
                name: 'licenseNumber',
                value: '',
                validation: {
                    required: true,
                    isLicenseNo: true,
                    message: 'Numar de permis nevalid.'
                },
                valid: false
            },
            expirationDate: {
                name: 'expirationDate',
                value: '',
                validation: {
                    required: true,
                    isExpirationDate: true,
                    message: 'Data de expirare nu poate fi o data anterioara.'
                },
                valid: false
            },
            issuer: {
                name: 'issuer',
                value: '',
                validation: {
                    required: true,
                    message: 'Selectati emitentul'
                },
                valid: false
            }
        },
        isFormValidated: false
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
        this.props.onRegister(
            this.state.controls.name.value,
            this.state.controls.password.value,
            this.state.controls.email.value,
            this.state.controls.phone.value,
            this.state.controls.licenseNumber.value,
            this.state.controls.expirationDate.value,
            this.state.controls.issuer.value
        );
    }

    render() {
        const todayDate = format(new Date(), "yyyy-MM-dd");
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
                                <Form.Group>
                                    <Form.Label>Nume</Form.Label>
                                    <Form.Control
                                        type="text"
                                        name="name"
                                        placeholder="Introduceti numele si prenumele"
                                        autoComplete={this.state.controls.name.autoComplete}
                                        isValid={this.state.controls.name.valid}
                                        isInvalid={this.state.controls.name.value !== '' && !this.state.controls.name.valid ? true : false}
                                        onChange={(ev) => this.inputChangedHandler(ev, this.state.controls.name.name)}
                                    />
                                    <Form.Control.Feedback type="invalid">{this.state.controls.name.validation.message}</Form.Control.Feedback>
                                </Form.Group>
                                <Form.Row>
                                    <Form.Group as={Col} md="6">
                                        <Form.Label htmlFor="inputPassword">Parola</Form.Label>
                                        <Form.Control
                                            type="password"
                                            id="inputPassword"
                                            aria-describedby="passwordHelpInline"
                                            placeholder="Introduceti o parola"
                                            autoComplete={this.state.controls.password.autoComplete}
                                            isValid={this.state.controls.password.valid}
                                            isInvalid={this.state.controls.password.value !== '' && !this.state.controls.password.valid ? true : false}
                                            onChange={(ev) => this.inputChangedHandler(ev, this.state.controls.password.name)}
                                        />
                                        <Form.Control.Feedback type="invalid">{this.state.controls.password.validation.message}</Form.Control.Feedback>
                                    </Form.Group>
                                    <Form.Group as={Col} md="6">
                                        <Form.Label htmlFor="inputPassword">Verificare parola</Form.Label>
                                        <Form.Control
                                            type="password"
                                            id="inputVerifyPassword"
                                            placeholder="Reintroduceti parola"
                                            autoComplete={this.state.controls.passwordVerify.autoComplete}
                                            isValid={this.state.controls.passwordVerify.valid}
                                            isInvalid={this.state.controls.passwordVerify.value !== '' && !this.state.controls.passwordVerify.valid ? true : false}
                                            onChange={(ev) => {
                                                this.inputChangedHandler(ev, this.state.controls.passwordVerify.name) &&
                                                    validate.verifyPassword(this.state.controls.password.valid.value, this.state.controls.passwordVerify.value)
                                            }}
                                        />
                                        <Form.Control.Feedback type="invalid">{this.state.controls.passwordVerify.validation.message}</Form.Control.Feedback>
                                    </Form.Group>
                                </Form.Row>
                                <Form.Row>
                                    <Form.Group as={Col} md="6">
                                        <Form.Label>Email</Form.Label>
                                        <Form.Control
                                            type="email"
                                            name="email"
                                            placeholder="Introduceti email-ul"
                                            autoComplete={this.state.controls.email.autoComplete}
                                            isValid={this.state.controls.email.valid}
                                            isInvalid={this.state.controls.email.value !== '' && !this.state.controls.email.valid ? true : false}
                                            onChange={(ev) => this.inputChangedHandler(ev, this.state.controls.email.name)}
                                        />
                                        <Form.Control.Feedback type="invalid">{this.state.controls.email.validation.message}</Form.Control.Feedback>
                                    </Form.Group>
                                    <Form.Group as={Col} md="6" controlId="">
                                        <Form.Label>Telefon</Form.Label>
                                        <Form.Control
                                            type="phone"
                                            name="phone"
                                            placeholder="Introduceti numarul de telefon"
                                            isValid={this.state.controls.phone.valid}
                                            isInvalid={this.state.controls.phone.value !== '' && !this.state.controls.phone.valid ? true : false}
                                            onChange={(ev) => this.inputChangedHandler(ev, this.state.controls.phone.name)}
                                        />
                                        <Form.Control.Feedback type="invalid">{this.state.controls.phone.validation.message}</Form.Control.Feedback>
                                    </Form.Group>
                                </Form.Row>

                                <Form.Text className="mt-4 mb-3"><h5>Informatii permis de conducere</h5></Form.Text>

                                <Form.Row>
                                    <Form.Group as={Col} md="4">
                                        <Form.Label>Numar</Form.Label>
                                        <Form.Control type="text"
                                            placeholder="Introduceti nr. permis"
                                            isValid={this.state.controls.licenseNumber.valid}
                                            isInvalid={this.state.controls.licenseNumber.value !== '' && !this.state.controls.licenseNumber.valid ? true : false}
                                            onChange={(ev) => this.inputChangedHandler(ev, this.state.controls.licenseNumber.name)}
                                        />
                                        <Form.Control.Feedback type="invalid">{this.state.controls.licenseNumber.validation.message}</Form.Control.Feedback>
                                    </Form.Group>
                                    <Form.Group as={Col} md="4">
                                        <Form.Label>Data expirarii</Form.Label>
                                        <Form.Control type="date"
                                            defaultValue={todayDate}
                                            isValid={this.state.controls.expirationDate.valid}
                                            isInvalid={this.state.controls.expirationDate.value !== '' && !this.state.controls.expirationDate.valid ? true : false}
                                            onChange={(ev) => this.inputChangedHandler(ev, this.state.controls.expirationDate.name)}
                                        />
                                        <Form.Control.Feedback type="invalid">{this.state.controls.expirationDate.validation.message}</Form.Control.Feedback>
                                    </Form.Group>
                                    <Form.Group as={Col} md="4">
                                        <Form.Label>Emitent</Form.Label>
                                        <Form.Control as="select" defaultValue="..."
                                            isValid={this.state.controls.issuer.valid}
                                            isInvalid={this.state.controls.issuer.value !== '' && !this.state.controls.issuer.valid ? true : false}
                                            onChange={(ev) => this.inputChangedHandler(ev, this.state.controls.issuer.name)}>
                                            <option>...</option>
                                            <option>Emitent2...</option>
                                        </Form.Control>
                                        <Form.Control.Feedback type="invalid">{this.state.controls.issuer.validation.message}</Form.Control.Feedback>
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

const mapDispatchToProps = dispatch => {
    return {
        onRegister: (name, password, email, phone, license, expDate, issuer) => dispatch(actionCreators.register(name, password, email, phone, license, expDate, issuer))
    }
}

export default connect(null, mapDispatchToProps)(Register);