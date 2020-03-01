using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado emp = new Empleado();
            emp.nombre = "Juan";
            emp.Edad = 30;
            emp.user = "juan12";
            emp.Pass = "probando123";

            Console.WriteLine("Datos del Empleado: ");
            Console.WriteLine("Nombre: "+emp.nombre+
                "\n"+"Edad: "+emp.Edad+
                "\n"+"User: "+emp.user+
                "\n"+"Contraseña: "+emp.Pass);

            Console.ReadKey();
        }
    }
}
