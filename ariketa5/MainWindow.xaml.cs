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

namespace ariketa5
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

        private Boolean check_texto()
        {
            label_mensaje.Content = "";
            if (txtbox_texto.Text.Length == 0)
            {
                MessageBox.Show("Primero escribe un texto en la caja.");
                return false;
            }
            return true;
        }

        private void salir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn_csans_Click(object sender, RoutedEventArgs e)
        {
            label_mensaje.Content = "";
            if (check_texto())
            {
                if (txtbox_texto.FontFamily.Source != "Comic Sans MS")
                {
                    txtbox_texto.FontFamily = new FontFamily("Comic Sans MS");
                }
                else
                {
                    txtbox_texto.FontFamily = new FontFamily("Segoe UI");
                }
            }
        }

        private void btn_courier_Click(object sender, RoutedEventArgs e)
        {
            label_mensaje.Content = "";
            if (check_texto())
            {
                if (txtbox_texto.FontFamily.Source != "Courier")
                {
                    txtbox_texto.FontFamily = new FontFamily("Courier");
                }
                else
                {
                    txtbox_texto.FontFamily = new FontFamily("Segoe UI");
                }
            }
        }

        private void btn_negrita_Click(object sender, RoutedEventArgs e)
        {
            label_mensaje.Content = "";
            if (check_texto())
            {
                if (txtbox_texto.FontWeight == FontWeights.Bold)
                {
                    txtbox_texto.FontWeight = FontWeights.Normal;
                }
                else
                {
                    txtbox_texto.FontWeight = FontWeights.Bold;
                }   
            }

        }

        private void btn_cursiva_Click(object sender, RoutedEventArgs e)
        {
            label_mensaje.Content = "";
            if (check_texto())
            {
                if (txtbox_texto.FontStyle == FontStyles.Italic)
                {
                    txtbox_texto.FontStyle = FontStyles.Normal;
                }
                else
                {
                    txtbox_texto.FontStyle = FontStyles.Italic;
                }                
            }
        }

        private void btn_tachado_Click(object sender, RoutedEventArgs e)
        {
            label_mensaje.Content = "";
            if (check_texto())
            {
                if (txtbox_texto.TextDecorations != TextDecorations.Strikethrough)
                {
                    txtbox_texto.TextDecorations = TextDecorations.Strikethrough;
                }
                else
                {
                    txtbox_texto.TextDecorations = null;
                }
            }
        }

        private void btn_subrayado_Click(object sender, RoutedEventArgs e)
        {
            label_mensaje.Content = "";
            if (check_texto())
            {
                if (txtbox_texto.TextDecorations != TextDecorations.Underline)
                {
                    txtbox_texto.TextDecorations = TextDecorations.Underline;
                }
                else
                {
                    txtbox_texto.TextDecorations = null;
                }
            }
        }

        private void btn_grande_Click(object sender, RoutedEventArgs e)
        {
            label_mensaje.Content = "";
            if (check_texto())
            {
                txtbox_texto.FontSize += 2;
            }
        }

        private void btn_pequeño_Click(object sender, RoutedEventArgs e)
        {
            label_mensaje.Content = "";
            if (check_texto())
            {
                txtbox_texto.FontSize -= 2;
            }
        }

        private void btn_seleccionar_Click(object sender, RoutedEventArgs e)
        {
            label_mensaje.Content = "";
            if (check_texto())
            {
                string seleccionado = txtbox_texto.SelectedText;
                int longi = txtbox_texto.Text.Length;

                if (string.IsNullOrEmpty(seleccionado))
                {
                    label_mensaje.Content = "El texto tiene " + longi + " caracteres, pero no hay texto seleccionado.";
                }
                else
                {
                    label_mensaje.Content = "El texto tiene " + longi + " caracteres y el texto seleccionado es: " + seleccionado;
                }
            }
        }

    }
}