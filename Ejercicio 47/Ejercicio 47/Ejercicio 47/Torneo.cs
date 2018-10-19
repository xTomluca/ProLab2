using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    /*a.Crear un proyecto del tipo Biblioteca de Clases:
    i.Generar la clase Torneo con un tipo genérico.
    1. Restringir el tipo genérico para que deba ser del tipo Equipo o sus derivados.
    2. Tendrá un atributo equipos : List<T> y otro nombre : string.
    3. Sobrecargar el operador == para que controle si un equipo ya está inscripto al
    torneo.*/
    public class Torneo<T> where T : Equipo
    {
        List<T> equipos;
        string nombre;
        public static bool operator ==(Equipo equipo, Torneo<T> torneo)
        {
            foreach (Equipo aux in torneo.equipos)
            {
                if (equipo == aux)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Equipo equipo, Torneo<T> torneo)
        {
            return !(equipo==torneo);
        }
        public static Torneo<T> operator +(Equipo equipo, Torneo<T> torneo)
        {
            if(equipo == torneo)
            {
                return torneo;
            }
            torneo.equipos.Add((T)equipo);
            return torneo;
        }
        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.
        }
    }
}
