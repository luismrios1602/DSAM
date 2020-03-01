using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Condicional
{
    class Nulleables
    {
        public int? num1, num2, sum;

        public int? sumar(int? num1, int? num2) {
            int? suma = num1 + num2;
            return suma;
        }



    }
}
