using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    class Jet : IProducto
    {
        public bool imp()
        {
            return false;
        }

        public string nombre()
        {
            return "Jet";
        }

        public int precio()
        {
            return 700;
        }
    }
}
