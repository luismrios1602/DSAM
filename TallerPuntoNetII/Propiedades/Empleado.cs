using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    class Empleado
    {
        public string nombre;
        private int _edad;
        public string user;
        //private string _pass;

        
        public int Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                _edad = value;
            }
        }
        public string Pass{ get; set; }
    }
}
