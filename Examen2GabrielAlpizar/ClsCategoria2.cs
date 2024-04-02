using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2GabrielAlpizar
{
    internal class ClsCategoria2 : ClsCategoria
    {
        public override void Promocion(ClsArticulos articulo)
        {
            Console.WriteLine("*** Promoción: llevas dos por el precio de 1 ***");
            
        }

        public override void Promocion()
        {
            Console.WriteLine("*** Promoción: llevas dos por el precio de 1 ***");
        }
    }
}
