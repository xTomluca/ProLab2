using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar : Prestamo
    {
        PeriodicidadDePagos periodicidad;
        public PrestamoDolar(float monto,DateTime vencimiento,PeriodicidadDePagos periodicidad) : base(monto,vencimiento)
        {
            this.periodicidad = periodicidad;
        }
        public PrestamoDolar(Prestamo prestamo,PeriodicidadDePagos periodicidad) : base(prestamo.Monto,prestamo.Vencimiento)
        {
            this.periodicidad = periodicidad;
        }
        public float Interes
        {
            get
            {
                return this.CalcularIntereses(); 
            }
        }
        public PeriodicidadDePagos Periodicidad
        {
            get
            {
                return this.periodicidad;
            }
        }
        private float CalcularIntereses()
        {
            switch(this.Periodicidad)
            {
                case PeriodicidadDePagos.Mensual:
                    return (this.Monto + (this.Monto * 0.25F));
                case PeriodicidadDePagos.Bimestral:
                    return (this.Monto + (this.Monto * 0.35F));
                case PeriodicidadDePagos.Trimestral:
                    return (this.Monto + (this.Monto * 0.40F));
            }
            return this.Monto;
        }
        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {

            ///Para los préstamos en dólares se incrementará el monto original en 2.5 dólares por cada día
            ///de extendido el plazo y se actualizará la fecha original de vencimiento a la nueva fecha.
            ///
            if(nuevoVencimiento>this.Vencimiento)
            {
                DateTime vencimientoActual = this.Vencimiento;
                TimeSpan timeSpan = nuevoVencimiento - vencimiento;
                float nuevoInteres = timeSpan.Days * 2.5F;
                this.monto = this.Monto + nuevoInteres;
                this.Vencimiento = nuevoVencimiento;
            }
        }
        public override string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0}Peridicidad: {1}\nIntereses: {2}",base.Mostrar(),this.Periodicidad,this.Interes);
            return str.ToString();
        }

    }
}
