using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace Formulario
{
    public partial class Principal : Form
    {
        Centralita c;
        public Principal()
        {
            this.c = new Centralita("La Central");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void buttonGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamador = new FrmLlamador(c);
            llamador.ShowDialog(this);
        }

        private void buttonFcTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(c, Llamada.tipoLLamada.Todas);
            mostrar.ShowDialog();
        }

        private void buttonFcLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(c, Llamada.tipoLLamada.Local);
            mostrar.ShowDialog();
        }

        private void buttonFcProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(c, Llamada.tipoLLamada.Provincial);
            mostrar.ShowDialog();
        }
    }
}
