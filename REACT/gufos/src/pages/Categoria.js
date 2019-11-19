import React, { Component } from 'react'; // Importante objeto React
import '../App.css'; // Importando CSS
import Rodape from '../componentes/Rodape' //  Importando o componente Rodape
import HeaderEstiloOne from './menu/HeaderEstiloOne';

class Categoria extends Component {

    constructor(props){
        super(props);
        this.state = {
            listaCategorias : [],
            titulo : ''
        }
        // Chamar funções do projeto 
        this.atualizaEstadoTitulo = this.atualizaEstadoTitulo.bind(this);
        this.buscarCategorias = this.buscarCategorias.bind(this);
        this.cadastrarCategoria = this.cadastrarCategoria.bind(this);
    }

    // Função que faz a requisão para a api 
    // Atribui os dados recebidos ao state listaCategorias
    // Caso ocorra um erro, exibe no console do navegador
    buscarCategorias(){
        fetch('http://localhost:5000/api/categorias')   
        .then(resposta => resposta.json())
        .then(data => this.setState({ listaCategorias : data}))
        .catch((erro) => console.log(erro))
    }

    // Assim que a página for carregada, chama a função buscarCategorias
    componentDidMount(){
        this.buscarCategorias();
    }

    // Recebe um evento, e recebo o valor do campo titulo
    atualizaEstadoTitulo(event){
        this.setState({titulo:event.target.value})
    }

    cadastrarCategoria(event){
        event.preventDefault(); // Evito comprtamento padrões

        fetch('http://localhost:5000/api/categorias',
            {
                method: 'POST', // Declara o metodo que será utiizado
                body: JSON.stringify({titulo : this.state.titulo}),
                headers: {
                    "Content-type" : "application/json"  
                }
            })
            .then(resposta => {
                if(resposta.status === 200) {
                    console.log('Categoria cadastrada!')
                }
            })
            .catch(erro => console.log(erro))
            .then(this.buscarCategorias)
    }

    deletarCategoria = (id) => {
        console.log("Excluindo");

        fetch("http://localhost:5000/api/categorias/" + id, {
            method : 'DELETE',
            headers : {
                "Content-type" : "application/json"
            }
        }) 

        .then(response => response.json())  
        .then(response => {
            console.log(response);
            this.listaAtualizada();
            this.setState( () => ({lista : this.state.lista}) )
        })
    
        .catch(error => console.log(error))
        .then(this.buscarCategorias)
    }

    render() {
        return (
            <div className="App"> {/* Usando o CSS chamando o nome da classe (App) */}
                
                <HeaderEstiloOne />

                <main class="conteudoPrincipal">
                    <section class="conteudoPrincipal-cadastro">
                        <h1 class="conteudoPrincipal-cadastro-titulo">Categorias</h1>
                        <div class="container" id="conteudoPrincipal-lista">
                            <table id="tabela-lista">
                                <thead>
                                    <tr>
                                        <th>#</th>
                                        <th>Título</th>
                                        <th>Ação</th>
                                    </tr>
                                </thead>
                                
                                <tbody id="tabela-lista-corpo">
                                {/* Utiliar função o map para preencher a lista */}
                                { 
                                    // Percorre o array listaCategorias e preenche o campo da tabela
                                    // com o ID e o título de cada categoria
                                    this.state.listaCategorias.map(function(categoria){
                                        return (
                                            <tr key={categoria.categoriaId}>
                                                <td>{categoria.categoriaId}</td>
                                                <td>{categoria.titulo}</td>
                                                <td>
                                                    <button type="submit" onClick={i => this.deletarCategoria(categoria.categoriaId)}>Excluir</button>
                                                </td>
                                            </tr>
                                        )
                                    }.bind(this))
                                }
                                </tbody>
                            </table>
                        </div>

                        <div class="container" id="conteudoPrincipal-cadastro">
                            <h2 class="conteudoPrincipal-cadastro-titulo">
                                Cadastrar Tipo de Evento
            </h2>
                            {/* Adicionar evento para submeter requisição e chamar a função a ser  */}
                            <form onSubmit={this.cadastrarCategoria}>
                                <div class="container">
                                    <input
                                        value={this.state.titulo} // O valor digitado no input vai para  
                                        onChange = {this.atualizaEstadoTitulo} // Evento do formulário 
                                        type="text"
                                        id="nome-tipo-evento"
                                        placeholder="tipo do evento"
                                    />
                                    <button type="submit" class="conteudoPrincipal-btn conteudoPrincipal-btn-cadastro">Cadastrar</button>
                                </div>
                            </form>
                        </div>
                    </section>
                </main>
                <Rodape /> {/*Usando o componente rodape*/}
            </div>
        )
    }
}
export default Categoria; // Por padrão recebe o return e envia para o navegador 