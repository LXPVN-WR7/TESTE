import React, { Component } from 'react'; // Importando objeto React
import Rodape from '../componentes/Rodape';

class Dashboard extends Component {
    render() {
        return (
            <div className="Dashboard">
                <header class="cabecalhoPrincipal">
                    <div class="container">
                        <img src={require("../assets/img/icon-login.png")} />

                        <nav class="cabecalhoPrincipal-nav" id="nav__email">Usuário</nav>
                    </div>
                </header>

                <main class="conteudoPrincipal">
                    <div class="container">
                        <nav>
                            <ul class="conteudoPrincipal-dados">
                                <li class="conteudoPrincipal-dados-link">
                                    <h2 class="conteudoPrincipal-dados-titulo titulo-azul">Usuários</h2>
                                    <i
                                        class="fa fa-2x fa-user-o conteudoPrincipal-icone-azul"
                                        aria-hidden="true"></i>
                                    <span class="conteudoPrincipal-icone-span" id="qtdUsuarios">10</span>
                                </li>
                                <li class="conteudoPrincipal-dados-link">
                                    <h2 class="conteudoPrincipal-dados-titulo titulo-verde">Eventos Públicos</h2>
                                    <i
                                        class="fa fa-2x fa-user-o conteudoPrincipal-icone-verde"
                                        aria-hidden="true"></i>
                                    <span class="conteudoPrincipal-icone-span" id="qtdEventosPublicos">5</span>
                                </li>
                                <li class="conteudoPrincipal-dados-link">
                                    <h2 class="conteudoPrincipal-dados-titulo titulo-roxo">Eventos Privados</h2>
                                    <i
                                        class="fa fa-2x fa-user-o conteudoPrincipal-icone-roxo"
                                        aria-hidden="true"></i>
                                    <span class="conteudoPrincipal-icone-span" id="qtdEventosPrivados">20</span>
                                </li>
                                <li class="conteudoPrincipal-dados-link">
                                    <h2 class="conteudoPrincipal-dados-titulo titulo-vermelho">Tipos de Eventos</h2>
                                    <i
                                        class="fa fa-2x fa-user-o conteudoPrincipal-icone-vermelho"
                                        aria-hidden="true"></i>
                                    <span class="conteudoPrincipal-icone-span" id="qtdTiposEventos">10</span>
                                </li>
                            </ul>
                        </nav>
                    </div>
                </main>
                <Rodape />
            </div>
        )
    }
}
export default Dashboard;