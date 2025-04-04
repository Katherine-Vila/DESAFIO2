using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO__7
{
    internal class Program
    {
        static bool[,] asientos = new bool[5, 8];
        static void Main(string[] args)
        {
            // Programa realizado por  
            // Día: ABRIL, 2025
            Console.WindowHeight = 100;
            Console.WindowWidth = 100;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.Title = "PROGRAMA DE GESTION DE ASIENTOS CINEMA UDB";

            //VARIABLE
            int opcion;//almacenar la opcion elegida

            //CALCULO
            do//iniciamos el bucle para ejecutarse al menos una vez
            {
                Console.Clear();
                Console.WriteLine("\n\t********************");
                Console.WriteLine("\t*    CINEMA UDB    *");
                Console.WriteLine("\t********************");
                Console.Write("\n");
                Console.WriteLine("1. Ver estado de los asientos");
                Console.WriteLine("2. Consultar disponibilidad de un asiento");
                Console.WriteLine("3. Reservar un asiento");
                Console.WriteLine("4. Salir");
                Console.Write("\n");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        MostrarEstadoAsientos();
                        break;
                    case 2:
                        ConsultarDisponibilidad();
                        break;
                    case 3:
                        ReservarAsiento();
                        break;
                    case 4:
                        Console.WriteLine("Gracias por usar Cinema UDB");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo");
                        break;
                }
            } while (opcion != 4);//aqui el bucle while seguira hasta que no sea la opcion 4
        }

        static void MostrarEstadoAsientos()//esto me es una función estática que no devuelve ningún valor (void) y me muestra el estado de los asientos
        {
            Console.Clear();
            Console.WriteLine("Estado actual de los asientos:");
            for (int i = 0; i < asientos.GetLength(0); i++)//getlength(0) aqui recorre la matriz y esto me dice cuantas filas tiene la matriz son 5
            {
                for (int j = 0; j < asientos.GetLength(1); j++)//aqui el getlength(1) me dice cuantas columnas son (8 butacas)
                {
                    Console.Write(asientos[i, j] ? "O" : "L");//la O significa ocupado y la L libre
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();
        }

        static void ConsultarDisponibilidad()//en esta funcion me vera si el asiento esta libre o ocupado
        {
            Console.WriteLine("Ingrese la fila (0-4):");
            int fila = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la columna (0-8):");
            int columna = int.Parse(Console.ReadLine());

            if (fila >= 0 && fila < 4 && columna >= 0 && columna < 8)//aqui en este operador logico"Y LOGICO" me evalua las dos condiciones al mismo tiempo y me lo devuelve true si  son verdaderas ambas y se validara si los valores que he ingreso estan dentro del rango limite
            {
                Console.WriteLine(asientos[fila, columna] ? "El asiento está ocupado" : "El asiento está libre");
            }
            else
            {
                Console.WriteLine("Ubicación fuera de rango. Intente de nuevo");
            }
            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();
        }

        static void ReservarAsiento()//en esta funcion me permitira guardar el asiento si esta solo
        {
            Console.WriteLine("Ingrese la fila (0-4):");
            int fila = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la columna (0-8):");
            int columna = int.Parse(Console.ReadLine());

            if (fila >= 0 && fila < 4 && columna >= 0 && columna < 8)
            {
                if (!asientos[fila, columna])//se revisa si el asiento esta libre
                {
                    asientos[fila, columna] = true;
                    Console.WriteLine("¡Reserva exitosa!");
                }
                else
                {
                    Console.WriteLine("El asiento ya está ocupado. Elige otro");
                }
            }
            else
            {
                Console.WriteLine("Ubicación fuera de rango. Intente de nuevo");
            }

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();
            Console.Write("\n");
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t*                                           * ");
            Console.WriteLine("\t*     Este programa fue diseñado por:       * ");
            Console.WriteLine("\t*                                           * ");
            Console.WriteLine("\t*         KATHERINE ALEXANDRA VILA          * ");
            Console.WriteLine("\t*                                           * ");
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tPresione ENTER para terminar");
            Console.ReadKey();
        }
    } 
}
