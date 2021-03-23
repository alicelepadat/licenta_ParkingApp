import React from 'react';

class Footer extends React.Component {
    render() {
        return (
            <footer className="footer-bottom text-center text-lg-start">
                <div className="text-center p-3" >
                    <p>
                        &copy;{new Date().getFullYear()} Alice-Georgiana Lepadat
                    </p>
                </div>
            </footer>
        );
    }
}

export default Footer;