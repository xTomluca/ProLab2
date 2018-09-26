using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercico_31;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            PuestoAtencion.Puesto puestoAtencion = PuestoAtencion.Puesto.Caja2;
            PuestoAtencion puesto = new PuestoAtencion(puestoAtencion);
            Cliente c2 = new Cliente(1, "Jose");
            Cliente c1 = new Cliente(2, "Martin");
            Cliente c3 = new Cliente(3, "Pedro");
            Negocio n1 = new Negocio("LA CONTINENTAL");
            if(n1+c1&& n1 + c2 && n1 + c3)
            {
                if((~n1)==true)
                {
                    Console.WriteLine("{0}",c1.Numero);
                }
                if ((~n1) == true)
                {
                    Console.WriteLine("{0}", c2.Numero);
                }
                if ((~n1) == true)
                {
                    Console.WriteLine("{0}", c3.Numero);
                }
                if ((~n1) == true)
                {
                }
            }
            Console.ReadKey();

        }
    }
}
