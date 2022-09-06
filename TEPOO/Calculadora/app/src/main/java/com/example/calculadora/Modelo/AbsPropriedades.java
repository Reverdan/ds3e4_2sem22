package com.example.calculadora.Modelo;

public abstract class AbsPropriedades implements IMetodos
{
    public String mensagem;
    public String numero1;
    public String numero2;
    public Double n1;
    public Double n2;
    public String resultado;
    public Double res;
    public String opcao;

    public AbsPropriedades(String numero1, String numero2, String opcao)
    {
        this.numero1 = numero1;
        this.numero2 = numero2;
        this.opcao = opcao;
    }

    public AbsPropriedades(Double n1, Double n2, String opcao)
    {
        this.n1 = n1;
        this.n2 = n2;
        this.opcao = opcao;
    }
}
