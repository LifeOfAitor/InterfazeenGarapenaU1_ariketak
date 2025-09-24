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

namespace ariketa10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            comfo_fila_uno.Items.Add("Imagen 1");
            comfo_fila_uno.Items.Add("Imagen 2");
            comfo_fila_uno.Items.Add("Imagen 3");
        }

        private void btn_salir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void comfo_fila_uno_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comfo_fila_uno.SelectedItem.ToString().Equals("Imagen 1")){
                img_1.Visibility = Visibility.Visible;
                img_2.Visibility = Visibility.Hidden;
                img_3.Visibility = Visibility.Hidden;
            }
            else if(comfo_fila_uno.SelectedItem.ToString().Equals("Imagen 2")){
                img_2.Visibility = Visibility.Visible;
                img_1.Visibility = Visibility.Hidden;
                img_3.Visibility = Visibility.Hidden;
            }
            else
            {
                img_3.Visibility = Visibility.Visible;
                img_1.Visibility = Visibility.Hidden;
                img_2.Visibility = Visibility.Hidden;
            }
           
        }

        private void combo_img_4_Checked(object sender, RoutedEventArgs e)
        {
            img_4.Visibility = Visibility.Visible;
        }
        private void combo_img_4_Unchecked(object sender, RoutedEventArgs e)
        {
            img_4.Visibility = Visibility.Hidden;
        }

        private void combo_img_5_Checked(object sender, RoutedEventArgs e)
        {
            img_5.Visibility = Visibility.Visible;
        }
        private void combo_img_5_Unchecked(object sender, RoutedEventArgs e)
        {
            img_5.Visibility = Visibility.Hidden;
        }

        private void combo_img_6_Checked(object sender, RoutedEventArgs e)
        {
            img_6.Visibility = Visibility.Visible;
        }   
        private void combo_img_6_Unchecked(object sender, RoutedEventArgs e)
        {
            img_6.Visibility = Visibility.Hidden;
        }   
    }
}