using System;

namespace Programa1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de login");

            // Entrada de Texto 
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            //Entrads de Texto
            Console.Write("Ingrese su apellido:");
            string apellido = Console.ReadLine();

            //Entrada de Números
            Console.Write("Ingresa tu edad: ");
            string edadTexto = Console.ReadLine();
            int edad = int.Parse(edadTexto); 

            //Entrada decimales
            Console.Write("promedio de materias aprobadas");
            double promedio  = double.Parse(Console.ReadLine());

            // 4. Mostrar los resultados procesados
            Console.WriteLine("\n Cuenta Registrada");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido:"+ apellido);
            Console.WriteLine("Edad: " + edad); 
            Console.WriteLine("Promedio de materias aprobadas: " + promedio + " aprobadas");

            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();
        }
    }
}