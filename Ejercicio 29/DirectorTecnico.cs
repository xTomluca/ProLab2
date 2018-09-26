using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class DirectorTecnico : Persona
    {
        DateTime fechaNacimiento;

        public DirectorTecnico(string nombre) : base(nombre)
        {

        }
        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        public new string MostrarDatos()
        {
            string str = base.Nombre;
            StringBuilder rtn = new StringBuilder();
            rtn.AppendFormat("Nombre: {0}\nFecha Nacimiento: {1}", str, this.fechaNacimiento);
            return rtn.ToString();
        }
        public static bool operator ==(DirectorTecnico dt1,DirectorTecnico dt2)
        {
            if (dt1.Dni == dt2.Dni)
                return true;
            return false;
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1.Dni == dt2.Dni);
        }
    }
}
