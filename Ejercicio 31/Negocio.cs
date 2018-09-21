using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Negocio
    {
        PuestoAtencion caja;
        Queue<Cliente> clientes;
        string nombre;

        Cliente Cliente
        {
            get
            {
                Cliente auxCliente = new Cliente();
                return auxCliente;
            }
            set
            {
                    
            }

        }
        Negocio()
        {
            caja = Caja1;
        }
    }
}
