using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string dibujo="";
            //En el Main, crear un bolígrafo de tinta azul(ConsoleColor.Blue) y una cantidad inicial de tinta
            //de 100 y otro de tinta roja(ConsoleColor.Red) y 50 de tinta
            Boligrafo azul = new Boligrafo();
            Boligrafo rojo = new Boligrafo();
            azul.color = ConsoleColor.Blue;
            azul.tinta = 100;
            rojo.color = ConsoleColor.Red;
            rojo.tinta = 50;
            if (rojo.Pintar(10, out dibujo) == true)
            {
                Console.WriteLine("{0}\n Tinta actual: {1}", dibujo,rojo.tinta);
            }
            Console.ReadKey();
        }
    }
}
