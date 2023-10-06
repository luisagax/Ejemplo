using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapadeNegocio.Busquedas
{
    public partial class frmBusquedaEstados : Form
    {
        public frmBusquedaEstados()
        {
            InitializeComponent();
        }
        public frmBusquedaEstados(string sConexion)
        {
            InitializeComponent();
            estadoTableAdapter.Connection.ConnectionString = sConexion;
        }
        private void frmBusquedaEstados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBusquedaEstados.Estado' Puede moverla o quitarla según sea necesario.
            Rellenar();
        }
        private void Rellenar()
        {
            this.estadoTableAdapter.Fill(this.dsBusquedaEstados.Estado, txtFiltro.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Rellenar();
        }
    }
}
