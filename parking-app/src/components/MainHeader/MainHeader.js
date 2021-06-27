import React, { useState } from 'react';
import { NavLink } from 'react-router-dom';
import { headerData } from './mainHeaderData';

import classes from './MainHeader.module.css';
import { Menu } from 'react-feather';


const MainHeader = () => {

    const [showSidebar, setShowSidebar] = useState(false);

    const handleNavClick = () => {
        setShowSidebar(!showSidebar);
    }

    console.log(showSidebar)

    return (
        <div className={classes["nav-container"]}>
            <div className={classes["nav-container_icon"]} onClick={handleNavClick}>
                <Menu color='var(--DarkBlue)' />
            </div>
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

export default MainHeader;
