package com.example.calculadora.Modelo;

public class Controle extends AbsPropriedades
{

    public Controle(String numero1, String numero2, String opcao)
    {
        super(numero1, numero2, opcao);
        executar();
    }

    @Override
    public void executar()
    {
        this.mensagem = "";
        Validacao validacao = new Validacao(this.numero1, this.numero2, this.opcao);
        if (validacao.mensagem.equals(""))
        {
            Calculos calculos = new Calculos(validacao.n1,
                    validacao.n2, this.opcao);
            this.resultado = calculos.res.toString();
        }
        else
            this.mensagem = validacao.mensagem;
    }
}
