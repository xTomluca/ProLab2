using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1TLS
{
    class Ejercio_1
    {
        static void Main(string[] args)
        {
            string numStr;
            int promedio=0,num,i,max=int.MinValue,min= int.MaxValue;
            Console.Title="Ejercicio Nro 1";
            //
            for(i=0;i<5;i++)
            {
                Console.WriteLine("INGRESE NUMERO");
                numStr = Console.ReadLine();
                num = int.Parse(numStr);
                if (max < num)
                    max = num;
                if (min > num)
                    min = num;
                promedio = promedio + num;
            }
            promedio = promedio / 5;
            Console.WriteLine();
            Console.WriteLine("PROMEDIO: {0}", promedio);
            Console.WriteLine();
            Console.WriteLine("MINIMO: {0}",min);
            Console.WriteLine();
            Console.WriteLine("MAXIMO: {0}",max);
            Console.Read();
        }
    }

}
