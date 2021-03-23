import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import { FaBars, FaRegWindowClose } from "react-icons/fa";
import { NavbarData } from './Navbar.Data';
import '../../styles/Navbar.css';
import { IconContext } from 'react-icons';

class Navbar extends Component {
    constructor() {
        super();

        this.state = {
            sidebar: false
        }

        this.showSidebar = this.showSidebar.bind(this);
    }

    showSidebar() {
        this.setState({
            sidebar: !this.state.sidebar
        });
    }

    render() {
        return (
            <div>
                <IconContext.Provider value={{ color: 'aliceblue' }}>
                    <div className="navbar h-100">
                        <Link to='#' className="menu-bars" onClick={this.showSidebar}>
                            <FaBars />
                        </Link>
                    </div>
                    <nav className={this.state.sidebar ? "nav-menu active" : "nav-menu"}>
                        <ul className="nav-menu-items" onClick={this.showSidebar}>
                            <li className="navbar-toggle">
                                <Link to="#" className="menu-bars" >
                                    <FaRegWindowClose />
                                </Link>
                            </li>
                            {NavbarData.map((item, index) => {
                                return (
                                    <li key={index} className="nav-text">
                                        <Link to={item.path}>
                                            {item.icon}
                                            <span>{item.title}</span>
                                        </Link>
                                    </li>
                                )
                            })}
                        </ul>
                    </nav>
                </IconContext.Provider>
            </div>
        )
    }
}

export default Navbar;