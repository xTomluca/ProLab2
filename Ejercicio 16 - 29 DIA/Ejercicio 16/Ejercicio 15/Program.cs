using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1Str;
            string num2Str;
            double num1;
            double num2;
            char operador;

            Console.WriteLine("Ingrese num 1: ");
            num1Str = Console.ReadLine();
            Console.WriteLine("Ingrese num 2: ");
            num2Str = Console.ReadLine();
            Console.WriteLine("Ingrese operador: ");
            operador = Console.ReadKey().KeyChar;
            if(double.TryParse(num1Str,out num1)&& double.TryParse(num2Str, out num2))
                Calculadora.calcular(num1, num2, operador);
            Console.ReadKey();
        }
    }
}
