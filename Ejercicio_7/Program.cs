using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia = 0;
            int mes = 0;
            int año=0;
            int añoItr=0;
            string diaStr;
            string mesStr;
            string añoStr;
            DateTime ahora = DateTime.Now;
            Console.WriteLine("Ingrese dia");
            diaStr = Console.ReadLine();
            Console.WriteLine("Ingrese mes");
            mesStr = Console.ReadLine();
            Console.WriteLine("Ingrese año");
            añoStr = Console.ReadLine();
            if((int.TryParse(diaStr,out dia))&& (int.TryParse(mesStr, out mes))&& (int.TryParse(añoStr, out año)))
            {
                añoItr = ahora.Year;
                //for()
                Console.WriteLine("AÑOS {0}", añoItr);
            }
            
            Console.ReadKey();
        }
    }
}
