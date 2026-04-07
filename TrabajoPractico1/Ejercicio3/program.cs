using System;

namespace Programa3
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" BLOQUE 2: Total de compras");

            //kilos comprados
                double kilosComprados = 2.75;
                Console.WriteLine("2. Cantidad de producto (double):");
                Console.WriteLine("   Kilos comprados: " + kilosComprados + " kg");

             // Precio total 
                decimal totalCompra = 3499.99m;
                Console.WriteLine("\n3. Total a pagar (decimal):");
                Console.WriteLine("   Total de la compra: $" + totalCompra);

                Console.WriteLine("\nPresiona ENTER para cerrar.");
                Console.ReadLine();
        }
    }
}