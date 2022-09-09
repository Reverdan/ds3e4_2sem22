using CRUDPessoas.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDPessoas.DAL
{
    public class PessoaDAO
    {
        Conexao con = new Conexao();
        SqlDataReader dr;
        public String mensagem = "";
        public void cadastrarPessoa(Pessoa pessoa)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into pessoas 
                        (nome, rg, cpf)
                        values (@nome, @rg, @cpf)";
            cmd.Parameters.AddWithValue("@nome", pessoa.Nome);
            cmd.Parameters.AddWithValue("@rg", pessoa.Rg);
            cmd.Parameters.AddWithValue("@cpf", pessoa.Cpf);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
                this.mensagem = "Pessoa cadastrada com sucesso";
            }
            catch (Exception e)
            {
                this.mensagem = "Erro de cadastro";
            }
            int i = 0;
        }
    }
}
