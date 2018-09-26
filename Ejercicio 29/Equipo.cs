using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Equipo
    {
        short cantidadDeJugadores;
        public List<Jugador> jugadores;
        string nombre;
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        public static bool operator +(Equipo e,Jugador j)
        {
            foreach(Jugador aux in e.jugadores)
            {
                if (aux == j)
                    return false;
            }
            if(e.jugadores.Count<e.cantidadDeJugadores)
            {
                e.jugadores.Add(j);
                return true;
            }
            return false;
        }
        public string Mostrar()
        {
            return this.nombre;
        }
    }
}

