import React, { Component } from 'react';
import { Form, Button, Card, Col } from 'react-bootstrap';
import { AppBar, Toolbar, IconButton } from '@material-ui/core';
import CloseIcon from '@material-ui/icons/Close';

class Register extends Component {
    render() {
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
                            <Form>
                                <Form.Group>
                                    <Form.Label>Nume</Form.Label>
                                    <Form.Control
                                        type="text"
                                        name="name"
                                        placeholder="Introduceti numele si prenumele"
                                    />
                                </Form.Group>
                                <Form.Row>
                                    <Form.Group as={Col} md="6">
                                        <Form.Label htmlFor="inputPassword">Parola</Form.Label>
                                        <Form.Control
                                            type="password"
                                            id="inputPassword"
                                            aria-describedby="passwordHelpInline"
                                            placeholder="Introduceti o parola"
                                        />
                                        <Form.Text id="passwordHelpInline" muted>
                                            Parola trebuie sa contina intre 8 si 20 de caractere.
                                    </Form.Text>
                                    </Form.Group>
                                    <Form.Group as={Col} md="6">
                                        <Form.Label htmlFor="inputPassword">Verificare parola</Form.Label>
                                        <Form.Control
                                            type="password"
                                            id="inputVerifyPassword"
                                            placeholder="Reintroduceti parola"
                                        />
                                    </Form.Group>
                                </Form.Row>
                                <Form.Row>
                                    <Form.Group as={Col} md="6">
                                        <Form.Label>Email</Form.Label>
                                        <Form.Control
                                            type="email"
                                            name="name"
                                            placeholder="Introduceti email-ul"
                                        />
                                    </Form.Group>
                                    <Form.Group as={Col} md="6" controlId="">
                                        <Form.Label>Telefon</Form.Label>
                                        <Form.Control
                                            type="phone"
                                            name="name"
                                            placeholder="Introduceti numarul de telefon"
                                        />
                                    </Form.Group>
                                </Form.Row>

                                <Form.Text className="mt-4 mb-3"><h5>Informatii permis de conducere</h5></Form.Text>

                                <Form.Row>
                                    <Form.Group as={Col} md="3">
                                        <Form.Label>Numar</Form.Label>
                                        <Form.Control type="text" placeholder="Introduceti nr. permis" />
                                    </Form.Group>
                                    <Form.Group as={Col} md="3">
                                        <Form.Label>Data expirarii</Form.Label>
                                        <Form.Control type="date" defaultValue={new Date()} />
                                    </Form.Group>
                                    <Form.Group as={Col} md="3">
                                        <Form.Label>Emitent</Form.Label>
                                        <Form.Control as="select" defaultValue="...">
                                            <option>...</option>
                                            <option>Emitent2...</option>
                                        </Form.Control>
                                    </Form.Group>
                                    <Form.Group as={Col} md="3">
                                        <Form.Label>Copie scanata permis</Form.Label>
                                        <Form.File
                                            id="license-file"
                                            label="Incarcati un fisier"
                                            data-browse="Alege"
                                            accept="image/*"
                                            custom
                                        />
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

export default Register;