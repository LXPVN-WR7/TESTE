import React from 'react';

function HeaderEstiloTwo() {
    return (
        <div>
            <header className="cabecalhoPrincipal">
                <div className="container">
                    <img src={require("../../../src/assets/img/icon-login.png")} />

                    <nav className="cabecalhoPrincipal-nav">
                        <a>Home</a>
                        <a>Eventos</a>
                        <a>Contato</a>
                        <a className="cabecalhoPrincipal-nav-login" href="login.html">Login</a>
                    </nav>
                </div>
            </header>
        </div>
    )
}
export default HeaderEstiloTwo;