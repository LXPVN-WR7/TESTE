// Arquivo de configuração de rotas 

import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import * as serviceWorker from './serviceWorker';

import {Route, BrowserRouter as Router} from 'react-router-dom'; // Importando dependências

import Categoria from './pages/Categoria'; // Importando a página categoria

const Rotas = (
    <Router>
        <div>
            <Route exact path="/" component={App}/> {/* Caminho da home */}
            <Route path="/categoria" component={Categoria}/>
            <Route path="/categorias" component={Categoria}/>
        </div>
    </Router>
)

// Trocar a reenderização chamando a variável declarada acima
ReactDOM.render(Rotas, document.getElementById('root'));

serviceWorker.unregister(); 