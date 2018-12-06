using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   //Crear un constructor que reciba y asigne el/los atributos de la misma.
   //La clase debe ser abstracta.
   //Crear un método abstracto llamado MostrarArchivos que retorne void.

    public abstract class Almacenador
    {
        public int capacidad;
        public delegate void MostarInfo(string s);
        public event MostarInfo MostrarInfo;

        public void DispararEvento(Archivo a)
        {
            this.MostrarInfo.Invoke(a.ToString());
        }
        public int Capacidad
        {
            get
            {
                return this.capacidad;
            }
            set
            {
                this.capacidad = value;
            }
        }

        public Almacenador(int capacidad)
        {
            this.Capacidad = capacidad;
        }

        public abstract void MostrarArchivo();


    }
}
