using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO__3
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
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = "Calculadora de Promedio Numérico";
            Console.WriteLine("\n\t****************************************");
            Console.WriteLine("\t*   Calculadora de Promedio Numérico   *");
            Console.WriteLine("\t****************************************");
            Console.Write("\n");

            //CALCULO
            Console.WriteLine("¿Cuántos números deseas ingresar?");
            int cantidadNumeros = int.Parse(Console.ReadLine());

            double suma = 0;//esta variable se usa para acumular la suma de los números ingresados
            double[] numeros = new double[cantidadNumeros];//en este vector (array) de tipo double se almacenará cantidad-Numeros valores

            for (int i = 0; i < cantidadNumeros; i++)//se usa el bucle for para repetir proceso dependiendo las veces que lo solicitemos
            {
                Console.Write($"Ingresa el número {i + 1}: ");
                numeros[i] = double.Parse(Console.ReadLine());//se ingresa el numero y lo convierte en double y lo guardara en numeros[i]
                suma += numeros[i];//se sumara el numero ingresado a suma para calcular el promedio
            }

            double promedio = suma / cantidadNumeros;//se saca calculando la suma por cantidad-numeros

            Console.WriteLine("\nNúmeros ingresados:");
            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.WriteLine($"Número {i + 1}: {numeros[i]}");
            }

            //SALIDA DE DATOS
            Console.Write("\n");
            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Promedio: {promedio}");

            Console.Write("\n");
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\t*                                           * ");
            Console.WriteLine("\t*     Este programa fue diseñado por:       * ");
            Console.WriteLine("\t*                                           * ");
            Console.WriteLine("\t*         KATHERINE ALEXANDRA VILA          * ");
            Console.WriteLine("\t*                                           * ");
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\tPresione ENTER para terminar");
            Console.ReadKey();
        }
    }
}
