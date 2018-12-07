using System;
using System.Windows.Forms;
using Entidades;
using Archivos;
using System.Text;
namespace VistaForm
{
    public partial class FormAgencia : Form
    {
        private Agencia agencia;

        public FormAgencia()
        {
            InitializeComponent();
            agencia = new Agencia("Agencia UTN");
            string[] items = new string[] { "Micro", "Avión" };
            this.cmbTipoPasaje.DataSource = items;
            this.cmbTipoPasaje.SelectedIndex = 0;
            this.nudEscalas.Enabled = false;


            this.txtNombre.Text = "Nombre";
            this.txtApellido.Text = "Apellido";
            this.txtDni.Text = "33444555";
            this.txtOrigen.Text = "Buenos Aires";
            this.txtDestino.Text = "Cordoba";
            cmbTipoServicio.DataSource = Enum.GetValues(typeof(Servicio));
        }

        private void btnEmitirPasaje_Click(object sender, System.EventArgs e)
        {
            PasajeAvion pasajeAvion;
            PasajeMicro pasajeMicro;
            if (this.cmbTipoPasaje.SelectedValue.ToString() == "Avión")
            {
                pasajeAvion = new PasajeAvion(this.txtOrigen.Text, this.txtDestino.Text, new Pasajero(this.txtNombre.Text, this.txtApellido.Text, this.txtDni.Text), float.Parse(this.txtPrecio.Text), DateTime.Parse(this.dtpFechaPartida.Text), (int)this.nudEscalas.Value);
                this.agencia += pasajeAvion;
            }
            else if(this.cmbTipoPasaje.SelectedValue.ToString() == "Micro")
            {
                pasajeMicro =  new PasajeMicro(this.txtOrigen.Text, this.txtDestino.Text, new Pasajero(this.txtNombre.Text, this.txtApellido.Text, this.txtDni.Text), float.Parse(this.txtPrecio.Text), this.dtpFechaPartida.Value, (Servicio)this.cmbTipoServicio.SelectedIndex);
                this.agencia += pasajeMicro;
            }
        }

        private void btnMostrar_Click(object sender, System.EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(agencia.Nombre);
            foreach(Pasaje p in this.agencia.PasajesVendidos)
            {
                stringBuilder.AppendLine(p.Mostrar());
            }
            rtbMostrar.Text = stringBuilder.ToString();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            Xml<Agencia> xml = new Xml<Agencia>();
            try
            {
                xml.Guardar("Agencia.xml", this.agencia);
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void cmbTipoPasaje_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.cmbTipoPasaje.SelectedIndex == 0)
            {
                this.nudEscalas.Enabled = false;
                this.nudEscalas.Value = 0;
                this.cmbTipoServicio.Enabled = true;
            }
            else
            {
                this.nudEscalas.Enabled = true;
                this.cmbTipoServicio.Enabled = false;
            }
        }

        void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void FormAgencia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormAgencia_Load(object sender, EventArgs e)
        {
            this.agencia.informar += this.MostrarMensaje;
        }
    }
}
