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

namespace ariketa9
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

        private void salir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn_del_all_Click(object sender, RoutedEventArgs e)
        {
            list_box_lista.Items.Clear();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(text_box_nuevo.Text))
            {
                list_box_lista.Items.Add(text_box_nuevo.Text.Trim());
                text_box_nuevo.Clear();
            }
            else
            {
                MessageBox.Show("Introduzca datos para poder añadirlos");
            }
        }

        private void text_box_lista_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (list_box_lista.SelectedItem != null)
            {
                text_box_seleccionado.Text = list_box_lista.SelectedItem.ToString();
            }
            
        }


        private void btn_del_Click(object sender, RoutedEventArgs e)
        {
            if (list_box_lista.SelectedItem != null)
            {
                list_box_lista.Items.Remove(list_box_lista.SelectedItem);
                text_box_seleccionado.Clear();
            }
            else
            {
                MessageBox.Show("Seleccione datos para poder eliminarlos");
            }
        }
    }
}