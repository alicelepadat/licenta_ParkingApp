import React, { Component } from 'react';
import { Route, Switch, withRouter } from 'react-router-dom';
import HomePage from './home/HomePage';
import PageNotFound from './PageNotFound';
import Navbar from './nav/Navbar';
import ReservationList from './reservation/ReservationList';
import Vehicles from './vehicles/Vehicles';
import Authenticate from './authentication/Authenticate';
import { connect } from 'react-redux';
import * as actions from '../store/actions/index';

class App extends Component {

  componentDidMount() {
    this.props.onTryAutoSignin();
  }

  render() {
    return (
      <div className="App">
        <Navbar />
        <Switch>
          <Route exact path="/" component={HomePage} />
          <Route exact path="/reservations" component={ReservationList} />
          <Route exact path="/vehicles" component={Vehicles} />
          <Route exact path="/profile" component={Authenticate} />
          <Route component={PageNotFound} />
        </Switch>
      </div>
    );
  }
}

const mapDispatchToProps = dispatch => {
  return {
    onTryAutoSignin: () => dispatch(actions.authCheckState())
  }
}

export default withRouter(connect(null, mapDispatchToProps)(App));
