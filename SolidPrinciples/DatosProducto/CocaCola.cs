using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    class CocaCola : IProducto
    {
        public bool imp()
        {
            return true;
        }

        public string nombre()
        {
            return "Coca Cola";
        }

        public int precio()
        {
            return 800;
        }
    }
}
