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
            int i=0;
            int j = 0;
            int suma=0;
            while(cantPerfecto < 4)
            {
                i++;
                for(j=1;j<=i;j++)
                {
                    if ((i % j) == 0)
                    {
                        suma = suma + j;
                    }
                }
                if(i==suma)
                {
                    Console.WriteLine("PERFECTO {0}",i);
                    cantPerfecto++;
                }
                suma = 0;
            }
        }
    }
}
