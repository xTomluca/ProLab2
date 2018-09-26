using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_29;
namespace Test_Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo e = new Equipo(5, "Moreno FC");
            Jugador j1 = new Jugador(39113917, "Tomas", 10, 2);
            Jugador j2 = new Jugador(11391129, "Luca", 8, 3);
            Jugador j3 = new Jugador(15445284, "Luis", 4, 3);
            Jugador j4 = new Jugador(15445284, "Clon", 2, 3);
            Jugador j5 = new Jugador(11391442, "Matias", 12, 3);
            Jugador j6 = new Jugador(11291139, "Wos", 14, 3);
            Jugador j7 = new Jugador(14725836, "Doki", 27, 3);
            DateTime fecha = new DateTime(1995,08,11);
            DirectorTecnico d1 = new DirectorTecnico("Sampoaoli", fecha);
            Console.WriteLine(d1.MostrarDatos());
            if (e + j1)
                Console.WriteLine("Jugador creado");
            if (e + j2)
                Console.WriteLine("Jugador creado");
            if (e + j3)
                Console.WriteLine("Jugador creado");
            if (e + j4)
                Console.WriteLine("Jugador creado");
            else
                Console.WriteLine("Jugador DUPLICADO");
            if (e + j5)
                Console.WriteLine("Jugador creado");
            if (e + j6)
                Console.WriteLine("Jugador creado");
            if (e + j7)
                Console.WriteLine("Jugador creado");
            Console.Write("\n");
            Console.WriteLine(e.Mostrar());
            Console.Write("\n");
            foreach (Jugador aux in e.jugadores)
            {
                Console.WriteLine(aux.MostrarDatos());
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
