using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        public int Dni
        {
            get
            {
                return this.dni;
            }
        }
        public int Edad
        {
            get
            {
                return this.edad;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        /// <summary>
        /// Muestra todos los datos del objeto de tipo Persona
        /// </summary>
        /// <returns>Todos los datos</returns>
        public virtual string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Nombre: {0}\nApellido: {1}\nEdad: {2}\nDni: {3}\n", this.Nombre, this.Apellido, this.Edad, this.Dni);
            return str.ToString();
        }
        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni=dni;
        }
        public abstract bool ValidadAptitud();

    }
}
