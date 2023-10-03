using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_promedio1
{
    internal class Planta
    {
        public string Nombre; 
        public int TiempoDeVida;
        public int CantidadFrutosVerduras;
        public float ValorSemilla;
        public float ValorProducto; 
        public bool Cosechada;

        public Planta(string nombre, int tiempoDeVida, int cantidadFrutosVerduras, float valorSemilla, float valorProducto)
        {
            Nombre = nombre;
            TiempoDeVida = tiempoDeVida;
            CantidadFrutosVerduras = cantidadFrutosVerduras;
            ValorSemilla = valorSemilla;
            ValorProducto = valorProducto;
            Cosechada = false;
        }
    }
}
