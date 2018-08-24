using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int num=0;
            int error = 1;
            int promedio=0;
            int max= int.MinValue;
            int min=int.MaxValue;
            string numStr;

            for(i=0;i<10;i++)
            {
                Console.WriteLine("Ingrese numero: ");
                numStr= Console.ReadLine();
                if (int.TryParse(numStr, out num))
                {
                    if (Validacion.Validar(num, -100, 100))
                    {
                        if (num > max)
                            max = num;
                        if (num < min)
                            min = num;
                        promedio += num;
                    }
                    /*else
                    {
                        Console.WriteLine("ERROR!");
                        error = 0;
                        break;
                    }*/

                }
                else
                {
                    Console.WriteLine("ERROR!");
                    error = 0;
                    break;
                }
            }
            if(error==1)
            {
                promedio = promedio / 10;
                Console.WriteLine("\n\nMaximo numero: {0} \nMinimo numero: {1} \nPromedio total: {2}", max,min,promedio);
            }
            Console.ReadKey();
        }
    }
}
