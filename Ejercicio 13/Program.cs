using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
	class Program
	{
		static void Main(string[] args)
		{
			int num;
			string numStr;
			string bin;
			Console.WriteLine("Ingresa numero a convertir");
			numStr = Console.ReadLine();
			if (int.TryParse(numStr, out num))
			{
				bin = Conversor.DecimalBinario(num);
				Console.WriteLine("Numero en Binario: {0}", bin);
			}
			Console.ReadKey();
		}
	}
}
