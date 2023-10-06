using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapadeNegocio.Clases
{
    public class Conexion
    {
        string conex = "";
        string ruta = @"C:\conex.txt";
        public string con()
        {
            using(StreamReader file = new StreamReader(ruta))
            {
                conex = @"" + file.ReadToEnd();
                file.Close();
            }
            return conex;
        }
    }
}
