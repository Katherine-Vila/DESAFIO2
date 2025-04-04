using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO__4
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
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.Title = "Registro de Notas y Promedios de Alumnos";
            Console.WriteLine("\n\t************************************************");
            Console.WriteLine("\t*   Registro de Notas y Promedios de Alumnos   *");
            Console.WriteLine("\t************************************************");
            Console.Write("\n");

            //CALCULO
            Console.WriteLine("Ingrese la cantidad de alumnos:");
            int cantidadAlumnos = int.Parse(Console.ReadLine());

            string[] nombres = new string[cantidadAlumnos];//vector (string[]) para guardar los nombres de los alumnos

            double[,] notas = new double[cantidadAlumnos, 3];//matriz (double[,]) donde cada fila representa un alumno y las tres columnas representan sus tres notas

            double[] promedios = new double[cantidadAlumnos];//vector (double[]) para almacenar el promedio de cada alumno

            for (int i = 0; i < cantidadAlumnos; i++)//el bucle for recorre cada alumno (i = 0 a cantidadAlumnos - 1) y solicita y almacena el nombre en nombres[i]
            {
                Console.Write($"Ingrese el nombre del alumno {i + 1}:");
                nombres[i] = Console.ReadLine();

                Console.WriteLine($"Ingrese las 3 notas de {nombres[i]}:");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Nota {j + 1}: ");
                    notas[i, j] = double.Parse(Console.ReadLine());//la [i] representa el alumno y la [j] recorre las notas
                }

                promedios[i] = (notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3;
            }

            //SALIDA
            Console.WriteLine("\nListado de alumnos con sus notas y promedio:");
            for (int i = 0; i < cantidadAlumnos; i++)
            {
                Console.WriteLine($"Alumno: {nombres[i]}");
                Console.WriteLine($"Notas: {notas[i, 0]}, {notas[i, 1]}, {notas[i, 2]}");
                Console.WriteLine($"Promedio: {promedios[i]:F2}\n");//en el promedio usamos F2 ya que lo redondea a 2 decimales

                Console.Write("\n");
                Console.Write("\t");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("*********************************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\t*                                           * ");
                Console.WriteLine("\t*     Este programa fue diseñado por:       * ");
                Console.WriteLine("\t*                                           * ");
                Console.WriteLine("\t*         KATHERINE ALEXANDRA VILA          * ");
                Console.WriteLine("\t*                                           * ");
                Console.Write("\t");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("*********************************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\tPresione ENTER para terminar");
                Console.Write("\n");
                Console.ReadKey();
            }
        }
    }
}
