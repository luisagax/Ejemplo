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
    public partial class frmBusquedaVentas : Form
    {
        string sConexion;
        public frmBusquedaVentas()
        {
            InitializeComponent();
        }
        public frmBusquedaVentas(string sConexion)
        {
            InitializeComponent();
            this.sConexion = sConexion;
            this.vVentasTableAdapter.Connection.ConnectionString = sConexion;
            this.vVentaDetTableAdapter.Connection.ConnectionString = sConexion;
        }
        private void cargardetalles(int id)
        {
            this.vVentaDetTableAdapter.Fill(this.dsVentaDet.vVentaDet, id);
        }
        private void frmBusquedaVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsVentas.vVentas' Puede moverla o quitarla según sea necesario.
            this.vVentasTableAdapter.Fill(this.dsVentas.vVentas);

        }

        private void dgVentas_SelectionChanged(object sender, EventArgs e)
        {
            cargardetalles(dsVentas.vVentas[vVentasBindingSource.Position].Folio);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
