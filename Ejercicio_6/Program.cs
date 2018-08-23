using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int año;
            string añoStr;
            Console.WriteLine("Ingrese año");
            añoStr = Console.ReadLine();
            if(int.TryParse(añoStr,out año))
                if ((año%4)==0)
                {
                    if(((año % 100) == 0) && ((año % 400) != 0))
                    {
                        Console.WriteLine("NO ES BISIESTO");
                    }
                    else
                    {
                         Console.WriteLine("Es bisiesto {0}", año);
                    }
                    //if (((año % 100) == 0) && ((año % 400) == 0))
                      //  Console.WriteLine("Es bisiesto {0}", año);
                }
                else
                    Console.WriteLine("NO ES BISIESTO");
            Console.ReadKey();
        }
    }
}
