import React from 'react';
import { Link } from 'react-router-dom';
import { GiCartwheel } from 'react-icons/gi';
import '../styles/PageNotFound.css';

class PageNotFound extends React.Component {
    render() {
        return (
            <div className="container w-100 h-100 text-center">
                <div className="error-page row justify-content-center">
                    4
                    <div>
                        <GiCartwheel />
                    </div>
                    4
                </div>
                <div className="msg">
                    <p>Oops, pagina pe care o cauti nu poate fi accesata!</p>
                    <p>Mergi inapoi <Link to='/'>acasa</Link>.
                    </p>
                </div>
            </div >
        );
    };
}

export default PageNotFound;