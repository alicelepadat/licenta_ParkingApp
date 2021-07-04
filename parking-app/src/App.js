import {Route} from 'react-router-dom';

import Home from './pages/Home/Home';
import Navigation from "./components/Navigation/Navigation";
import Login from "./components/Login/Login";
import Vehicles from "./pages/Vehicles/Vehicles";
import Reservations from "./pages/Reservations/Reservations";
import Profile from "./components/Profile/Profile";

function App() {
    return (
        <div>
            <Navigation/>
            <main>
                <Route path="/home"><Home/></Route>
                <Route path="/login"><Login/></Route>
                <Route path="/profile"><Profile/></Route>
                <Route path="/reservations"><Reservations/></Route>
                <Route path="/cars"><Vehicles/></Route>
            </main>
        </div>
    );
}

export default App;
