using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        DateTime fechaIngreso;
        public int Antiguedad
        {
            get
            {
                DateTime now = DateTime.Now;
                TimeSpan dias = now - this.fechaIngreso;
                int cantidadDias = dias.Days;
                return cantidadDias;
            }
        }
        public Profesor(string nombre, string apellido, string documento) : base(nombre,apellido,documento)
        {
            
        }
        public Profesor(string nombre, string apellido, string documento,DateTime fechaIngreso) : this(nombre,apellido,documento)
        {
            this.fechaIngreso = fechaIngreso;
        }
        protected override bool ValidarDocumentacion(string doc)
        {
            bool r = false;
            if (doc.Length == 9)
                for (int i = 0; i < doc.Length; i++)
                {
                    int aux = 0;
                    if ((i == 2 || i == 7) && (doc[i] == '-'))
                    {
                        continue;
                    }
                    else if ((i != 2 && i != 7) && int.TryParse(doc[i].ToString(), out aux))
                    {
                        r = true;
                    }
                    else
                    {
                        r = false;
                        break;
                    }
                }
            return r;
        }
        public override string ExponerDatos()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0}Fecha de Ingreso: {1}\nAntiguedad: {2}\n", base.ExponerDatos(),this.fechaIngreso, this.Antiguedad);
            return str.ToString();
        }
    }
}
