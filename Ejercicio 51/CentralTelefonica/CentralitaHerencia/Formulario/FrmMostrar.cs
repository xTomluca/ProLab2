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
    public partial class FrmMostrar : Form
    {
        Centralita c;
        Llamada.tipoLLamada tipo;
        public FrmMostrar()
        {
            InitializeComponent();
        }
        public FrmMostrar(Centralita c, Llamada.tipoLLamada tipo)
        {
            InitializeComponent();
            this.c = c;
            this.tipo = tipo;
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            switch(tipo)
            {
                case Llamada.tipoLLamada.Local:
                    richTextBox1.Text = string.Format("Ganancias Local: "+c.GananciasPorLocal);
                    break;
                case Llamada.tipoLLamada.Provincial:
                    richTextBox1.Text = string.Format("Ganancias Provincial: " + c.GananciasPorProvincial);
                    break;
                case Llamada.tipoLLamada.Todas:
                    richTextBox1.Text =  string.Format("Ganancias Total: " + c.GananciasPorTotal);
                    break;
            }
        }
    }
}
