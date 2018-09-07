using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Producto;


namespace Producto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Producto pepe = null;
            //string str = pepe.MostrarProducto(pepe);
            //Console.WriteLine("{0}", str);
            //            if(pepe is null)
            //          {
            //          Console.WriteLine("asdasd");
            //        }
            /* string str2 = pepe2.MostrarProducto(pepe2);
             if (pepe2 != "Merca2") 
                 Console.WriteLine("{0}", str2);
                 */
            
            Producto pepe1 = new Producto("Mez4r23c1a", "040404", 11);
            Producto pepe2 = new Producto("Mfe124rc2a", "040404", 11);
            Producto pepe3 = new Producto("Masercwsasd3a", "040404", 11);
            Producto pepe4 = new Producto("Mererqwec4a", "040404", 11);
            Estante estanteriaPepe = new Estante(10, 5);
            //for(i=0;estanteriaPepe.GetProductos()
            //estanteriaPepe.GetProductos()
            Console.ReadKey();

        }
    }
}
