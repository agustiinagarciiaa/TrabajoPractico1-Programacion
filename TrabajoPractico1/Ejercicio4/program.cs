using System;

namespace Programa4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1 - Datos del estudiante
            Console.WriteLine("\n---Datos del estudiante---");

            string alumno = "Agustina Garcia";
            Console.WriteLine("Nombre del Alumno (string):");
            Console.WriteLine("   Alumno: " + alumno);

            char curso = 'B';
            Console.WriteLine("\nDivision de curso (char):");
            Console.WriteLine("   Curso: '" + curso + "'");
             
            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

            //Ejercicio 2 - Datos del profesor
            Console.WriteLine("\n---Datos del profesor---");

            string profesor = "Rodrigo Esper";
            Console.WriteLine("Nombre del Profesor (string):");
            Console.WriteLine("   Profesor: " + profesor);

            Char comision = '8';
            Console.WriteLine("\nComision del profesor (char):");
            Console.WriteLine("   Comision: '" + comision + "'");

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

            //Ejercicio 3 - Datos de los alumnos aprobados
            Console.WriteLine("\n---Datos del curso---");

            string cursoNombre = "Programacion I";
            Console.WriteLine("Nombre del curso (string):");
            Console.WriteLine("   Curso: " + cursoNombre);

           char alumnosAprobados= '5';
            Console.WriteLine("\nCantidad de alumnos aprobados (char):");
            Console.WriteLine("   Alumnos Aprobados: '" + alumnosAprobados + "'");

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine(); 

            //Ejercicio 4 - Perfil de un jugador
            Console.WriteLine("\n---Perfil de un jugador---");
            string jugador = "xSuga20";
            Console.WriteLine("Nombre del jugador (string):");
            Console.WriteLine("   Jugador: " + jugador);

            char nivel = 'A';
            Console.WriteLine("\nNivel del jugador (char):");
            Console.WriteLine("   Nivel: '" + nivel + "'");

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

            //Ejercicio 5 - Pasaje de avion
            Console.WriteLine("\n---Pasaje de avion---");
            string pasajero = "Agustina Yazmin Garcia";
            Console.WriteLine("Nombre del pasajero (string):");
            Console.WriteLine("   Pasajero: " + pasajero);

            char clase = 'A';
            Console.WriteLine("\nClase del pasaje (char):");
            Console.WriteLine("   Clase: '" + clase + "'");

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

        }
    }
}