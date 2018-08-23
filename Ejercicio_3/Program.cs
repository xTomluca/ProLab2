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
            int i,j;
            int num;
            int primo = 0;
            string numStr;
            Console.WriteLine("INGRESE NUMERO");
            numStr = Console.ReadLine();
            if(int.TryParse(numStr, out num))
            {
                for(i=1;i<=num;i++)
                {
                    for (j = 1; j <= i; j++)
                    {
                        if ((i % j) == 0)
                        {
                            primo++;
                        }
                        
                    }
                    if (primo == 2)
                        Console.WriteLine("ES PRIMO: {0}", i);
                    primo = 0;
                }

            }
            Console.Read();

        }
    }
}
