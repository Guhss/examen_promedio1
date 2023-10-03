using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_promedio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido!");
            Console.Write("Ingresa la cantidad de dinero inicial en tu granja: $");
            float dineroInicial = float.Parse(Console.ReadLine());
            Granja granja = new Granja(dineroInicial);

            while (true)
            {
                Console.WriteLine("-- Menú de acciones --");
                Console.WriteLine("1. Comprar espacio en la granja");
                Console.WriteLine("2. Comprar semillas para plantar");
                Console.WriteLine("3. Comprar animales");
                Console.WriteLine("4. Pasar de turno");
                Console.WriteLine("5. Mostrar estado de la granja");
                Console.WriteLine("6. Vender productos");
                Console.WriteLine("7. Salir del juego");

                Console.Write("Selecciona una acción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        granja.ComprarEspacioEnGranja();
                        break;

                    case 2:


                    case 3:


                    case 4:


                    case 5:


                    case 6:


                    case 7:
                        Console.WriteLine("Gracias por jugar. ¡Hasta la próxima!");
                        return;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, selecciona una opción válida.");
                        break;
                }
            }
        }
}
