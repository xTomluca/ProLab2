using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Comensal
    {
        string _apellido;
        string _nombre;

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
        }
        public string Apellido
        {
            get
            {
                return this._apellido;
            }
        }
        /*Se desea administrar las mesas para un evento donde cada una tendrá sus comensales:
        Comensal:  Clase abstracta con dos atributos privados(_nombre y _apellido). 
        El único constructor recibirá dos parámetros.Las propiedades Nombre y Apellido serán de sólo lectura.

        Método virtual y public Mostrar().Retornará el nombre y el apellido con el formato "Nombre Apellido".
        Se deberá utilizar el método Format de la clase String.*/
        public Comensal(string nombre, string apellido)
        {
            this._apellido = apellido;
            this._nombre = nombre;
        }
        public virtual string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Nombre: {0}\nApellido: {1}", this.Nombre,this.Apellido);
            return str.ToString();
        }

    }
}
