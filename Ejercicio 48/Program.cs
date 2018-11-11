using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();
            Factura fc1 = new Factura(123);
            Factura fc2 = new Factura(456);
            Factura fc3 = new Factura(789);
            Recibo r1 = new Recibo(1);
            Recibo r2 = new Recibo(2);
            Recibo r3 = new Recibo(3);

            contabilidad += fc1;
            contabilidad += fc2;
            contabilidad += fc3;
            contabilidad += r1;
            contabilidad += r2;
            contabilidad += r3;

            Console.WriteLine(contabilidad.Mostrar());
            Console.ReadKey();

        }
    }
}
