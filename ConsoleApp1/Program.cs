using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantPerfecto=0;
            int num=0;
            int i = 0;
            int suma=0;
            while(cantPerfecto <= 4)
            {
                num++;
                for(i=1;i<num;i++)
                {
                    if ((num % i) == 0)
                    {
                        suma = suma + i;
                    }
                }
                if(num==suma)
                {
                    cantPerfecto++;
                    Console.WriteLine("Numero perfecto {0}: {1}", cantPerfecto, num);
                }
                suma = 0;
            }
            Console.ReadKey();
        }
    }
}
