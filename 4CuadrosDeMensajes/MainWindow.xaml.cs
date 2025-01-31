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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _4CuadrosDeMensajes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            while (true) //para un bucle eterno hasta que elige la opción que queremos, en este caso se rompe eligiendo "No"
            {
                MessageBoxResult result = MessageBox.Show("Sí o No", "Elige", MessageBoxButton.YesNo, MessageBoxImage.Question); //para guardar el resultado que haya seleccionado
                if (result == MessageBoxResult.Yes)
                {
                    result = MessageBox.Show("Sí o No", "Elige", MessageBoxButton.YesNo, MessageBoxImage.Question);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
