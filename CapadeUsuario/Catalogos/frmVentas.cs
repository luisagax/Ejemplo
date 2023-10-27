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

namespace CapadeUsuario.Catalogos
{
    public partial class frmVentas : Form
    {
        static Conexion c = new Conexion();
        SqlConnection con = new SqlConnection(@"" + c.con());
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;
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
        void cargarconsecutivo()
        {
            SqlCommand comando = new SqlCommand("select isnull(max(Folio),0)+1 as maxid from Venta", con);
            con.Open();
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                txtFolio.Text = lector["maxid"].ToString();
            }
            con.Close();
        }
        int cargarconsecutivodet()
        {
            int iddet = 0;
            SqlCommand comando = new SqlCommand("select isnull(max(id),0)+1 as maxid from VentaDet", con);
            con.Open();
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                iddet = int.Parse(lector["maxid"].ToString());
            }
            con.Close();
            return iddet;
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            CapadeNegocio.Clases.Clientes x = new CapadeNegocio.Clases.Clientes(sConexion);
            x.buscar();
            txtIdCliente.Text = x.id.ToString();
            txtNombreCliente.Text = x.nombre;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            CapadeNegocio.Clases.Productos x = new CapadeNegocio.Clases.Productos(sConexion);
            x.buscar();
            txtIdProducto.Text = x.id.ToString();
            txtNombreProducto.Text = x.nombre;
            txtPrecio.Text = x.costo.ToString();
        }
        void bclientes()
        {
            CapadeNegocio.Clases.Clientes x = new CapadeNegocio.Clases.Clientes(sConexion);
            x.id = int.Parse(txtIdCliente.Text);
            x.obtener();
            txtNombreCliente.Text = x.nombre;
        }
        void bproductos()
        {
            CapadeNegocio.Clases.Productos x = new CapadeNegocio.Clases.Productos(sConexion);
            x.id = int.Parse(txtIdProducto.Text);
            x.obtener();
            txtNombreProducto.Text = x.nombre;
            txtPrecio.Text = x.costo.ToString();
        }

        private void txtIdProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bproductos();
            }
        }

        private void txtIdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                bclientes();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int u;
            string s = dsVentaDet.spVentaDet.Compute("MAX(id)", "").ToString();
            if (s == "")
                u = cargarconsecutivodet();
            else
            {
                u = int.Parse(s);
                u++;
            }
            dsVentaDet.spVentaDetRow R;
            R = dsVentaDet.spVentaDet.NewspVentaDetRow();
            R.id = u;
            R.idVenta = int.Parse(txtFolio.Text);
            R.Precio = decimal.Parse(txtPrecio.Text);
            R.Cantidad = int.Parse(txtCantidad.Text);
            decimal total = (R.Precio * R.Cantidad);
            R.Total = total;
            R.idProducto = int.Parse(txtIdProducto.Text);
            R.Nombre = txtNombreProducto.Text;
            dsVentaDet.spVentaDet.AddspVentaDetRow(R);
            CalculaTotal();
        }
        void CalculaTotal()
        {
            txtTotal.Text = dsVentaDet.spVentaDet.Compute("sum(Total)", "").ToString();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            cargarconsecutivo();
        }
        private void tsGuardar_Click(object sender, EventArgs e)
        {
            CapadeNegocio.Clases.Ventas x = new Ventas(sConexion);
            x.detalles = dsVentaDet.spVentaDet;
            x.Folio = int.Parse(txtFolio.Text);
            x.Fecha = dtpFecha.Value;
            x.Estatus = 1;
            x.idCliente = int.Parse(txtIdCliente.Text);
            x.Importe = decimal.Parse(txtTotal.Text);
            MessageBox.Show(x.guardar());
        }
    }
}
