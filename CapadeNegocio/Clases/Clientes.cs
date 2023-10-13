using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapadeNegocio.Clases
{
    public class Clientes
    {
        static Conexion c = new Conexion();
        SqlConnection con = new SqlConnection(@"" + c.con());
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;
        string sConexion;

        public int id = 0;
        public string nombre = "";
        public string apellidop = "";
        public string apellidom = "";
        public string RFC = "";
        public string telefono = "";
        public string correo = "";
        public int idDomicilio = 0;
        public int idRegimen = 0;

        public Clientes()
        {
            comando.Connection = con;
        }
        public Clientes(string sConexion)
        {
            con.ConnectionString = sConexion;
            comando.Connection = con;
            this.sConexion = sConexion;
        }
        public string obtener()
        {
            string msj = "";
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "spClientes";
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
            Busquedas.frmBusquedaClientes x = new Busquedas.frmBusquedaClientes(sConexion);
            x.ShowDialog();
            if (x.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                id = int.Parse(x.dgClientes.SelectedRows[0].Cells["id"].Value.ToString());
                nombre = x.dgClientes.SelectedRows[0].Cells["Nombre"].Value.ToString();
            }
        }
    }
}
