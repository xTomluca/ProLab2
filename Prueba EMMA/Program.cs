using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_EMMA
{
    class Program
    {
        static void Main(string[] args)
        {


            //TIPOS DE DATOS
            
            // DECLARO UN INT ES NUMERO SIN COMA
            int numero = 1;
            int numero2 = 10;
            int suma = numero + numero2;

            // FLOAT ES CON COMA
            float numeroConComa = 1.5F;

            // CADENA DE CARACTERES
            string cadena = "Esto es una prueba de String 14548";



            // CARACTER
            char nombreDeLaVariable = 'a';
            char nombreDeVariable2 = 'b';


            // CON EL + UNIS LOS CHAR O STRING    SE LE AGREGA .ToString(); PARA CONVERTIR DE CHAR A STRING
            // \n: SIRVE PARA DAR ENTER
            string deChars = string.Format("{0} {1}\n\n\n{2}", nombreDeLaVariable.ToString(), nombreDeVariable2.ToString(), cadena);


            // MUUESTRA POR PANTALLA
            Console.WriteLine("Este es el numero: {0}",numero);
            
            //MUESTRA POR PANTALLA EL FLOAT
            Console.WriteLine("Este es el Float: {0}",numeroConComa);

            //Muestra por pantalla String
            Console.WriteLine(cadena);
            Console.WriteLine();
            Console.WriteLine(deChars);
            Console.WriteLine("El primer numero es {0}\nEl segundo Numero es: {1}\nEl Resultado es: {2}",numero,numero2,suma);

            // COMO MUESTRO LO QUE ESCRIBO
            Console.WriteLine("INTRODUSCA UN STRING PARA PROBAR");

            string obtenidoPantalla;
            obtenidoPantalla =  Console.ReadLine();



            Console.WriteLine("MUESTRO EL STRING:{0}",obtenidoPantalla);

            // SUMA DESDE CONSOLA VALOR INGRESADOS POR EL USUARIO
            int numeroASumar1;
            int numeroASumar2;
            int resultado;

            Console.WriteLine("INGRESE EL PRIMER NUMERO A MULTIPLICAR");
            //numeroASumar1 = int.Parse(Console.ReadLine()); // ESTO CAPTURA UN NUMERO Y LO CONVIERTE CON EL PARSE A ENTERO


            string numeroASumarString;

            numeroASumarString = Console.ReadLine(); // OBTENGO EL NUMERO EN FORMATO STRING

            numeroASumar1 = int.Parse (numeroASumarString); // PASO EL NUMERO STRING A UN NUMERO ENTERO


            Console.WriteLine("INGRESE EL SEGUNDO NUMERO A MULTIPLICAR");
            numeroASumar2 = int.Parse(Console.ReadLine()); // ESTO CAPTURA UN NUMERO Y LO CONVIERTE CON EL PARSE A ENTERO
            resultado = numeroASumar1 * numeroASumar2;

            Console.WriteLine("Este es el resultaod de la musltriplaksdjhiasid : {0}", resultado);
            int resultadoIf;
            int numeroIf;

            Console.WriteLine("ACA VAMOS A PROBAR EL IF");
            Console.WriteLine("INGRESE EL PRIEMRO NUMERO DEL IF");
            string numeroIfString = Console.ReadLine(); // OBTENGO EL NUMERO EN FORMATO STRING

            numeroIf = int.Parse(numeroIfString); // PASO EL NUMERO STRING A UN NUMERO ENTERO A TRAVES DE  "PARSE"

            Console.WriteLine("INGRESE EL SEGUNDO NUMERO DEL IF");
            int numeroIf2;

            string numeroIf2String = Console.ReadLine(); // OBTENGO EL NUMERO EN FORMATO STRING

            numeroIf2 = int.Parse(numeroIf2String); // PASO EL NUMERO STRING A UN NUMERO ENTERO A TRAVES DE  "PARSE"

            if(numeroIf > numeroIf2) // SI TAL COSA // PARA QUE SUCEDA DEBE SER VERDADERA LA CONDICION
            {
                resultadoIf = numeroIf - numeroIf2; // PASA ESTO
            }
            else // SI NO PASA ESTO
            {
                resultadoIf = numeroIf + numeroIf2;
            }
            Console.WriteLine("El resultado del if es: {0}", resultadoIf);




            // OBTIENE UN VALOR LO PODES USAR O SIMPLEMENTE PARA PAUSAR
            Console.ReadKey();


        }
    }
}
