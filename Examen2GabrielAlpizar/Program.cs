// See https://aka.ms/new-console-template for more information
using Examen2GabrielAlpizar;

ClsInventario inventario = new ClsInventario();
ClsVendedor vendedor = new ClsVendedor(); 
ClsReporte reporte = new ClsReporte(inventario, vendedor);

ClsMenu menu = new ClsMenu(inventario, reporte, vendedor); 
menu.MenuPrincipal();