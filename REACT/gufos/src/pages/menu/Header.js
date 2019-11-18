import React from 'react';

function Header() {
    return (
        <div>
            <header className="cabecalhoPrincipal">
                <div>
                    <img src={require("../../../src/assets/img/icon-login.png")} />
                   
                    <nav className="cabecalhoPrincipal-nav">
                        <a> Home </a>
                        <a> Eventos </a>
                        <a> Contato </a>
                        <a className="cabecalhoPrincipal-nav-login" href="login.html"> Login </a>
                    </nav>
                </div>
            </header>
        </div>
    )
}
export default Header;