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

namespace ariketa11
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn_aceptar_Click(object sender, RoutedEventArgs e)
        {
            if (check_strings())
            {
                Pertsona.sartuPertsona(text_box_nombre.Text, text_box_apellido1.Text, text_box_apellido2.Text, text_box_DNI.Text);
                btn_cargar_visualizar.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Mete todos los valores");
            }
        }

        private bool check_strings()
        {
            return !(string.IsNullOrEmpty(text_box_nombre.Text) ||
                string.IsNullOrEmpty(text_box_apellido1.Text) ||
                string.IsNullOrEmpty(text_box_apellido1.Text) ||
                string.IsNullOrEmpty(text_box_DNI.Text));
        }

        private void btn_cargar_visualizar_Click(object sender, RoutedEventArgs e)
        {
            Window1 ventana = new Window1(Pertsona.izena, Pertsona.abizena1, Pertsona.abizena2, Pertsona.dni);
            ventana.Show();
        }
    }
}