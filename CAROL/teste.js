import React, { Component } from 'react';
import Rodape from '../componentes/Rodape';

// Importamos nosso logo dos Assets
import logo from '../assets/img/icon-login.png';

//IMPORTAR A BIBLIOTECA MDB
import { MDBContainer, MDBBtn, MDBModal, MDBModalBody, MDBModalHeader, MDBModalFooter, MDBInput } from 'mdbreact';


class Categorias extends Component {

    constructor(props){
        super(props);
        this.state = {
            listaCategorias : [],
            titulo : "",
            loading : false,
            erroMsg : "",
            modal : false,
            editarModal : {
                categoriaId : "",
                titulo : ""
            }       
        }

        this.cadastrarCategoria = this.cadastrarCategoria.bind(this);
        this.deletarCategoria   = this.deletarCategoria.bind(this);
        
    }

    //ADD TOGGLEik
    toggle = () => {
      this.setState({
        modal: !this.state.modal
      });
    }

    buscarCategorias(){
      //setar state loading mostrar
      this.setState({loading : true});

      fetch("http://localhost:5000/api/categorias")
          .then(resposta => resposta.json())
          .then(data => {
            this.setState({ listaCategorias : data})
            
            //setar state do loading nao aparecer 
            this.setState({loading: false}); 
          })
          .catch(error => {
              //setar state do loading para nao aparecer
              this.setState({loading: false}); 
              
              console.log(error);
          })
  }

    cadastrarCategoria(event){

        event.preventDefault();
        console.log("Cadastrando");

        fetch("http://localhost:5000/api/categorias", {
           method : "POST",
           body: JSON.stringify({ titulo : this.state.titulo }),
           headers : { 
               "Content-Type" : "application/json"
           }
        })
        .then(response => response.json())
        .then(response => {
            console.log(response);
            this.buscarCategorias();
        })
        .catch(error => console.log(error))
    }

    deletarCategoria = (id) => {
      console.log("Excluindo");
   
      fetch("http://localhost:5000/api/categorias/"+id,{
         method : "DELETE",
         headers : {
           "Content-type" : "application/json"
         }
      })
   
      .then(response => response.json())
      
      .then(response => {
         console.log(response);
         this.buscarCategorias();//atualizar categorias
         this.setState( () => ({listaCategorias: this.state.listaCategorias}) )
      })
      .catch(error => { 
        console.log(error) 
        this.setState({erroMsg : "Não foi possivel excluir, verifique se não há evento já cadastrado nessa categoria"})
      })
   }
   
  //Funcoes de Alterar (PUT)

  alterarCategoria = (categoria) =>{
      this.setState({
        editarModal : {
          categoriaId: categoria.categoriaId,
          titulo: categoria.titulo
        }
      })
    //ABRIR MODAL
      this.toggle();
    }

    salvarAlteracoes = (event) => {
        event.preventDefault(); //evitar o comportamento padrao da pagina

        fetch("http://localhost:5000/api/categorias/"+this.state.editarModal.categoriaId,{
            method : "PUT",
            body: JSON.stringify(this.state.editarModal),
            headers : {
              "Content-Type" : "application/json"
            }
        })
        .then(response => response.json())
        .then(
           setTimeout(() => {
             this.buscarCategorias()
           }, 2000)
        )
        .catch(error => console.log(error))

        //Fechar Modal 
        this.toggle();
    }
 
    atualizaEstadoTitulo(event){
      this.setState({titulo:event.target.value}) 
  }
  
  //Atualizar titutlo do modal
  atualizaEditarModalTitulo(input){
        this.setState({
          editarModal: {
            categoriaId : this.state.editarModal.categoriaId,
            titulo: input.target.value
        }
    })
  }


    componentDidMount(){
        this.buscarCategorias();
    }


    render(){

       //ADD VARIAVEL LOADING 
       let {loading} = this.state;
    
        return(
            <div className="App">
                <header className="cabecalhoPrincipal">
                    <div className="container">
                    <img src={logo} alt="Logo Gufos" />

                    <nav className="cabecalhoPrincipal-nav">
                        Administrador
                    </nav>
                    </div>
                </header>

                <main className="conteudoPrincipal">
                    <section className="conteudoPrincipal-cadastro">
                    <h1 className="conteudoPrincipal-cadastro-titulo">Categorias</h1>
                    
                    <div className="container" id="conteudoPrincipal-lista">
                        <table id="tabela-lista">
                        <thead>
                            <tr>
                            <th>#</th>
                            <th>Título</th>
                            <th>Ação</th>
                            </tr>
                        </thead>

                        <tbody id="tabela-lista-corpo">
                            {
                                this.state.listaCategorias.map(function(categoria){
                                    return (
                                        <tr key={categoria.categoriaId}>
                                            <td>{categoria.categoriaId}</td>
                                            <td>{categoria.titulo}</td>
                                            <td>
                                                {/* ADD BOTAO DE ALTERAR */}
                                                <button onClick={obj=> this.alterarCategoria(categoria)}>Alterar</button>
                                                <button onClick={e => this.deletarCategoria(categoria.categoriaId)}>Excluir</button>
                                            </td>
                                        </tr>
                                    );
                                }.bind(this))
                            }
                        </tbody>
                        </table>
                    </div>
                    
                    {/* ADD CONDICOES DE LOADING  */}
                    {loading && <i className="fa fa-spin fa-spinner fa-2x"></i>}

                    {/* EXIBIR MSG DE ERRRO */}
                    {this.state.erroMsg && <div className="text-danger">{this.state.erroMsg}</div>}

                    <div className="container" id="conteudoPrincipal-cadastro">
                        <h2 className="conteudoPrincipal-cadastro-titulo">
                        Cadastrar Categoria
                        </h2>
                        <form onSubmit={this.cadastrarCategoria}>
                        <div className="container">

                            <input
                                type="text"
                                className="class__categoria"
                                id="input__categoria"
                                placeholder="tipo do evento"
                                value={this.state.titulo}
                                onChange={this.atualizaEstadoTitulo.bind(this)}
                            />

                            <button
                            id="btn__cadastrar"
                            className="conteudoPrincipal-btn conteudoPrincipal-btn-cadastro"
                            >
                            Cadastrar
                            </button>
                        </div>
                        </form>
                    </div>
                    </section>
                </main>
                {/* ADCIONAR CONTAINER MODAL  */}
                
    <MDBContainer>
     <form onSubmit={this.salvarAlteracoes}>
      <MDBModal isOpen={this.state.modal} toggle={this.toggle}>
        <MDBModalHeader toggle={this.toggle}> Alterar <b> {this.state.editarModal.titulo} </b></MDBModalHeader>
        <MDBModalBody>
            <MDBInput
                label="Categoria"
                value={this.state.editarModal.titulo}
                onChange={this.atualizaEditarModalTitulo.bind(this)}
            />
        </MDBModalBody>
        <MDBModalFooter>
          <MDBBtn color="secondary" onClick={this.toggle}>Fechar</MDBBtn>
          <MDBBtn color="primary" type="submit">Alterar</MDBBtn>
        </MDBModalFooter>
      </MDBModal>
      </form>
    </MDBContainer>
            

                <Rodape />
            </div>
        );
    }
}

export default Categorias;