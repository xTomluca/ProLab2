using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;
        public int AñosExperiencia
        {
            get
            {
                return  this.añosExperiencia;
            }
            set
            {
                this.añosExperiencia = value;
            }
        }
        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia) : base(nombre, apellido, edad,dni)
        {
            this.AñosExperiencia = añosExperiencia;
        }
        /// <summary>
        /// Muestra todos los datos del Director Tecnico
        /// </summary>
        /// <returns>Datos del Director Tecnico</returns>
        public override string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0}\nAños Experiencia: {1}\n", base.Mostrar(),this.AñosExperiencia);
            return str.ToString();
        }
        /// <summary>
        /// Verifica que el director tenga mas de 2 años de EXPERIENCIA y EDAD menor a 65 años
        /// </summary>
        /// <returns>TRUE = DT Apto || FALSE = DT No Apto</returns>
        public override bool ValidadAptitud()
        {
            if (this.Edad < 65 && this.AñosExperiencia > 2)
                return true;
            return false;
        }
    }
}
