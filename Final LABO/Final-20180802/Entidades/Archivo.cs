using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Archivo
    {
        public string nombre;
        public string contenido;

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

        public string Contenido
        {
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }

        public Archivo(string nombre, string contenido)
        {
            this.Nombre = nombre;
            this.Contenido = contenido;
        }
        public override string ToString()
        {
            return string.Format("Nombre: {0} - Contenido: {1}\n", this.Nombre, this.Contenido);
        }

        public static explicit operator string(Archivo archivo)
        {
            return archivo.ToString();
        }

    }
    //Sobreescribir el método ToString para mostrar los valores de sus atributos.
    //Utilizar String.Format.
    //Agregar el operador explicit para retornar el contenido del archivo.
    
    
}
