using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;
using _9CrystalReports.bbdd;
using MySql.Data.MySqlClient;

namespace _9CrystalReports
{
    /// <summary>
    /// Lógica de interacción para WindowPaisesContinenteParametroDSN.xaml
    /// </summary>
    public partial class WindowPaisesContinenteParametroDSN : Window
    {
        DBConnect dBConnect=new DBConnect();
        public WindowPaisesContinenteParametroDSN()
        {
            InitializeComponent();
            crvPaises.Visibility = Visibility.Hidden;
            inicializaCbxContinente();
        }

        private void inicializaCbxContinente()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select distinct(Continent) from Country";
            MySqlDataReader mySqlDataReader=dBConnect.Select(cmd);
            while (mySqlDataReader.Read())
            {
                cbxContinente.Items.Add(mySqlDataReader.GetString(0));
            }
            mySqlDataReader.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            crvPaises.Visibility=Visibility.Visible;
            if (cbxContinente.SelectedIndex>=0)
            {
               
                //DataTable que guardara el resultado de la consulta
                DataTable dataTable = new DataTable();
                //Contruimos la sentencia
                MySqlCommand mySqlCommand = new MySqlCommand("select Name from Country where Continent=@CONTINENTE order by Name");
                mySqlCommand.Parameters.AddWithValue("CONTINENTE",cbxContinente.SelectedItem.ToString());
                dataTable = dBConnect.getDataTable(mySqlCommand);
                //crear el informe y pasar datos 
                CRPaisesMundo cRPaisesMundo = new CRPaisesMundo();
                cRPaisesMundo.SetDataSource(dataTable);
                //asignamos el informe anterior al visor 
                crvPaises.ViewerCore.ReportSource = cRPaisesMundo;
            }
            else
            {
                MessageBox.Show("Selecciona un continente","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
    }
}
