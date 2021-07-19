import React, {useState} from 'react';
import {NavLink} from 'react-router-dom';
import classes from './Navigation.module.css';
import {Menu, X} from 'react-feather';
import FloatingButton from "../UI/FloatingButton/FloatingButton";
import {connect} from "react-redux";
import {User, Calendar, Home} from 'react-feather';
import {BiCar} from 'react-icons/bi';
import {RiParkingBoxLine} from "react-icons/all";


const Navigation = (props) => {

    const [showSidebar, setShowSidebar] = useState(false);
    const anonimIdentifier = localStorage.getItem("identifier") !== null;

    const handleNavClick = () => {
        setShowSidebar(!showSidebar);
    }


    return (
        <div className={classes["nav-container"]}>
            <FloatingButton onClick={handleNavClick}>
                <Menu color='var(--DarkBlue)'/>
            </FloatingButton>
            {
                showSidebar &&
                <nav className={classes["nav-menu"]}>
                    <button type="button" onClick={handleNavClick}><X/></button>
                    <ul className={classes["nav-menu-items"]}>
                        <li className={classes["nav-text"]} onClick={handleNavClick}>
                            <NavLink to="/">
                                <Home/>
                                <span>Home</span>
                            </NavLink>
                        </li>
                        <li className={classes["nav-text"]} onClick={handleNavClick}>
                            <NavLink to="/reservations">
                                <Calendar/>
                                <span>Rezervari</span>
                            </NavLink>
                        </li>
                        {
                            (props.role === 200 || (anonimIdentifier && props.role === null)) &&
                            <li className={classes["nav-text"]} onClick={handleNavClick}>
                                <NavLink to="/vehicles">
                                    <BiCar size={25}/>
                                    <span>Masini</span>
                                </NavLink>
                            </li>
                        }
                        {
                            props.role === 220  &&
                            <li className={classes["nav-text"]} onClick={handleNavClick}>
                                <NavLink to="/parking-areas">
                                    <RiParkingBoxLine size={26}/>
                                    <span>Zone de parcare</span>
                                </NavLink>
                            </li>
                        }
                        <li className={classes["nav-text"]} onClick={handleNavClick}>
                            <NavLink
                                to={props.userId !== null && props.role === 200 ? "/profile" : props.role === 210 ? "/admin-dashboard" : "/login"}>
                                <User/>
                                <span>Utilizator</span>
                            </NavLink>
                        </li>
                    </ul>
                </nav>
            }
        </div>
    );
};

const mapStateToProps = state => {
    return {
        userId: state.driverAuth.userId,
        role: state.driverAuth.role,
    }
}

export default connect(mapStateToProps, null)(Navigation);
