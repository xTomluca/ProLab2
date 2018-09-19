using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temp;

namespace Ejercicio_24
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double temp = 0;
			txtCel.Text = Change(txtCel.Text);
			if (double.TryParse(txtCel.Text, out temp))
			{
				Celsius cel = new Celsius(temp);
				txtCAC.Text = txtCel.Text;
				txtCAF.Text = (((Fahrenheit)cel).GetTemperature().ToString());
				txtCAK.Text = (((Kelvin)cel).GetTemperature().ToString());
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			double temp = 0;
			txtFah.Text = Change(txtFah.Text);
			if (double.TryParse(txtFah.Text, out temp))
			{
				Fahrenheit fah = new Fahrenheit(temp);
				txtFAF.Text = txtFah.Text;
				txtFAC.Text = (((Celsius)fah).GetTemperature().ToString());
				txtFAK.Text = (((Kelvin)fah).GetTemperature().ToString());
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			double temp = 0;
			txtKel.Text = Change(txtKel.Text);
			if (double.TryParse(txtKel.Text, out temp))
			{
				Kelvin kel = new Kelvin(temp);
				txtKAK.Text = txtKel.Text;
				txtKAC.Text = (((Celsius)kel).GetTemperature().ToString());
				txtKAF.Text = (((Fahrenheit)kel).GetTemperature().ToString());
			}
		}

		private string Change(string s)
		{
			string newString = "";
			for (int i = 0; i < s.Length; i++)
			{

				if (s.ElementAt(i) == '.')
					newString += ',';
				else
					newString += s[i];
			}
			return newString;
		}
	}
}
