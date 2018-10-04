using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Menor : Comensal
    {
        public enum eMenu
        {
            Milanesa,
            Hamburguesa
        }
        eMenu menu;
        public eMenu Menu
        {
            set
            {
                this.menu = value;
            }
            get
            {
                return this.menu;
            }
        }
        private Menor(string nombre, string apellido) : base(nombre, apellido)
        {

        }
        public Menor(string nombre, string apellido, eMenu menu) : this(nombre,apellido)
        {
            this.menu = menu;
        }
        public override string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0}\nMenu: {1}", base.Mostrar(), this.menu.ToString());
            return str.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public static bool operator ==(Menor m1, Menor m2)
        {
            if (m1.Nombre == m2.Nombre && m1.Apellido == m2.Apellido && m1.Menu == m2.Menu)
                return true;
            return false;
        }
        public static bool operator !=(Menor m1, Menor m2)
        {
            return !(m1 == m2);
        }
        public override bool Equals(object obj)
        {
            if (obj is Menor)
                if((Menor)obj == this)
                    return true;
            return false;
        }

        /*Menor: Clase pública que hereda de Comensal con un atributos propios(_menu). 
         * Contará con dos constructores, uno privado y otro público donde recibe el menú.
         * Implementar el método mostrar(). Retornará toda la información del Menor.  
         * Contendrá el enumerado eMenu (Milanesa, Hamburguesa)
        Operadores:      • Dos Menores serán iguales si comparten nombre, apellido y menu.
        Sobreescribir:   • Método ToString() para que publique la información del Menor.
                             • Método Equals para que reutilice ==. */


    }
}
