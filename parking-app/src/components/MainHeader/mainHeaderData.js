import { User, Calendar } from 'react-feather';
import { BiCar } from 'react-icons/bi';

export const headerData = [
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
        path: '/login',
        icon: <User />
    },
]