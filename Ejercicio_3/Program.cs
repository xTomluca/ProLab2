using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Ejercicio_3
    {
        static void Main(string[] args)
        {
            int i;
            int num;
            string numStr;
            Console.WriteLine("INGRESE NUMERO");
            numStr = Console.ReadLine();
            if(int.TryParse(numStr, out num))
            {
                for(i=0;i<=num;i++)
                {
                    if((i % num) == 0)
                    {
                        Console.WriteLine("PRIMOS : {0}", i);
                    }
                }

            }
            Console.Read();

        }
    }
}
