using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapadeUsuario.Catalogos
{
    public partial class frmVentas : Form
    {
        string sConexion;
        public frmVentas()
        {
            InitializeComponent();
        }
        public frmVentas(string sConexion)
        {
            InitializeComponent();
            this.sConexion = sConexion;
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            CapadeNegocio.Clases.Clientes x = new CapadeNegocio.Clases.Clientes(sConexion);
            x.buscar();
            txtIdCliente.Text = x.id.ToString();
            txtNombreCliente.Text = x.nombre;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            CapadeNegocio.Clases.Productos x = new CapadeNegocio.Clases.Productos(sConexion);
            x.buscar();
            txtIdProducto.Text = x.id.ToString();
            txtNombreProducto.Text = x.nombre;
            txtPrecio.Text = x.costo.ToString();
        }
        void bclientes()
        {
            CapadeNegocio.Clases.Clientes x = new CapadeNegocio.Clases.Clientes(sConexion);
            x.id = int.Parse(txtIdCliente.Text);
            x.obtener();
            txtNombreCliente.Text = x.nombre;
        }
        void bproductos()
        {
            CapadeNegocio.Clases.Productos x = new CapadeNegocio.Clases.Productos(sConexion);
            x.id = int.Parse(txtIdProducto.Text);
            x.obtener();
            txtNombreProducto.Text = x.nombre;
            txtPrecio.Text = x.costo.ToString();
        }

        private void txtIdProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bproductos();
            }
        }

        private void txtIdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                bclientes();
            }
        }
    }
}
