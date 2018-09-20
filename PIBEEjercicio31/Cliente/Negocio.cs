using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio31
{
    public class Negocio
    {
        private int numeroActual;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get
            {
                Cliente auxiliar = new Cliente(numeroActual);
                return Cliente;
            }
            set
            {
                Negocio auxiliarNegocio = new Negocio();
                bool flag;
                Cliente auxiliar = new Cliente(numeroActual, nombre);
                foreach(Cliente auxiliarDos in clientes)
                {
                    if(auxiliar == auxiliarDos)
                    {
                        break;
                    }
                    else
                    {
                        flag=auxiliar + auxiliarNegocio;
                    }
                }
            }
        }

        private Negocio()
        {
             
        }

        public Negocio(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
