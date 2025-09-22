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

namespace ariketa9
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

        private void salir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(text_box_nuevo.Text))
            {
                text_box_lista.Text += text_box_nuevo.Text + Environment.NewLine;
                text_box_nuevo.Clear();
            }
            else
            {
                MessageBox.Show("Introduzca datos para poder añadirlos");
            }
        }
    }
}