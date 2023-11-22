using CapadeNegocio.Clases;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        int idEdo = 0;
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
            rep();
        }
        void rep()
        {
            if (idEdo == 0)
                idEdo = 1;
            else
                idEdo = int.Parse(cbFiltroEstado.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("spRMunicipio", sConexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Clear();
            da.SelectCommand.Parameters.Add("@idEstado", idEdo);
            da.Fill(dt);
            this.rptVMunicipio.LocalReport.DataSources.Clear();
            this.rptVMunicipio.LocalReport.ReportEmbeddedResource = "CapadeUsuario.Reportes.rptMunicipio.rdlc";
            ReportDataSource r = new ReportDataSource("dsRMunicipio", dt);
            this.rptVMunicipio.LocalReport.DataSources.Add(r);
            this.rptVMunicipio.RefreshReport();
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

        private void cbFiltroEstado_SelectedValueChanged(object sender, EventArgs e)
        {
           rep();
        }

        public void SavePDF(ReportViewer viewer, string savePath)

        {
            byte[] Bytes = viewer.LocalReport.Render(format: "PDF", deviceInfo: "");

            using (FileStream stream = new FileStream(savePath, FileMode.Create))
            {
                stream.Write(Bytes, 0, Bytes.Length);
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
           // SavePDF(rptVMunicipio, @"C:\PDF");
        }
    }
}
