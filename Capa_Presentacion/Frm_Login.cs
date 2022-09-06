using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Entidades;

namespace Capa_Presentacion
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                try
                {
                    N_IniciarSesion login = new N_IniciarSesion();
                    bool existe = login.ValidaUsuario(this.TxtUsuario.Text, this.TxtClave.Text);
                    if (existe)
                    {
                        MessageBox.Show("Bievenido: " + DatosLogin.NombrePersonal, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FrmPrincipal2 principal = new FrmPrincipal2();
                        principal.Show();
                        principal.FormClosed += CerrarSesion;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Nombre de Usuario o Clave incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo Iniciar Sesión", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            this.TxtUsuario.Clear();
            this.TxtClave.Clear();
            this.Show();
            this.TxtUsuario.Focus();
        }

        private void LkLblRecuperacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_CambiarClave frm = new Frm_CambiarClave();
            frm.ShowDialog();
        }

        private void TxtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.TxtUsuario.Text))
            {
                this.ErrNotificator.SetError(this.TxtUsuario, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.TxtUsuario, "El usuario no debe estar vacío");
                e.Cancel = true;
            }
        }

        private void TxtClave_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.TxtClave.Text))
            {
                this.ErrNotificator.SetError(this.TxtClave, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.TxtClave, "Debe ingresar una contraseña");
                e.Cancel = true;
            }
        }
    }
}
