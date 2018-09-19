using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace Ejercicio_23
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

		private void btnConvertEuro_Click(object sender, EventArgs e)
		{
			double euro = 0;
			if(double.TryParse(txtEuro.Text, out euro))
			{
				Euro auxEuro = new Euro(euro);
				txtEuroAEuro.Text = txtEuro.Text;
				txtEuroADolar.Text = (((Dolar)auxEuro).GetCantidad()).ToString();
				txtEuroAPesos.Text = (((Pesos)auxEuro).GetCantidad()).ToString();
			}
		}

		private void btnConvertDolar_Click(object sender, EventArgs e)
		{
			double dolar = 0;
			if (double.TryParse(txtDolar.Text, out dolar))
			{
				Dolar auxDolar = new Dolar(dolar);
				txtDolarADolar.Text = txtDolar.Text;
				txtDolarAEuro.Text = (((Euro)auxDolar).GetCantidad()).ToString();
				txtDolarAPesos.Text = (((Pesos)auxDolar).GetCantidad()).ToString();
			}
		}

		private void btnConvertPesos_Click(object sender, EventArgs e)
		{
			double pesos = 0;
			if (double.TryParse(txtPesos.Text, out pesos))
			{
				Pesos auxPesos = new Pesos(pesos);
				txtPesosAPesos.Text = txtPesos.Text;
				txtPesosAEuro.Text = (((Euro)auxPesos).GetCantidad()).ToString();
				txtPesosADolar.Text = (((Dolar)auxPesos).GetCantidad()).ToString();
			}
		}
	}
}
