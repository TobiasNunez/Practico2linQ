using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2linQ
{
    internal class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public void getDataEmpresa()
        {
            Console.WriteLine("Empresa {0} con Id {1}", Nombre, Id);
        }
    }
}
