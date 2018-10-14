using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class TryCatch
    {
        int num;
        int numero2;
        public static int MetodoExcepcion(string numStr, string numStr2)
        {
            int retorno = 0;
            try
            {
                int num = int.Parse(numStr);
                int num2 = int.Parse(numStr2);
                retorno = num / num2;
            }
            catch (DivideByZeroException excepcion)
            {
                throw excepcion;
            }
            return retorno;
        }
        public string Mostrar()
        {
            string retorno = string.Format("El numero es:  {0}",this.num);
            return retorno;
        }
        public TryCatch(string num1,string num2, string num3) : this(num3)
        {
            try
            {
                this.num = MetodoExcepcion(num1, num2);
            }
            catch(DivideByZeroException excepcion)
            {
                throw excepcion;
            }
        }
        public TryCatch(string numero)
        {
            try
            {
                this.numero2 = int.Parse(numero);
            }

            catch(DivideByZeroException ex)
            {
                throw (new UnaExcepcion(ex));
            }
           catch(OverflowException ex1)
           {
             throw (new UnaExcepcion(ex1));
           }
        }

    }
}
