using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Alumno : Persona
    {
        short anio;
        Divisiones divisiones;
        public string AnioDivision
        {
            get
            {
                return String.Format("{0}°{1}", this.anio, this.divisiones);
            }
        }
        public Alumno(string nombre,string apellido,string documento,short anio, Divisiones division) : base(nombre,apellido,documento)
        {
            this.anio = anio;
            this.divisiones = division;
        }
        protected override bool ValidarDocumentacion(string doc)
        {
            bool r = false;
            if(doc.Length==9)
                for(int i=0; i<doc.Length-1;i++)
                {
                    int aux = 0;
                    if ((i == 2 || i == 7) && (doc[i] == '-'))
                    {
                        continue;
                    }              
                    else if((i != 2 || i != 7) && int.TryParse(doc[i].ToString(), out aux))
                    {
                        r = true;
                    }
                    else
                        break;
                }
            return r;
        }
        public override string ExponerDatos()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0} {1}", base.ExponerDatos(), this.AnioDivision);
            return str.ToString();
        }

    }
}
