using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class UnaExcepcion : Exception
    {
        public UnaExcepcion(Exception exception)
        {
            Console.WriteLine("{0}", exception.Message);
        }

    }
}
