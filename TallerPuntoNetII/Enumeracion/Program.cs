using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracion
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Domingo es el día número {0}", (int)Semana.Domingo);
            Console.ReadKey();
        }

        public enum Semana { Lunes = 1, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo };
    }
}
