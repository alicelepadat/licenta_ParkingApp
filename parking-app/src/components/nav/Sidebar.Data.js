import React from 'react';
import { FaUserAlt } from "react-icons/fa";
import { AiFillHome } from 'react-icons/ai';

export const SidebarData = [
    {
        title: 'Acasa',
        path: '/',
        icon: <AiFillHome />
    },
    {
        title: 'Profil',
        path: '/profile',
        icon: <FaUserAlt />
    },
]
