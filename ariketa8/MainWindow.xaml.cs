using System.Data;
using System.Diagnostics;
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

namespace ariketa8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String fechaHoy = DateTime.Now.ToShortDateString();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_limpiar_Click(object sender, RoutedEventArgs e)
        {
            txtBox_ahora.Clear();
            txtBox_hoy.Clear();
            txtBox_hora_hoy.Clear();
            txtBox_suma.Clear();
            txtBox_diferencia.Clear();
        }

        private void btn_salir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn_ejecutar_Click(object sender, RoutedEventArgs e)
        {
            txtBox_ahora.Text = DateTime.Now.ToString();
            txtBox_hoy.Text = fechaHoy;
            txtBox_hora_hoy.Text = DateTime.Now.TimeOfDay.ToString("hh\\:mm\\:ss");
        }

        private void txtBox_suma_GotFocus(object sender, RoutedEventArgs e)
        {
            Window2 nuevaVentana = new Window2();
            if (nuevaVentana.ShowDialog() == true)
            {
                int sumaMeses = nuevaVentana.meses;
                DateTime nuevaFecha = DateTime.Now.AddMonths(sumaMeses);
                txtBox_suma.Text = "Fecha de inicio: " + fechaHoy + ", Meses a sumar: " + sumaMeses + ". Nueva fecha: " + nuevaFecha.ToShortDateString();
            }
            else
            {
                MessageBox.Show("Ventana cerrada, no se puede hacer la operacion");
            }
            
        }

        private void txtBox_diferencia_GotFocus(object sender, RoutedEventArgs e)
        {
            Window1 nuevaVentana_f_ini = new Window1();
            Window3 nuevaVentana_f_fin = new Window3();
            if ((nuevaVentana_f_ini.ShowDialog() == true) && (nuevaVentana_f_fin.ShowDialog() == true))
            {
                DateTime fechaInicial = nuevaVentana_f_ini.fechaIni;
                DateTime fechaFinal = nuevaVentana_f_fin.fechaFin;
                TimeSpan dias = fechaFinal - fechaInicial;
                txtBox_diferencia.Text = "Desde " + fechaInicial.ToShortDateString() + " hasta " + fechaFinal.ToShortDateString() + " hay: " + dias.Days + " dias.";
            }
            else
            {
                MessageBox.Show("Ventana cerrada, no se puede hacer la operacion");
            }
        }
    }
}