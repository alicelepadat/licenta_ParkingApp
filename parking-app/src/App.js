import { Route, Switch, withRouter } from 'react-router-dom';

import Home from './pages/Home/Home';
import Navigation from "./components/Navigation/Navigation";
import Vehicles from "./pages/Vehicles/Vehicles";
import Reservations from "./pages/Reservations/Reservations";
import Register from './components/Auth/Register/Register';
import { connect } from "react-redux";
import * as actionsCreators from './store/actions/index';
import { useEffect } from "react";
import Login from "./components/Auth/Login/Login";
import Profile from "./pages/Profile/Profile";

function App(props) {

    useEffect(() => {
        props.onTryDriverAutoSignin();
    });

    return (
        <div>
            <Navigation />
            <Switch>
                <Route exact path="/"><Home /></Route>
                <Route exact path="/register"><Register /></Route>
                <Route exact path="/login"><Login /></Route>
                <Route path="/profile"><Profile /></Route>
                <Route exact path="/reservations"><Reservations /></Route>

                <Route exact path="/vehicles"><Vehicles /></Route>
            </Switch>
        </div>
    );
};

const mapDispatchToProps = dispatch => {
    return {
        onTryDriverAutoSignin: () => dispatch(actionsCreators.authCheckState())
    }
}

export default withRouter(connect(null, mapDispatchToProps)(App));
