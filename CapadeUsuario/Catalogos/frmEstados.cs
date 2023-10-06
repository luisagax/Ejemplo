using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapadeNegocio;
using CapadeNegocio.Clases;

namespace CapadeUsuario.Catalogos
{
    public partial class frmEstados : Form
    {
        string sConexion;
        public frmEstados()
        {
            InitializeComponent();
        }
        public frmEstados(string sConexion)
        {
            InitializeComponent();
            this.sConexion = sConexion;
        }
        private void tsGuardar_Click(object sender, EventArgs e)
        {
            CapadeNegocio.Clases.Estados x = new CapadeNegocio.Clases.Estados(sConexion);
            x.id = int.Parse(txtID.Text);
            x.nombre = txtNombre.Text;
            MessageBox.Show(x.guardar());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CapadeNegocio.Clases.Estados x = new CapadeNegocio.Clases.Estados(sConexion);
            x.buscar();
            txtID.Text = x.id.ToString();
            txtNombre.Text = x.nombre;
        }

        private void frmEstados_Load(object sender, EventArgs e)
        {

        }
    }
}
