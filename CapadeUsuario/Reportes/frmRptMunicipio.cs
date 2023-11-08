using CapadeNegocio.Clases;
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

namespace CapadeUsuario.Reportes
{
    public partial class frmRptMunicipio : Form
    {
        SqlDataReader lector;
        static CapadeNegocio.Clases.Conexion x = new CapadeNegocio.Clases.Conexion();
        SqlConnection con = new SqlConnection(x.con());
        string sConexion = x.con();
        public frmRptMunicipio()
        {
            InitializeComponent();
        }
        public frmRptMunicipio(string sConexion)
        {
            InitializeComponent();
            this.sConexion = sConexion;
            cargarestados();
        }
        private void frmRptMunicipio_Load(object sender, EventArgs e)
        {

            this.rptVMunicipio.RefreshReport();
        }
        void rep()
        {

        }
        void cargarestados()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Estado", sConexion);
            da.Fill(dt);
            cbFiltroEstado.DisplayMember = "Nombre";
            cbFiltroEstado.ValueMember = "id";
            cbFiltroEstado.DataSource = dt;
        }
    }
}
