using Capa_Presentacion.Formularios_Busqueda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.Comercializacion
{
    public partial class Frm_RegistrarSalidaMercaderia : Form
    {
        public Frm_RegistrarSalidaMercaderia()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_BuscarUnidadTransporte frm = new Frm_BuscarUnidadTransporte();
            frm.ShowDialog();
        }
    }
}
