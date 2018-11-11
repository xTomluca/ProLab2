using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_47_EDIT
{
    public class Torneo<T> where T : Equipo
    {
        List<T> equipos;
        string nombre;

        public string JugarPartido
        {
            get
            {
                Random equipo = new Random();
                int equipo1;
                int equipo2;
                do
                {
                    equipo1 = equipo.Next(this.equipos.Count);
                    Thread.Sleep(60);
                    equipo2 = equipo.Next(this.equipos.Count);

                } while (equipo1 == equipo2);

                string resultado =
                    this.CalcularPartido(this.equipos.ElementAt(equipo1), this.equipos.ElementAt(equipo2));
                return resultado;
            }
        }

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach (Equipo aux in torneo.equipos)
            {
                if (aux == equipo)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }
        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if (torneo != equipo)
            {
                torneo.equipos.Add(equipo);
            }
            return torneo;
        }
        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(this.nombre);
            foreach (Equipo aux in this.equipos)
            {
                stringBuilder.AppendLine(aux.ToString());
            }
            return stringBuilder.ToString();
        }
        string CalcularPartido<T>(T e1, T e2) where T : Equipo
        {
            Random r = new Random();
            StringBuilder stringBuilder = new StringBuilder();

            int goles1 = r.Next(10);
            Thread.Sleep(60);
            int goles2 = r.Next(10);

            stringBuilder.AppendFormat("[{0}] [{1}] – [{2}] [{3}]", e1.nombre, goles1, e2.nombre, goles2);
            return stringBuilder.ToString();
        }
        public Torneo(string nombre)
        {
            this.equipos = new List<T>();
            this.nombre = nombre;
        }

    }
}
