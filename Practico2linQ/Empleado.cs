using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2linQ
{
    internal class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public int Salario { get; set; }

        public int EmpresaId { get; set; }

        public Empleado() { }
        public Empleado(int id, string nombre, string cargo, int salario, int empresaId)
        {
            Id = id;
            Nombre = nombre;
            Cargo = cargo;
            Salario = salario;
            EmpresaId = empresaId;
        }

        public void getDatosEmpleado()
        {
            Console.WriteLine("Empleado {0} con Id {1}, con cargo {2}, con salario {3}", Nombre, Id, Cargo, Salario);
        }



    }
}
