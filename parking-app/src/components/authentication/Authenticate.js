import { Link } from '@material-ui/core';
import React, { Component } from 'react';
import { Form, Button, Card } from 'react-bootstrap';
import Dialog from '@material-ui/core/Dialog';
import Register from './Register';

class Authenticate extends Component {
    state = {
        open: false
    }

    handleRegisterClicked = () => {
        this.setState({ open: true });
    }

    handleClose = () => {
        this.setState({ open: false });
    }

    render() {
        return (
            <div className="container">
                <Card className="m-3">
                    <Card.Header className="text-center">
                        <Card.Title>Autentificare</Card.Title>
                    </Card.Header>
                    <Card.Body>
                        <Form>
                            <Form.Group controlId="formBasicEmail">
                                <Form.Label>Email</Form.Label>
                                <Form.Control type="email" placeholder="Introduceti adresa de email" />
                            </Form.Group>
                            <Form.Group controlId="formBasicPassword">
                                <Form.Label>Parola</Form.Label>
                                <Form.Control type="password" placeholder="Introduceti parola" />
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
                <Dialog fullScreen open={this.state.open} onClose={this.handleClose}>
                    <Register onClose={this.handleClose} />
                </Dialog>
            </div>
        )
    }
}

export default Authenticate;