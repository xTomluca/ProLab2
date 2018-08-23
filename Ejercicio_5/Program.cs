using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string numStr;
            int num=0;
            int numAnt  = 0;
            int numPos = 0;
            //int centros=0;
            int i;
            int j;
            Console.WriteLine("Ingrese numero: ");
            numStr = Console.ReadLine();
            if(int.TryParse(numStr,out num))
            {
                for(i=0;i<num;i++)
                {
                    for(j=(i-1);j>0;j--)
                    {
                        numAnt = numAnt + j;                        
                    }
                    for(j=(i+1); j < num; j++)
                    {
                        numPos = numPos + j;
                        if(numAnt==numPos && numPos>0 && numAnt>0)
                        {
                            Console.WriteLine("Centro : {0}", i);
                        }
                    }
                    numAnt = 0;
                    numPos=0;
                }
                Console.ReadKey();
            }

        }
    }
}
