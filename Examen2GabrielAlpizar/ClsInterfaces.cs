using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2GabrielAlpizar
{
   
    public interface IAgentVendedor1
    {
        void VentasContado();
    }

    public interface IAgentVendedor2
    {
        string VentasCredito();
    }

    public class Interfaces 
    {
        
        public interface IVendedor1
        {
            void VentasContado();
        }

        
        public interface IVendedor2
        {
            string VentasCredito();
        }
    }

}
