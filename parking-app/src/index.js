import ReactDOM from 'react-dom';
import { BrowserRouter } from 'react-router-dom';

import 'bootstrap/dist/css/bootstrap.min.css';

import './index.css';
import App from './App';
import { Provider } from "react-redux";
import { createStore, combineReducers, applyMiddleware, compose } from 'redux';
import thunk from "redux-thunk";
import driverAuthReducer from "./store/reducers/authReducer";
import userDataReducer from "./store/reducers/userDataReducer";
import driverVehiclesReducer from "./store/reducers/driverVehiclesReducer";
import reservationReducer from "./store/reducers/reservationReducer";
import parkingAreaReducer from "./store/reducers/parkingAreaReducer";
import * as serviceWorkerRegistration from './serviceWorkerRegistration';


const rootReducer = combineReducers({
    driverAuth: driverAuthReducer,
    driverData: userDataReducer,
    driverVehicles: driverVehiclesReducer,
    reservations: reservationReducer,
    parkingArea: parkingAreaReducer,
});

const composeEnhancers = window.__REDUX_DEVTOOLS_EXTENSION_COMPOSE__ || compose;

const store = createStore(rootReducer, composeEnhancers(applyMiddleware(thunk)));

ReactDOM.render(
    <Provider store={store}>
        <BrowserRouter>
            <App />
        </BrowserRouter>
    </Provider>,
    document.getElementById('root')
);

serviceWorkerRegistration.register();
