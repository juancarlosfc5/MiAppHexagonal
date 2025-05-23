using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using MiAppHexagonal.Application.Services;
using MiAppHexagonal.Domain.Factory;

namespace MiAppHexagonal.Application.UI.Clientes;
public class UICliente
{
    private readonly ClienteService clienteService;
    private readonly IDbFactory _factory;
    //var servicio = new ClienteService(factory.CrearClienteRepository());

    public UICliente(IDbFactory factory)
    {
        _factory = factory;
        clienteService = new ClienteService(factory.CrearClienteRepository());

    }

    public void MenuCliente(){
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--- MENÚ CLIENTES ---");
            Console.WriteLine("1. Mostrar todos");
            Console.WriteLine("2. Crear nuevo");
            Console.WriteLine("3. Actualizar");
            Console.WriteLine("4. Eliminar");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");
            var opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Clientes registrados.\n");
                    clienteService.MostrarCliente();
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Crear nuevo cliente.");
                    Console.Write("Ingrese nombre del cliente: ");
                    clienteService.CrearCliente(Console.ReadLine()!);
                    Console.WriteLine("\nCliente creado.");
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Actualizar cliente.");
                    Console.Write("Ingrese ID del cliente a actualizar: ");
                    int idActualizar = int.Parse(Console.ReadLine()!);
                    Console.Write("Nuevo nombre: ");
                    string nuevoNombre = Console.ReadLine()!;
                    clienteService.ActualizarCliente(idActualizar, nuevoNombre);
                    Console.WriteLine("\nCliente actualizado.");
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Eliminar cliente.");
                    Console.Write("Ingrese ID del cliente a eliminar: ");
                    int idEliminar = int.Parse(Console.ReadLine()!);
                    clienteService.EliminarCliente(idEliminar);
                    Console.WriteLine("\nCliente eliminado.");
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("❌ Opción inválida.");
                    Console.WriteLine("Presione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
    }
}