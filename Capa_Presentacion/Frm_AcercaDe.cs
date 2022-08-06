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
    public partial class Frm_AcercaDe : Form
    {
        private static Frm_AcercaDe _instance;
        private Frm_AcercaDe()
        {
            InitializeComponent();
        }

        public static Frm_AcercaDe Instance
        {
            get
            {
                if(_instance == null || _instance.IsDisposed)
                {
                    _instance = new Frm_AcercaDe();
                    
                }
                else
                {
                    _instance.BringToFront();
                }
                return _instance;
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
