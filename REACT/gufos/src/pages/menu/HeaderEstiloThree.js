import React from 'react';

function HeaderEstiloThree() {
    return (
        <header class="cabecalhoPrincipal">
            <div class="container">
                <img src={require("../../../src/assets/img/icon-login.png")} />

                <nav class="cabecalhoPrincipal-nav" id="nav__email">Usuário</nav>
            </div>
        </header>
    )
}
export default HeaderEstiloThree;