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
    public partial class FrmLlamador : Form
    {
        Centralita c;
        public FrmLlamador()
        {
            InitializeComponent();
        }
        public FrmLlamador(Centralita c)
        {
            this.c = c;
            InitializeComponent();
        }
        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            comboBoxFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            if (string.Compare(textBox1.Text[0].ToString(), "#") != 0)
                comboBoxFranja.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            if (string.Compare(textBox1.Text[0].ToString(), "#") != 0)
                comboBoxFranja.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            if (string.Compare(textBox1.Text[0].ToString(), "#") != 0)
                comboBoxFranja.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            if (string.Compare(textBox1.Text[0].ToString(), "#") != 0)
                comboBoxFranja.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text+= "5";
            if (string.Compare(textBox1.Text[0].ToString(), "#") != 0)
                comboBoxFranja.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            if (string.Compare(textBox1.Text[0].ToString(), "#") != 0)
                comboBoxFranja.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            if (string.Compare(textBox1.Text[0].ToString(), "#") != 0)
                comboBoxFranja.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            if (string.Compare(textBox1.Text[0].ToString(), "#") != 0)
                comboBoxFranja.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            if (string.Compare(textBox1.Text[0].ToString(), "#") != 0)
                comboBoxFranja.Enabled = false;
        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            textBox1.Text += "#";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0" ;
            if (string.Compare(textBox1.Text[0].ToString(), "#") != 0)
                comboBoxFranja.Enabled = false;
        }

        private void buttonAst_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
            if (string.Compare(textBox1.Text[0].ToString(), "#") != 0)
                comboBoxFranja.Enabled = false;
        }

        private void buttonLlamar_Click(object sender, EventArgs e)
        {
            if (string.Compare(textBox1.Text[0].ToString(),"#") == 0)
            {
                Random num = new Random();
                float duracion = num.Next(1, 50);
                Provincial.Franja franjas;
                Enum.TryParse<Provincial.Franja>(comboBoxFranja.SelectedValue.ToString(), out franjas);
                Provincial provincial = new Provincial(textBox2.Text, franjas, duracion, textBox1.Text);
                this.c += provincial;
            }
            else
            {
                Random num = new Random();
                float duracion = num.Next(1, 50);
                Random num2 = new Random(); ;
                int costoInt = num.Next(0, 5);
                float costo = (float)num2.NextDouble();
                float costoReal = (float)costoInt + costo;
                comboBoxFranja.Enabled = false;
                Local local = new Local(textBox2.Text, duracion, textBox1.Text, costoReal);
                this.c += local;
                
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text is "Nro Origen")
                textBox2.Clear();
        }
    }
}
