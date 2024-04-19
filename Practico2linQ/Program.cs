using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2linQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>
        {
            new Persona(50, "Juan", "Lima"),
            new Persona(31, "Maria", "Bogota"),
            new Persona(35, "Pedro", "Madrid"),
            new Persona(40, "Ana", "Lima"),
            new Persona(40, "Jose", "Buenos Aires")
        };

            //Ej 1

            personas.OrderBy(p => p.Nombre).ToList()
                          .Where(p => p.Edad > 30 && p.Ciudad == "Lima")
                          .ToList()
                          .ForEach(p => Console.WriteLine(p.Nombre));
            Console.ReadKey();

            //Ej 2

             personas.Where(p => p.Edad >= 25 && p.Edad <= 35)
                  .ToList()
                  .OrderBy(p => p.Nombre)
                  .ToList()
                  .ForEach(p => Console.WriteLine(p.Nombre));
            Console.ReadKey();

            ControlEmpresasEmpleados prueba1 = new ControlEmpresasEmpleados();

            prueba1.getCeo("CEO");
            Console.ReadKey();

            prueba1.getEmpleadosOrdenados();
            Console.ReadKey();


            List<int> valores = new List<int>() { 1, 32, 22, 13, 98, 8, 7, 4, 16 };

            for (var i = 0; i < valores.Count - 1; i++)
            {
                if (valores[i] > valores[i + 1])
                {
                    var temp = valores[i];
                    valores[i] = valores[i + 1];
                    valores[i + 1] = temp;

                    i = -1;
                }
            }

            foreach (var valorOrdenado in valores)
            {
                Console.WriteLine(valorOrdenado);
            }
            Console.ReadKey();

            //EJ 3-1
            valores.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.ReadKey();


            //EJ 4-id 

            Console.WriteLine(valores.Sum());
            Console.ReadKey();

            Console.WriteLine(valores.Where(v => v % 2 == 0).ToList().Sum());
            Console.ReadKey();


            //EJ 4-2



            //EJ 5-1



            //EJ 5-2

            List<int> valores2 = new List<int>() { 1, 5, 6, 32, 22, 13, 98, 8, 7, 4, 16 };

            int sumaTotalValoresMayoresAOCHO = valores2.Where(v => v > 8 && v % 2 == 0).Sum();
            int sumaTotalValoresMenoresAOCHO = valores2.Where(v => v < 8 && v % 2 == 0).Sum();

            Console.WriteLine(sumaTotalValoresMayoresAOCHO);
            Console.WriteLine(sumaTotalValoresMenoresAOCHO);


            //Ej 6-2


            Console.WriteLine("Coloque una letra de la A a la F");
            string letra = Console.ReadLine();

            string[] letras = { "a", "b", "c", "d", "e", "f" };

            for (int i = 0; i < letras.Length; i++)
            {
                if (letras[i] == "f")
                {
                    Console.WriteLine("no hay mas letras");
                    break;
                }
                else if (letras[i] == letra)
                {
                    Console.WriteLine($"La letra siguiente del abecedario es {letras[i + 1]}");
                    break;
                }
            }
            Console.ReadKey();
        }

        }
}
