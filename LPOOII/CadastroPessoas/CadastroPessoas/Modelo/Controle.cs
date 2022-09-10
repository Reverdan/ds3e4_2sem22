using CRUDPessoas.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDPessoas.Modelo
{
    public class Controle
    {
        public String  Mensagem { get; set; }

        public void cadastrarPessoa(List<String> listaDadosPessoa)
        {
            Validacao validacao = new Validacao();
            validacao.validarDadosPessoa(listaDadosPessoa);
            if (validacao.Mensagem.Equals(""))
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Nome = listaDadosPessoa[1];
                pessoa.Rg = listaDadosPessoa[2];
                pessoa.Cpf = listaDadosPessoa[3];
                PessoaDAO pessoaDAO = new PessoaDAO();
                pessoaDAO.cadastrarPessoa(pessoa);
                this.Mensagem = pessoaDAO.mensagem;
            }
            else
            {
                this.Mensagem = validacao.Mensagem;
            }
        }
    }
}
