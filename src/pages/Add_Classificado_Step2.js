import React, { Component } from 'react';
import '../assets/css/add_classificado_step_2.css';

class Add_Classificado_Step2 extends Component {

    constructor(props) {
        super(props);
        this.state = {
            idEquipamento: {
            },
            equipamento: [
            ],
            preco: '',
            numeroDeSerie: '',
            codigoClassificado: '',
            avaliacao: '',
            fimDeVidaUtil: '',
            dataFabricacao: '',
            softwaresInclusos: '',
            idEquipamento: '',
            imagemclassificado: []
        }
        this.buscarEquipamento = this.buscarEquipamento.bind(this);
    }

    buscarEquipamento() {
        console.log(this.props.location.state.idEquipamento)
        fetch('https://localhost:5001/api/equipamento/' + this.props.location.state.idEquipamento)
            .then(response => response.json())
            .then(data => this.setState({ equipamento: data }))
            .catch(erro => console.log(erro))
    }

    cadastrarClassificado() {
        fetch('http://localhost:5000/api/classificado', {
            method: 'POST',
            body: JSON.stringify({
                preco: this.state.preco,
                numeroDeSerie: this.state.numeroDeSerie,
                avaliacao: this.state.avaliacao,
                fimDeVidaUtil: this.state.fimDeVidaUtil,
                dataFabricacao: this.state.dataFabricacao,
                softwaresInclusos: this.state.softwaresInclusos,
                imagemclassificado: this.state.imagemclassificado
            }),
            headers: {
                "Content-type": "application/json"
            }
        })
            .then(response => {
                if (response.status === 200) {
                    console.log('Classificado Cadastrado!')
                }
            })
            .catch(erro => console.log(erro))
    }

    atualizaEstado = (event) => {
        this.setState({ [event.target.name]:[event.target.value] })
        console.log([event.target.value])
    }

    componentDidMount() {
        this.buscarEquipamento();
    }

