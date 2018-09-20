using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    
    class Cliente
    {
        string nombre;
        int numero;

        string Nombre
        {
            set
            {   
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        int Numero
        {
            get
            {
                return numero;
            }
        }
        Cliente(int numero)
        {
            this.numero = numero;
        }
        Cliente(int numero,string nombre)
        {
            this.Nombre = nombre;
            this.numero = numero;
        }
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if (c1.Nombre == c2.Nombre)
                return true;
            return false;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}
