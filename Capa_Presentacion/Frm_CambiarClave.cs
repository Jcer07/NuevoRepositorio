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
    public partial class Frm_CambiarClave : Form
    {
        public Frm_CambiarClave()
        {
            InitializeComponent();
        }

        private void Frm_CambiarClave_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(510, 220);
        }

        private void BtnValidarDatos_Click(object sender, EventArgs e)
        {
            this.GbVerificarCodigo.Visible = true;
            this.GbValidarDatos.Visible = false;
        }

        private void BtnVerificarCodigo_Click(object sender, EventArgs e)
        {
            this.GbVerificarCodigo.Visible = false;
            this.GbCambiarClave.Visible = true;
        }
    }
}
