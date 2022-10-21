using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Modelo
{
    public class Livro
    {
        public int Id { get; set; }
        public String Titulo { get; set; }
        public String Autor { get; set; }
        public String Ano { get; set; }
        public String Paginas { get; set; }
    }
}
