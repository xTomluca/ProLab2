﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            if(valor>=min&&valor<=max)
            {
                return true;
            }
            return false;
        }
    }
}
