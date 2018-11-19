using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_04
{
    public class TrackingIdRepetidoException : Exception
    {
        public TrackingIdRepetidoException(string mensaje) : base(mensaje)
        {

        }
        public TrackingIdRepetidoException(string mensaje, Exception inner) : base(mensaje,inner)
        {

        }

    }
}
