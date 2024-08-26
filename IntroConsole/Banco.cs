/*
using System;
using System.Collections.Generic;

class Program
{
    // Variables
    static int[] billetes = { 500, 200, 100, 50, 20 };
    static int[] monedas = { 10, 5, 1 };
    static List<int> retiros = new List<int>();

    static void Main()
    {
        int opcion;
        do
        {
            // menu opciones
            Console.Clear();
            Console.WriteLine("---------- Banco CDIS ----------");
            Console.WriteLine("1. Ingresar la cantidad de retiros hechos por los usuarios.");
            Console.WriteLine("2. Revisar la cantidad entregada de billetes y monedas.");
            Console.WriteLine("3. Salir del programa.");
            Console.Write("Ingresa la opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    IngresarRetiros();
                    break;
                case 2:
                    MostrarResumen();
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Esta opción no esta disponible. Intenta de nuevo.");
                    break;
            }

        } while (opcion != 3);
    }

    static void IngresarRetiros()
    {
        Console.Clear();
        Console.Write("¿Cuántos retiros se hicieron (máximo 10)? ");
        int cantidadRetiros = int.Parse(Console.ReadLine());

        if (cantidadRetiros > 0 && cantidadRetiros <= 10)
        {
            for (int i = 0; i < cantidadRetiros; i++)
            {
                Console.Write($"Ingresa la cantidad del retiro #{i + 1} (máximo 50,000): ");
                int cantidad = int.Parse(Console.ReadLine());

                if (cantidad > 0 && cantidad <= 50000)
                {
                    retiros.Add(cantidad);
                }
                else
                {
                    Console.WriteLine("Cantidad fuera del rango. Intenta de nuevo.");
                    i--;
                }
            }
        }
        else
        {
            Console.WriteLine("Cantidad de retiros fuera de rango. Intenta de nuevo");
        }

        Console.WriteLine("Presiona ‘enter’ para continuar …");
        Console.ReadLine();
    }

    static void MostrarResumen()
    {
        Console.Clear();

        for (int i = 0; i < retiros.Count; i++)
        {
            int cantidad = retiros[i];
            Console.WriteLine($"Retiro #{i + 1}: {cantidad} pesos");
            DesglosarCantidad(cantidad);
            Console.WriteLine();
        }

        Console.WriteLine("Presiona ‘enter’ para continuar …");
        Console.ReadLine();
    }

    static void DesglosarCantidad(int cantidad)
    {
        int restante = cantidad;
        int[] conteoBilletes = new int[billetes.Length];
        int[] conteoMonedas = new int[monedas.Length];

        // ciclo para contar los billetes
        for (int i = 0; i < billetes.Length; i++)
        {
            conteoBilletes[i] = restante / billetes[i];
            restante %= billetes[i];
        }

        // ciclo para contar las monedas
        for (int i = 0; i < monedas.Length; i++)
        {
            conteoMonedas[i] = restante / monedas[i];
            restante %= monedas[i];
        }

        // Mostrar resultado
        Console.WriteLine("Billetes:");
        for (int i = 0; i < billetes.Length; i++)
        {
            if (conteoBilletes[i] > 0)
            {
                Console.WriteLine($"{conteoBilletes[i]} billete(s) de {billetes[i]} pesos");
            }
        }

        Console.WriteLine("Monedas:");
        for (int i = 0; i < monedas.Length; i++)
        {
            if (conteoMonedas[i] > 0)
            {
                Console.WriteLine($"{conteoMonedas[i]} moneda(s) de {monedas[i]} peso(s)");
            }
        }
    }
}
*/

