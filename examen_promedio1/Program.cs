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
        }
    }
}
