import React from 'react';

const ErrorMessage = props => {
    return (
        <div>
            <h2>{props.error}</h2>
        </div>
    );
};

export default ErrorMessage;
