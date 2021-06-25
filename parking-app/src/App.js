import {Route} from 'react-router-dom';

import Home from './pages/Home/Home';
import MainHeader from "./components/MainHeader/MainHeader";
import Login from "./pages/Login/Login";
import Vehicles from "./pages/Vehicles/Vehicles";
import Reservations from "./pages/Reservations/Reservations";

function App() {
    return (
        <div>
            <MainHeader/>
            <main>
                <Route path="/home"><Home/></Route>
                <Route path="/login"><Login/></Route>
                <Route path="/reservations"><Reservations/></Route>
                <Route path="/cars"><Vehicles/></Route>
            </main>
        </div>
    );
}

export default App;
