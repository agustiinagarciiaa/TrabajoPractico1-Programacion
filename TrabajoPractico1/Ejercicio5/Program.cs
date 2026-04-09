using System;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio 1 - proyecto a entregar
             Console.WriteLine("\n---Proyecto entregado  ---");

            // Booleano (bool) - Solo true o false
            bool ProyectoEntregado = true;

            Console.WriteLine("6. TIPO LÓGICO (bool):");
            Console.WriteLine("   ¿El proyecto está entregado?: " + ProyectoEntregado);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();


            //Ejercicio 2 - En un videojuego si o no tiene curacion 
             Console.WriteLine("\n---Tiene curacion---");
            
            // Booleano (bool) - Solo true o false
            bool TieneCuracion = false;
            Console.WriteLine("7. TIPO LÓGICO (bool) EN VIDEOJUEGO:");
            Console.WriteLine("   ¿El personaje tiene curación?: " + TieneCuracion);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

            //Ejercicio 3 - habilidades desbloqueadas o no en un videojuego
            Console.WriteLine("\n---Habilidades desbloqueadas---");

            // Booleano (bool) - Solo true o false
            bool HabilidadesDesbloqueadas = true;
            Console.WriteLine("8. TIPO LÓGICO (bool) EN VIDEOJUEGO:");
            Console.WriteLine(" ¿Las habilidades están desbloqueadas?: " + HabilidadesDesbloqueadas);

            //Ejercicio 4 - En un sistema de seguridad si la alarma esta activada o no
            Console.WriteLine("\n---Alarma activada---");

            // Booleano (bool) - Solo true o false
            bool AlarmaActivada = false;

            Console.WriteLine("9. TIPO LÓGICO (bool) EN SISTEMA DE SEGURIDAD:");
            Console.WriteLine("   ¿La alarma está activada?: " + AlarmaActivada);
        
            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

             //Ejercicio 5 - En una aplicación de clima si esta lloviendo o no
            Console.WriteLine("\n---Está lloviendo---");

            // Booleano (bool) - Solo true o false
            bool EstaLloviendo = true;
            Console.WriteLine("10. TIPO LÓGICO (bool) EN APLICACIÓN DE CLIMA:");
            Console.WriteLine("   ¿Está lloviendo?: " + EstaLloviendo);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

        }
    }
}