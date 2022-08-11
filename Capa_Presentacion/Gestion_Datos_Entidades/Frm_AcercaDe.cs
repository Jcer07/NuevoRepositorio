using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidades;
using Capa_Negocio;

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
            this.LblRazonSocial.Text = "Nombre de la Empresa: ";
            this.LblDireccion.Text = "Dirección: ";
            this.LblTelefono.Text = "Número de Teléfono: ";
            this.LblCorreo.Text = "Correo: ";
        }

        private void Frm_AcercaDe_Load(object sender, EventArgs e)
        {
            N_AcercaDe acercaDe = new N_AcercaDe();
            try
            {
                E_AcercaDe Datos = acercaDe.GetEmpresa();

                LblRazonSocial.Text += Datos.RazonSocial;
                LblDireccion.Text += Datos.Telefono;
                LblTelefono.Text += Datos.Telefono;
                LblCorreo.Text += Datos.Correo;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Sistema");
            }
        }
    }
}
