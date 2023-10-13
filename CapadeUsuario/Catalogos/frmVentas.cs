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
    }
}
