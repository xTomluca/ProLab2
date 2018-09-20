using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio31
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        private string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        private int Numero
        {
            get
            {
                return numero;
            }
        }

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero,string nombre)
        {
            this.numero = numero;
            Nombre = nombre;
        }

        public static bool operator ==(Cliente primerCliente,Cliente segundoCliente)
        {
            if(primerCliente.Numero == segundoCliente.Numero)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Cliente primerCliente,Cliente segundoCliente)
        {
            return !(primerCliente == segundoCliente);
        }

        public static bool operator +(Cliente c,Negocio n)
        {
            if(c.Numero == n.Cliente.Numero)
            {
                return false;
            }
            else
            {
                n.Cliente = c;
            }
            return true;
        }
    }
}
