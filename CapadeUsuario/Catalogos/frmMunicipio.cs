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

namespace CapadeUsuario.Catalogos
{
    public partial class frmMunicipio : Form
    {
        SqlDataReader lector;
        static CapadeNegocio.Clases.Conexion x = new CapadeNegocio.Clases.Conexion();
        SqlConnection con = new SqlConnection(x.con());
        string sConexion = x.con();

        public frmMunicipio()
        {
            InitializeComponent();
            cargarestados();
        }

        private void frmMunicipio_Load(object sender, EventArgs e)
        {

        }
        void cargarestados()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Estado", sConexion);
            da.Fill(dt);
            cbEstado.DisplayMember = "Nombre";
            cbEstado.ValueMember = "id";
            cbEstado.DataSource = dt;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CapadeNegocio.Clases.Municipio x = new CapadeNegocio.Clases.Municipio();
            x.buscar();
        }
    }
}
