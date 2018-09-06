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
            Producto pepe2 = new Producto("Merca", "040404", 11);
            string str2 = pepe2.MostrarProducto(pepe2);
            if (pepe2 != "Merca2") 
                Console.WriteLine("{0}", str2);

            Console.ReadKey();

        }
    }
}
