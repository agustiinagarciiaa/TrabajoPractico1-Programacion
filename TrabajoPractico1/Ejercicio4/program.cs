using System;

namespace Programa4
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" BLOQUE 3: Datos del estudiante ");

            string alumno = "Agustina Garcia";
            Console.WriteLine("4. Nombre del Alumno (string):");
            Console.WriteLine("   Alumno: " + alumno);

            char curso = 'B';
            Console.WriteLine("\n5. Division de curso (char):");
            Console.WriteLine("   Curso: '" + curso + "'");
             
            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
        }
    }
}