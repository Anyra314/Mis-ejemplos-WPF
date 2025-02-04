using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DataGrid.clases
{
    internal class LogicaNegocio
    {
        static ObservableCollection<Persona> personas = new ObservableCollection<Persona>();
        static public void addPersona(Persona persona)
        {
            personas.Add(persona);
        }
        static public void removePersona(Persona persona)
        {
            personas.Remove(persona);
        }
        static public ObservableCollection<Persona> getPersonas()
        {
            return personas;
        }
        static public void cargaPersonas()
        {
            for (int i = 0; i < 10; i++)
            {
                personas.Add(new Persona("Nombre" + Convert.ToString(i), "Apellido" + Convert.ToString(i)));

            }  
        }
    }
}
