using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace VistaForm
{
    public partial class FormDT : Form
    {
        
        DirectorTecnico dt;
        public FormDT()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Valida datos ingresados y crea Director Tecnico si los datos son validos No 0 No ""
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCrear_Click(object sender, EventArgs e)
        {
            if (!(textBoxNombre.Text == "" && textBoxApellido.Text == "" && (int)numericUpDownEdad.Value == 0 && (int)numericUpDownDni.Value == 0 && (int)numericUpDownExperiencia.Value == 0))
            {
                dt = new DirectorTecnico(textBoxNombre.Text, textBoxApellido.Text, (int)numericUpDownEdad.Value, (int)numericUpDownDni.Value, (int)numericUpDownExperiencia.Value);
                MessageBox.Show("Se ha creado el DT");
            }
        }

        /// <summary>
        /// Valida Director Tecnico si es Apto o No
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValidar_Click(object sender, EventArgs e)
        {
            if (dt is null)
                MessageBox.Show("Aun no se ha creado el DT del Formulario");
            else
            {
                if(dt.ValidadAptitud()==true)
                    MessageBox.Show("El DT es Apto");
                else
                    MessageBox.Show("El DT no es Apto");

            }
        }

        private void FormDT_Load(object sender, EventArgs e)
        {

        }
    }
}
