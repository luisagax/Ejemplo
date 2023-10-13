using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapadeUsuario
{
    public partial class frmMenu : Form
    {
        static CapadeNegocio.Clases.Conexion x = new CapadeNegocio.Clases.Conexion();
        string sConexion = x.con();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogos.frmEstados x = new Catalogos.frmEstados(sConexion);
            x.Show();
        }

        private void municipioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogos.frmMunicipio x = new Catalogos.frmMunicipio(sConexion);
            x.Show();
        }

        private void tsVentas_Click(object sender, EventArgs e)
        {
            Catalogos.frmVentas x = new Catalogos.frmVentas(sConexion);
            x.Show();
        }
    }
}
