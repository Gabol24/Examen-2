using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2GabrielAlpizar
{

    internal class ClsMenu
    {
        public static char opcion;
        private readonly ClsInventario _inventario;
        private readonly ClsReporte _reporte;
        private readonly ClsVendedor _vendedor;

        public ClsMenu(ClsInventario inventario, ClsReporte reporte, ClsVendedor vendedor)
        {
            _inventario = inventario;
            _reporte = reporte;
            _vendedor = vendedor; 
        }

        #region MenuPrincipal

        public void MenuPrincipal()
        {
            do
            {
                Console.WriteLine("**** Bienvenido *****");
                Console.WriteLine("--- Menú Principal ---");
                Console.WriteLine("A. Articulos");
                Console.WriteLine("B. Facturación");
                Console.WriteLine("C. Reporte");
                Console.WriteLine("D. Salir");
                Console.WriteLine("Digite una opción...");

                try
                {
                    string input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("No ha ingresado ninguna opción. Por favor, ingrese una letra.");
                        
                    }
                    else if (char.TryParse(input, out opcion))
                    {
                        switch (char.ToUpper(opcion))
                        {
                            case 'A': ClsSubmenuArticulos.SubmenuArticulos(_inventario); break;
                            case 'B':
                                _reporte.Facturacion(); 
                                break;
                            case 'C': MostrarReporte(); break;
                            case 'D': Console.WriteLine(" *** Saliendo del programa ***"); return;
                            default: Console.WriteLine("*** Opción no válida. Por favor, ingrese una letra válida. ***"); break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("*** La opción ingresada no es válida. Por favor, ingrese una letra. ***");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($" *** Ha ocurrido la siguiente excepción: {ex.Message} ***");
                }
                Console.WriteLine("*** Presione cualquier tecla para poder continuar... ***");
                Console.ReadKey();
                Console.Clear();
            } while (char.ToUpper(opcion) != 'D');
            
        }
        #endregion


        #region MostrarReporte
        public void MostrarReporte()
        {
            Console.WriteLine("----- Información de Vendedores -----");
            MostrarVendedores();
            MostrarArticulos();
            Console.WriteLine();
        }
        #endregion


        #region MostrarVendedores
        public void MostrarVendedores()
        {
            var vendedores = _vendedor.ListadoVendedores();
            foreach (var kvp in vendedores)
            {
                Console.WriteLine($"Código: {kvp.Key}, Nombre: {kvp.Value}");
            }
        }
        #endregion


        #region MostrarArticulos
        public void MostrarArticulos()
        {
            List<ClsArticulos> articulos = _inventario.ObtenerArticulos();

            if (articulos.Count == 0)
            {
                Console.WriteLine("*** No hay artículos en el inventario para mostrar. ***");
                return;
            }

            Console.WriteLine("----- Listado de los Artículos ingresados: -----");
            foreach (ClsArticulos articulo in articulos)
            {
                Console.WriteLine($"Código: {articulo.GetCodigo()}");
                Console.WriteLine($"Nombre: {articulo.GetNombre()}");
                Console.WriteLine($"Precio: {articulo.GetPrecio()}");
                Console.WriteLine();
            }
        }
        #endregion

    }

}

