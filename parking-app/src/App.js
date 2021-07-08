import { Route } from 'react-router-dom';

import Home from './pages/Home/Home';
import Navigation from "./components/Navigation/Navigation";
import Login from "./components/Auth/Login/Login";
import Vehicles from "./pages/Vehicles/Vehicles";
import Reservations from "./pages/Reservations/Reservations";
import Profile from "./pages/Profile/Profile";
import Register from './components/Auth/Register/Register';

function App() {
    return (
        <div>
            <Navigation />
            <main>
                <Route path="/home"><Home /></Route>
                <Route path="/login"><Login /></Route>
                <Route path="/register"><Register /></Route>
                <Route path="/profile"><Profile /></Route>
                <Route path="/reservations"><Reservations /></Route>
                <Route path="/cars"><Vehicles /></Route>
            </main>
        </div>
    );
}

export default App;
