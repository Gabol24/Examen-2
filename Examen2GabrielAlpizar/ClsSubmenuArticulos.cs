using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2GabrielAlpizar
{
    internal class ClsSubmenuArticulos
    {
        public static void SubmenuArticulos(ClsInventario inventario)
        {
            do
            {
                Console.WriteLine("--- Submenú de Artículos ---");
                Console.WriteLine("1. Agregar artículo");
                Console.WriteLine("2. Borrar artículo");
                Console.WriteLine("3. Consultar artículo");
                Console.WriteLine("4. Regresar al menú principal");
                Console.WriteLine("Digite una opción...");

                try
                {
                    string subInput = Console.ReadLine();
                    if (int.TryParse(subInput, out int submenuOp))
                    {
                        switch (submenuOp)
                        {
                            case 1:
                                inventario.AgregarArticulo();
                                break;
                            case 2:
                                Console.WriteLine("Ingrese el código del artículo que desea eliminar:");
                                if (int.TryParse(Console.ReadLine(), out int codigo))
                                {
                                    inventario.BorrarArticulo(codigo);
                                }
                                else
                                {
                                    Console.WriteLine("El código del artículo ingresado no es válido.");
                                }
                                break;
                            case 3:
                                Console.WriteLine("Ingrese el código del artículo a consultar:");
                                if (int.TryParse(Console.ReadLine(), out int codigoArticulo))
                                {
                                    inventario.ConsultarArticulo(codigoArticulo);
                                }
                                else
                                {
                                    Console.WriteLine("El código del artículo ingresado no es válido.");
                                }
                                break;
                            case 4:
                                Console.WriteLine("Volviendo al menú principal");
                                return;
                            default:
                                Console.WriteLine("Digite una opción válida");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("La opción no es correcta. Ingrese un número ");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($" *** Ha ocurrido la siguiente excepción: {ex.Message} ***");
                }
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }
    }
}
