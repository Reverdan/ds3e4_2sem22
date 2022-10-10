package com.example.calculadora;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;
import androidx.appcompat.app.AppCompatActivity;

import com.example.calculadora.Modelo.Controle;

public class MainActivity extends AppCompatActivity
{
    EditText edtNumero1;
    EditText edtNumero2;
    Button btnSomar;
    Button btnSubtrair;
    Button btnMultiplicar;
    Button btnDividir;
    TextView txvResultado;
    String mensagem = "";
    String resposta = "";

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        configuracao();
        eventos();
    }

    private void configuracao()
    {
        edtNumero1 = findViewById(R.id.edtNumero1);
        edtNumero2 = findViewById(R.id.edtNumero2);
        btnSomar = findViewById(R.id.btnSomar);
        btnSubtrair = findViewById(R.id.btnSubtrair);
        btnMultiplicar = findViewById(R.id.btnMultiplicar);
        btnDividir = findViewById(R.id.btnDividir);
        txvResultado = findViewById(R.id.txvResultado);
    }

    private void Calcular(String opcao)
    {
        Controle controle = new Controle(edtNumero1.getText().toString(),
                edtNumero2.getText().toString(), opcao);
        if (controle.mensagem.equals(""))
            txvResultado.setText(controle.resultado);
        else
        {
            txvResultado.setText("");
            Toast.makeText(getApplicationContext(), getString(R.string.erro_conversao), Toast.LENGTH_LONG).show();
        }
    }

    private void eventos()
    {
        btnSomar.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                Calcular("+");
            }
        });

        btnSubtrair.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                Calcular("-");
            }
        });

        btnMultiplicar.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                Calcular("*");
            }
        });

        btnDividir.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                Calcular("/");
            }
        });
    }
}