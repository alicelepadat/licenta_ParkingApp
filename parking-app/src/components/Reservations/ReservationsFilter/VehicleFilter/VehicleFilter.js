import React from 'react';
import Input from "../../../UI/Input/Input";

const VehicleFilter = (props) => {
    return (
        <div>
            <Input
                id="vehicleFilter"
                label="Cauta dupa nr. inmatriculare"
                type={"text"}
                placeholder="Introduceti nr. inmatriculare"
                value={props.value}
                onChange={props.onChange}
            />
        </div>
    );
};

export default VehicleFilter;
