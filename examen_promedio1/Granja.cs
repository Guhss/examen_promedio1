using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_promedio1
{
    internal class Granja
    {
        private float dinero;
        private List<Planta> plantas;
        private List<Animal> animales;
        private float precioExpansion;

        public Granja(float dineroInicial)
        {
            dinero = dineroInicial;
            plantas = new List<Planta>();
            animales = new List<Animal>();
            precioExpansion = 10.0;
        }

        public void ComprarEspacioEnGranja()
        {
            if (dinero >= precioExpansion)
            {
                dinero -= precioExpansion;
                precioExpansion += 10.0;
                Console.WriteLine("Espacio en la granja comprado con éxito.");
            }
            else
            {
                Console.WriteLine("No tienes suficiente dinero para comprar espacio en la granja.");
            }
        }

        public void ComprarPlanta(Planta planta)
        {
            if (dinero >= planta.ValorSemilla)
            {
                dinero -= planta.ValorSemilla;
                plantas.Add(planta);
                Console.WriteLine($"Has plantado una {planta.Nombre} en tu granja.");
            }
            else
            {
                Console.WriteLine("No tienes suficiente dinero para comprar la semilla.");
            }
        }

        public void ComprarAnimal(Animal animal)
        {
            if (dinero >= animal.PrecioAnimal)
            {
                dinero -= animal.PrecioAnimal;
                animales.Add(animal);
                Console.WriteLine($"Has comprado un {animal.Nombre} para tu granja.");
            }
            else
            {
                Console.WriteLine("No tienes suficiente dinero para comprar el animal.");
            }
        }


        public void MostrarEstadoGranja()
        {
            Console.WriteLine($"Dinero disponible en la granja: ${dinero}");
            Console.WriteLine("Estado de la granja:");
            Console.WriteLine("Plantas:");

            foreach (var planta in plantas)
            {
                if (!planta.Cosechada)
                {
                    Console.WriteLine($"- {planta.Nombre} (Tiempo de vida: {planta.TiempoDeVida}, Cosechada: No)");
                }
            }

            Console.WriteLine("Animales:");

            foreach (var animal in animales)
            {
                if (!animal.Recolectado)
                {
                    Console.WriteLine($"- {animal.Nombre} (Tiempo de vida: {animal.TiempoDeVida}, Recolectado: No)");
                }
            }
        }

        
    }
}
