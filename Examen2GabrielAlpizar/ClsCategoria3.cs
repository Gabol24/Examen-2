using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2GabrielAlpizar
{
    internal class ClsCategoria3 : ClsCategoria
    {
        public override void Promocion()
        {
            Console.WriteLine("Todo a mitad de precio");
        }

   
        public override void Promocion(ClsArticulos articulo)
        {
            double descuento = articulo.GetPrecio() * 0.5;
            double precioConDescuento = articulo.GetPrecio() - descuento;
           
            articulo.SetPrecio(precioConDescuento);

            Console.WriteLine($"Descuento aplicado: ₡{descuento}");
            Console.WriteLine($"Nuevo precio con descuento: ₡{precioConDescuento}");
        }
    }
}
