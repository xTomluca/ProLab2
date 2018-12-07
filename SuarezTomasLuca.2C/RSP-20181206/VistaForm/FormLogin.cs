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
using Excepciones;
namespace VistaForm
{
    public partial class FormLogin : Form
    {
        Usuario usuario;
        public FormLogin()
        {
            InitializeComponent();
            txtClave.UseSystemPasswordChar = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //ALUMNO
            UsuarioDAO dao = new UsuarioDAO();
            try
            {
                usuario = dao.Leer(this.txtUsuario.Text, this.txtClave.Text);
                if (usuario != null)
                {
                    this.Hide();
                    FormAgencia f2 = new FormAgencia();
                    f2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o Clave Icorrectos","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {

            //ALUMNO
            UsuarioDAO dao = new UsuarioDAO();
            try
            {
                this.usuario = new Usuario(this.txtUsuario.Text, this.txtClave.Text);
                if (dao.Guardar(usuario))
                    MessageBox.Show("Usuario Registrado");
                else
                    MessageBox.Show("Error al registrar usuario");
            }
            catch(ClaveInvalidaException a)
            {
                MessageBox.Show(a.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //limpio los controles después del registro
            this.txtUsuario.Clear();
            this.txtClave.Clear();
            usuario = null;

        }
    }
}