    render() {
        return (
            <div className="add_classificado_step_2">
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
                                <img src="../assets/img/user.png" alt="ícone de usuário" />
                            </div>
                        </div>
                        <div class="icon_menu_lateral_adm">
                            <img src="../assets/img/laptop.png" alt="ícone de equipamentos" />
                        </div>
                        <div class="icon_menu_lateral_adm">
                            <img src="../assets/img/file.png" alt="ícone de classificados" />
                        </div>
                        <div class="icon_menu_lateral_adm">
                            <img src="../assets/img/categorias.png" alt="ícone de categorias" />
                        </div>
                        <div class="icon_menu_lateral_adm">
                            <img src="../assets/img/logout.png" alt="ícone de saída" />
                        </div>
                    </nav>

                    <section id="conteudo_tela_lateral_direita_adm">
                        <div id="cabecalho_corpo_adm">
                            <p>Usuários</p>
                        </div>
                        <div id="corpo_conteudo_adm">
                            <div id="limitacao_espaco_corpo_conteudo_adm">
                                <div id="conteudo_add_classificado_adm">
                                    <div id="margin_tela_add_classificado_adm">
                                        <form>
                                            <div id="imagens_do_classificado">
                                                <div>
                                                    <div id="style_add_img_adm" style={{ position: 'relative', display: 'inlineBlock' }}>
                                                        <input id="input_add_img_adm" type="file"
                                                            // @change="onFileChange"
                                                            style={{ position: 'absolute', left: '0', top: '0', opacity: '0' }} />
                                                    </div>
                                                    <div id="imagens_do_classificado_baixa">
                                                        <div class="style_add_img_baixa_adm"
                                                            style={{ position: 'relative', display: 'inlineBlock' }}>
                                                            <input class="input_add_img_classificado_baixa_adm" type="file"
                                                                // @change="onFileChange"
                                                                style={{ position: 'absolute', left: '0', top: '0', opacity: '0', }} />
                                                        </div>
                                                        <div class="style_add_img_baixa_adm"
                                                            style={{ position: 'relative', display: 'inlineBlock' }}>
                                                            <input class="input_add_img_classificado_baixa_adm" type="file"
                                                                // @change="onFileChange"
                                                                style={{ position: 'absolute', left: '0', top: '0', opacity: '0' }} />
                                                        </div>
                                                        <div class="style_add_img_baixa_adm"
                                                            style={{ position: 'relative', display: 'inlineBlock' }}>
                                                            <input class="input_add_img_classificado_baixa_adm" type="file"
                                                                // @change="onFileChange"
                                                                style={{ position: 'absolute', left: '0', top: '0', opacity: '0', }} />
                                                        </div>
                                                        <div class="style_add_img_baixa_adm"
                                                            style={{ position: 'relative', display: 'inlineBlock' }}>
                                                            <input class="input_add_img_classificado_baixa_adm" type="file"
                                                                // @change="onFileChange"
                                                                style={{ position: 'absolute', left: '0', top: '0', opacity: '0' }} />
                                                        </div>
                                                    </div>
                                                </div>
                                                <div id="div_uiop_32">
                                                    <div>
                                                        <div id="inputs_classificado_01">
                                                            <div class="formatando_input">
                                                                <label for=""><b>preço</b></label>
                                                                <input class="input_classificado_adm" name='preco' type="text" value={this.state.preco} onChange={i => this.atualizaEstado(i)} />
                                                            </div>
                                                            <div class="formatando_input">
                                                                <label for=""><b>número de série</b></label>
                                                                <input class="input_classificado_adm" name='numeroDeSerie' type="text" value={this.state.numeroDeSerie} onChange={i => this.atualizaEstado(i)} />
                                                            </div>
                                                            <div class="formatando_input">
                                                                <label for=""><b>código</b></label>
                                                                <input class="input_classificado_adm" name='codigo' type="text" value={this.state.codigo} onChange={i => this.atualizaEstado(i)} />
                                                            </div>
                                                            <div class="formatando_input">
                                                                <label for=""><b>fim da vida util</b></label>
                                                                <input class="input_classificado_adm" name='fimDaVidaUtil' type="text" value={this.state.fimDaVidaUtil} onChange={i => this.atualizaEstado(i)} />
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div>
                                                        <div class="inputs_classificado_02" action="">
                                                            <div class="formatando_input">
                                                                <label for=""><b>data de fabricação</b></label>
                                                                <input class="input_classificado_adm" name='dataDeFabricacao' type="text" value={this.state.dataDeFabricacao} onChange={i => this.atualizaEstado(i)} />
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div>
                                                        <div class="inputs_classificado_02" action="">
                                                            <div class="formatando_input">
                                                                <label for=""><b>softwares inclusos</b></label>
                                                                <textarea class="input_classificado_adm" type="text"
                                                                    style={{ width: '100%', height: '54px', resize: 'none', color: '#fff' }} name='softwaresInclusos' value={this.state.softwaresInclusos} onChange={i => this.atualizaEstado(i)} />
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div>
                                                <div action="" class="inputs_classificado_02" style={{ marginLeft: '0' }}>
                                                    <div class="formatando_input">
                                                        <label for=""><b>avaliação</b></label>
                                                        <textarea class="input_classificado_adm" type="text"
                                                            style={{ width: '100%', height: '250px', resize: 'none', color: '#fff' }} name='avaliacao' value={this.state.avaliacao} onChange={i => this.atualizaEstado(i)} />
                                                    </div>
                                                </div>
                                            </div>
                                            <button type="submit" onClick={(e) => e.cadastrarClassificado()} >Enviar</button>
                                        </form>
                                        <div>
                                            <hr
                                                style={{ width: '100%', marginTop: '30px', border: '0.5px solid rgba(255, 255, 255, 0.137)' }} />
                                        </div>
                                        <div style={{ marginTop: '25px' }}>
                                            <p><b style={{ color: '#fff', textTransform: 'uppercase' }}>equipamento</b></p>
                                            <div class="formatando_paragrafos">
                                                <div class="espacamento_info">
                                                    <div class="mj6yt">
                                                        <p>
                                                            <b>nome</b>
                                                        </p>
                                                    </div>
                                                    <div>
                                                        <p>{this.state.equipamento.nomeEquipamento}</p>
                                                    </div>
                                                </div>
                                                <div class="espacamento_info">
                                                    <div class="mj6yt">
                                                        <p>
                                                            <b>ssd</b>
                                                        </p>
                                                    </div>
                                                    <div>
                                                        <p>{this.state.equipamento.ssd}}</p>
                                                    </div>
                                                </div>
                                            </div>

                                            <div class="formatando_paragrafos">
                                                <div class="espacamento_info">
                                                    <div class="mj6yt">
                                                        <p>
                                                            <b>marca</b>
                                                        </p>
                                                    </div>
                                                    <div>
                                                        <p>{this.state.equipamento.marca}</p>
                                                    </div>
                                                </div>
                                                <div>
                                                    <div class="mj6yt">
                                                        <p>
                                                            <b>hd</b>
                                                        </p>
                                                    </div>
                                                    <div>
                                                        <p>{this.state.equipamento.hd}</p>
                                                    </div>
                                                </div>
                                            </div>

                                            <div class="formatando_paragrafos">
                                                <div class="espacamento_info">
                                                    <div class="mj6yt">
                                                        <p>
                                                            <b>modelo</b>
                                                        </p>
                                                    </div>
                                                    <div>
                                                        <p>{this.state.equipamento.modelo}</p>
                                                    </div>
                                                </div>
                                                <div>
                                                    <div class="mj6yt">
                                                        <p>
                                                            <b>placa de vídeo</b>
                                                        </p>
                                                    </div>
                                                    <div>
                                                        <p>{this.state.equipamento.placaDeVideo}</p>
                                                    </div>
                                                </div>
                                            </div>

                                            <div class="formatando_paragrafos">
                                                <div class="espacamento_info">
                                                    <div>
                                                        <div class="mj6yt">
                                                            <p>
                                                                <b>sistema operacional</b>
                                                            </p>
                                                        </div>
                                                        <div>
                                                            <p>{this.state.equipamento.sistemaOperacional}</p>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div>
                                                    <div class="mj6yt">
                                                        <p>
                                                            <b>alimentação</b>
                                                        </p>
                                                    </div>
                                                    <div>
                                                        <p>{this.state.equipamento.alimentacao}</p>
                                                    </div>
                                                </div>
                                            </div>

                                            <div class="formatando_paragrafos">
                                                <div class="espacamento_info">
                                                    <div>
                                                        <div class="mj6yt">
                                                            <p>
                                                                <b>polegada</b>
                                                            </p>
                                                        </div>
                                                        <div>
                                                            <p>{this.state.equipamento.polegada}</p>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div>
                                                    <div>
                                                        <p>
                                                            <b>peso</b>
                                                        </p>
                                                    </div>
                                                    <div>
                                                        <p>{this.state.equipamento.peso}</p>
                                                    </div>
                                                </div>
                                            </div>

                                            <div class="formatando_paragrafos">
                                                <div class="espacamento_info">
                                                    <div>
                                                        <div class="mj6yt">
                                                            <p>
                                                                <b>processador</b>
                                                            </p>
                                                        </div>
                                                        <div>
                                                            <p>{this.state.equipamento.processador}</p>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div>
                                                    <div class="mj6yt">
                                                        <p>
                                                            <b>dimensões</b>
                                                        </p>
                                                    </div>
                                                    <div>
                                                        <p>{this.state.equipamento.dimensoes}</p>
                                                    </div>
                                                </div>
                                            </div>

                                            <div class="formatando_paragrafos">
                                                <div>
                                                    <div class="mj6yt">
                                                        <p>
                                                            <b>memória ram</b>
                                                        </p>
                                                    </div>
                                                    <div>
                                                        <p>{this.state.equipamento.memoriaRam}</p>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </section>
                </main>
            </div>
        )
    }
}

export default Add_Classificado_Step2;