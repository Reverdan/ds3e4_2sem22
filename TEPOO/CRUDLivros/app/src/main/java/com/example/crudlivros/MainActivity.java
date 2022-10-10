package com.example.crudlivros;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity
{
    Intent intCadastro;
    Intent intPEE;
    Button btnCadastrar;
    Button btnPEE;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        configuracao();


        btnCadastrar = findViewById(R.id.btnCadastrar);
        btnPEE = findViewById(R.id.btnPEE);
        intCadastro = new Intent(this, actCadastrar.class);
        intPEE = new Intent(this, actPEE.class);

        btnCadastrar.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                startActivity(intCadastro);
            }
        });

        btnPEE.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                startActivity(intPEE);
            }
        });

        eventos();
    }

    private void configuracao()
    {

    }

    private void eventos()
    {

    }
}