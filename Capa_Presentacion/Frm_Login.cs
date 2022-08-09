using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            MessageBox.Show("Bienvenido al Sistema", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LkLblRecuperacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Comuniquese con el administrador", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
