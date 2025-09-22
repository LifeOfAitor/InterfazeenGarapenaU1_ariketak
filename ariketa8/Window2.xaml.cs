using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace ariketa8
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public int meses = 0;
        public Window2()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, RoutedEventArgs e)
        {
            int valor;
            if (string.IsNullOrEmpty(txtBox_fechaIntroducida.Text) || !int.TryParse(txtBox_fechaIntroducida.Text, out valor))
            {
                MessageBox.Show("Introduce una fecha válida");
            }
            else
            {
                meses = valor;
                this.DialogResult = true;
                Close();
            }
        }

        private void btn_cancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
