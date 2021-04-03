import * as actionTypes from '../actions/actionTypes';
import { updateObject } from '../utility';

const initialState = {
    userId: null,
    error: null,
    loading: false,
    isLoggedIn: false,
};

const authStart = (state, action) => {
    return updateObject(state, { error: null, loading: true });
}

const authSucces = (state, action) => {
    return updateObject(state, {
        userId: action.userId,
        isLoggedIn: true,
        error: null,
        loading: false
    });
};

const authFail = (state, action) => {
    return updateObject(state, {
        error: action.error,
        loading: false
    });
};

const authLogOut = (state, action) => {
    return updateObject(state, {
        userId: null,
        isLoggedIn: false
    })
}

const reducer = (state = initialState, action) => {
    switch (action.type) {
        case actionTypes.AUTHENTICATION_START:
            return authStart(state, action);
        case actionTypes.AUTHENTICATION_SUCCESS:
            return authSucces(state, action);
        case actionTypes.AUTHENTICATION_FAILED:
            return authFail(state, action);
        case actionTypes.AUTHENTICATION_LOGOUT:
            return authLogOut(state, action);
        default:
            return state;
    }
}

export default reducer;