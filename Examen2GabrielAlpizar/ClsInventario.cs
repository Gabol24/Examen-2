using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2GabrielAlpizar
{
    internal class ClsInventario : ClsArticulos
    {
        private ClsArticulos[] articulos = new ClsArticulos[5];
        private int cantidadArticulos = 0;


        #region AgregarArticulo
        public void AgregarArticulo()
        {
            try
            {
                if (cantidadArticulos >= articulos.Length)
                {
                    Console.WriteLine("No se pueden ingresar más artículos. El inventario está lleno.");
                    return;
                }

                Console.WriteLine("Ingrese el código del artículo:");
                int codigo = int.Parse(Console.ReadLine());
               
                Console.WriteLine("Ingrese el nombre del artículo:");
                string nombre = Console.ReadLine();
    
                Console.WriteLine("Ingrese el precio del artículo:");
                double precio = double.Parse(Console.ReadLine());
               
                ClsArticulos nuevoArticulo = new ClsArticulos(codigo, nombre, precio);

                articulos[cantidadArticulos] = nuevoArticulo;
                cantidadArticulos++;

                Console.WriteLine("Artículo agregado correctamente.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Por favor, asegúrese de ingresar un número válido para el código y el precio del artículo.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: El número ingresado es demasiado grande para el código o el precio del artículo.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se produjo una excepción: {ex.Message}");
            }
        }
        #endregion


        #region BorrarArticulo
        public void BorrarArticulo(int codigo)
        {
            try
            {
                bool encontrado = false;

                for (int i = 0; i < cantidadArticulos; i++)
                {
                    if (articulos[i].GetCodigo() == codigo)
                    {
                        encontrado = true;
                        Console.WriteLine("Artículo encontrado:");
                        Console.WriteLine($"Código: {articulos[i].GetCodigo()}, Nombre: {articulos[i].GetNombre()}, Precio: {articulos[i].GetPrecio()}");

                        for (int j = i; j < cantidadArticulos; j++)
                        {
                            articulos[j] = articulos[j + 1];
                        }
                        cantidadArticulos--;
                        Console.WriteLine("Artículo eliminado correctamente.");
                        break;
                    }
                }
                if (!encontrado)
                {
                    Console.WriteLine("No se encontró ningún artículo con el código especificado.");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Por favor, ingrese un número válido para el código del artículo.");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error: Índice fuera de rango - {ex.Message}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Error: Referencia nula - {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se produjo una excepción: {ex.Message}");
            }
        }

        #endregion


        #region ConsultarArticulo

        public ClsArticulos ConsultarArticulo(int codigoArticulo)
        {
            try
            {
                if (cantidadArticulos == 0)
                {
                    Console.WriteLine("No hay artículos en el inventario para consultar.");
                    return null;
                }

                foreach (ClsArticulos articulo in articulos)
                {
                    if (articulo != null && articulo.GetCodigo() == codigoArticulo)
                    {
                        Console.WriteLine($"Detalles del artículo encontrado:");
                        Console.WriteLine($"Código: {articulo.GetCodigo()}");
                        Console.WriteLine($"Nombre: {articulo.GetNombre()}");
                        Console.WriteLine($"Precio: {articulo.GetPrecio()}");
                        return articulo;
                    }
                }
                Console.WriteLine("El artículo no fue encontrado en el inventario.");
                return null;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Por favor, asegúrese de ingresar un número válido para el código del artículo.");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se produjo una excepción: {ex.Message}");
                return null;
            }
        }
        #endregion


        #region ObtenerArticulos
        public List<ClsArticulos> ObtenerArticulos()
        {
            List<ClsArticulos> listaArticulos = new List<ClsArticulos>();

            for (int i = 0; i < cantidadArticulos; i++)
            {
                listaArticulos.Add(articulos[i]);
            }

            return listaArticulos;
        }
        #endregion
    }

}
