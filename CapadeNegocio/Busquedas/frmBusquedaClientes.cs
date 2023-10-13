using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapadeNegocio.Busquedas
{
    public partial class frmBusquedaClientes : Form
    {
        static CapadeNegocio.Clases.Conexion x = new CapadeNegocio.Clases.Conexion();
        SqlConnection con = new SqlConnection();
        string sConexion;
        public frmBusquedaClientes()
        {
            InitializeComponent();
            con.ConnectionString = x.con();
        }
        public frmBusquedaClientes(string sConexion)
        {
            InitializeComponent();
            this.sConexion = sConexion;
            con.ConnectionString = x.con();
        }
        void cargardg()
        {
            string query = "select * from vClientes where Nombre LIKE '%" + txtFiltro.Text + "%'";
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            dgClientes.DataSource = dt;
            con.Close();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frmBusquedaClientes_Load(object sender, EventArgs e)
        {
            cargardg();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            cargardg();
        }
    }
}
