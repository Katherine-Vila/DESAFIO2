using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO__6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa realizado por  
            // Día: MARZO, 2025
            Console.WindowHeight = 100;
            Console.WindowWidth = 100;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.Title = "PROGRESION MATEMATICA";
            Console.WriteLine("\n\t*************************************");
            Console.WriteLine("\t*       Progresión Matemática       *");
            Console.WriteLine("\t*************************************");

            //PROCESO
            try//Inicia el bloque try para ejecutar el código principal. Si hay un error, como ingresar texto en vez de un número, el programa no se rompe
            {
                Console.Write("\n\tIngrese el valor de X: ");
                double x = double.Parse(Console.ReadLine());

                Console.Write("\tIngrese el valor de N:");
                int n = int.Parse(Console.ReadLine());

                if (n < 0)
                {
                    Console.WriteLine("\n\tError: El valor de N debe ser un entero positivo");
                }
                else
                {
                    double resultado = CalcularProgresion(x, n);

                    Console.WriteLine($"\n\tEl resultado de la progresión es: {Math.Round(resultado, 2)}");//Si N es válido, el programa llama a CalcularProgresion(x, n) y guarda el resultado Luego con la funcion matematica imprime el resultado redondeado a 2 decimales
                }
            }
            catch (Exception error)//En caso de que haya un error, el programa no se interrumpirá y en su lugar, mostrará el mensaje de error utilizando error.Message
            {
                Console.WriteLine(error.Message);
            }

            Console.WriteLine("\n\tPresione cualquier tecla para salir...");
            Console.ReadKey();

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

        static double CalcularProgresion(double x, int n)//en esta función estática se acepta dos parámetros: x, que representa el número base de la progresión (tipo double), y n, que indica el número de términos de la progresión (tipo int)
        {
            double suma = 1;
            double potencia = 1;

            for (int i = 1; i <= n; i++)//el bucle for recorre desde 1 hasta N 
            {
                potencia *= x;
                suma += potencia;
            }

            return suma;

        }               
    }
}
