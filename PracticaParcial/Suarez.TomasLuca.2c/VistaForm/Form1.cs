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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Curso curso;
        /// <summary>
        /// CREAR CURSO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Divisiones div;
            if(Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out div))
            {
                curso = new Curso(short.Parse(nudAnioCurso.Text), div, 
                    new Profesor(txtNombreProfe.Text, txtApellidoProfe.Text, txtDocumentoProfe.Text,DateTime.Parse(dtpFechaIngreso.Text)));
            }
            nudAnioCurso.Text = "";
            cmbDivisionCurso.Text = "";
            txtNombreProfe.Clear();
            txtDocumentoProfe.Clear();
            txtApellidoProfe.Clear();
            dtpFechaIngreso.Text = "";

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (curso is null)
                MessageBox.Show(MessageBoxButtons.OKCancel.ToString(),"ERROR!");
                rtbDatos.Text = (string)curso;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Divisiones div;
            if(Enum.TryParse<Divisiones>(cmbDivison.SelectedValue.ToString(), out div))
            {
                Alumno alumno = new Alumno(txtNombre.Text, txtApellido.Text, txtLegajo.Text,short.Parse(nudAnio.Text), div);
                curso = curso + alumno;
            }
            cmbDivison.Text = "";
            txtNombre.Clear();
            txtApellido.Clear();
            txtLegajo.Clear();
            nudAnio.Text = "";


        }

        private void gpbDatosCurso_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDivison.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
        }
    }
}
