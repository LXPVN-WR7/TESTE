import React, {Component} from "react"; // Importante objeto React
import '../App.css'; // Importando CSS
import Rodape from '../componentes/Rodape' //  Importando o componente Rodape

class Categoria extends Component {
    render(){
        return (
            <div className="App"> {/* Usando o CSS chamando o nome da classe (App) */}
                <h1>Categoria</h1>
                <p>teste categoria</p>
                <Rodape/> {/*Usando o componente rodape*/}
            </div>
        )
    }
}
export default Categoria; // Por padrão recebe o return e envia para o navegador 