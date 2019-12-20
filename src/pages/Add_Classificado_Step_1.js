import React, { Component } from 'react';
import '../assets/css/add_classificado_step1.css'
import { Link } from 'react-router-dom';

class Add_Classificado_Step1 extends Component {

    constructor(props) {
        super(props);
        this.state = {
            listaEquipamentos: [],
            idEquipamento: '',
            marca: '',
            nomeEquipamento: '',
            modelo: '',
            sistemaOperacional: '',
            processador: '',
            // statusEquipamento: '',
            loading: false,
        }
        this.BuscarEquipamentos =  this.BuscarEquipamentos.bind(this);
        this.direcionaId = this.direcionaId.bind(this);
    }

    BuscarEquipamentos() {
        this.setState({ loading: true })

        fetch('https://localhost:5001/api/equipamento')
            .then(resposta => resposta.json())
            .then(data => {
                this.setState({ listaEquipamentos: data })
            })
            .catch((erro) => console.log(erro))
    }

    

    componentDidMount() {
        this.BuscarEquipamentos();
    }

    direcionaId(id) {
        window.location.href = '/cadastroclassificado?id=' + id 
        // console.log(id);
    }

    render() {
        return (
            <div className="add_classificado_step1">
                <header class="fixed">
                    <div id="menu_header_lateral_esquerda_adm">
                        <div id="icon_menu_header_adm"><i class="fas fa-bars"></i></div>

                        <div id="campo_busca_header_adm">
                            <i id="icon_campo_busca_header_adm" class="fas fa-search"></i>
                            <form action="">
                                <input type="text" value="" placeholder="Buscar usuário" />
                            </form>
                        </div>
                    </div>

                    <div id="menu_header_lateral_direita_adm">
                        <p>Victor Costa</p>

                        <div id="img_menu_header_adm">
                            <p>V</p>
                        </div>
                    </div>
                </header>

                <main id="conteudo_adm">
                    <nav id="menu_lateral_esquerda_adm">
                        <div class="identificador_menu_lateral_adm">
                            <div class="identificador_menu_lateral_cor_adm"></div>
                            <div class="icon_menu_lateral_adm">
                                <img src={require("../assets/img/user.png")} alt="ícone de usuário" />
                            </div>
                        </div>
                        <div class="icon_menu_lateral_adm">
                            <img src={require("../assets/img/laptop.png")} alt="ícone de equipamentos" />
                        </div>
                        <div class="icon_menu_lateral_adm">
                            <img src={require("../assets/img/file.png")} alt="ícone de classificados" />
                        </div>
                        <div class="icon_menu_lateral_adm">
                            <img src={require("../assets/img/categorias.png")} alt="ícone de categorias" />
                        </div>
                        <div class="icon_menu_lateral_adm">
                            <img src={require("../assets/img/logout.png")} alt="ícone de saída" />
                        </div>
                    </nav>

                    <section id="conteudo_tela_lateral_direita_adm">
                        <div id="cabecalho_corpo_adm">
                            <p>Usuários</p>
                        </div>
                        <div id="corpo_conteudo_adm">
                            <div id="limitacao_espaco_corpo_conteudo_adm">
                                <div id="sombra_tabela_adm">
                                    <table id="tabela_usuarios_adm">
                                        <thead>
                                            <tr>
                                                <th>
                                                    <a href="#">
                                                        marca
                                                    </a>
                                                </th>
                                                <th>
                                                    <a href="#">
                                                        nome
                                                    </a>
                                                </th>
                                                <th>
                                                    <a href="#">
                                                        modelo
                                                    </a>
                                                </th>
                                                <th>
                                                    <a href="#">
                                                        s.o.
                                                    </a>
                                                </th>
                                                <th>
                                                    <a href="#">
                                                        processador
                                                    </a>
                                                </th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            {this.state.listaEquipamentos.map(function (equipamento) {
                                                return (
                                                    <tr key={equipamento.idEquipamento}>

                                                        <td id="nome_usuario">{equipamento.marca}</td>
                                                        <td>{equipamento.nomeEquipamento}</td>
                                                        <td>{equipamento.modelo}</td>
                                                        <td id="numero_compras_user">{equipamento.sistemaOperacional}</td>
                                                        <td id="botao_delete">{equipamento.processador}</td>
                                                        <td><button type="submit" 
                                                        onClick={() => this.direcionaId(equipamento.idEquipamento) }>
                                                            {/* onClick={(e) => { e.preventDefault(); this.direcionaId(equipamento.idEquipamento) }}> */}
                                                           
                                                        
                                                            {/* <Link to={{
                                                                pathname: '/cadastroclassificado',
                                                                state: { idEquipamento: equipamento.idEquipamento }
                                                            }}>
                                                                Enviar
                                                                </Link> */}
                                                                Enviar
                                                        </button>
                                                        </td>

                                                    </tr>
                                                )
                                            }.bind(this))
                                            }
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </section>
                </main>
            </div >
        )
    }
}

export default Add_Classificado_Step1;