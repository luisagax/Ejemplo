using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapadeNegocio.Clases
{
    public class Estados
    {
        static Conexion c = new Conexion();
        SqlConnection con = new SqlConnection(@"" + c.con());
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;

        public int id = 0;
        public string nombre = "";

        public Estados()
        {
            comando.Connection = con;
        }
        public Estados(string sConexion)
        {
            con.ConnectionString = sConexion;
            comando.Connection = con;
        }

        public string guardar()
        {
            string msj = "";
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "spEstados";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@op", 2);
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            try
            {
                con.Open();
                comando.ExecuteNonQuery();
                msj = "Proceso exitoso, Estado guardado/actualizado correctamente";
            }
            catch (Exception e)
            {
                msj = "Proceso fallido, error al guardar/actualizar el Estado";
            }
            finally
            {
                con.Close();
            }
            return msj;
        }
        public string eliminar()
        {
            string msj = "";
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "spEstados";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@op", 3);
            comando.Parameters.AddWithValue("@id", id);

            try
            {
                con.Open();
                comando.ExecuteNonQuery();
                msj = "Proceso exitoso, Estado eliminado correctamente";
            }
            catch (Exception e)
            {
                msj = "Proceso fallido, error al eliminar el Estado";
            }
            finally
            {
                con.Close();
            }
            return msj;
        }
        public string obtener()
        {
            string msj = "";
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "spEstados";
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
        public void buscar()
        {
            CapadeNegocio.Busquedas.frmBusquedaEstados x = new Busquedas.frmBusquedaEstados(con.ConnectionString);
            x.ShowDialog();
            if(x.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                id = x.dsBusquedaEstados.Estado[x.estadoBindingSource.Position].id;
                nombre = x.dsBusquedaEstados.Estado[x.estadoBindingSource.Position].Nombre;
            }
        }
    }
}
