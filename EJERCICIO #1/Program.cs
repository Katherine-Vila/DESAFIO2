using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa realizado por  
            // Día: MARZO, 2025
            Console.WindowHeight = 30;
            Console.WindowWidth = 80;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.Title = "PROGRAMA DE UN GESTOR DE RANGO NUMERICO";
            Console.Write("\n");
            

            //VARIABLE
            int opcion = 0;

            //CALCULO
            while (opcion != 3)//se tendra que interactuar hasta que elija la opción 3 para salir
            {
                Console.Clear();
                Console.WriteLine("***********************************************");
                Console.WriteLine("*   PROGRAMA DE UN GESTOR DE RANGO NUMÉRICO   *");
                Console.WriteLine("***********************************************");
                Console.Write("\n");

                Console.WriteLine("Ingrese el rango de números");
                Console.Write("Inicio: ");
                int inicio = int.Parse(Console.ReadLine());
                Console.Write("Fin:");
                int fin = int.Parse(Console.ReadLine());

                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Imprimir números divisibles por 3");
                Console.WriteLine("2. Imprimir números múltiplos de 7");
                Console.WriteLine("3. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)//si la condición es verdadera (true) se ejecutara el bloque de código dentro del el
                {
                    Console.WriteLine("\nNúmeros divisibles por 3:");
                    for (int i = inicio; i <= fin; i++)//el bucle for recorre cada número en el rango desde inicio hasta fin
                    {
                        if (i % 3 == 0)//si i % (NUMERO) == 0 para verificar qué números cumplen la condición
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("\nNúmeros múltiplos de 7:");
                    for (int i = inicio; i <= fin; i++)
                    {
                        if (i % 7 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("\nSaliendo del programa...");
                }
                else
                {
                    Console.WriteLine("\nOpción no válida. Por favor intente nuevamente");
                }

                if (opcion != 3)
                {
                    Console.WriteLine("\nPresione Enter para continuar...");
                    Console.ReadLine();
                }
                
                Console.Write("\n");
                Console.Write("\t");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("*********************************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\t*                                           * ");
                Console.WriteLine("\t*     Este programa fue diseñado por:       * ");
                Console.WriteLine("\t*                                           * ");
                Console.WriteLine("\t*         KATHERINE ALEXANDRA VILA          * ");
                Console.WriteLine("\t*                                           * ");
                Console.Write("\t");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("*********************************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\tPresione ENTER para terminar");
                Console.ReadKey();
            }
        }
    }
}
