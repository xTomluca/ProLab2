using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            string numOne="";
            string numTwo = "";
            Console.WriteLine("Numero uno:");
            numOne = Console.ReadLine();
            Console.WriteLine("Numero Dos:");
            numTwo = Console.ReadLine();
            try
            {
                EjercicioExcepcion.MetodoExcepcion(numOne, numTwo);
            }
            catch(MiExcepcion e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("-----");
                Console.WriteLine(e.InnerException);
            }
            Console.ReadKey();
        }
    }
}
