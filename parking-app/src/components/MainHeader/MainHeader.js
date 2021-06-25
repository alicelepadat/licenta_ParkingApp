import React from 'react';
import {NavLink} from 'react-router-dom';

import classes from './MainHeader.module.css';
import {Home, UserPlus} from 'react-feather';


const MainHeader = () => {
    return (
        <header className={classes.header}>
            <nav>
                <ul>
                    <li>
                        <NavLink activeClassName={classes.active} to='/home' aria-label='Home'>
                            <Home/>
                        </NavLink>
                    </li>
                    <li>
                        <div className={classes.dropdown}>
                            <UserPlus/>
                            <div className={classes["dropdown-content"]}>
                                <NavLink to='/login' aria-label='Login'>
                                    Profil
                                </NavLink>
                                <NavLink to='/reservations' aria-label='Reservations'>
                                    Rezervari
                                </NavLink>
                                <NavLink to='/cars' aria-label='Cars'>
                                    Masini
                                </NavLink>
                            </div>
                        </div>
                    </li>
                </ul>
            </nav>
        </header>
    );
};

export default MainHeader;
