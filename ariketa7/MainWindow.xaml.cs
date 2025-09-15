using System.Data;
using System.Linq.Expressions;
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

namespace ariketa7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String operacion = "";  // operacion total
        String individual = ""; // la operacion donde se mete el numero
        public MainWindow()
        {           
            InitializeComponent();
            EncenderCalculadora(true);
        }

        private void encender_Click(object sender, RoutedEventArgs e)
        {
            EncenderCalculadora(!txtBox_erantzuna.IsEnabled);
        }

        private void EncenderCalculadora(bool encender)
        {
            txtBox_erantzuna.IsEnabled = encender;
            btn0.IsEnabled = encender;
            btn1.IsEnabled = encender;
            btn2.IsEnabled = encender;
            btn3.IsEnabled = encender;
            btn4.IsEnabled = encender;
            btn5.IsEnabled = encender;
            btn6.IsEnabled = encender;
            btn7.IsEnabled = encender;
            btn8.IsEnabled = encender;
            btn9.IsEnabled = encender;
            btnDedcimal.IsEnabled = encender;
            btnC.IsEnabled = encender;
            btn_zatiketa.IsEnabled = encender;
            btn_kenketa.IsEnabled = encender;
            btn_biderketa.IsEnabled = encender;
            btn_gehiketa.IsEnabled = encender;
            btn_berdin.IsEnabled = encender;
            btn_porciento.IsEnabled = encender;
            btnCE.IsEnabled = encender;

            if (encender)
                txtBox_erantzuna.Text = "0";
            else
                txtBox_erantzuna.Clear();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            individual += "1";
            txtBox_erantzuna.Text =individual.ToString();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            individual += "2";
            txtBox_erantzuna.Text = individual.ToString();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            individual += "3";
            txtBox_erantzuna.Text = individual.ToString();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            individual += "4";
            txtBox_erantzuna.Text = individual.ToString();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            individual += "5";
            txtBox_erantzuna.Text = individual.ToString();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            individual += "6";
            txtBox_erantzuna.Text = individual.ToString();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            individual += "7";
            txtBox_erantzuna.Text = individual.ToString();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            individual += "8";
            txtBox_erantzuna.Text = individual.ToString();
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            individual += "9";
            txtBox_erantzuna.Text = individual.ToString();
        }

        private void btnDedcimal_Click(object sender, RoutedEventArgs e)
        {
            if (!individual.Contains("."))
            {
                if (string.IsNullOrEmpty(individual))
                {
                    individual = "0.";
                }
                else
                {
                    individual += ".";
                }
                txtBox_erantzuna.Text = individual;
            }
        }


        private void btn_berdin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                operacion += individual;
                var dt = new DataTable();
                var resultado = dt.Compute(operacion, "");
                txtBox_erantzuna.Text = resultado.ToString();
                operacion = "";
                individual = "";
            }
            catch (Exception ex)
            {
                txtBox_erantzuna.Text = ex.Message;
                operacion = "";
                individual = "";
            }
        }


        private void btn_zatiketa_Click(object sender, RoutedEventArgs e)
        {
            operacion += individual +"/";
            individual = "";
        }

        private void btn_kenketa_Click(object sender, RoutedEventArgs e)
        {
            operacion += individual + "-";
            individual = "";
        }

        private void btn_biderketa_Click(object sender, RoutedEventArgs e)
        {
            operacion += individual + "*";
            individual = "";
        }

        private void btn_gehiketa_Click(object sender, RoutedEventArgs e)
        {
            operacion += individual + "+";
            individual = "";
        }

        private void btn_porciento_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(individual, out double valor))
            {
                valor /= 100;
                individual = valor.ToString();
                txtBox_erantzuna.Text = individual;
            }
        }


        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            if (individual.Length == 0)
            {
                return;  // No hay nada que borrar
            }
            individual = individual.Substring(0, individual.Length - 1);
            txtBox_erantzuna.Text = individual.Length > 0 ? individual : "0";
        }


        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            individual = "";
            txtBox_erantzuna.Text = "0";
            operacion = "";
        }
    }
}