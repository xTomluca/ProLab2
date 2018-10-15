using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    public class EjercicioExcepcion : Exception
    {
        int num;
        public static int MetodoExcepcion(string numOne, string numTwo)
        {
            int num=0;
            try
            {
                num = int.Parse(numOne) / int.Parse(numTwo);
            }
            catch(DivideByZeroException exc)
            {
               throw new EjercicioExcepcion(exc);
            }
            return num;
        }
        public EjercicioExcepcion(Exception exception)
        {
            throw new ExcepcionPropia("Error en Constructor EjercioExcepcion",exception);
        }

    }
        public class ExcepcionPropia : Exception
        {
            public ExcepcionPropia(string message,Exception innerException) :base(message,innerException)
            {
                throw new MiExcepcion("Error en ExcepcionPropia",this);
            }

        }

        public class MiExcepcion : Exception
        {
            public MiExcepcion(string message,Exception innetException) : base (message,innetException)
            {
                throw this;
            }
        }
}
