using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class Camion : VehiculoTerrestre
    {
        int pesoCarga;
        public Camion(short cantidadDeRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga) : base(cantidadDeRuedas, cantidadPuertas, color, cantidadMarchas)
        {
            this.pesoCarga = pesoCarga;
        }
        public string Mostra()
        {
            string str = base.MostrarAutoCamion();
            StringBuilder aux = new StringBuilder();
            aux.AppendFormat("Detalle Camion\n{0}\nCarga: {1}kg", str, this.pesoCarga);
            return aux.ToString();
        }
    }
}
