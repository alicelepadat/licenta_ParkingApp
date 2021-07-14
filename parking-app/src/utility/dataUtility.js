export const getAreaZone = (price) => {
    let zone = '';
    switch (price) {
        case 10:
            return zone = 'ZONA 0 - CENTRU';
        case 5:
            return zone = 'ZONA 1';
        default:
            return zone = 'ZONA 2';
    }
};

export const getNumberOfReservatiosn = (reservations, state) => {
    let number = 0;
    if (reservations.length > 0) {
        reservations.forEach(reservation => {
            if (reservation.state === state) {
                number += 1;
            }
        });
    }
    return number;
}
