using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosPersonales;

namespace EntidadFinanciera
{
    public class Financiera
    {
        List<Prestamo> listaDePrestamos;
        string razonSocial;
        public float InteresesEnDolares
        {
            get
            {
                return this.CalcularInteresGanado(TipoDePrestamo.Dolares);
            }
        }
        public float InteresesEnPesos
        {
            get
            {
                return this.CalcularInteresGanado(TipoDePrestamo.Pesos);
            }
        }
        public float InteresesTotales
        {
            get
            {
                return this.CalcularInteresGanado(TipoDePrestamo.Todos);
            }
        }
        public List<Prestamo> ListaDePrestamos
        {
            get
            {
                return this.listaDePrestamos;
            }
        }
        public string RazonSocial
        {
            get
            {
                return this.razonSocial;
            }
        }
        private Financiera()
        {
            this.listaDePrestamos = new List<Prestamo>();
        }
        public Financiera(string razonSocial) : this()
        {
            this.razonSocial = razonSocial;
        }
        public static string Mostrar(Financiera financiera)
        {
            return (string)financiera;
        }
        public static explicit operator string(Financiera financiera)
        {
            StringBuilder str = new StringBuilder();
            financiera.OrdenarPrestamos();
            str.AppendFormat("\nRazon Social: {0}\nIntereses en Dolares: {1}\nIntereses en Pesos: {2}\nIntereses Totales: {3}\nLista de Prestamos:\n"
            ,financiera.RazonSocial,financiera.InteresesEnDolares,financiera.InteresesEnPesos, financiera.InteresesTotales);
            foreach(Prestamo aux in financiera.ListaDePrestamos)
            {
                if(aux is PrestamoPesos)
                {
                    str.AppendLine(((PrestamoPesos)aux).Mostrar());
                    str.AppendLine("");
                }
                else if (aux is PrestamoDolar)
                    str.AppendLine(((PrestamoDolar)aux).Mostrar());
                str.AppendLine("");
            }
            return str.ToString();
        }
        public void OrdenarPrestamos()
        {
            this.ListaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }
        /*        e.CalcularInteresGanado: Método privado que recibe un Enumerado de tipo TipoDePrestamo y
        retornará el valor equivalente a la suma de intereses entre todos los préstamos(invocar a la
        propiedad Interes de la clase PrestamoPesos o PrestamoDolar según el tipo de préstamo
        evaluado).*/
        private float CalcularInteresGanado(TipoDePrestamo tipoPrestamo)
        {
            float interesGanado = 0;
            switch (tipoPrestamo)
            {
                case TipoDePrestamo.Pesos:
                    foreach(Prestamo aux in this.ListaDePrestamos)
                    {
                        if(aux is PrestamoPesos)
                        {
                            interesGanado = interesGanado + ((PrestamoPesos)aux).Interes;
                        }
                    }
                    break;
                case TipoDePrestamo.Dolares:
                    foreach (Prestamo aux in this.ListaDePrestamos)
                    {
                        if (aux is PrestamoDolar)
                        {
                            interesGanado = interesGanado + ((PrestamoDolar)aux).Interes;
                        }
                    }
                    break;
                case TipoDePrestamo.Todos:
                    foreach (Prestamo aux in this.ListaDePrestamos)
                    {
                        if (aux is PrestamoPesos)
                        {
                            interesGanado = interesGanado + ((PrestamoPesos)aux).Interes;
                        }
                        if (aux is PrestamoDolar)
                        {
                            interesGanado = interesGanado + ((PrestamoDolar)aux).Interes;
                        }
                    }
                    break;
            }
            return interesGanado;
        }

        /* 11. Sobrecarga de operadores:
         a.Se deberán sobrecargar el operador ''+'' para que permitirá cargar un préstamo a la financiera
         */
        public static bool operator ==(Financiera financiera, Prestamo prestamo)
        {
            foreach(Prestamo aux in financiera.ListaDePrestamos)
            {
                if (aux == prestamo)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }
        /*b.El operador ''=='' que será utilizado para validar que el que un mismo préstamo no sea cargado
         más de una vez en la financiera.*/
        public static Financiera operator +(Financiera financiera,Prestamo prestamoNuevo)
        {
            if(financiera !=prestamoNuevo)
            {
                financiera.listaDePrestamos.Add(prestamoNuevo);
            }
            return financiera;
        }
    }
}
