using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapadeNegocio.Clases
{
    public class Municipio
    {
        static Conexion c = new Conexion();
        SqlConnection con = new SqlConnection(@"" + c.con());
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;
        string sConexion;

        public int id = 0;
        public string nombre = "";
        public int idEstado = 0;

        public Municipio()
        {
            comando.Connection = con;
        }
        public Municipio(string sConexion)
        {
            con.ConnectionString = sConexion;
            comando.Connection = con;
            this.sConexion = sConexion;
        }

        public string guardar()
        {
            string msj = "";
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "spMunicipios";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@op", 2);
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@idEstado", idEstado);
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
            comando.CommandText = "spMunicipios";
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
            comando.CommandText = "spMunicipios";
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
                    idEstado = (int)lector["idEstado"];
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
            Busquedas.frmBusquedaMunicipio x = new Busquedas.frmBusquedaMunicipio();
            x.ShowDialog();
            if(x.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                id = int.Parse(x.dgMunicipios.SelectedRows[0].Cells["id"].Value.ToString());
                nombre = x.dgMunicipios.SelectedRows[0].Cells["Nombre"].Value.ToString();
                idEstado = int.Parse(x.dgMunicipios.SelectedRows[0].Cells["idEstado"].Value.ToString());
            }
        }
    }
}

