import React from 'react';
import { Link } from 'react-router-dom';
import { GiCartwheel } from 'react-icons/gi';
import '../styles/PageNotFound.css';

class PageNotFound extends React.Component {
    render() {
        return (
            <div className="container w-100 h-100 text-center">
                <div className="row">
                    <div className="col-sm ml-4">
                        4
                    </div>
                    <div className="col-sm">
                        <GiCartwheel />
                    </div>
                    <div className="col-sm mr-4">
                        4
                    </div>
                </div>
                <div className="msg">
                    <p>Oops, page not found!</p>
                    <p>Go <Link to='/'>home</Link> instead.
                    </p>
                </div>
            </div>
        );
    };
}

export default PageNotFound;