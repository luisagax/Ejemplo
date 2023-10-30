using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapadeNegocio.Clases
{
    public class Ventas
    {
        static Conexion c = new Conexion();
        SqlConnection con = new SqlConnection(@"" + c.con());
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;

        public int Folio;
        public decimal Importe;
        public DateTime Fecha;
        public byte Estatus;
        public string Status;
        public int idCliente;
        public string Cliente;
        public DataTable detalles;

        public Ventas()
        {
            comando.Connection = con;
        }
        public Ventas(string sConexion)
        {
            con.ConnectionString = sConexion;
            comando.Connection = con;
        }
        public string guardar()
        {
            string msj = "";
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "spVentas";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@op", 2);
            comando.Parameters.AddWithValue("@Folio", Folio);
            comando.Parameters.AddWithValue("@Importe", Importe);
            comando.Parameters.AddWithValue("@Fecha", Fecha);
            comando.Parameters.AddWithValue("@Estatus", Estatus);
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            SqlParameter vParam = comando.Parameters.AddWithValue("@detalles", detalles);
            vParam.SqlDbType = SqlDbType.Structured;
            vParam.TypeName = "dbo.VentaDetalle";
            try
            {
                con.Open();
                comando.ExecuteNonQuery();
                msj = "Venta exitosa";
            }
            catch (Exception e)
            {
                msj = "Errores en ventas";
            }
            finally
            {
                con.Close();
            }
            return msj;
        }
        public void buscar()
        {
            Busquedas.frmBusquedaVentas x = new Busquedas.frmBusquedaVentas(con.ConnectionString);
            x.ShowDialog();
            if(x.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                Folio = x.dsVentas.vVentas[x.vVentasBindingSource.Position].Folio;
                Importe = x.dsVentas.vVentas[x.vVentasBindingSource.Position].Importe;
                Fecha = x.dsVentas.vVentas[x.vVentasBindingSource.Position].Fecha;
                Status = x.dsVentas.vVentas[x.vVentasBindingSource.Position].EstatusVenta;
                idCliente = x.dsVentas.vVentas[x.vVentasBindingSource.Position].idCliente;
                Cliente = x.dsVentas.vVentas[x.vVentasBindingSource.Position].Cliente;
                detalles = x.dsVentaDet.vVentaDet;
            }
    }
    }
}
