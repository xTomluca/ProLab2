using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
	public class Conversor
	{
		public static string DecimalBinario(int d)//. Convierte un número de decimal a binario. 
		{
			string bin = "";
			string retorno ="";
			int i;
			while (d > 0)
			{
				d = d / 2;
				Console.WriteLine("Numero {0}", d);
				if (d % 2 == 0)
					bin += '0';
				else
				{
					bin += '1';
				}	
			}
			for (i = bin.Length-1; i >= 0; i--)
			{
				retorno +=bin[i];
			}
			return retorno;
		}

		//double BinarioDecimal(string). Convierte un número binario a decimal.
	}
}
