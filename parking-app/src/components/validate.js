import { format } from 'date-fns';

export const checkValidity = (value, rules) => {
    let isValid = true;
    if (!rules) {
        return true;
    }

    if (rules.required) {
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

    return isValid;
}

export const verifyPassword = (value, verifyValue) => {
    return value === verifyValue ? true : false;
}