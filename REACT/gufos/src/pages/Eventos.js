import React, { Component } from 'react'; // Importando objeto React 
import Rodape from '../componentes/Rodape';
import HeaderEstiloOne from './menu/HeaderEstiloOne';

class Eventos extends Component {

    constructor(props) {
        super(props);
        this.state = {
            listaEventos: [],
            titulo: '',
            dataEvento: '',
            acessoLivre: '',
            categoria: ''
        }
        // Chamar funções do projeto 
        this.buscarEventos = this.buscarEventos.bind(this);
        this.cadastrarEvento = this.cadastrarEvento.bind(this);
        this.atualizaEstadoTitulo = this.atualizaEstadoTitulo.bind(this);
        this.atualizaEstadoDataEvento = this.atualizaEstadoDataEvento.bind(this);
        this.atualizaEstadoAcessoLivre = this.atualizaEstadoAcessoLivre.bind(this);
        this.atualizaEstadoCategoria = this.atualizaEstadoCategoria.bind(this);
    }

   

    componentDidMount() {
        this.buscarEventos();
    }

    atualizaEstadoTitulo(event) {
        this.setState({ titulo: event.target.value })
        alert(this.state.titulo);
    }

    atualizaEstadoDataEvento(event) {
        this.setState({ dataEvento: event.target.value })
    }

    atualizaEstadoAcessoLivre(event) {
        this.setState({ acessoLivre: event.target.value })
    }

    atualizaEstadoCategoria(event) {
        this.setState({ categoria: event.target.value })
    }

    buscarEventos() {
        fetch('https://localhost:5001/api/eventos')
            .then(resposta => resposta.json())
            .then(data => this.setState({ listaEventos: data }))
            .catch((erro) => console.log(erro))
    }

    cadastrarEvento(event) {
        event.preventDefault();

        fetch('https://localhost:5001/api/eventos',
            {
                method: 'POST', // Declarando o método que será utilizado
                body: JSON.stringify({
                    titulo: this.state.titulo,
                    dataEvento: this.state.dataEvento,
                    acessoLivre: this.state.acessoLivre,
                    categoria : this.state.categoria
                }),
                    headers: {"Content-type" : "application/json"}
                })
            .then(resposta => {
                if (resposta.status === 200) {
                    console.log('Evento cadastrado!')
                }
            })
            .catch(erro => console.log(erro))
            .then(this.buscarEventos)
    }

    render() {
        return (
            <div className="App">
                
                <HeaderEstiloOne />

                <main class="conteudoPrincipal">
                    <section class="conteudoPrincipal-cadastro">
                        <h1 class="conteudoPrincipal-cadastro-titulo">Eventos</h1>
                        <div class="container" id="conteudoPrincipal-lista">
                            <table id="tabela-lista">
                                <thead>
                                    <tr>
                                        <th>#</th>
                                        <th>Evento</th>
                                        <th>Data</th>
                                        <th>Acesso Livre</th>
                                        {/* <th>Tipo do Evento</th> */}
                                    </tr>
                                </thead>

                                <tbody id="tabela-lista-corpo">
                                    {
                                        this.state.listaEventos.map(function (eventos) {
                                            return (
                                                <tr key={eventos.eventoId}>
                                                    <td>{eventos.eventoId}</td>
                                                    <td>{eventos.titulo}</td>
                                                    <td>{eventos.dataEvento}</td>
                                                    <td>{eventos.acessoLivre ? 'Público' : 'Privado'}</td>
                                                </tr>
                                            )
                                        })
                                    }
                                </tbody>
                            </table>
                        </div>

                        <form onSubmit={this.cadastrarEvento}>  
                            <div class="container" id="conteudoPrincipal-cadastro">
                                <h2 class="conteudoPrincipal-cadastro-titulo">Cadastrar Evento</h2>
                                <div class="container">

                                    <input
                                        value={this.state.titulo}
                                        onChange={this.atualizaEstadoTitulo}
                                        type="text"
                                        id="evento__titulo"
                                        placeholder="título do evento" />

                                    <input 
                                    value={this.state.dataEvento}
                                    onChange={this.atualizaEstadoDataEvento}
                                    type="date" 
                                    id="evento__data" 
                                    placeholder="dd/MM/yyyy" />

                                    <select id="option__acessolivre" value={this.state.acessoLivre} onChange={this.state.atualizaEstadoAcessoLivre}>
                                        <option value="true">Livre</option>
                                        <option value="false">Restrito</option>
                                    </select>

                                    <select id="option__tipoevento">
                                        <option value="1" >Tipo do Evento</option>
                                    </select>
                                    {/* <textarea
                                        rows="3"
                                        cols="50"
                                        placeholder="descrição do evento"
                                        id="evento__descricao">
                                    </textarea> */}
                                </div>
                                <button
                                    type="submit"
                                    class="conteudoPrincipal-btn conteudoPrincipal-btn-cadastro">Cadastrar</button>
                            </div>
                        </form>
                    </section>
                </main>
                <Rodape />
            </div>
        )
    }
}

export default Eventos;