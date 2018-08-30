using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    public class Calculadora
    {
        public static double calcular(double num1, double num2, char operador)
        {
            double resultado = 0;
            switch(operador)
            {
                case '+':
                    resultado = num1 + num2;
                    Calculadora.mostrar(resultado);
                    break;
                case '-':
                    resultado = num1 - num2;
                    Calculadora.mostrar(resultado);
                    break;
                case '*':
                    resultado = num1 * num2;
                    Calculadora.mostrar(resultado);
                    break;
                case '/':
                    if (Calculadora.validar(num2)==true)
                    {
                        resultado = num1 / num2;
                        Calculadora.mostrar(resultado);
                    }
                    break;
            }
            return resultado;
        }
        public static bool validar(double num2)
        {
            if(num2>0)
            {
                return true;
            }
            return false;
        }
        public static void mostrar(double resultado)
        {
            Console.WriteLine("Resultado: {0}",resultado);
            Console.ReadKey();
        }
    }
}
