import React, { Component } from 'react';
import '../assets/css/dashboard_classificados.css';
import { Link } from 'react-router-dom';

class Dashboard_Classificados extends Component {

    constructor(props) {
        super(props);
        this.state = {
            idClassificado : '',
            listaClassificados: [],
            fimDeVidaUtil: '',
            dataFabricacao: '',
            numeroDeSerie: '',
            codigoClassificado: '',
            preco: '',
            mensagemErro : '',
            loading: false
        }
        this.BuscarClassificados.bind(this);
    }

    BuscarClassificados() {
        this.setState({ loading: true });

        fetch('https://localhost:5001/api/Classificado/adm')
            .then(resposta => resposta.json())
            .then(data => {
                this.setState({ listaClassificados: data })
            })
            .catch((erro) => console.log(erro))
    }

    DeletarClassificado = (idClassificado) => {
        console.log("Excluido!")

        fetch("https://localhost:5001/api/classificado/" + idClassificado,
            {
                method: "PUT",
                headers: {
                    "Content-type": "application/json"
                }
            })
            .then(response => response.json())
            .then(response => {
                console.log(response)
                this.BuscarClassificados();
                this.setState(() => ({ listaClassificados : this.state.listaClassificados }))
            })
            .catch(error => {
                console.log(error)
                this.setState({ mensagemErro : "Não foi possível excluir, verifique se não há anúncio já cadastrado com esse equipamento" })
            })
    }

    // CadastrarCategoria(event){

    //     event.preventDefault();
    //     console.log("Cadastrando");

    //     fetch("https://localhost:5001/api/classificado", {
    //         method : "POST",
    //         body : JSON.stringify({ fimDeVidaUtil : this.state.fimDeVidaUtil}),
    //         headers : {
    //             "Content-Type" : "application/json"
    //         }
    //     })
    //     .then(response => response.json())
    //     .then(Response => {
    //         console.log(response);
    //         this.BuscarClassificados();
    //     })
    //     .catch(error => console.log(error))
    // }

    componentDidMount() {
        this.BuscarClassificados();
    }

    Funciona() {
        console.log("Tá funcionando!");
    }

    render() {
        return (
            <div className="dashboard_classificados">
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
                            <p>Classificados</p>
                            <div>
                                <div id="box_icon_delete_user">
                                    <Link to={{
                                        pathname: '/cadastroclassificado/equipamento'
                                    }}>
                                        <img id="icon_delete_user" src={require("../assets/img/delete-photo.png")}
                                            alt="icone do botão de deletar um usuário" />
                                    </Link>
                                </div>
                            </div>
                        </div>
                        <div id="corpo_conteudo_adm">
                            <div id="limitacao_espaco_corpo_conteudo_adm">
                                <table id="tabela_usuarios_adm">
                                    <thead>
                                        <tr>
                                            <th></th>
                                            <th></th>
                                            <th>
                                                <a href="#">
                                                    nome
                                    </a>
                                            </th>
                                            <th>
                                                <a href="#">
                                                    fim da vida útil
                                    </a>
                                            </th>
                                            <th>
                                                <a href="#">
                                                    número de série
                                    </a>
                                            </th>
                                            <th>
                                                <a href="#">
                                                    código
                                    </a>
                                            </th>
                                            <th>
                                                <a href="#">
                                                    preço
                                    </a>
                                            </th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        {this.state.listaClassificados.map(function (classificado) {
                                            return (
                                                <tr key={classificado.idClassificado}>
                                                    <td id="td_input_adm">
                                                        <form id="form_input_user_adm" action="">
                                                            <input type="checkbox" name="" id="" />
                                                        </form>

                                                    </td>

                                                    <td id="td_imagem_adm">
                                                        <img id="imagem_perfil_usuario"
                                                            src={require("../assets/img/Mac.png")}
                                                            alt="imagem de perfil de usuário" />
                                                    </td>
                                                    <td id="nome_usuario">{classificado.idClassificado}</td>
                                                    <td>{classificado.fimDeVidaUtil}</td>
                                                    <td>{classificado.numeroDeSerie}</td>
                                                    <td id="numero_compras_user">{classificado.codigoClassificado}</td>
                                                    <td>{classificado.preco}</td>
                                                    <td id="botao_delete">
                                                        <a href="#">
                                                            <div onClick={i => this.DeletarClassificado(classificado.idClassificado)} id="box_icon_delete_user">
                                                                <img id="icon_delete_user" src={require("../assets/img/delete-photo.png")}
                                                                    alt="icone do botão de deletar um usuário" />
                                                            </div>
                                                        </a>
                                                    </td>
                                                </tr>
                                            )
                                        })
                                        }
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </section>
                </main>
            </div>
        )
    }
}

export default Dashboard_Classificados;