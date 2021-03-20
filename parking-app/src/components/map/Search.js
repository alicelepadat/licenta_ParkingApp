import React from 'react';
import { FaSearch } from 'react-icons/fa';

class Search extends React.Component {
    render() {
        return (
            <div className="container-xl bg-transparent">
                <form className="search-form" role="search">
                    <div className="input-group">
                        <div className="input-group-btn">
                            <button className="btn btn-default" type="submit">
                                <FaSearch color='cornflowerblue' />
                            </button>
                        </div>
                        <input
                            placeholder="Introduceti adresa"
                            className="form-control form-control-underlined"
                        >
                        </input>

                    </div>
                </form>
            </div>
        );
    }
}

export default Search;