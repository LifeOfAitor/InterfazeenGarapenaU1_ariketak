using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ariketa3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double num1 = 0;
        double num2 = 0;
        double num3 = 0;
        double num4 = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(zenbakiak_text.Text))
            {
                MessageBox.Show("Por favor, introduce un número.");
                return;
            }

            double valor;
            if (!double.TryParse(zenbakiak_text.Text, out valor))
            {
                MessageBox.Show("Por favor, introduce un número válido.");
                return;
            }

            if (label_zenbakiak.Content.Equals("Numero 1:"))
            {
                num1 = valor;
                label_zenbakiak.Content = "Numero 2:";
                zenbakiak_text.Clear();
            }
            else if (label_zenbakiak.Content.Equals("Numero 2:"))
            {
                num2 = valor;
                label_zenbakiak.Content = "Numero 3:";
                zenbakiak_text.Clear();
            }
            else if (label_zenbakiak.Content.Equals("Numero 3:"))
            {
                num3 = valor;
                label_zenbakiak.Content = "Numero 4:";
                zenbakiak_text.Clear();
            }
            else if (label_zenbakiak.Content.Equals("Numero 4:"))
            {
                num4 = valor;
                double resultado = (num1 + (num1 * num2) + (num2 * num3) + (num3 * num4)) / 4;
                new Window1(resultado).Show();
                label_zenbakiak.Content = "Numero 1:";
                zenbakiak_text.Clear();
            }
        }

        private void btn_salir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}