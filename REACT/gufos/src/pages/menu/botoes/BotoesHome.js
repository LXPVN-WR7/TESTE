import React from 'react';

function BotoesHome() {
    return ( 
        <div>
            <nav className = "cabecalhoPrincipal-nav">
                <a> Home </a> 
                <a> Eventos </a> 
                <a> Contato </a> 
                <a className = "cabecalhoPrincipal-nav-login" href = "login.html"> Login </a> 
            </nav> 
        </div>
    );
}
export default BotoesHome;