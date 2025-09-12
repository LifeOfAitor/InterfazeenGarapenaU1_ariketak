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

namespace ariketak
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double numa = double.Parse(a.Text);
                double numb = double.Parse(a.Text);
                double numc = double.Parse(a.Text);
                double numd = double.Parse(a.Text);

                double result = (numa + 2 * numb + 3 * numc + 4 * numd) / 4;

                resul.Text = result.ToString();
            }catch (Exception ex)
            {
                resul.Text = "Bakarrik zenbakiak";
            }
            
        }

        private void limpiar_Click(object sender, RoutedEventArgs e)
        {
            a.Clear();
            b.Clear();
            c.Clear();
            d.Clear();
            resul.Clear();
        }

        private void salir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}