using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2GabrielAlpizar
{
    internal abstract class ClsCategoria
    {
        public static List<ClsCategoria> categorias = new List<ClsCategoria>();

        public abstract void Promocion(ClsArticulos articulo);


        public abstract void Promocion(); 



        public static void AgregarCategoria(ClsCategoria categoria)
        {
            categorias.Add(categoria);
        }


        public static void ListadoCategorias()
        {
            foreach (var categoria in categorias)
            {
                Console.WriteLine(categoria.GetType().Name);
            }
        }


        public static bool CategoriaExiste(ClsCategoria categoria)
        {
            return categorias.Contains(categoria);
        }
    }
}
