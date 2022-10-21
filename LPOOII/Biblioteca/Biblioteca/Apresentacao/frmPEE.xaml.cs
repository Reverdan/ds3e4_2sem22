
using Biblioteca.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Biblioteca.Apresentacao
{
    /// <summary>
    /// Lógica interna para frmPEE.xaml
    /// </summary>
    public partial class frmPEE : Window
    {
        public frmPEE()
        {
            InitializeComponent();
        }

        private void btnPesquisarId_Click(object sender, RoutedEventArgs e)
        {
            Controle controle = new Controle();
            Livro livro = controle.pesquisarLivroPorId(txbId.Text);
            if (controle.Mensagem.Equals(""))
            {
                txbId.Text = livro.Id.ToString();
                txbTitulo.Text = livro.Titulo;
                txbAutor.Text = livro.Autor;
                txbAno.Text = livro.Ano;
                txbPaginas.Text = livro.Paginas;
            }
            else
            {
                MessageBox.Show(controle.Mensagem);
                txbId.Text = "";
                txbTitulo.Text = "";
                txbAutor.Text = "";
                txbAno.Text = "";
                txbPaginas.Text = "";
            }
        }
    }
}
