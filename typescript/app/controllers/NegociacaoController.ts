import { Negociacao } from "../models/Negociacao.js";
import { Negociacoes } from "../models/Negociacoes.js";

export class NegociacaoController{
    private inputData: HTMLInputElement;
    private inputQuantidade: HTMLInputElement;
    private inputValor: HTMLInputElement;
    private negociacoes = new Negociacoes();

    constructor(){
        this.inputData = document.querySelector("#data");
        this.inputQuantidade = document.querySelector("#quantidade");
        this.inputValor = document.querySelector("#valor");
    }

    adiciona(): void{
        const negociacao = this.criaNegociacao();
        this.negociacoes.adiciona(negociacao);
        this.limpaFormulario();
        console.log(this.negociacoes.lista());
    }

    criaNegociacao(): Negociacao{
        const exp = /-/g;
        const date = new Date(this.inputData.value.replace(exp, ","));
        const quantidade = parseInt(this.inputQuantidade.value);
        const valor = parseInt(this.inputValor.value);
        return new Negociacao(date, quantidade, valor);
    }

    limpaFormulario():void{
        this.inputData.value = '';
        this.inputQuantidade.value = '';
        this.inputValor.value = '';
        this.inputData.focus();
    }
}