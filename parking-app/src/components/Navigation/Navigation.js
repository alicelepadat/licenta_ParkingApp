import React, { useState } from 'react';
import { NavLink } from 'react-router-dom';
import { headerData } from './navigationData';

import classes from './Navigation.module.css';
import { Menu } from 'react-feather';
import FloatingButton from "../UI/FloatingButton/FloatingButton";


const Navigation = () => {

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
                    <ul className={classes["nav-menu-items"]} onClick={handleNavClick}>
                        {headerData.map((item, index) => {
                            return (
                                <li key={index} className={classes["nav-text"]}>
                                    <NavLink to={item.path}>
                                        {item.icon}
                                        <span>{item.title}</span>
                                    </NavLink>
                                </li>
                            )
                        })}
                    </ul>
                </nav>
            }
        </div>
    );
};

export default Navigation;
