import React from 'react';
import { FaSearch } from 'react-icons/fa';
import { GoogleApiWrapper } from 'google-maps-react';
import Autocomplete from './Autocomplete';

class Search extends React.Component {
    state = {
        display: false,
        search: '',
    }

    constructor(props) {
        super(props);

        this.handleChange = this.handleChange.bind(this);
    }

    handleChange(event) {
        this.setState({ search: event.target.value, display: true });
    }

    render() {
        return (
            < div className="container-fluid bg-transparent" >
                <div>
                    <form className="form-inline justify-content-center m-2">
                        <FaSearch color='cornflowerblue' />
                        <input
                            className="form-control form-control-underlined form-control-sm ml-2 w-75"
                            onChange={this.handleChange}
                            placeholder="Introduceti adresa"
                            value={this.state.search}
                        />
                    </form>
                </div>
                {this.state.display && this.state.search !== '' && (
                    <Autocomplete searchAddress={this.state.search} />
                )}
            </div >
        );
    }
}

export default GoogleApiWrapper({
    apiKey: process.env.REACT_APP_GOOGLE_MAPS_API_KEY,
    libraries: ["places"]
})(Search);