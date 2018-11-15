using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Ejercicio_63
{
    public partial class Form1 : Form
    {
        Thread hora;
        public Form1()
        {
            InitializeComponent();
            hora = new Thread(this.AsignarHora);
            hora.Start();
        }
        public void AsignarHora()
        {
                    do
                    {
            if(this.label1.InvokeRequired)
            {
                this.label1.BeginInvoke((MethodInvoker)delegate()
                {
                    label1.Text = DateTime.Now.ToString();
                }
                );

            }
                else
                {
                    label1.Text = DateTime.Now.ToString() + "ELSE";
                }
                Thread.Sleep(100);
            } while (true) ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            hora.Abort();
            if(hora.IsAlive==false)
                MessageBox.Show("Se cerro hilo");

        }

        private void start_Click(object sender, EventArgs e)
        {
            if(hora.IsAlive==false)
            {
                hora = new Thread(this.AsignarHora);
                hora.Start();
            }
        }

        /*
         c. Generar tres prácticas, independientes, en el orden planteado:
            i. Realizar la actualización de la hora 1 vez por segundo utilizando alguna estructura de
            control dada en clase.
            ii. Agregar un objeto del tipo Timer para refrescar la hora actual cada 1 segundo.
            iii. Resolver el mismo ejercicio con Threads.*/
    }
}
