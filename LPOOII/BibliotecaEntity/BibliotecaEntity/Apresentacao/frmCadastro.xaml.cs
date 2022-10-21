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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Biblioteca
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class frmCadastro : Window
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Controle controle = new Controle();
            List<String> listaLivro = new List<String>();
            listaLivro.Add("0");
            listaLivro.Add(txbTitulo.Text);
            listaLivro.Add(txbAutor.Text);
            listaLivro.Add(txbAno.Text);
            listaLivro.Add(txbPaginas.Text);
            controle.cadastrarLivro(listaLivro);
            MessageBox.Show(controle.Mensagem);
        }
    }
}
