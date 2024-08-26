using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

class Program2
{
    // Clase Usuario para almacenar los datos
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public decimal Saldo { get; set; }
        public string Tipo { get; set; } // 'c' para Cliente, 'e' para Empleado
    }

    static List<Usuario> usuarios = new List<Usuario>();
    const string filePath = "usuarios.json";

    static void Main(string[] args)
    {
        // Cargar datos desde el archivo JSON si existe
        CargarDatos();

        while (true)
        {
            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1. Agregar usuario");
            Console.WriteLine("2. Eliminar usuario");
            Console.WriteLine("3. Salir");
            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarUsuario();
                    break;
                case "2":
                    EliminarUsuario();
                    break;
                case "3":
                    GuardarDatos();
                    return;
                default:
                    Console.WriteLine("Opción no válida, intenta nuevamente.");
                    break;
            }
        }
    }

    static void AgregarUsuario()
    {
        int id = ObtenerId();
        while (UsuarioExiste(id))
        {
            Console.WriteLine("El ID ya existe. Intenta con otro ID.");
            id = ObtenerId();
        }

        string email = ObtenerEmail();

        decimal saldo = ObtenerSaldo();

        string tipo = ObtenerTipo();

        usuarios.Add(new Usuario { Id = id, Email = email, Saldo = saldo, Tipo = tipo });
        Console.WriteLine("Usuario agregado exitosamente.");
    }

    static void EliminarUsuario()
    {
        int id = ObtenerId();
        while (!UsuarioExiste(id))
        {
            Console.WriteLine("El ID no existe. Intenta con otro ID.");
            id = ObtenerId();
        }

        usuarios.RemoveAll(u => u.Id == id);
        Console.WriteLine("Usuario eliminado exitosamente.");
    }

    static int ObtenerId()
    {
        int id;
        Console.Write("Ingrese el ID (entero positivo): ");
        while (!int.TryParse(Console.ReadLine(), out id) || id <= 0)
        {
            Console.WriteLine("ID no válido. Debe ser un entero positivo.");
            Console.Write("Ingrese el ID (entero positivo): ");
        }
        return id;
    }

    static string ObtenerEmail()
    {
        string email;
        Console.Write("Ingrese el Email: ");
        email = Console.ReadLine();
        while (!ValidarEmail(email))
        {
            Console.WriteLine("Email no válido. Ingrese un formato correcto.");
            Console.Write("Ingrese el Email: ");
            email = Console.ReadLine();
        }
        return email;
    }

    static decimal ObtenerSaldo()
    {
        decimal saldo;
        Console.Write("Ingrese el Saldo (decimal positivo): ");
        while (!decimal.TryParse(Console.ReadLine(), out saldo) || saldo < 0)
        {
            Console.WriteLine("Saldo no válido. Debe ser un decimal positivo.");
            Console.Write("Ingrese el Saldo (decimal positivo): ");
        }
        return saldo;
    }

    static string ObtenerTipo()
    {
        string tipo;
        Console.Write("Ingrese el tipo (c para Cliente, e para Empleado): ");
        tipo = Console.ReadLine().ToLower();
        while (tipo != "c" && tipo != "e")
        {
            Console.WriteLine("Tipo no válido. Debe ser 'c' para Cliente o 'e' para Empleado.");
            Console.Write("Ingrese el tipo (c para Cliente, e para Empleado): ");
            tipo = Console.ReadLine().ToLower();
        }
        return tipo;
    }

    static bool UsuarioExiste(int id)
    {
        return usuarios.Exists(u => u.Id == id);
    }

    static bool ValidarEmail(string email)
    {
        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, pattern);
    }

    static void CargarDatos()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            usuarios = JsonConvert.DeserializeObject<List<Usuario>>(json) ?? new List<Usuario>();
        }
    }

    static void GuardarDatos()
    {
        string json = JsonConvert.SerializeObject(usuarios, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }
}
