using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2linQ
{
    internal class Persona
    {

        public int Edad { get; set; }
        public string Nombre { get; set; } 
        public string Ciudad { get; set;}

        public Persona()
        {

        }

        public Persona(int edad, string nombre, string ciudad)
        {
            Edad = edad;
            Nombre = nombre;
            Ciudad = ciudad;

        }



    }
}
