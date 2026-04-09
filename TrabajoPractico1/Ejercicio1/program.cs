using System;

namespace Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1 . Sistema de login
            Console.WriteLine("Sistema de login");

            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine()!;

            Console.Write("Ingrese su apellido:");
            string apellido = Console.ReadLine()!;

            Console.Write("Ingresa tu edad: ");
            string edadTexto = Console.ReadLine()!;
            int edad = int.Parse(edadTexto); 

            Console.Write("promedio de materias aprobadas: ");
            double promedio  = double.Parse(Console.ReadLine()!);

            // 4. Mostrar los resultados procesadosAG
            Console.WriteLine("\n Cuenta Registrada");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido:"+ apellido);
            Console.WriteLine("Edad: " + edad); 
            Console.WriteLine("Promedio de materias aprobadas: " + promedio + " aprobadas");

            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();

            // Ejercicio 2. Registro Alumno
            Console.WriteLine("\n---Registro de Alumno---");

                Console.Write("Ingrese su nombre: ");
                string nombreAlumno = Console.ReadLine()!;
    
                Console.Write("Ingrese su apellido:");
                string apellidoAlumno = Console.ReadLine()!;
    
                Console.Write("Ingresa tu edad: ");
                string edadTextoAlumno = Console.ReadLine()!;
                int edadAlumno = int.Parse(edadTextoAlumno); 

                Console.Write("Ingrese su numero de legajo: ");
                string legajoTextoAlumno = Console.ReadLine()!;
                int legajoAlumno = int.Parse(legajoTextoAlumno);
    
                Console.Write("promedio de materias aprobadas");
                double promedioAlumno  = double.Parse(Console.ReadLine()!);

                // Mostrar los resultados
                Console.WriteLine("\n Cuenta Registrada");
                Console.WriteLine("Nombre: " + nombreAlumno);
                Console.WriteLine("Apellido:"+ apellidoAlumno);
                Console.WriteLine("Edad: " + edadAlumno);
                Console.WriteLine("Numero de legajo: " + legajoAlumno);
                Console.WriteLine("Promedio de materias aprobadas: " + promedioAlumno + " aprobadas");

                Console.WriteLine("\nPresiona ENTER para salir.");
                Console.ReadLine();


                // Ejercicio 3. Registro de Empleado
                Console.WriteLine("\n---Registro de Empleado---");

                Console.Write("Ingrese su nombre: ");
                string nombreEmpleado = Console.ReadLine()!;

                Console.Write("Ingrese su apellido:");
                string apellidoEmpleado = Console.ReadLine()!;

                Console.Write("Ingresa tu sueldo: ");
                string sueldoTextoEmpleado = Console.ReadLine()!;
                int sueldoEmpleado = int.Parse(sueldoTextoEmpleado);

                Console.Write("Ingrese tu puesto de trabajo: ");
                string puestoEmpleado = Console.ReadLine()!;

                // Mostrar los resultados
                Console.WriteLine("\n Cuenta Registrada");
                Console.WriteLine("Nombre: " + nombreEmpleado);
                Console.WriteLine("Apellido:"+ apellidoEmpleado);
                Console.WriteLine("Sueldo: " + sueldoEmpleado);
                Console.WriteLine("Puesto de trabajo: " + puestoEmpleado);

                Console.WriteLine("\nPresiona ENTER para salir.");
                Console.ReadLine();

                //Ejercicio 4. Registro de turnos medicos

                    Console.WriteLine("\n---Registro de Turnos Médicos---");

                    Console.Write("Ingrese su nombre: ");
                    string nombrePaciente = Console.ReadLine()!;

                    Console.Write("Ingrese su apellido:");
                    string apellidoPaciente = Console.ReadLine()!;

                    Console.Write("Ingresa tu edad: ");
                    string edadTextoPaciente = Console.ReadLine()!;
                    int edadPaciente = int.Parse(edadTextoPaciente);

                    Console.Write("Ingrese su número de teléfono: ");
                    string telefonoPaciente = Console.ReadLine()!;
                    int telefonoNumerico = int.Parse(telefonoPaciente);

                    Console.Write("Ingrese medico a atender: ");
                    string medicoPaciente = Console.ReadLine()!;

                    Console.Write("Ingrese fecha del turno: ");
                    string fechaPaciente = Console.ReadLine()!;
                    DateTime fechaTurno = DateTime.Parse(fechaPaciente);

                    // Mostrar los resultados
                    Console.WriteLine("\n Cuenta Registrada");
                    Console.WriteLine("Nombre: " + nombrePaciente);
                    Console.WriteLine("Apellido:"+ apellidoPaciente);
                    Console.WriteLine("Edad: " + edadPaciente);
                    Console.WriteLine("Número de teléfono: " + telefonoNumerico);
                    Console.WriteLine("Medico a atender: " + medicoPaciente);
                    Console.WriteLine("Fecha del turno: " + fechaTurno.ToShortDateString());

                    Console.WriteLine("\nPresiona ENTER para salir.");
                    Console.ReadLine();

                    //Ejercicio 5. Reserva de hotel
                    Console.WriteLine("\n---Reserva de Hotel---");

                    Console.Write("Ingrese su nombre: ");
                    string nombreHuesped = Console.ReadLine()!;

                    Console.Write("Ingrese su apellido:");
                    string apellidoHuesped = Console.ReadLine()!;

                    Console.Write("Ingresa tu DNI: ");
                    string dniHuesped = Console.ReadLine()!;
                    int DNI = int.Parse(dniHuesped);

                    Console.Write("Ingrese su reservacion en el hotel:");
                    string reservacionHuesped = Console.ReadLine()!;

                    Console.Write("Ingrese fecha de entrada: ");
                    string fechaEntradaHuesped = Console.ReadLine()!;

                    Console.Write("Ingrese fecha de salida: ");
                    string fechaSalidaHuesped = Console.ReadLine()!;

                    // Mostrar los resultados
                    Console.WriteLine("\n Cuenta Registrada");
                    Console.WriteLine("Nombre: " + nombreHuesped);
                    Console.WriteLine("Apellido:"+ apellidoHuesped);
                    Console.WriteLine("DNI: " + DNI);
                    Console.WriteLine("Reservacion en el hotel: " + reservacionHuesped);
                    Console.WriteLine("Fecha de entrada: " + fechaEntradaHuesped);
                    Console.WriteLine("Fecha de salida: " + fechaSalidaHuesped);

                    Console.WriteLine("\nPresiona ENTER para salir.");
                    Console.ReadLine();

        }
    }
}