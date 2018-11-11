using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    public class Contabilidad<T,U> where T : Documento where U : Documento, new()
    {
        List<T> egresos;
        List<U> ingresos;
        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }
        public static Contabilidad<T, U> operator +(Contabilidad<T,U> contabilidad,T t)
        {
            contabilidad.egresos.Add(t);
            return contabilidad;
        }
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> contabilidad, U u)
        {
            contabilidad.ingresos.Add(u);
            return contabilidad;
        }
        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(T aux in this.egresos)
            {
                stringBuilder.AppendFormat("Egreso: {0}\n",aux.documento);
            }
                stringBuilder.AppendLine("<------------------------------------->");
            foreach (U aux in this.ingresos)
            {
                stringBuilder.AppendFormat("Ingreso: {0}\n", aux.documento);
            }
            return stringBuilder.ToString();
        }
    }
}
