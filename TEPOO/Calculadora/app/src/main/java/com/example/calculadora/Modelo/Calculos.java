package com.example.calculadora.Modelo;

public class Calculos extends AbsPropriedades
{

    public Calculos(Double n1, Double n2, String opcao)
    {
        super(n1, n2, opcao);
        executar();
    }

    @Override
    public void executar()
    {
        if (opcao.equals("+")) res = n1 + n2;
        if (opcao.equals("-")) res = n1 - n2;
        if (opcao.equals("*")) res = n1 * n2;
        if (opcao.equals("/")) res = n1 / n2;
    }
}
