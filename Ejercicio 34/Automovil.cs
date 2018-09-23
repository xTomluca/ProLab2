using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class Automovil : VehiculoTerrestre
    {
        int cantidadPasajeros;
        public Automovil(int cantidadPasajeros, short cantidadDeRuedas, short cantidadPuertas, Colores color, short cantidadMarchas) : base (cantidadDeRuedas, cantidadPuertas, color, cantidadMarchas)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }
        public string Mostra()
        {
            string str = base.MostrarAutoCamion();
            StringBuilder aux = new StringBuilder();
            aux.AppendFormat("Auto detalle:\n{0}\nCantidad de Pasajeros {1}", str, this.cantidadPasajeros);
            return aux.ToString();
        }
    }
}
