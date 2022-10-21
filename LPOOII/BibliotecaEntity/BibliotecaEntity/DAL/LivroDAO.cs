using Biblioteca.Modelo;
using BibliotecaEntity.DAL;
using Microsoft.EntityFrameworkCore;
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
        }

        public void editarLivro(Livro livro)
        {
            try
            {
                conexao.Entry(livro).State = EntityState.Modified;
                conexao.SaveChanges();
                this.mensagem = "Livro editado com sucesso";
            }
            catch (Exception)
            {
                this.mensagem = "Erro de conexão com BD";
            }
        }

        public void excluirLivro(Livro livro)
        {
            try
            {
                livro = pesquisarLivroPorId(livro);
                if (livro == null) this.mensagem = "Livro não encontrado";
                else
                {
                    conexao.Remove(livro);
                    conexao.SaveChanges();
                    this.mensagem = "Livro excluido com sucesso";
                }
            }
            catch (Exception)
            {
                this.mensagem = "Erro de conexão com BD";
            }
        }

    }
}
