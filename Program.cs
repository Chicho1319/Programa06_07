using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa06_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcula impuesto ambiental

            // Variables
            int opcion = 0;
            int fabricacion = 0;
            string dato = "";

            // Pedimos el tipo de vehiculo 
            Console.WriteLine("1. Auto, 2. Motocicleta, 3. Bicicleta");
            dato = Console.ReadLine();
            opcion = Convert.ToInt32(dato);

            // Pedimos cuando se fabrico
            Console.WriteLine("¿Cuándo se fabricó?");
            dato = Console.ReadLine();
            fabricacion = Convert.ToInt32(dato);

            // Verificamos las opciones
            ///Cambios

            if (opcion == 1)
            {
                if (fabricacion <= 1980)
                    Console.WriteLine("El impuesto del auto es 8%");
                if (fabricacion > 1980 && fabricacion < 2000)
                    Console.WriteLine("El impuesto del auto es 5%");
                if (fabricacion >= 2000)
                    Console.WriteLine("El impuesto del auto es 3%");
                Console.WriteLine("Nuevo Cambii");
            }

            if (opcion == 2)
            {
                if (fabricacion <= 1980)
                    Console.WriteLine("El impuesto de la motocicleta es 4%");
                if (fabricacion > 1980 && fabricacion < 2000)
                    Console.WriteLine("El impuesto de la motocicleta es 2%");
                if (fabricacion >= 2000)
                    Console.WriteLine("El impuesto de la motocicleta es 1%");
            }

            if (opcion == 3)
                Console.WriteLine("La bicicleta no paga impuesto");

            Console.ReadKey();
        }
    }
}
