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

namespace ex06
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            panResultado.Visibility = Visibility.Visible;
        }

        private void btnOk_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnOk_Click_2(object sender, RoutedEventArgs e)
        {
            int atual = DateTime.Now.Year;
            int nasc;
            int.TryParse(txtNasc.Text, out nasc);
            int idade = atual - nasc;
            lblMsg1.Content = $"Estamos no ano de {atual}.";
            lblMsg2.Content = $"Quem nasceu em {nasc:D} vai ter {idade:D} anos.";

            panResultado.Visibility = Visibility.Visible;
        }
    }
}
