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

export const getPrice = (startTime, endTime, pricePerHour) => {
    let start = startTime.split(':');
    if (start[0] === '00') {
        start[0] = '24';
    }
    let end = endTime.split(':');
    if (end[0] === '00') {
        end[0] = '24';
    }
    let startDate = new Date(0, 0, 0, start[0], start[1], 0);
    let endDate = new Date(0, 0, 0, end[0], end[1], 0);
    let diff = endDate.getTime() - startDate.getTime();
    let hours = Math.floor(diff / 1000 / 60 / 60);
    diff -= hours * 1000 * 60 * 60;
    let minutes = Math.floor(diff / 1000 / 60);
    const duration = `${hours} ${hours > 1 ? ' ore' : ' ora'} ${minutes > 0 ? ` si ${minutes} minute` : ''}`
    if (minutes > 0) {
        hours++;
    }
    return [duration, pricePerHour * hours];
}
