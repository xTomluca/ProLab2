using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos : Prestamo
    {
        float porcentajeInteres;
        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }
        public PrestamoPesos(float monto, DateTime vencimiento,float interes) : base(monto,vencimiento)
        {
            this.porcentajeInteres = interes;
        }
        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres) : base(prestamo.Monto,prestamo.Vencimiento)
        {
            this.porcentajeInteres = porcentajeInteres;
        }
        public float CalcularInteres()
        {
            return (this.Monto * (this.porcentajeInteres/100));
        }
        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            if(nuevoVencimiento>this.Vencimiento)
            {
                DateTime vencimientoActual = this.Vencimiento;
                float interes = (nuevoVencimiento - vencimientoActual).Days;
                interes = (interes * 0.25F);
                this.monto = this.monto + (this.monto * (interes/100));
                this.Vencimiento = nuevoVencimiento;
            }
        }
        public override string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0}Porcentaje Interes:{1}\nInteres:{2}", base.Mostrar(), this.porcentajeInteres, this.Interes);
            return str.ToString();
        }
    }
}
