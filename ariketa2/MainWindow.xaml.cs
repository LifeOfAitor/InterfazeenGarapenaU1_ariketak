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

namespace ariketa2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String erantzuna;
        public MainWindow()
        {
            InitializeComponent();
            erantzuna = "";
        }

        private void frase_1_Click(object sender, RoutedEventArgs e)
        {
            frase_2.IsEnabled = true;
            erantzuna = erantzuna + salida.Text.ToString() + " ";
            salida.Clear();
        }

        private void frase_2_Click(object sender, RoutedEventArgs e)
        {
            frase_3.IsEnabled = true;
            erantzuna = erantzuna + salida.Text.ToString() + " ";
            salida.Clear();
        }

        private void frase_3_Click(object sender, RoutedEventArgs e)
        {
            frase_4.IsEnabled = true;
            erantzuna = erantzuna + salida.Text.ToString() + " ";
            salida.Clear();
        }

        private void frase_4_Click(object sender, RoutedEventArgs e)
        {
            frase_5.IsEnabled = true;
            erantzuna = erantzuna + salida.Text.ToString() + " ";
            salida.Clear();
        }

        private void frase_5_Click(object sender, RoutedEventArgs e)
        {
            unir.IsEnabled = true;
            erantzuna = erantzuna + salida.Text.ToString();
            salida.Clear();
        }

        private void unir_Click(object sender, RoutedEventArgs e)
        {
            salida.Text = erantzuna;
        }

        private void limpiar_Click(object sender, RoutedEventArgs e)
        {
            salida.Clear();
            frase_2.IsEnabled = false;
            frase_3.IsEnabled = false;
            frase_4.IsEnabled = false;
            frase_5.IsEnabled = false;
            unir.IsEnabled = false;
        }

        private void salir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}