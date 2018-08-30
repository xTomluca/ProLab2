using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double resultado = 0;
            string num1Str;
            string num2Str;
            string opcion;
            int option = 0;
            Console.WriteLine("OPCION:\n1)Calcular Cuadrado \n2) Calcular Triangulo \n3)Calcular Circulo");
            opcion = Console.ReadLine();
            if(int.TryParse(opcion,out option))
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Ingrese lado: ");
                        num1Str = Console.ReadLine();
                        if (double.TryParse(num1Str, out num1))
                        {
                            resultado = CalculoDeArea.CalcularCuadrado(num1);
                            Console.WriteLine("Resultado: {0}", resultado);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingrese altura:");
                        num1Str = Console.ReadLine();
                        Console.WriteLine("Ingrese base: ");
                        num2Str = Console.ReadLine();
                        if (double.TryParse(num1Str, out num1)&& double.TryParse(num2Str, out num2))
                        {
                            resultado=CalculoDeArea.Calculartriangulo(num1, num2);
                            Console.WriteLine("Resultado: {0}", resultado);
                        }

                        break;
                    case 3:
                        Console.WriteLine("Ingrese perimetro: ");
                        num1Str = Console.ReadLine();
                        if (double.TryParse(num1Str, out num1))
                        {
                            resultado = CalculoDeArea.CalcularCirculo(num1);
                            Console.WriteLine("Resultado: {0}", resultado);
                        }
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
