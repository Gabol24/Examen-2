using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2GabrielAlpizar
{
    internal class ClsReporte
    {
        private readonly ClsInventario _inventario;
        private readonly ClsVendedor _vendedor;

        // Constructor que recibe ClsInventario y ClsVendedor como parámetros
        public ClsReporte(ClsInventario inventario, ClsVendedor vendedor)
        {
            _inventario = inventario;
            _vendedor = vendedor; // Inicializa el campo _vendedor con el objeto proporcionado en el constructor
        }


        #region Facturacion
        public void Facturacion()
        {
            try
            {
                Console.WriteLine("Ingrese el código del artículo:");
                int codigoArticulo;
                if (!int.TryParse(Console.ReadLine(), out codigoArticulo))
                {
                    Console.WriteLine("Error: Ingrese un número válido para el código del artículo.");
                    return;
                }

                ClsArticulos articulo = _inventario.ConsultarArticulo(codigoArticulo);

                if (articulo != null)
                {
                    ClsCategoria categoria = SeleccionarCategoria();

                    if (categoria != null)
                    {
                        categoria.Promocion(articulo);

                        Console.WriteLine("Vendedores disponibles:");
                        foreach (var kvp in _vendedor.ListadoVendedores())
                        {
                            Console.WriteLine($"Código: {kvp.Key}, Nombre: {kvp.Value}");
                        }

                        Console.WriteLine("Ingrese el código del vendedor:");
                        int codigoVendedor;
                        if (!int.TryParse(Console.ReadLine(), out codigoVendedor))
                        {
                            Console.WriteLine("Error: Ingrese un número válido para el código del vendedor.");
                            return;
                        }

                        string nombreVendedor = _vendedor.BuscarVendedor(codigoVendedor);
                        if (nombreVendedor != null)
                        {
                            Console.WriteLine($"El vendedor {nombreVendedor} ha sido identificado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("El vendedor no fue encontrado.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("El artículo no fue encontrado en el inventario.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se produjo una excepción: {ex.Message}");
            }
        }
        #endregion


        #region SeleccionarCategoria
        private static ClsCategoria SeleccionarCategoria()
        {
            Console.WriteLine("--- Selección de Categoría ---");
            Console.WriteLine("1. Categoria 1");
            Console.WriteLine("2. Categoria 2");
            Console.WriteLine("3. Categoria 3");
            Console.WriteLine("Digite una opción...");

            try
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            return new ClsCategoria1();
                        case 2:
                            return new ClsCategoria2();
                        case 3:
                            return new ClsCategoria3();
                        default:
                            Console.WriteLine("Digite una opción válida");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("La opción no es correcta. Ingrese un número.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se produjo la siguiente excepción: {ex.Message}");
            }

            return null;
        }
        #endregion
    }
}