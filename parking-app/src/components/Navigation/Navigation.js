import React, { useState } from 'react';
import { NavLink } from 'react-router-dom';
import classes from './Navigation.module.css';
import { Menu, X } from 'react-feather';
import FloatingButton from "../UI/FloatingButton/FloatingButton";
import { connect } from "react-redux";
import { User, Calendar, Home } from 'react-feather';
import { BiCar } from 'react-icons/bi';


const Navigation = (props) => {

    const [showSidebar, setShowSidebar] = useState(false);

    const handleNavClick = () => {
        setShowSidebar(!showSidebar);
    }


    return (
        <div className={classes["nav-container"]}>
            <FloatingButton onClick={handleNavClick}>
                <Menu color='var(--DarkBlue)' />
            </FloatingButton>
            {
                showSidebar &&
                <nav className={classes["nav-menu"]}>
                    <button type="button" onClick={handleNavClick}><X /></button>
                    <ul className={classes["nav-menu-items"]}>
                        <li className={classes["nav-text"]} onClick={handleNavClick}>
                            <NavLink to="/">
                                <Home />
                                <span>Home</span>
                            </NavLink>
                        </li>
                        <li className={classes["nav-text"]} onClick={handleNavClick}>
                            <NavLink to="/reservations">
                                <Calendar />
                                <span>Rezervari</span>
                            </NavLink>
                        </li>
                        <li className={classes["nav-text"]} onClick={handleNavClick}>
                            <NavLink to="/vehicles">
                                <BiCar size={25} />
                                <span>Masini</span>
                            </NavLink>
                        </li>
                        <li className={classes["nav-text"]} onClick={handleNavClick}>
                            <NavLink to={props.userId !== null ? "/profile" : "/login"}>
                                <User />
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
    }
}

export default connect(mapStateToProps, null)(Navigation);
