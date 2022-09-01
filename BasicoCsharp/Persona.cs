using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicoCsharp
{
    public class Persona
    {
        //Propiedades
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }

        public string NombresCompletos { get; set; }

        //Procedimiento
        public void AsignarNombresCompletos()
        {
            NombresCompletos = Nombres + "" + Apellidos;
        }

        //Funcion
        public string GetNombresCompletos()
        {
            return Nombres + " " + Apellidos;
        }

    }
}
