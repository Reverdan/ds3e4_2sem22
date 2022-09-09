using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDPessoas.Modelo
{
    public class Validacao
    {
        public String Mensagem { get; set; }
        public void validarDadosPessoa(List<String> listaDadosPessoa)
        {
            try
            {
                int numero = Convert.ToInt32(listaDadosPessoa[0]);
                if (listaDadosPessoa[1].Equals(""))
                    this.Mensagem = "Nome não pode ser vazio";
                if (listaDadosPessoa[1].Length < 3)
                    this.Mensagem = "Nome deve ter mais que 3 caracteres";
                if (listaDadosPessoa[1].Length > 50)
                    this.Mensagem = "Nome deve ter menos que 50 caracteres";
                if (listaDadosPessoa[2].Length > 10)
                    this.Mensagem = "RG deve ter menos que 10 caracteres";
                if (listaDadosPessoa[3].Length > 10)
                    this.Mensagem = "CPF deve ter menos que 13 caracteres";
            }
            catch
            {
                this.Mensagem = "ID inválido";
            }
        }
    }
}
