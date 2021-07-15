export const getAreaZone = (price) => {
    switch (price) {
        case 10:
            return 'ZONA 0 - CENTRU';
        case 5:
            return 'ZONA 1';
        default:
            return 'ZONA 2';
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
