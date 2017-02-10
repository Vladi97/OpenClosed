using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolidPrinciples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void agregar()
        {
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeof(IProducto).IsAssignableFrom(p))
                .Where(a => !a.FullName.Equals("SolidPrinciples.IProducto"));
            int total = 0;
            if (!(txtTotal.Text == ""))
            {
                total = int.Parse(txtTotal.Text);
            }
            foreach (var imp in types)
            {
                IProducto implementation = (IProducto)Activator.CreateInstance(imp);
                String datos = ("nombre: "+implementation.nombre() + " -- precio: " + implementation.precio()+ " -- Cantidad: "+txtCantidad.Text);
                if (implementation.nombre().Equals(cbProductos.Text))
                {
                    total += implementation.precio() * int.Parse(txtCantidad.Text);
                    lbProductos.Items.Add(datos);
                    txtTotal.Text = Convert.ToString(total);
                    return;
                }
            }
            Console.Error.WriteLine("Reader {0} was not found", cbProductos.Text);
        }

        private void cargarDatos()
        {
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeof(IProducto).IsAssignableFrom(p))
                .Where(a => !a.FullName.Equals("SolidPrinciples.IProducto"));

            foreach (var imp in types)
            {
                IProducto implementation = (IProducto)Activator.CreateInstance(imp);
                cbProductos.Items.Add(implementation.nombre());
            }
        }
    }
}
