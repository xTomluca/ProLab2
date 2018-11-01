using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_57
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Jose", "Tester");
            Persona.Guardar(p);
            Console.WriteLine(p.ToString());
            Console.ReadKey();
        }
    }
}
