using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    public class Boligrafo
    {
        const short cantidadMaximaTinta = 100;
        public ConsoleColor color = new ConsoleColor();
        public short tinta;
        ConsoleColor GetColor()
        {
            return this.color;
        }
        short getTinta()
        {
            return this.tinta;
        }
        private void setTinta(short tinta)
        {
            if (tinta > 0 && (this.tinta + tinta) <= cantidadMaximaTinta)
                this.tinta += tinta;
            else if (tinta < 0 && (this.tinta - tinta) >= 0)
                this.tinta -= tinta;
        }
        private void Recargar()
        {
            this.tinta = cantidadMaximaTinta;
        }
        public bool Pintar(int gasto, out string dibujo)
        {
            bool retorno = false;
            dibujo = "";
            //if (this.tinta > 0 && gasto > 0)
            while(this.tinta>0 && gasto>0)
            {
                this.tinta--;
                gasto--;
                dibujo += "*";

                /*for(int i=gasto; (i<this.tinta && this.tinta>0);i--)
                {
                    this.tinta--;
                    dibujo += "*";
                }*/
                retorno = true;
            }
            return retorno;
        }

    }
}
