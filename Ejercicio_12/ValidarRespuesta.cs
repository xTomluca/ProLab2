﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
	public class ValidarRespuesta
	{
		public static bool validaS_N(char c)
		{
			if (c== 's' || c == 'S')
			{
				return true;
			}
			return false;
		}
	}
}
