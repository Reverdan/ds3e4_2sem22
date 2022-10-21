using Biblioteca.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAL
{
    public class LivroDAO
    {
        Conexao con = new Conexao();
        SqlDataReader dr;
        public String mensagem = "";
        BibliotecaContext conexao = new();

        public void cadastrarLivro(Livro livro)
        {
            try
            {
                conexao.Add(livro);
                conexao.SaveChanges();
                this.mensagem = "Livro cadastrado com sucesso";
            }
            catch (Exception)
            {
                this.mensagem = "Erro de cadastro";
            }
            

            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = @"insert into livros 
            //            (titulo, autor, ano, paginas)
            //            values (@titulo, @autor, @ano, @paginas)";
            //cmd.Parameters.AddWithValue("@titulo", livro.Titulo);
            //cmd.Parameters.AddWithValue("@autor", livro.Autor);
            //cmd.Parameters.AddWithValue("@ano", livro.Ano);
            //cmd.Parameters.AddWithValue("@paginas", livro.Paginas);
            //try
            //{
            //    cmd.Connection = con.Conectar();
            //    cmd.ExecuteNonQuery();
            //    con.Desconectar();
            //    this.mensagem = "Livro cadastrado com sucesso";
            //}
            //catch (Exception e)
            //{
            //    this.mensagem = "Erro de cadastro";
            //}
            //int i = 0;
        }

        public Livro pesquisarLivroPorId(Livro livro)
        {
            try
            {
                livro = conexao.LivroBD
                    .Where(l => l.Id == livro.Id)
                    .FirstOrDefault();
                if (livro == null) this.mensagem = "Livro não encontrado";
            }
            catch (Exception)
            {
                this.mensagem = "Erro de conexão com BD";
            }
            return livro;


            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = @"select * from livros 
            //                    where id = @id";
            //cmd.Parameters.AddWithValue("@id", livro.Id);
            //try
            //{
            //    cmd.Connection = con.Conectar();
            //    dr = cmd.ExecuteReader();
            //    if (dr.HasRows)
            //    {
            //        dr.Read();
            //        livro.Titulo = dr["titulo"].ToString();
            //        livro.Autor = dr["autor"].ToString();
            //        livro.Ano = dr["ano"].ToString();
            //        livro.Paginas = dr["paginas"].ToString();
            //    }
            //    else
            //    {
            //        livro.Id = 0;
            //        this.mensagem = "Registro não encontrado";
            //    }
            //}
            //catch (Exception e)
            //{
            //    this.mensagem = "Erro de conexão com BD";
            //}
            //con.Desconectar();
            //return livro;
        }

    }
}
