using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47_EDIT
{
    public class EquipoBasquet : Equipo
    {
        public EquipoBasquet(string nombre, DateTime fechaCreacion) : base(nombre, fechaCreacion)
        {

        }
        public override string ToString()
        {
            return string.Format("Nombre Basquet: {0}\n Fecha: {1}/{2}/{3}", this.nombre, this.fechaCreacion.Day, this.fechaCreacion.Month, this.fechaCreacion.Year);
        }
    }
}
