using System;
using System.Collections;
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

namespace _1PrimeraAplicacion
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

        private void btnAdd_Click(object sender, RoutedEventArgs e) //evento
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstName.Items.Contains(txtName.Text))//si no es nulo o un espacio y no está ya en la lista
            {
                lstName.Items.Add(txtName.Text);//lo agregamos
                txtName.Clear();//limpiamos el texto del txtName para poder escribir otra vez
            }
        }
    }
}
