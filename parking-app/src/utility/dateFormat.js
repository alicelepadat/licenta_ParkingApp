import {format} from "date-fns";

export const dateFormat = (date) => {
    return format(new Date(date), "yyyy-MM-dd");
};

export const timeFormat = (date) => {
    return new Date(date).toLocaleTimeString().slice(0,-3);
}
