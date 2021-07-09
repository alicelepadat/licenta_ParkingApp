import {Route, Switch, withRouter} from 'react-router-dom';

import Home from './pages/Home/Home';
import Navigation from "./components/Navigation/Navigation";
import Vehicles from "./pages/Vehicles/Vehicles";
import Reservations from "./pages/Reservations/Reservations";
import Register from './components/Auth/Register/Register';
import Profile from "./pages/Profile/Profile";
import {connect} from "react-redux";
import * as actionsCreators from './store/actions/index';
import {useEffect} from "react";

function App(props) {

    useEffect(() => {
        props.onTryDriverAutoSignin();
    });

    return (
        <div>
            <Navigation/>
            <Switch>
                <Route exact path="/"><Home/></Route>
                <Route exact path="/register"><Register/></Route>
                <Route exact path="/profile"><Profile/></Route>
                <Route exact path="/reservations"><Reservations/></Route>
                <Route exact path="/cars"><Vehicles/></Route>
            </Switch>
        </div>
    );
};

const mapDispatchToProps = dispatch => {
    return {
        onTryDriverAutoSignin: () => dispatch(actionsCreators.driverAuthCheckState())
    }
}

export default withRouter(connect(null, mapDispatchToProps)(App));
