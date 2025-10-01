using System;
using System.Windows;
using System.Windows.Input;

namespace ariketa12
{
    public partial class MainWindow : Window
    {
        private const double GOSARIA = 3;
        private const double BAZKARIA = 9;
        private const double AFARIA = 15.5;
        private const double KM_RATE = 0.25;
        private const double BIDAIA_ORDUA = 18;
        private const double LAN_ORDUA = 42;

            
        public MainWindow()             // FALTA ActualizarTotalGeneral y gestionar errores
        {
            InitializeComponent();
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            //espero no tener que memorizar esto
            if (e.Key == Key.Enter)
            {
                e.Handled = true;  // Evitamos el sonido o acción por defecto
                // Mover foco al siguiente control (como Tab)
                var request = new TraversalRequest(FocusNavigationDirection.Next);
                var focusedElement = Keyboard.FocusedElement as UIElement;

                if (focusedElement != null)
                    focusedElement.MoveFocus(request);
            }
        }
        private void Dietas_LostFocus(object sender, RoutedEventArgs e)
        {
            // Cuando el foco salga de cualquiera de los checkboxes de dietas, recalculamos
            double totalDietas = CalcularTotalDietas();
            text_box_total_dietas.Text = totalDietas.ToString();
            ActualizarTotalGeneral(totalDietas);
        }
        private void Viaje_LostFocus(object sender, RoutedEventArgs e)
        {
            // Cuando el foco salga de cualquiera de los checkboxes de dietas, recalculamos
            double totalViaje = CalcularTotalDietas();
            text_box_total_viaje.Text = CalcularTotalViaje().ToString();
            ActualizarTotalGeneral(totalViaje);
        }
        private void Trabajo_LostFocus(object sender, RoutedEventArgs e)
        {
            // Cuando el foco salga de cualquiera de los checkboxes de dietas, recalculamos
            double totalTrabajo = CalcularTotalDietas();
            text_box_total_trabajo.Text = totalTrabajo.ToString();
            ActualizarTotalGeneral(totalTrabajo);
        }

        private void ActualizarTotalGeneral(double total_add)
        {

        }


        private void btn_limpiar_Click(object sender, RoutedEventArgs e)
        {
            check_box_afaria.IsChecked = false;
            check_box_bazkaria.IsChecked = false;
            check_box_gosaria.IsChecked = false;

            text_box_km.Clear();
            text_box_bidaia_orduak.Clear();
            text_box_lan_orduak.Clear();

            text_box_total_dietas.Clear();
            text_box_total_viaje.Clear();
            text_box_total_trabajo.Clear();

            text_box_total.Clear();
        }

        private void btn_salir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private double CalcularTotalDietas()
        {
            double totalDietas = 0;

            if (check_box_gosaria.IsChecked == true)
                totalDietas += GOSARIA;

            if (check_box_bazkaria.IsChecked == true)
                totalDietas += BAZKARIA;

            if (check_box_afaria.IsChecked == true)
                totalDietas += AFARIA;

            return totalDietas;
        }

        private double CalcularTotalViaje()
        {
            if (double.TryParse(text_box_km.Text, out double km) &&
                double.TryParse(text_box_bidaia_orduak.Text, out double orduak))
            {
                return (km * KM_RATE) + (orduak * BIDAIA_ORDUA);
            }
            else
            {
                MessageBox.Show("Por favor, introduce solo números válidos para Km y Horas de viaje.");
                return 0;
            }
        }

        private double CalcularTotalTrabajo()
        {
            if (double.TryParse(text_box_lan_orduak.Text, out double lanOrduak))
            {
                return lanOrduak * LAN_ORDUA;
            }
            else
            {
                MessageBox.Show("Por favor, introduce solo números válidos para Horas de trabajo.");
                return 0;
            }
        }

        private void btn_calcular_Click(object sender, RoutedEventArgs e)
        {
            double dietas = CalcularTotalDietas();
            double viaje = CalcularTotalViaje();
            double trabajo = CalcularTotalTrabajo();

            text_box_total_dietas.Text = dietas.ToString("F2");
            text_box_total_viaje.Text = viaje.ToString("F2");
            text_box_total_trabajo.Text = trabajo.ToString("F2");

            double total = dietas + viaje + trabajo;
            text_box_total.Text = total.ToString("F2");
        }
    }
}
