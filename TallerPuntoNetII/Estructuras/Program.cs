using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro;
            carro.cantLlantas = 4;
            carro.cantSillas = 4;
            carro.tipoCarro = "Renault";
            Console.WriteLine("Cantidad de LLantas: " + carro.cantLlantas);
            Console.WriteLine("Cantidad de Sillas: " + carro.cantSillas);
            Console.WriteLine("Tipo de Carro: " + carro.tipoCarro);

            ModificarCarro(carro);
            Console.ReadKey();

            Console.WriteLine("<------------------------->");

            Console.WriteLine("Cantidad de LLantas: " + carro.cantLlantas);
            Console.WriteLine("Cantidad de Sillas: " + carro.cantSillas);
            Console.WriteLine("Tipo de Carro: " + carro.tipoCarro);

            Console.ReadKey();
           
        }
        
    
        public static void ModificarCarro(Carro carro)
        {
            carro.cantLlantas = 2;
            carro.cantSillas = 2;
            carro.tipoCarro = "4 fiesta";
        }

    }
}

