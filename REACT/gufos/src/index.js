// Arquivo de configuração de rotas 
import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import * as serviceWorker from './serviceWorker';
// Importando as dependências da Biblioteca MDB
import '@fortawesome/fontawesome-free/css/all.min.css';
import 'bootstrap-css-only/css/bootstrap.min.css';
import 'mdbreact/dist/css/mdb.css';

import { Route, BrowserRouter as Router, Switch } from 'react-router-dom'; // Importando dependências

// Importar páginas
import Categoria from './pages/Categoria'; // Importando a página categoria
import NotFound from './pages/NotFound'; // Importando a página NotFound
import Dashboard from './pages/Dashboard'; // Importando a página Dashboard
import Login from './pages/Login'; // Importando a página Login 
import Eventos from './pages/Eventos'; // Importando a página Eventos
import Usuarios from './pages/Usuarios';

const Rotas = (
    <Router>
        <div>
            <Switch>
                <Route exact path="/" component={App} /> {/* Caminho da home */}
                <Route path="/categorias" component={Categoria} />
                <Route path="/dashboard" component={Dashboard} />
                <Route path="/eventos" component={Eventos} />
                <Route path="/login" component={Login} />
                <Route path="/usuarios" component={Usuarios} />
                <Route component={NotFound} />
            </Switch>
        </div>
    </Router>
)

// Trocar a reenderização chamando a variável declarada acima
ReactDOM.render(Rotas, document.getElementById('root'));

serviceWorker.unregister(); 