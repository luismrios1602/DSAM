using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {

            int a=8;
            int? b, c=null;

            b = a;
            Console.WriteLine(b);
            b = c;
            Console.WriteLine(b?.GetType());

            Console.ReadKey();
        }
    }
}
