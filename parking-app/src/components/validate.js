import { format } from 'date-fns';

export const formatTime = (time) => {
    return time.toLocaleTimeString('en-US', {
        hour12: false,
        hour: "numeric",
        minute: "numeric"
    });
}

export const addHoursToDate = (date, hours) => {
    return new Date(new Date(date).setHours(date.getHours() + hours));
}

export const checkValidity = (value, rules) => {
    let isValid = true;
    if (!rules) {
        return true;
    }

    if (rules.isRequired) {
        isValid = value.trim() !== '' && isValid;
    }

    if (rules.minLength) {
        isValid = value.length >= rules.minLength && isValid
    }

    if (rules.maxLength) {
        isValid = value.length <= rules.maxLength && isValid
    }

    if (rules.isEmail) {
        const pattern = /[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/;
        isValid = pattern.test(value) && isValid
    }

    if (rules.isNumeric) {
        const pattern = /^\d+$/;
        isValid = pattern.test(value) && isValid
    }

    if (rules.isPhoneNo) {
        const pattern = /(\+4|)?(07[0-9]{1}[0-9]{1}|02[0-9]{2}|03[0-9]{2}){1}?(\s|\.|)?([0-9]{3}(\s|\.|)){2}$/;
        isValid = pattern.test(value) && isValid
    }

    if (rules.isExpirationDate) {
        const todayDate = format(new Date(), "yyyy-MM-dd");
        isValid = value.localeCompare(todayDate) === 1 || value.localeCompare(todayDate) === 0 ? true : false
    }

    if (rules.isLicenseNo) {
        const pattern = /[A-Za-z]\d{8}[A-Za-z]$/;
        isValid = pattern.test(value) && isValid
    }

    if (rules.isLicensePlate) {
        const pattern = /[A-Z]{1,2}[0-9]{1,3}[A-Z]{3}$/;
        isValid = pattern.test(value) && isValid
    }

    if (rules.isTime) {
        const currentTime = formatTime(new Date());
        isValid = value.localeCompare(currentTime) === 1 || value.localeCompare(currentTime) === 0 ? true : false
    }

    return isValid;
}


export const verifyPassword = (value, verifyValue) => {
    return value === verifyValue ? true : false;
}

const convertMS = (ms) => {
    var d, h, m, s;
    s = Math.floor(ms / 1000);
    m = Math.floor(s / 60);
    s = s % 60;
    h = Math.floor(m / 60);
    m = m % 60;
    d = Math.floor(h / 24);
    h = h % 24;
    h += d * 24;
    return h + ':' + m + ':' + s;
}


export const verifyReservationTime = (date, endValue, startValue) => {
    let data = date.split('-');
    let start = startValue.split(':');
    let end = endValue.split(':');
    let startTime = new Date(data[0], data[1], data[2], start[0], start[1]);
    let endTime = new Date(data[0], data[1], data[2], end[0], end[1]);

    const diff = convertMS(endTime.getTime() - startTime.getTime()).split(':');

    return diff[0] >= 1;
}

export const validateForm = (errors) => {
    let valid = true;
    Object.values(errors).forEach(
        (val) => val.length > 0 && (valid = false)
    );
    return valid;
}