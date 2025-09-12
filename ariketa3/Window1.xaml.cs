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

namespace ariketa3
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1(double resultado)
        {
            InitializeComponent();
            resultado_text.Text = resultado.ToString();
        }

        private void btn_limpiar_Click(object sender, RoutedEventArgs e) => Close();

        private void btn_exit_Click(object sender, RoutedEventArgs e) => Application.Current.Shutdown();
    }
}
