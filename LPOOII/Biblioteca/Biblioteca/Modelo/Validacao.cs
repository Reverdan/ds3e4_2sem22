using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Modelo
{
    public class Validacao
    {
        public String Mensagem { get; set; }

        public void validarLivro(List<String> listaLivros)
        {
            this.Mensagem = "";
            if (listaLivros[1].Length < 3)
                this.Mensagem += "Título deve ter mais que 3 caracteres \n";
            if (listaLivros[1].Length > 50)
                this.Mensagem += "Título deve ter menos que 50 caracteres \n";

            if (listaLivros[2].Length < 3)
                this.Mensagem += "Autor deve ter mais que 3 caracteres \n";
            if (listaLivros[2].Length > 50)
                this.Mensagem += "Autor deve ter menos que 50 caracteres \n";

            if (listaLivros[3].Length < 2)
                this.Mensagem += "Ano deve ter mais que 2 caracteres \n";
            if (listaLivros[3].Length > 4)
                this.Mensagem += "Ano deve ter menos que 4 caracteres \n";

            if (listaLivros[4].Length < 1)
                this.Mensagem += "Paginas deve ter mais que 1 caracter \n";
            if (listaLivros[4].Length > 5)
                this.Mensagem += "Páginas deve ter menos que 5 caracteres \n";
        }

        public int validarId(String id)
        {
            int numero = 0;
            this.Mensagem = "";
            try
            {
                numero = Convert.ToInt32(id);
            }
            catch (Exception e)
            {
                this.Mensagem = "ID inválido";
            }
            return numero;
        }
    }
}
