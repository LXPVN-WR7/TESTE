import React from 'react';

function HeaderEstiloOne() {
    return (
        <div>
            <header class="cabecalhoPrincipal">
                <div class="container">
                    <img src={require("../../../src/assets/img/icon-login.png")} />

                    <nav class="cabecalhoPrincipal-nav">
                        Administrador
                    </nav>
                </div>
            </header>
        </div>
    )
}
export default HeaderEstiloOne;