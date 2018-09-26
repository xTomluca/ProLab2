using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Jugador : Persona
    {
        int partidosJugados;
        int totalGoles;
        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }
        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }
        public float PromedioGoles
        {
            get
            {
                return (float)this.TotalGoles / (float)this.PartidosJugados;
            }
        }

        private Jugador() : base(0, "")
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre) : this()  
        {
            base.Dni = dni;
            base.Nombre = nombre;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : base(dni,nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public new string MostrarDatos()
        {
            string persona = base.MostrarDatos();
            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0}\nPartidos Jugados: {1}\nTotalGoles: {2}\nPromedioGoles: {3}", persona, this.PartidosJugados, this.TotalGoles, this.PromedioGoles);
            return str.ToString();
        }
        public static bool operator ==(Jugador j1,Jugador j2)
        {
            if (j1.Dni == j2.Dni)
                return true;
            return false;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.Dni == j2.Dni);
        }
    }
}
