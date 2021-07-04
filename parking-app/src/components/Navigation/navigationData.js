import { User, Calendar, Home } from 'react-feather';
import { BiCar } from 'react-icons/bi';

export const headerData = [
    {
        title: 'Acasa',
        path: '/home',
        icon: <Home />
    },
    {
        title: 'Rezervari',
        path: '/reservations',
        icon: <Calendar />
    },
    {
        title: 'Masini',
        path: '/cars',
        icon: <BiCar size={25} />
    },
    {
        title: 'Profil',
        path: '/profile',
        icon: <User />
    },
]
