using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Dieciseis
{
    class Alumno
    {
        public string name;
        public string lastName;
        public int legajo;
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        Random objetoRandom = new Random();
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
        public void CalcularFinal()
        {
            this.notaFinal = -1;
            if (this.nota1 > 4 && this.nota2 > 4)
                this.notaFinal = objetoRandom.Next(5,10);
                //this.notaFinal = (this.nota1 + this.nota2) / 2;
            //else
        }
        public void mostrar()
        {
            Console.WriteLine("Nombre: {0}\nApellido: {1}\nLegajo: {2}\nNota 1: {3}\nNota 2: {4}", this.name,this.lastName,this.legajo,this.nota1,this.nota2);
            if (this.notaFinal != -1)
                Console.WriteLine("Nota final: {0}", this.notaFinal);
            else
                Console.WriteLine("Nota final: Alumno Desaprobado");
        }

    }
}
