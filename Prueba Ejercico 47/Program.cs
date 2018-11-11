using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_47_EDIT;
namespace Prueba_Ejercico_47
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
 * iii. Generar la clase EquipoFutbol que herede de Equipo. 
 * iv. Generar la clase EquipoBasquet que herede de Equipo. 



    b. Crear un proyecto del tipo Console:

    i. Crear un programa que genere 2 torneos, uno de Futbol y otro de Basquet. 
    ii. Crear 3 equipos de cada tipo. 
    iii. Agregar los equipos en tantos torneos como se pueda. 
    iv. Llamar al método Mostrar de Torneo e imprimir su retorno por pantalla. 
    v. Llamar al menos 3 veces a la propiedad JugarPartido de cada torneo e imprimir su respuesta por pantalla. 
 */
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Torneo Basquet");
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Torneo Futbol");
            EquipoBasquet eb1 = new EquipoBasquet("Defensores BASQUET",new DateTime(1995,08,11));
            EquipoBasquet eb2 = new EquipoBasquet("Los Indios BASQUET", new DateTime(1963, 09, 05));
            EquipoBasquet eb3 = new EquipoBasquet("Padua BASQUET", new DateTime(1961, 02, 25));
            EquipoFutbol ef1 = new EquipoFutbol("Defensores FCLUB", new DateTime(1998, 07, 11));
            EquipoFutbol ef2 = new EquipoFutbol("Los Indios FCLUB", new DateTime(1988, 05, 11));
            EquipoFutbol ef3 = new EquipoFutbol("Padua BASQUET FCLUB", new DateTime(1978, 03, 11));
            torneoBasquet += eb1;
            torneoBasquet += eb2;
            torneoBasquet += eb3;

            torneoFutbol += ef1;
            torneoFutbol += ef2;
            torneoFutbol += ef3;

            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(torneoFutbol.Mostrar());
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.ReadKey();
            Console.Clear();



        }
    }
}
