using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapadeNegocio.Clases
{
    public class Productos
    {
        static Conexion c = new Conexion();
        SqlConnection con = new SqlConnection(@"" + c.con());
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;
        string sConexion;

        public int id = 0;
        public string nombre = "";
        public decimal costo = 0;

        public Productos()
        {
            comando.Connection = con;
        }
        public Productos(string sConexion)
        {
            con.ConnectionString = sConexion;
            comando.Connection = con;
            this.sConexion = sConexion;
        }
        public string obtener()
        {
            string msj = "";
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "spProductos";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@op", 1);
            comando.Parameters.AddWithValue("@id", id);
            try
            {
                con.Open();
                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    nombre = lector["Nombre"].ToString();
                    costo = (decimal)lector["Costo"];
                }
                msj = "listo";
            }
            catch (Exception e)
            {
                msj = "Error";
            }
            finally
            {
                con.Close();
            }
            return msj;
        }
        //Prueba cambios
        public void buscar()
        {
            Busquedas.frmBusquedaProducto x = new Busquedas.frmBusquedaProducto(sConexion);
            x.ShowDialog();
            if (x.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                id = int.Parse(x.dgProductos.SelectedRows[0].Cells["id"].Value.ToString());
                nombre = x.dgProductos.SelectedRows[0].Cells["Nombre"].Value.ToString();
                costo = decimal.Parse(x.dgProductos.SelectedRows[0].Cells["Costo"].Value.ToString());
            }
        }
    }
}
