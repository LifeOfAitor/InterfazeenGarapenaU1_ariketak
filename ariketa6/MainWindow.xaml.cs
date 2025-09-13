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

namespace ariketa6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String message = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Limpiar_Click(object sender, RoutedEventArgs e)
        {
            _1.Clear();
            _2.Clear();
            _3.Clear();
        }
        private void evento (object sender, KeyEventArgs e)
        {
            if ((e.Key == Key.Enter) && (check_text()))
            {
                if (_1.Text.Length > 0)
                {
                    message = _1.Text;
                    _1.Clear();
                    _2.Text = message;
                }
                else if (_2.Text.Length > 0)
                {
                    message = _2.Text;
                    _2.Clear();
                    _3.Text = message;
                }
                else
                {
                    message = _3.Text;
                    _3.Clear();
                    _1.Text = message;
                }
                // Keyboard.ClearFocus();
            }
        }

        private bool check_text()
        {
            int count = 0;

            if (!string.IsNullOrEmpty(_1.Text)) count++;
            if (!string.IsNullOrEmpty(_2.Text)) count++;
            if (!string.IsNullOrEmpty(_3.Text)) count++;

            if (count != 1)
            {
                MessageBox.Show("Introduce texto en una sola fila");
                return false;
            }

            return true;
        }

    }
}