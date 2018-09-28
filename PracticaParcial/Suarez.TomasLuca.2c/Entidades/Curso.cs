using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        public string AnioDivision
        {
            get
            {
                return String.Format("{0}°{1}", this.anio, this.division);
            }
        }
        private Curso()
        {
            alumnos = new List<Alumno>();
        }
        public Curso(short anio, Divisiones division, Profesor profesor) : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }
        public static explicit   operator string (Curso c)
        {
            StringBuilder str = new StringBuilder();
            foreach(Alumno aux in c.alumnos)
            {
                str.Append(aux.ExponerDatos());
            }
            return str.ToString();
        }
        public static bool operator ==(Curso c, Alumno a)
        {
            if(c.AnioDivision == a.AnioDivision)
                return true;
            return false;
        }
        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }
        public static Curso operator +(Curso c, Alumno a)
        {
            if(c == a)
            {
                c.alumnos.Add(a);
            }
            return c;
            
        }

    }
}
