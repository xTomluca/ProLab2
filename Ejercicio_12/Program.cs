using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
	class Program
	{
		static void Main(string[] args)
		{
			char c;
			string s;
			string numStr;
			int num = 0;
			int acumulador = 0;
			bool continuar=true;
			while (continuar == true)
			{
				Console.WriteLine("Ingrese numero a sumar: ");
				numStr = Console.ReadLine();
				if (int.TryParse(numStr, out num))
				{
					acumulador += num;
					Console.WriteLine("Total actual: {0}", acumulador);
					Console.WriteLine();
					Console.WriteLine("Continuar S/N");
					s = Console.ReadLine();
					if (char.TryParse(s, out c))
					{
						continuar = ValidarRespuesta.validaS_N(c);
					}
					else
						continuar = false;
				}
				
			}
			Console.ReadKey();

		}
	}
}
