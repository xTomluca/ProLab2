using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico_31
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get
            {
                if(clientes.Count>0)
                    return this.clientes.Dequeue();
                return null;
            }
            set
            {
                this.clientes.Enqueue(value);
            }
        }

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }
        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente aux in n.clientes)
            {
                if (aux.Nombre == c.Nombre)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        public static bool operator ~(Negocio n)
        {
            if (n.clientes is null)
                return false;
            Cliente cli = n.Cliente;
            if (n.caja.Atender(cli))
                return true;
            return false;
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            if(n!=c)
            {
                n.Cliente = c;
                return true;
            }
            return false;

        }
        
    }
}
