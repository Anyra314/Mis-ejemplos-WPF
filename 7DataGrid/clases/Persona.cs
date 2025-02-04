using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DataGrid.clases
{
    internal class Persona:INotifyPropertyChanged
    {
        private string _nombre, _apellido;

        public Persona(string nombre, string apellido)
        {
            _nombre = nombre;
            _apellido = apellido;
        }

        public string Nombre
        {
            get => _nombre;
            set
            {
                _nombre = value;
                PropertyChanged(this,new PropertyChangedEventArgs("Nombre"));
            }
        }
        public string Apellido { 
            get => _apellido;
            set
            {
                _apellido = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Apellido"));

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
