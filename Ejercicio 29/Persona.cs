using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Persona
    {
        long dni;
        string nombre;
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }
        public string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Nombre: {0}\nDni: {1}", this.Nombre, this.Dni);
            return str.ToString();
        }
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public Persona(long dni,string nombre) : this(nombre)
        {
            this.Dni = dni;
        }

    }
}
