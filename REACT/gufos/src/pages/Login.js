import React, { Component } from 'react';
import Rodape from '../componentes/Rodape';
import '../assets/css/login.css';
import Axios from 'axios';

class Login extends Component {

    constructor(props){
        super(props);
        this.state = {
            email : '',
            senha : '',
            erroMensagem : '',
            isLoading : false
        }
    }

    efetuaLogin(event){

        event.preventDefault();
        
        // Remove a frase de erro do state erroMensagem
        this.setState({ erroMensagem: '' });

        // Define que a requisição está em andamento
        this.setState({ isLoading: true });

        // Primeiro parâmetro URL da requisição 
        Axios.post('http://localhost:5000/api/login', 
        {
            // Segundo parâmetro são os dados
            email : this.state.email,
            senha : this.state.senha
        }) 
        
        .then(data => {
            // Criando uma condição que analiza o status da requisição 
            if(data.status === 200){
                localStorage.setItem('usuario-gufos', data.data.token)
                console.log("Meu token é " + data.data.token)
            }
        })

        // Criando um tratamento para o erro
        .catch(erro => {
            this.setState({ erroMensagem : "E-mail ou Senha inválidos!" })
            console.log("E-mail ou Senha inválidos!");
        })
    }

    atualizaStateCampo(event){
        this.setState({ [event.target.name] : event.target.value})
    }

    render() {
        return (
            <div className="App">
                <section class="container flex">
                    <div class="img__login"><div class="img__overlay"></div></div>

                    <div class="item__login">
                        <div class="row">
                            <div class="item">
                                <img src={require("../assets/img/icon-login.png")} class="icone__login" />
                            </div>
                            <div class="item" id="item__title">
                                <p class="text__login" id="item__description">Bem-vindo! Faça login para acessar sua conta.</p>
                            </div>
                            <form onSubmit={this.efetuaLogin.bind(this)}>
                                <div class="item">
                                    <input
                                        // E-mail
                                        class="input__login"
                                        placeholder="username"
                                        type="text"
                                        value={this.state.email}
                                        onChange={this.atualizaStateCampo.bind(this)}
                                        name="email"
                                        id="login__email"/>
                                </div>
                                <div class="item">
                                    <input
                                        // Senha
                                        class="input__login"
                                        placeholder="password"
                                        type="password"
                                        value={this.state.senha}
                                        onChange={this.atualizaStateCampo.bind(this)}
                                        name="senha"
                                        id="login__password"/>
                                </div>
                                <div class="item">
                                    <button class="btn btn__login" id="btn__login" type="submit">Login</button>
                                </div>
                            </form>
                        </div>
                    </div>
                </section>
                <Rodape />
            </div>
        )
    }
}
export default Login;