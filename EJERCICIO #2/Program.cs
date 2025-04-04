using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa realizado por  
            // Día: MARZO, 2025
            Console.WindowHeight = 65;
            Console.WindowWidth = 65;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.Title = "CALCULADORA";
            Console.WriteLine("\n\t*******************");
            Console.WriteLine("\t*   CALCULADORA   *");
            Console.WriteLine("\t*******************");
            
            //PROCESO
            for (int i = 0; ; i++)
            {
                Console.WriteLine("\nSelecciona una operación");
                Console.Write("\n");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Salir");
                Console.Write("\n");
                Console.Write("Opción:");

                string opcion = Console.ReadLine();

                if (opcion == "5")
                {
                    Console.WriteLine("Saliendo del programa...");
                    break;
                }

                Console.Write("Ingresa el primer número: ");
                double numero1;
                if (!double.TryParse(Console.ReadLine(), out numero1))
                {
                    Console.WriteLine("Entrada inválida. Inténtalo de nuevo.");
                    continue;
                }

                Console.Write("Ingresa el segundo número: ");
                double numero2;
                if (!double.TryParse(Console.ReadLine(), out numero2))
                {
                    Console.WriteLine("Entrada inválida. Inténtalo de nuevo.");
                    continue;
                }

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine($"El resultado de la suma es: {numero1 + numero2}");
                        break;
                    case "2":
                        Console.WriteLine($"El resultado de la resta es: {numero1 - numero2}");
                        break;
                    case "3":
                        Console.WriteLine($"El resultado de la multiplicación es: {numero1 * numero2}");
                        break;
                    case "4":
                        if (numero2 == 0)
                        {
                            Console.WriteLine("Error: No se puede dividir entre cero.");
                        }
                        else
                        {
                            Console.WriteLine($"El resultado de la división es: {numero1 / numero2}");
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                }

                Console.Write("\n");
                Console.Write("\t");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine("*********************************************");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t*                                           * ");
                Console.WriteLine("\t*     Este programa fue diseñado por:       * ");
                Console.WriteLine("\t*                                           * ");
                Console.WriteLine("\t*         KATHERINE ALEXANDRA VILA          * ");
                Console.WriteLine("\t*                                           * ");
                Console.Write("\t");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine("*********************************************");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\tPresione ENTER para terminar");
                Console.ReadKey();
            }
        }
    }
}
