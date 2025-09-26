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

namespace ariketa11
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private String izena, abizena1, abizena2, dni;
        public Window1(string izena, string abizena1, string abizena2, string dni)
        {
            InitializeComponent();
            label_izena.Content = izena;
            label_abizena1.Content = abizena1;
            label_abizena2.Content = abizena2;
            label_dni.Content = dni;
        }

        private void btn_salir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
