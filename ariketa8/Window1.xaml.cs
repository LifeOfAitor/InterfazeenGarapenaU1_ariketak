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
using System.Globalization;

namespace ariketa8
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public DateTime fechaIni;
        public Window1()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_aceptar_Click(object sender, RoutedEventArgs e)
        {
            // esto no lo saco ni loco por mi cuenta, anotado para trabajar con fechas en un futuro
            // parsea la fecha a un formato correcto 
            DateTime fecha;
            bool esValida = DateTime.TryParseExact(txtBox_fechaIntroducida.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha);
            if (!esValida)
            {
                MessageBox.Show("Introduce una fecha válida con formato dd/MM/yyyy");
            }
            else
            {
                fechaIni = fecha;
                this.DialogResult = true;
                Close();
            }
        }
    }
}
