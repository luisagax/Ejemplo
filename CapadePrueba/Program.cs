using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapadeNegocio;


namespace CapadePrueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CapadeNegocio.Clases.Estados x = new CapadeNegocio.Clases.Estados();
            x.id = 2;
            x.obtener();
            Console.WriteLine(x.nombre);
            Console.ReadLine();
        }
    }
}
