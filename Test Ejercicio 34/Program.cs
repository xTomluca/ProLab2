using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_34;

namespace Test_Ejercicio_34
{
    class Program
    {
        static void Main(string[] args)
        {
            List<VehiculoTerrestre> listaVehiculos = new List<VehiculoTerrestre>();
            Automovil a1 = new Automovil(4, 4, 5, VehiculoTerrestre.Colores.Azul, 5);
            listaVehiculos.Add(a1);
            Console.ReadKey();
            Console.WriteLine(a1.Mostra());
            Moto m1 = new Moto(2, 0, VehiculoTerrestre.Colores.Negro, 150);
            listaVehiculos.Add(m1);
            Console.ReadKey();
            Console.WriteLine(m1.Mostra());
            Camion c1 = new Camion(8, 2, VehiculoTerrestre.Colores.Blanco, 8, 1500);
            listaVehiculos.Add(c1);
            Console.ReadKey();
            Console.WriteLine(c1.Mostra());
            Console.ReadKey();
        }
    }
}
