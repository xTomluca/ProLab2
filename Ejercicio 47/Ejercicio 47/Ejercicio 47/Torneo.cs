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
        public static bool operator ==(T equipo, Torneo<T> torneo)
        {
            foreach (Equipo aux in torneo.equipos)
            {
                if (equipo == aux)
                    return true;
            }
            return false;
        }
        public static bool operator !=(T equipo, Torneo<T> torneo)
        {
            return !(equipo==torneo);
        }
        public static Torneo<T> operator +(T equipo, Torneo<T> torneo)
        {
            if(equipo == torneo)
            {
                return torneo;
            }
            torneo.equipos.Add((T)equipo);
            return torneo;
        }
            /*El método Mostrar retornará los datos del torneo y de los equipos
            participantes.
            6. El método privado CalcularPartido<T, T>: string recibirá dos elementos del
            tipo T, que deberán ser del tipo Equipo o sus herencias, y calculará utilizando
            Random un resultado del partido. Retornará el resultado con el siguiente
            formato: “[EQUIPO1] [RESULTADO1] – [RESULTADO2] [EQUIPO2]”, siendo
            EQUIPOX el nombre del equipo y RESULTADOX la cantidad de goles/puntos.*/
        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Nombre Torneo: {0}");
            foreach(Equipo aux in this.equipos)
            {
                str.Append(aux.Ficha());
            }
            return str.ToString();
        }
        private string CalcularPartido(T a, T b) 
        {

            return "";
        }
            /* El método privado CalcularPartido<T, T>: string recibirá dos elementos del
            tipo T, que deberán ser del tipo Equipo o sus herencias, y calculará utilizando
            Random un resultado del partido. Retornará el resultado con el siguiente
            formato: “[EQUIPO1] [RESULTADO1] – [RESULTADO2] [EQUIPO2]”, siendo
            EQUIPOX el nombre del equipo y RESULTADOX la cantidad de goles/puntos.
            7. La propiedad pública JugarPartido tomará dos equipos de la lista al azar y
            calculará el resultado del partido a través del método CalcularPartido.*/
    }
}
