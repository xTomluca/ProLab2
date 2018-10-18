using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if(value.ValidadAptitud()==true)
                    this.directorTecnico = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }
        /// <summary>
        /// Muestra todos los datos del equipo a traves de sobrecarga STRING
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator string(Equipo e)
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Nombre Equipo: {0}\n", e.Nombre);
            if (e.directorTecnico is null)
                str.AppendFormat("Director Tecnico: Sin DT asingnado\n");
            else
                str.AppendFormat("Director Tecnico: \n", e.directorTecnico);
            foreach(Jugador aux in e.jugadores)
                str.AppendLine(aux.Mostrar());
            return str.ToString();
        }

        /// <summary>
        /// Verifica si hay un jugador igual en el Equipo
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns>TRUE = JUGADOR ENCONTRADO || FALSE = JUGADOR NO ENCONTRADO</returns>
        public static bool operator ==(Equipo e, Jugador j)
        {
            foreach(Jugador aux in e.jugadores)
            {
                if (aux == j)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Agrega Jugador al Equipo si este no se encuentra en el
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns>Equipo</returns>
        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e == j)
                return e;
            if (cantidadMaximaJugadores > e.jugadores.Count && j.ValidadAptitud()==true)
                e.jugadores.Add(j);
            return e;
        }

        /// <summary>
        /// Verifica si el jugador no se encuentra en el Equipo
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns>TRUE = JUGADOR NO ENCONTRADO || FALSE = JUGADOR ENCONTRADO</returns>
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }
        /// <summary>
        /// Verifica que solo haya un arquero
        /// Al menos un jugador con posicion asignada
        /// Cantidad maxima de jugadores sea igual a cantidad de juegadores
        /// y que tenga un DT Asignado
        /// </summary>
        /// <param name="e"></param>
        /// <returns>TRUE = Equipo Valido || FALSE = Equipo Invalido</returns>
        public static bool ValidarEquipo(Equipo e)
        {
            int cantidadArqueros = 0;
            int jugadoresAsignados = 0;
            if (e.directorTecnico is null)
                return false;
            if(cantidadMaximaJugadores == e.jugadores.Count)
            {
                foreach(Jugador aux in e.jugadores)
                {
                    if(aux.Posicion.ToString() is null)
                        continue;
                    else
                        jugadoresAsignados++;
                    if (aux.Posicion == Posicion.Arquero)
                        cantidadArqueros++;
                }
            }
            if (jugadoresAsignados > 0 && cantidadArqueros == 1)
                return true;
            return false;
        }
    }
}
