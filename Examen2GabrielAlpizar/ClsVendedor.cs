using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2GabrielAlpizar
{
    internal class ClsVendedor
    {
        private static Dictionary<int, string> vendedores = new Dictionary<int, string>();

        static ClsVendedor()
        {
            vendedores.Add(1, "Juan");
            vendedores.Add(2, "Carlos");
        }

        public Dictionary<int, string> ListadoVendedores()
        {
            return vendedores;
        }

        public string BuscarVendedor(int codigo)
        {
            if (vendedores.ContainsKey(codigo))
            {
                return vendedores[codigo];
            }
            else
            {
                return null;
            }
        }
    }
}
