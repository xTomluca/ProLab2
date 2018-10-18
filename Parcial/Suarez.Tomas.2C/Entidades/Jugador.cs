using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;
        public float Altura
        {
            get
            {
                return this.altura;
            }
        }
        public float Peso
        {
            get
            {
                return this.peso;
            }
        }
        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }
        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion) : base(nombre,apellido,edad,dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }
        /// <summary>
        /// Muestra todos los datos del jugador
        /// </summary>
        /// <returns>Los datos del jugador</returns>
        public override string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0}Altura: {1}\nPeso: {2}\nPosicion:{3}\n", base.Mostrar(), this.Altura, this.Peso, this.Posicion.ToString());
            return str.ToString();
        }

        /// <summary>
        /// Valida Estado Fisico del Jugador en relacion a INDICE DE MASA CORPORAL
        /// </summary>
        /// <returns> Jugador Apto = TRUE / Jugador No Apto = FALSE</returns>
        public bool ValidarEstadoFisico()
        {
            float imc = this.Peso / (float)Math.Pow(this.Altura,2);
            if (imc <= 25 && imc > 18.5)
                return true;
            return false;
        }
        /// <summary>
        /// Valida si el jugador esta Apto, teniendo en cuenta IMC y EDAD no supere los 40 años
        /// </summary>
        /// <returns>Jugador Apto = TRUE / Jugador No Apto = FALSE</returns>
        public override bool ValidadAptitud()
        {
            if (this.Edad <= 40 && this.ValidarEstadoFisico() == true)
                return true;
            return false;
        }
    }
}
