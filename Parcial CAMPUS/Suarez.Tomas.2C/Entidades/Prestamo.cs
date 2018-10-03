using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public abstract class Prestamo
    {
        protected float monto;
        protected DateTime vencimiento;

        public float Monto
        {
            get
            {
                return this.monto;
            }
        }
        public DateTime Vencimiento
        {
            set
            {
                if (this.vencimiento < value)
                    this.vencimiento = value;
                else
                    this.vencimiento = DateTime.Now;
            }
            get
            {
                return this.vencimiento;
            }
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Monto: {0}\n", this.Monto);
            str.AppendFormat("Vencimiento: {0}\n", this.Vencimiento.ToString());
            return str.ToString();
        }

        public static int OrdenarPorFecha(Prestamo p1,Prestamo p2)
        {
            if (p1.Vencimiento > p2.Vencimiento)
                return 1;
            else if (p1.Vencimiento < p2.Vencimiento)
                return -1;
            else
                return 0;
        }
        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            this.vencimiento = vencimiento;
        }

    }
}
