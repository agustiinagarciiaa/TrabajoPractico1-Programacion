using System;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio 1 - Configuracion del juego 
              
              Console.WriteLine("\n---Configuración del juego---");
            
            const string nombreDelJuego = "Roblox";
            const string version = "0.533.0.5330256";
            const int edadMinima = 13;

            Console.WriteLine("=== " + nombreDelJuego + " (" + version + ") ===");
            Console.WriteLine("Cargando reglas del sistema...");
            Console.WriteLine("Restricción: Prohibida la venta a menores de " + edadMinima + " años.");
            
            // Intento de uso con constantes (sin estructuras de control)
            const int edadCliente = 24;
            const bool PuedeIngresar = edadCliente >= edadMinima; 

            Console.WriteLine("\nVerificando cliente de " + edadCliente + " años...");
            Console.WriteLine("Edad mínima: " + edadMinima);
            Console.WriteLine("Acceso permitido (valor bool constante): " + PuedeIngresar);

            // Mostrar constantes para reforzar concepto
            Console.WriteLine("Constante nombre del Juego = " + nombreDelJuego);
            Console.WriteLine("Constante version = " + version);
            
            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();


            //Ejercicio 2 - XP necesaria para subir de nivel
             Console.WriteLine("\n---XP necesaria para subir de nivel---");

            const string nombreDelJuego2 = "Fornite";
            const int xpNivel1 = 1000;
            const int NivelMaximo = 100;

            //Datos del jugador

            const string nombreJugador = "xSuga20";
            const int xpActual = 1500;
    

            Console.WriteLine("=== " + nombreDelJuego2 + " ===");
            Console.WriteLine("Jugador: " + nombreJugador);
            Console.WriteLine("XP actual: " + xpActual);

            //calculo de XP necesaria para subir al siguiente nivel
            const int xpSiguienteNivel = xpNivel1 * 2;

            Console.WriteLine("XP necesaria para subir al siguiente nivel: " + xpSiguienteNivel);

            // Verificar si el jugador puede subir de nivel

            const bool PuedeSubirNivel = xpActual >= xpSiguienteNivel;
            Console.WriteLine("¿Puede subir de nivel? " + PuedeSubirNivel);
            Console.WriteLine("Nivel maximo permitido: " + NivelMaximo);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

            //Ejercicio 3 - Configuracion de un sistema de seguridad
                
                Console.WriteLine("\n---Configuración del sistema de seguridad---");    

            const string nombreDelSistema = "Alarma de seguridad";
            const string versionSistema = "1.0.0";
            const int nivelSeguridad = 5;
            const int nivel_minimoRecomendado = 3;

            Console.WriteLine("=== " + nombreDelSistema + " (" + versionSistema + ") ===");
            Console.WriteLine("Nivel de seguridad configurado: " + nivelSeguridad);
            Console.WriteLine("Nivel mínimo recomendado: " + nivel_minimoRecomendado);


            // Verificar si el nivel de seguridad es adecuado
            const bool NivelAdecuado = nivelSeguridad >= nivel_minimoRecomendado;
            Console.WriteLine("¿El nivel de seguridad es adecuado? " + NivelAdecuado);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

                //Ejercicio 4 - Configuracion de una aplicacion de clima
                Console.WriteLine("\n---Configuración de la aplicación de clima---");

            const string nombreAplicacionClima = "WeatherNow";
            const string versionAplicacion = "2.5.1";
            const int temperaturaMaxima = 40;
            const int temperaturaMinima = -10;

            Console.WriteLine("=== " + nombreAplicacionClima + " (" + versionAplicacion + ") ===");
            Console.WriteLine("Rango de temperatura permitido: " + temperaturaMinima + "°C a " + temperaturaMaxima + "°C");

            // Verificar si la temperatura actual está dentro del rango permitido
            const int temperaturaActual = 25;
            const bool TemperaturaValida = temperaturaActual >= temperaturaMinima && temperaturaActual <= temperaturaMaxima;
            Console.WriteLine("Temperatura actual: " + temperaturaActual + "°C");
            Console.WriteLine("¿La temperatura es válida? " + TemperaturaValida);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

             //Ejercicio 5 - Configuracion de un sistema de control de acceso
             Console.WriteLine("\n---Configuración del sistema de control de acceso---");

            const string nombreSistemaAcceso = "Control de acceso";
            const string versionSistemaAcceso = "3.2.0";
            const int nivelAccesoRequerido = 4;
            const int nivelAccesoUsuario = 5;

            Console.WriteLine("=== " + nombreSistemaAcceso + " (" + versionSistemaAcceso + ") ===");
            Console.WriteLine("Nivel de acceso requerido: " + nivelAccesoRequerido);
            Console.WriteLine("Nivel de acceso del usuario: " + nivelAccesoUsuario);

            // Verificar si el usuario tiene el nivel de acceso requerido
            const bool AccesoPermitido = nivelAccesoUsuario >= nivelAccesoRequerido;
            Console.WriteLine("¿El acceso está permitido? " + AccesoPermitido);
            
            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();




        }
    }
}