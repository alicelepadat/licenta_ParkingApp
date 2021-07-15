import {Route, Switch, withRouter} from 'react-router-dom';

import Home from './pages/Home/Home';
import Navigation from "./components/Navigation/Navigation";
import Vehicles from "./pages/Vehicles/Vehicles";
import Reservations from "./pages/Reservations/Reservations";
import Register from './components/Auth/Register/Register';
import {connect} from "react-redux";
import * as actionsCreators from './store/actions/index';
import {useEffect} from "react";
import Login from "./components/Auth/Login/Login";
import Profile from "./pages/Profile/Driver/Driver";
import * as actionCreators from "./store/actions";
import Admin from "./pages/Profile/Admin/Admin";
import Administrator from "./pages/Profile/Administrator/Administrator";
import PageNotFound from "./components/PageNotFound/PageNotFound";
import ParkingAreas from "./pages/ParkingAreas/ParkingAreas";

function App(props) {

    useEffect(() => {
        props.onTryDriverAutoSignin();
    });

    useEffect(() => {
        if (props.userId) {
            props.getUserRole(props.userId);
        }
    }, [props]);

    return (
        <div>
            <Navigation/>
            <Switch>
                <Route exact path="/"><Home/></Route>
                {
                    props.role !== 210 && <Route exact path="/register"><Register/></Route>
                }
                <Route exact path="/login"><Login/></Route>
                {
                    props.role === 200 && <Route exact path="/profile"><Profile/></Route>
                }
                {
                    props.role === 210 && <Route exact path="/admin-dashboard"><Admin/></Route>
                }
                {
                    props.role === 220 && <Route exact path="/administrator-dashboard"><Administrator/></Route>
                }
                {
                    props.role === 220 && <Route exact path="/parking-areas"><ParkingAreas/></Route>
                }
                <Route exact path="/reservations"><Reservations/></Route>
                <Route exact path="/vehicles"><Vehicles/></Route>
                <Route component={PageNotFound} />
            </Switch>
        </div>
    );
}

const mapStateToProps = state => {
    return {
        userId: state.driverAuth.userId,
        role: state.driverAuth.role,
        user: state.driverData.user,
    };
};

const mapDispatchToProps = dispatch => {
    return {
        onTryDriverAutoSignin: () => dispatch(actionsCreators.authCheckState()),
        getUserRole: (userId) => dispatch(actionCreators.getUserRole(userId)),
        onFetchDriverData: (userId) => dispatch(actionCreators.fetchDriverData(userId)),
        onFetchAdminData: (userId) => dispatch(actionCreators.fetchAdminData(userId)),
    }
}

export default withRouter(connect(mapStateToProps, mapDispatchToProps)(App));
