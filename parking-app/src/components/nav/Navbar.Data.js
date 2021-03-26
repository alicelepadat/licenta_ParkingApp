import React from 'react';
import { FaUserAlt, FaParking, FaCarSide } from "react-icons/fa";
import { AiFillHome } from 'react-icons/ai';

export const NavbarData = [
    {
        title: 'Acasa',
        path: '/',
        icon: <AiFillHome />
    },
    {
        title: 'Rezervari',
        path: '/reservations',
        icon: <FaParking />
    },
    {
        title: 'Masini',
        path: '/vehicles',
        icon: <FaCarSide />
    },
    {
        title: 'Profil',
        path: '/profile',
        icon: <FaUserAlt />
    },
]
