using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Ejercicio_67
{
    public delegate void encargadoTiempo();
    public class Temporizador
    {
        Thread hilo;
        int intervalo;
        public event encargadoTiempo EventoTiempo;    
        bool Activo
        {
            get
            {
                return hilo.IsAlive;
            }
            set
            {
                if (hilo.IsAlive == true && value is true)
                {
                    hilo.Abort();
                    this.hilo = new Thread(this.Corriendo);
                    hilo.Start();
                }
                else if (hilo.IsAlive == false && value is true)
                    hilo.Start();
            }
        }
        int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }
        void Corriendo()
        {
            Thread.Sleep(this.Intervalo);
            this.EventoTiempo.Invoke();
        }
           
    }
}
