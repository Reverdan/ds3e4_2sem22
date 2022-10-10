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
    /// Lógica interna para frmPrincipal.xaml
    /// </summary>
    public partial class frmPrincipal : Window
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mniCadastro_Click(object sender, RoutedEventArgs e)
        {
            frmCadastro frmC = new frmCadastro();
            frmC.ShowDialog();
        }

        private void mniPEE_Click(object sender, RoutedEventArgs e)
        {
            frmPEE frmP = new frmPEE();
            frmP.ShowDialog();
        }
    }
}
