using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class VehiculoTerrestre
    {
        public enum Colores
        {
            Rojo,
            Blanco,
            Azul,
            Gris,
            Negro
        }
        short cantidadRuedas;
        short cantidadPuertas;
        short cantidadMarchas;
        Colores color;
        public VehiculoTerrestre(short cantidadRuedas,short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }
        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color,short cantidadMarchas)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
            this.cantidadMarchas = cantidadMarchas;
        }
        public string Mostrar()
        {
            StringBuilder aux = new StringBuilder();
            aux.AppendFormat("Cantidad Ruedas: {0}\nCantidadPuertas: {1}\nColor: {2}", this.cantidadRuedas,this.cantidadPuertas,this.color);
            return aux.ToString();
        }
        public string MostrarAutoCamion()
        {
            StringBuilder aux = new StringBuilder();
            aux.AppendFormat("Cantidad Ruedas: {0}\nCantidadPuertas: {1}\nColor: {2}\nMarchas: {3}", this.cantidadRuedas, this.cantidadPuertas, this.color,this.cantidadMarchas);
            return aux.ToString();
        }
    }
}
