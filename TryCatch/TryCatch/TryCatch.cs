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
        public TryCatch(string num1,string num2)
        {
            try
            {
                MetodoExcepcion(num1, num2);
            }
            catch(DivideByZeroException excepcion)
            {
                throw excepcion;
            }
        }
        public TryCatch()
        {
            try
            { 
            }

            catch(Exception c)
            {
                throw (new Exception("ERROR"));
            }
        }

    }
}
