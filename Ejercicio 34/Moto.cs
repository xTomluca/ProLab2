using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class Moto : VehiculoTerrestre
    {
        short cilindrada;
        public Moto(short cantidadDeRuedas, short cantidadPuertas, Colores color, short cilindrada) : base(cantidadDeRuedas,cantidadPuertas,color)
        {
            this.cilindrada = cilindrada;
        }
        public string Mostra()
        {
            string str = base.Mostrar();
            StringBuilder aux = new StringBuilder();
            aux.AppendFormat("Moto detalle:\n{0}\nCilindrada {1}", str, this.cilindrada);
            return aux.ToString();
        }
    }
}
