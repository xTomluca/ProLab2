using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ClaveInvalidaException : Exception
    {
        public ClaveInvalidaException(string message) : base(message)
        {

        }
    }
}
