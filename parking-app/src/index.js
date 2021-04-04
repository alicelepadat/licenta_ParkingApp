import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter as Router } from "react-router-dom";
import 'bootstrap/dist/css/bootstrap.min.css';
import 'font-awesome/css/font-awesome.min.css';
import './index.css';
import App from './components/App';
import registerServiceWorker from './registerServiceWorker';

import { createStore, combineReducers, applyMiddleware, compose } from 'redux';
import thunk from 'redux-thunk';
import parkingAreasReducer from './store/reducers/parkingAreas';
import authReducer from './store/reducers/authentication';
import reservationReducer from './store/reducers/reservation';
import vehicleReducer from './store/reducers/vehicles';
import { Provider } from 'react-redux';

const rootReducer = combineReducers({
    parkingAreas: parkingAreasReducer,
    auth: authReducer,
    reserve: reservationReducer,
    vehicles: vehicleReducer,
});

const composeEnhancers = window.__REDUX_DEVTOOLS_EXTENSION_COMPOSE__ || compose;

const store = createStore(rootReducer, composeEnhancers(applyMiddleware(thunk)));

ReactDOM.render(
    <Provider store={store}>
        <Router>
            <App />
        </Router>
    </Provider>, document.getElementById('root'));
registerServiceWorker();
