using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Practico2linQ
{
    internal class ControlEmpresasEmpleados
    {
        public List<Empresa> ListaEmpresas;
        public List<Empleado> ListaEmpleados;

        public ControlEmpresasEmpleados()
        {
            ListaEmpresas = new List<Empresa>();
            ListaEmpleados = new List<Empleado>();

            ListaEmpresas.Add(new Empresa { Id = 1, Nombre = "IAIpha" });
            ListaEmpresas.Add(new Empresa { Id = 2, Nombre = "UdeLarm" });
            ListaEmpresas.Add(new Empresa { Id = 3, Nombre = "SpaceZ" });

            ListaEmpleados.Add(new Empleado { Id = 1, Nombre = "Gonzalo", Cargo = "CEO", EmpresaId = 1, Salario = 3000 });
            ListaEmpleados.Add(new Empleado { Id = 2, Nombre = "JuanC", Cargo = "Desarrollador", EmpresaId = 1, Salario = 2000 });
            ListaEmpleados.Add(new Empleado { Id = 3, Nombre = "JuanR", Cargo = "Desarrollador", EmpresaId = 1, Salario = 2000 });
            ListaEmpleados.Add(new Empleado { Id = 4, Nombre = "Daniel", Cargo = "Desarrollador", EmpresaId = 1, Salario = 2000 });
            ListaEmpleados.Add(new Empleado { Id = 5, Nombre = "Gonzalo", Cargo = "CEO", EmpresaId = 2, Salario = 2000 });
            ListaEmpleados.Add(new Empleado { Id = 6, Nombre = "Leonardo", Cargo = "CEO", EmpresaId = 1, Salario = 3000 });
            ListaEmpleados.Add(new Empleado { Id = 1, Nombre = "Gonzalo", Cargo = "CEO", EmpresaId = 3, Salario = 3000 });

        }

        public void getCeo(string cargo)
        {
            ListaEmpleados.Where(x => x.Cargo == cargo).ToList().ForEach(x => x.getDatosEmpleado());

        }

        public void getEmpleadosOrdenados()
        {
            ListaEmpleados.OrderBy(x => x.Nombre).ToList().ForEach(x => x.getDatosEmpleado());
        }

        public void getEmpleadosOrdenadosSalario()
        {
            ListaEmpleados.OrderBy(x => x.Salario).ToList().ForEach(x => x.getDatosEmpleado());
        }

        public void getEmpleadosEmpresa(int idEmpresa)
        {
            ListaEmpleados.Where(x => x.EmpresaId == idEmpresa).ToList().ForEach(x => x.getDatosEmpleado());
        }

        public void promedioSalario()
        {
            var promedio = ListaEmpleados
            .GroupBy(e => e.EmpresaId)
            .Select(g => new
            {
                empresa = g.Key,
                PromedioSalario = g.Average(e => e.Salario)
            })
            .ToList();

            foreach (var p in promedio)
            {
                switch (p.empresa)
                {
                    case 1:
                        Console.WriteLine($"Empresa IAlpha - Promedio de salario: {p.PromedioSalario}");
                        break;
                    case 2:
                        Console.WriteLine($"Empresa UdeLaR - Promedio de salario: {p.PromedioSalario}");
                        break;
                    case 3:
                        Console.WriteLine($"Empresa SpaceZ - Promedio de salario: {p.PromedioSalario}");
                        break;
                }
            }
        }
    }
}
