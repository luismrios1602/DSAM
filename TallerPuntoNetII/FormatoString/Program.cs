using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatoString
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal temperatura = 31.5m;
            //String s = $"A las {0} la temperatura es de: {1}°C", DateTime.Now, temperatura;
            String s = String.Format("A las {0} la temperatura es de: {1}°C", DateTime.Now, temperatura);
            String h = String.Format("A las {0:t} la temperatura es de: {1}°C", DateTime.Now, temperatura);

            Console.WriteLine(s);
            Console.WriteLine(h);
            Console.ReadLine();

        }
    }
}
