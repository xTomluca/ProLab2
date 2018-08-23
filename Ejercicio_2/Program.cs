using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Ejercicio_2
    {
        static void Main(string[] args)
        {
            int cuadrado = 0;
            int cubo = 0;
            int num = 0;
            string numStr;
            Console.Title = "Ejercicio Nro 2";
            Console.WriteLine("Escriba un numero");
            numStr = Console.ReadLine();
            num = int.Parse(numStr);
            if (num > 0)
            {
                cuadrado = (int)Math.Pow(num, 2);
                cubo = (int)Math.Pow(num, 3);

                Console.WriteLine("CUADRADO {0}", cuadrado);
                Console.WriteLine("CUBO {0}", cubo);
            }
            Console.Read();
        }
    }
}
