using Biblioteca.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Modelo
{
    public class Controle
    {
        public String Mensagem { get; set; }

        public void cadastrarLivro(List<String> listaLivro)
        {
            this.Mensagem = "";
            Validacao validacao = new Validacao();
            validacao.validarLivro(listaLivro);
            if (validacao.Mensagem.Equals(""))
            {
                Livro livro = new Livro();
                livro.Titulo = listaLivro[1];
                livro.Autor = listaLivro[2];
                livro.Ano = listaLivro[3];
                livro.Paginas = listaLivro[4];
                LivroDAO livroDAO = new LivroDAO();
                livroDAO.cadastrarLivro(livro);
                this.Mensagem = livroDAO.mensagem;
            }
            else
            {
                this.Mensagem = validacao.Mensagem;
            }
        }

        public Livro pesquisarLivroPorId(String id)
        {
            Validacao validacao = new Validacao();
            Livro livro = new Livro();
            LivroDAO livroDAO = new LivroDAO();
            livro.Id = validacao.validarId(id);
            if (validacao.Mensagem.Equals(""))
            {
                livro = livroDAO.pesquisarLivroPorId(livro);
                this.Mensagem = livroDAO.mensagem;
            }
            else
                this.Mensagem = validacao.Mensagem;
            return livro;
        }
    }
}
