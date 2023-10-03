using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_promedio1
{
    internal class Animal
    {
        public string Nombre; 
        public int TiempoDeVida; 
        public int CantidadCarneLecheLanaHuevos;
        public float PrecioAnimal;
        public float PrecioProductosFinales; 
        public bool Recolectado; 

        public Animal(string nombre, int tiempoDeVida, int cantidadCarneLecheLanaHuevos, float precioAnimal, float precioProductosFinales)
        {
            Nombre = nombre;
            TiempoDeVida = tiempoDeVida;
            CantidadCarneLecheLanaHuevos = cantidadCarneLecheLanaHuevos;
            PrecioAnimal = precioAnimal;
            PrecioProductosFinales = precioProductosFinales;
            Recolectado = false;
        }
    }
}
