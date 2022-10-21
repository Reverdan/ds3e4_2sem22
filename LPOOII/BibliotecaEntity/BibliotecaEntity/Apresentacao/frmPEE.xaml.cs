
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

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            Controle controle = new Controle();
            List<String> listaLivro = new List<String>();
            listaLivro.Add(txbId.Text);
            listaLivro.Add(txbTitulo.Text);
            listaLivro.Add(txbAutor.Text);
            listaLivro.Add(txbAno.Text);
            listaLivro.Add(txbPaginas.Text);
            controle.editarLivro(listaLivro);
            MessageBox.Show(controle.Mensagem);
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            Controle controle = new Controle();
            MessageBoxResult resultado = MessageBox.Show("Deseja realmente excluir este livro?", 
                "Confirmação",MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (resultado == MessageBoxResult.Yes)
            {
                controle.excluirLivro(txbId.Text);
                MessageBox.Show(controle.Mensagem);
            }

        }
    }
}
