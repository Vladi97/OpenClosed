using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    class Hamburguesa : IProducto
    {
        public bool imp()
        {
            return false;
        }

        public string nombre()
        {
            return "Hamburguesa";
        }

        public int precio()
        {
            return 2000;
        }
    }
}
