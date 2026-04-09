using System;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1 Facturacion de una tienda gamer
            Console.WriteLine("---Ejercicio 1: Facturación de una tienda gamer---");

            const string NOMBRE_TIENDA = "GamerZone";
            const decimal TASA_IVA = 0.21m;
            const char SIMBOLO_PESO = '$';

            //Producto Gamer
            const string NOMBRE_PRODUCTO = "Pase de batalla de Fornite";
            decimal PrecioBase = 11599.99m;
            decimal impuesto = PrecioBase * TASA_IVA;
            decimal PrecioFinal = PrecioBase + impuesto;

            

            Console.WriteLine("\nDetalle de la compra:");
            Console.WriteLine("Tienda: " + NOMBRE_TIENDA);
            Console.WriteLine("Producto: " + NOMBRE_PRODUCTO);
            Console.WriteLine("Precio: " + SIMBOLO_PESO + PrecioBase);
            Console.WriteLine("IVA (" + (TASA_IVA * 100) + "%): " + SIMBOLO_PESO + impuesto);
            Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + PrecioFinal);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();


                //Ejercicio 2 - Configuracion del juego 
                
                Console.WriteLine("\n---Ejercicio 2: Facturacion de cafeteria---");

                const string NOMBRE_CAFETERIA = "Oliver Brown";
                const decimal PROMO_AMERICANO = 15000.00m;
                const decimal TASA_IVA_CAFETERIA = 0.10m;
                char simboloPeso1 = '$';

                //Producto Cafeteria
                const string NOMBRE_PRODUCTO_CAFETERIA = "Americano";

                decimal impuestoCafeteria = PROMO_AMERICANO * TASA_IVA_CAFETERIA;
                decimal precioFinalCafeteria = PROMO_AMERICANO + impuestoCafeteria;

                Console.WriteLine("\nDetalle de la compra:");
                Console.WriteLine("Cafetería: " + NOMBRE_CAFETERIA);
                Console.WriteLine("Producto: " + NOMBRE_PRODUCTO_CAFETERIA);
                Console.WriteLine("Precio: " + simboloPeso1 + PROMO_AMERICANO);
                Console.WriteLine("IVA (" + (TASA_IVA_CAFETERIA * 100) + "%): " + simboloPeso1 + impuestoCafeteria);
                Console.WriteLine("TOTAL A PAGAR: " + simboloPeso1 + precioFinalCafeteria);

                Console.WriteLine("\nPresiona ENTER para cerrar.");
                Console.ReadLine();

           //Ejercicio 3 - Facturacion con descuento a estudiantes 

           Console.WriteLine("\n---Ejercicio 3: Facturación con descuento a estudiantes---");

            const string NOMBRE_LIBRERIA = "Librería El Saber";
            const decimal tasaIvaLibreria = 0.21m;
            const decimal PrecioLibro = 14000.00m;
            const decimal descuento_Estudiante = 0.20m;
            const bool estudiante = true;
            char simboloPeso2 = '$';

            //Producto Libreria
            const string NOMBRE_PRODUCTO_LIBRERIA = "Libro de programación en C#";
            
            //Calculo del descuento 
            decimal descuento = PrecioLibro * descuento_Estudiante;
            decimal precioConDescuento = PrecioLibro - descuento;
            decimal impuestoLibreria = precioConDescuento * tasaIvaLibreria;
            decimal precioFinalLibreria = precioConDescuento + impuestoLibreria;
            
            Console.WriteLine("\nDetalle de la compra:");
            Console.WriteLine("Librería: " + NOMBRE_LIBRERIA);
            Console.WriteLine("Producto: " + NOMBRE_PRODUCTO_LIBRERIA);
            Console.WriteLine("Precio: " + simboloPeso2 + PrecioLibro);
            Console.WriteLine("Es estudiante?: " + estudiante);
            Console.WriteLine("Descuento para estudiantes (" + (descuento_Estudiante * 100) + "%): -" + simboloPeso2 + descuento);
            Console.WriteLine("TOTAL A PAGAR: " + simboloPeso2 + precioFinalLibreria);


            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

            //Ejercicio 4 - Facturacion de un servicio de streaming
            Console.WriteLine("\n---Ejercicio 4: Facturación de un servicio de streaming---");

            const string nombreServicioStreaming = "StreamFlix";
            const decimal precioBaseStreaming = 399.99m;
            const decimal tasaIvaStreaming = 0.21m;
            char simboloPeso3 = '$';

            //Producto Streaming
            const string nombreProductoStream = "Suscripción mensual";
            
            //calculo 
            decimal impuestoStreaming = precioBaseStreaming * tasaIvaStreaming;
            decimal precioFinalStreaming = precioBaseStreaming + impuestoStreaming;

            Console.WriteLine("\nDetalle de la compra:");
            Console.WriteLine("Servicio de streaming: " + nombreServicioStreaming);
            Console.WriteLine("Producto: " + nombreProductoStream);
            Console.WriteLine("Precio: " + simboloPeso3 + precioBaseStreaming);
            Console.WriteLine("IVA (" + (tasaIvaStreaming * 100) + "%): " + simboloPeso3 + impuestoStreaming);
            Console.WriteLine("TOTAL A PAGAR: " + simboloPeso3 + precioFinalStreaming);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();


            //Ejercicio 5 - Facturacion de un servicio de internet
            Console.WriteLine("\n---Ejercicio 5: Facturación de un servicio de internet---");

            const string nombreProveedorInternet = "NetConnect";
            const decimal precioBaseInternet = 5999.99m;
            const decimal tasaIvaInternet = 0.21m;
            char simboloPeso4 = '$';

            //Producto Internet
            const string nombreProductoInternet = "Plan mensual de internet";

            //calculo
            decimal impuestoInternet = precioBaseInternet * tasaIvaInternet;
            decimal precioFinalInternet = precioBaseInternet + impuestoInternet;


            Console.WriteLine("\nDetalle de la compra:");
            Console.WriteLine("Proveedor de internet: " + nombreProveedorInternet);
            Console.WriteLine("Producto: " + nombreProductoInternet);
            Console.WriteLine("Precio: " + simboloPeso4 + precioBaseInternet);
            Console.WriteLine("IVA (" + (tasaIvaInternet * 100) + "%): " + simboloPeso4 + impuestoInternet);
            Console.WriteLine("TOTAL A PAGAR: " + simboloPeso4 + precioFinalInternet);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
        }
    }
}