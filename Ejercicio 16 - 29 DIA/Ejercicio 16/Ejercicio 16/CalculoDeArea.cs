using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double area=0;
            area = lado * lado;
            return area;
        }
        public static double Calculartriangulo(double altura, double nbase)
        {
            double area=0;
            area = (nbase * altura) / 2;
            return area;
        }
        public static double CalcularCirculo(double perimetro)
        {
            double area = 0;
            double pi = 3.14;
            double radio = 0;
            radio = perimetro / (pi * 2);
            area = pi * Math.Pow(radio, 2);
            return area;
        }
    }
}
