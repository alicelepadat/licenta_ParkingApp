import React, { Component } from 'react';
import { Route, Switch } from 'react-router-dom';
import HomePage from './home/HomePage';
import PageNotFound from './PageNotFound';
import Navbar from './nav/Navbar';
import Reservation from './reservation/Reservation';

class App extends Component {
  render() {
    return (
      <div className="App">
        <Navbar />
        <Switch>
          <Route exact path="/" component={HomePage} />
          <Route exact path="/reservation" component={Reservation} />
          <Route component={PageNotFound} />
        </Switch>
      </div>
    );
  }
}

export default App;
