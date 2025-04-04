using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa realizado por  
            // Día: MARZO, 2025
            Console.WindowHeight = 100;
            Console.WindowWidth = 100;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.Title = "Análisis de Alturas: Promedio y Distribución";
            Console.WriteLine("\n\t************************************************");
            Console.WriteLine("\t* Análisis de Alturas: Promedio y Distribución *");
            Console.WriteLine("\t************************************************");
            Console.Write("\n");

            //VARIABLES
            double[] alturas = new double[5];//este vector me almacena las 5 alturas (un array)
            double suma = 0;

            //CALCULO
            for (int i = 0; i < alturas.Length; i++)//este bucle for me permite repetir 5 veces el progrma
            {
                Console.Write($"Ingrese la altura de la persona {i + 1}: ");
                alturas[i] = double.Parse(Console.ReadLine());
                suma += alturas[i];
            }

            double promedio = suma / alturas.Length;//calculo para sacar promedio se divide la suma entre la cantidad de personas(alturas.length)

            int masAltas = 0, masBajas = 0;

            for (int i = 0; i < alturas.Length; i++)
            {
                if (alturas[i] > promedio)
                {
                    masAltas++;
                }
                else if (alturas[i] < promedio)
                {
                    masBajas++;
                }
            }

            //SALIDA DE DATOS
            Console.WriteLine("\nResultados:");
            Console.WriteLine($"Promedio de las alturas: {promedio:F2}");//usamos la funcion F2 ya que esta redondea a 2 decimales 
            Console.WriteLine($"Personas más altas que el promedio: {masAltas}");
            Console.WriteLine($"Personas más bajas que el promedio: {masBajas}");

            Console.Write("\n");
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t*                                           * ");
            Console.WriteLine("\t*     Este programa fue diseñado por:       * ");
            Console.WriteLine("\t*                                           * ");
            Console.WriteLine("\t*         KATHERINE ALEXANDRA VILA          * ");
            Console.WriteLine("\t*                                           * ");
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\tPresione ENTER para terminar");
            Console.ReadKey();
        }
    }
}
