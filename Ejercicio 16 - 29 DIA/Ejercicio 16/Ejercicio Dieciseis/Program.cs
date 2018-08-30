using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Dieciseis
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1= new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();
            alumno1.name = "Tomas";
            alumno1.lastName = "Suarez";
            alumno1.legajo = 1;
            alumno1.Estudiar(1, 5);
            alumno1.CalcularFinal();
            alumno1.mostrar();
            Console.WriteLine();
            alumno2.name = "Pepe";
            alumno2.lastName = "Asddd";
            alumno2.legajo = 2;
            alumno2.Estudiar(5, 6);
            alumno2.CalcularFinal();
            alumno2.mostrar();
            Console.WriteLine();
            alumno3.name = "Jose";
            alumno3.lastName = "Broh";
            alumno3.legajo = 3;
            alumno3.Estudiar(5, 9);
            alumno3.CalcularFinal();
            alumno3.mostrar();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
