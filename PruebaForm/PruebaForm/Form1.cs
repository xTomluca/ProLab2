using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numStr = "";
            double peso = 0;
            double dolar = 0;
            numStr = textBox6.Text;
            if (double.TryParse(numStr, out peso))
            {
                peso = peso * (38.550);
                textBox1.Text = peso.ToString("N2");
                dolar = peso / 38.550;
                textBox2.Text = dolar.ToString("N2");
            }    


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string hi = "";
            hi = textBox6.Text;
            
        }
    }
}
