using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using _7DataGrid.clases;

namespace _7DataGrid
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Persona> ocPersonas;
        public MainWindow()
        {
            InitializeComponent();
            LogicaNegocio.cargaPersonas();
            ocPersonas=LogicaNegocio.getPersonas();
            dgPersonas.ItemsSource = ocPersonas;
       
        }

        private void anadir_Click(object sender, RoutedEventArgs e)
        {
            ocPersonas.Add(new Persona("Carmen", "Carmen"));
        }

        private void borrar_Click(object sender, RoutedEventArgs e)
        {
            if(dgPersonas.SelectedItems.Count > 0)
            {
                var seleccionados=dgPersonas.SelectedItems.Cast<Persona>().ToList();
                foreach (Persona persona in seleccionados)
                {
                    ocPersonas.Remove(persona);
                }
            }
        }
    }
}
