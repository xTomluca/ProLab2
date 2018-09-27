using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio nº 38";
            Sobreescrito sobrecarga = new SobreSobreescrito();
            Sobreescrito sobrecarga2 = new SobreSobreescrito();
            Console.WriteLine(sobrecarga.ToString());
            string objeto = "River plate Pechitooo!";
            Console.Write(sobrecarga.MiPropiedad);
 
             Console.WriteLine("-------------------------------");
            Console.Write("Comparacion Sobrecargas con String: ");
            Console.WriteLine(sobrecarga.Equals(objeto));

            Console.WriteLine("-------------------------------");
            Console.WriteLine(sobrecarga.GetHashCode());

            Console.ReadKey();
        }
    }
}
