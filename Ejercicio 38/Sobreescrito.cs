using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_38
{
    public abstract class Sobreescrito
    {
        protected string miAtributo;
        public abstract string MiPropiedad
        {
            get;
        }
        public Sobreescrito()
        {
            this.miAtributo = "Probar abstract";
        }
        public override string ToString()
        {
            return "River plate Pechitooo!";
        }
        public override bool Equals(object objeto)
        {
            if(objeto is Sobreescrito)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return 1142510187;
        }
        public abstract string MiMetodo();
    }
}
