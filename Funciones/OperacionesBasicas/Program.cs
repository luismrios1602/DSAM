using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesBasicas
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Ingrese el primer número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(num1+" + "+num2+" = "+Sumar(num1, num2));
            Console.WriteLine(num1+" - "+num2+" = "+Restar(num1, num2));
            Console.WriteLine(num1+" x "+num2+" = "+Multiplicar(num1, num2));
            Console.WriteLine(num1+" / "+num2+" = "+Dividir(num1, num2));

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        public static int Sumar(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }

        public static int Restar(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }

        public static int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }

        public static float Dividir(int num1, int num2)
        {
            float resultado = num1 / num2;
            return resultado;
            
        }
    }
}
