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
    public partial class frmBusquedaVentasCod : Form
    {
        static CapadeNegocio.Clases.Conexion x = new CapadeNegocio.Clases.Conexion();
        SqlConnection con = new SqlConnection();
        string sConexion;
        public DataTable dtDet = new DataTable();

        public frmBusquedaVentasCod(string sConexion)
        {
            InitializeComponent();
            this.sConexion = sConexion;
            con.ConnectionString = sConexion;
        }
        void cargardg()
        {
            string query = "select * from vVentas";
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            dgVentasCod.DataSource = dt;
            con.Close();
        }
        void cargardgDet()
        {
            if (dgVentasCod.Rows.Count != 0)
            {
                string Folio = dgVentasCod.Rows[dgVentasCod.CurrentRow.Index].Cells["Folio"].Value.ToString();
                con.Close();               
                string query = "select * from vVentaDet where idVenta = " + Folio + "";
                DataTable dt = new DataTable();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                dgVentasDetCod.DataSource = dt;
                con.Close();
                dtDet = dt;
            }
        }
        private void frmBusquedaVentasCod_Load(object sender, EventArgs e)
        {
            cargardg();
        }

        private void dgVentasCod_SelectionChanged(object sender, EventArgs e)
        {
            cargardgDet();
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
