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

namespace ariketa13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void item_salir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void cortar_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(textBoxEditor.Text);
            textBoxEditor.Clear();
        }

        private void copiar_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(textBoxEditor.Text);
        }
        private void pegar_Click(object sender, RoutedEventArgs e)
        {
            textBoxEditor.Text += Clipboard.GetText();
        }
        private void eliminar_Click(object sender, RoutedEventArgs e)
        {
            textBoxEditor.Clear();
        }
        private void arial_Click(object sender, RoutedEventArgs e)
        {
            textBoxEditor.FontFamily = new FontFamily("Arial");
        }
        private void courier_Click(object sender, RoutedEventArgs e)
        {
            textBoxEditor.FontFamily = new FontFamily("Courier");
        }
        private void impact_Click(object sender, RoutedEventArgs e)
        {
            textBoxEditor.FontFamily = new FontFamily("Impact");
        }
        private void symbol_Click(object sender, RoutedEventArgs e)
        {
            textBoxEditor.FontFamily = new FontFamily("Symbol");
        }
    }
}