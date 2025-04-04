using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO__8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa realizado por  
            // Día: ABRIL, 2025
            Console.WindowHeight = 100;           
            Console.WindowWidth = 100; 
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.Title = "JUEGO DE ADIVINANZA CON NUMEROS";

            //VARIABLES
            Random random = new Random();//esta funcion me va a generar un numero al azar
            bool jugarDeNuevo = true;//esta funcion booleana me va a ver si es true ejecutara el programa

            //PROCESO
            while (jugarDeNuevo)//este bucle se mantendra mientras la condicion aun sea true
            {
                int numeroSecreto = random.Next(1,100);//esto me demilitara el numero del 1 al 100 y eligira uno al azar
                int intentosRestantes = 10;
                bool adivinado = false;

                Console.Clear();
                Console.WriteLine("\n\t***************************************");
                Console.WriteLine("\t* ¡Bienvenido al juego de adivinanza! *");
                Console.WriteLine("\t***************************************");
                Console.Write("\n");
                Console.WriteLine("Debes adivinar un número entre 1 y 100");
                Console.WriteLine($"Tienes {intentosRestantes} intentos");

                while (intentosRestantes > 0 && !adivinado)// aqui me leera si sigo teniendo intentos y continuara hasta que gane o pierda
                {
                    Console.Write("\nIngresa tu número:");
                    int intentoUsuario;

                    if (!int.TryParse(Console.ReadLine(), out intentoUsuario)) //esta condicion me dira que si hay algo que no es numero me escriba correctamente el numero
                    {
                        Console.WriteLine("Entrada inválida. Ingresa un número válido");
                        continue;
                    }

                    if (intentoUsuario == numeroSecreto)
                    {
                        Console.WriteLine("\n¡Ganaste!");
                        adivinado = true;
                    }
                    else//esta condicion me dira que si no adivino se seguira el juego hasta la final
                    {
                        intentosRestantes--;
                        Console.WriteLine($"Intentos restantes: {intentosRestantes}");

                        if (intentoUsuario < numeroSecreto) //en esta parte vamos a dar pista dependiendo el numero si es mayor o menor
                        {
                            Console.WriteLine("El número es mayor.");
                        }
                        else
                        {
                            Console.WriteLine("El número es menor.");
                        }
                    }
                }

                if (!adivinado)
                {
                    Console.WriteLine($"\nPerdiste, el número era {numeroSecreto}");
                }

                //SALIDA
                Console.Write("\n¿Quieres jugar otra vez? (s/n): ");
                string respuesta = Console.ReadLine();
                jugarDeNuevo = respuesta == "s" || respuesta == "S";
                Console.WriteLine("\nGracias por jugar ¡JUEGA A LA PROXIMA!");

            }

            Console.Write("\n");
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t*                                           * "); 
            Console.WriteLine("\t*     Este programa fue diseñado por:       * "); 
            Console.WriteLine("\t*                                           * ");
            Console.WriteLine("\t*         KATHERINE ALEXANDRA VILA          * "); 
            Console.WriteLine("\t*                                           * ");
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\tPresione ENTER para terminar");
            Console.ReadKey();
        }
    }
}
