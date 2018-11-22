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
namespace FrmPpal
{
    public partial class FrmPpal : Form
    {
        Correo correo;
        public FrmPpal()
        {
            InitializeComponent();
            this.correo = new Correo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paquete p = new Paquete(this.txtDireccion.Text, this.mtxtTrackingID.Text);
            p.InformaEstado += this.paq_InformaEstado;
            p.BaseSql += this.errorBaseDato;
            try
            {
                this.correo += p;
            }
            catch(TrackingIdRepetidoException exc)
            {
                MessageBox.Show(exc.Message);
            }
            this.ActualizarEstado();
            this.mtxtTrackingID.Clear();
            this.txtDireccion.Clear();
        }
        private void errorBaseDato(object obj, EventArgs args)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(errorBaseDato);
                this.Invoke(d, new object[] { obj, args });
            }
            else
            {
                MessageBox.Show("Error al guardar en BASE DE DATOS");
            }
        }

        private void paq_InformaEstado(object sender,EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstado();
            }
        }
        private void ActualizarEstado()
        {
            this.lstEstadoIngresado.Items.Clear();
            this.lstEstadoEnViaje.Items.Clear();
            this.lstEstadoEntregado.Items.Clear();
            foreach(Paquete p in this.correo.Paquetes)
            {
                switch(p.Estado)
                {
                    case Paquete.EEstado.Ingresado:
                        this.lstEstadoIngresado.Items.Add(p.ToString());
                        break;
                    case Paquete.EEstado.EnViaje:
                        this.lstEstadoEnViaje.Items.Add(p.ToString());
                        break;
                    case Paquete.EEstado.Entregado:
                        this.lstEstadoEntregado.Items.Add(p.ToString());
                        break;
                }
            }
        }
        private void FrmPpal_FormClosing(object sender, FormClosedEventArgs e)
        {
            this.correo.FinEntregas();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }
        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if(!(elemento is null))
            {
                rtbMostrar.Text = elemento.MostrarDatos(elemento);
                try
                {
                    GuardarString.Guardar(rtbMostrar.Text, "salida.txt");
                }
                catch(Exception)
                {
                    MessageBox.Show("Error al guardar TXT");
                }
            }
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }
        

    }
}
