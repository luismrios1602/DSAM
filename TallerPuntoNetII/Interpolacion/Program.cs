using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpolacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre, Apellido;
            int Edad;

            Console.Write("Ingrese el nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("Ingrese el apellido: ");
            Apellido = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            Edad = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nNombre: {Nombre} {Apellido}");
            Console.WriteLine("Edad: {0} ", Edad);

            Console.ReadKey();

        }
    }
}
