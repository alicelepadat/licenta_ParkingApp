import React, { Component } from 'react';
import { Route, Switch } from 'react-router-dom';
import Footer from './Footer';
import HomePage from './home/HomePage';
import PageNotFound from './PageNotFound';
import Navbar from './nav/Navbar';

class App extends Component {
  constructor() {
    super();

    this.state = {
      width: window.innerWidth
    }
  }

  componentDidMount() {
    window.addEventListener('resize', this.handleWindowSizeChange);
  }

  componentWillUnmount() {
    window.removeEventListener('resize', this.handleWindowSizeChange);
  }

  handleWindowSizeChange = () => {
    this.setState({ width: window.innerWidth });
  };

  render() {
    const isMobile = this.state.width <= 1024;

    return (
      <div className="App">
        <Navbar />
        <Switch>
          <Route exact path="/" component={HomePage} />
          <Route component={PageNotFound} />
        </Switch>
        {isMobile ? null : <Footer />}
      </div>
    );
  }
}

export default App;
