using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Examen2GabrielAlpizar
{
    internal class ClsArticulos
    {
        protected int Codigo;
        protected string Nombre;
        protected double Precio;

        public ClsArticulos()
        {

        }

        public ClsArticulos(int codigo, string nombre, double precio)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Precio = precio;
        }

        public int GetCodigo()
        {
            return Codigo;
        }

        public void SetCodigo(int codigo)
        {
            Codigo = codigo;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }

        public double GetPrecio()
        {
            return Precio;
        }

        public void SetPrecio(double precio)
        {
            Precio = precio;
        }
    }
}
