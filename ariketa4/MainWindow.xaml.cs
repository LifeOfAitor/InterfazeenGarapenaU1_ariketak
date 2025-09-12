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

namespace ariketa4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String user = "Usuario";
        private String password = "admin";
        public MainWindow()
        {
            InitializeComponent();
            contrasena_textbox.PasswordChar = '*';
        }

        private void aceptar_btn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usuario_textbox.Text) || string.IsNullOrWhiteSpace(contrasena_textbox.Password.ToString()))
            {
                MessageBox.Show("Please insert credentials");
                return;
            }
            if (usuario_textbox.Text.Equals(user))
            {
                if (contrasena_textbox.Password.ToString().Equals(password))
                {
                    erantzuna.Content = "Wellcome back, " + user;
                }
            }
            else
            {
                MessageBox.Show("Incorrect user or password");
            }
        }

        private void limpiar_btn_Click(object sender, RoutedEventArgs e)
        {
            usuario_textbox.Text = "";
            contrasena_textbox.Password = "";
            erantzuna.Content = "";
        }

        private void salir_btn_Click(object sender, RoutedEventArgs e) => Close();
    }
}