using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    public class Equipo
    {
        string nombre;
        DateTime fechaCreacion;
        public static bool operator ==(Equipo e1, Equipo e2)
        {
            if (e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion)
                return true;
            return false;
        }
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }
        //3. El método Ficha retornará el nombre del equipo y su fecha de creación con el
        // siguiente formato “[EQUIPO]  fundado el[FECHA]”.
        public string Ficha()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Nombre: {0}\nFecha Creacion: {1}", this.nombre, this.fechaCreacion.ToString());
            return stringBuilder.ToString();
        }
    }
}
