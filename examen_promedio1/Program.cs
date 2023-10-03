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
                        Console.Write("Ingrese el nombre de la planta: ");
                        string nombrePlanta = Console.ReadLine();
                        Console.Write("Ingrese el tiempo de vida de la planta: ");
                        int tiempoDeVidaPlanta = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese la cantidad de frutos/verduras: ");
                        int cantidadFrutosVerduras = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el valor de la semilla: $");
                        float valorSemilla = float.Parse(Console.ReadLine());
                        Console.Write("Ingrese el valor del producto cuando crece: $");
                        float valorProducto = float.Parse(Console.ReadLine());

                        Planta nuevaPlanta = new Planta(nombrePlanta, tiempoDeVidaPlanta, cantidadFrutosVerduras, valorSemilla, valorProducto);
                        granja.ComprarPlanta(nuevaPlanta);
                        break;

                    case 3:
                        Console.Write("Ingrese el nombre del animal: ");
                        string nombreAnimal = Console.ReadLine();
                        Console.Write("Ingrese el tiempo de vida del animal: ");
                        int tiempoDeVidaAnimal = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese la cantidad de carne/leche/lana/huevos: ");
                        int cantidadCarneLecheLanaHuevos = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el precio del animal: $");
                        float precioAnimal = float.Parse(Console.ReadLine());
                        Console.Write("Ingrese el precio de los productos finales: $");
                        float precioProductosFinales = float.Parse(Console.ReadLine());

                        Animal nuevoAnimal = new Animal(nombreAnimal, tiempoDeVidaAnimal, cantidadCarneLecheLanaHuevos, precioAnimal, precioProductosFinales);
                        granja.ComprarAnimal(nuevoAnimal);
                        break;

                    case 4:
                        granja.PasarDeTurno(),
                        break;

                    case 5:
                        granja.MostrarEstadoGranja();
                        break;

                    case 6:


                    case 7:
                        Console.WriteLine("Gracias. ¡Hasta la próxima!");
                        return;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
}
