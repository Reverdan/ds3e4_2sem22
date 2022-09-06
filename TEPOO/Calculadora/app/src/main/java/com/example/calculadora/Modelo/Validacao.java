package com.example.calculadora.Modelo;

class Validacao extends AbsPropriedades
{
    public Validacao(String numero1, String numero2, String opcao)
    {
        super(numero1, numero2, opcao);
        executar();
    }

    @Override
    public void executar()
    {
        this.mensagem = "";
        try
        {
            this.n1 = Double.parseDouble(this.numero1);
            this.n2 = Double.parseDouble(this.numero2);
            if (this.n2.equals(0) && this.opcao.equals("/"))
                this.mensagem = "Divisão por zero";
        }
        catch (NumberFormatException e)
        {
            this.mensagem = "Erro de conversão";
        }
    }
}
