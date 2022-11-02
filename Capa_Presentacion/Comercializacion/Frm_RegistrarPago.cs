using Capa_Entidades;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercializacionFerroCenter.Comercializacion
{
    public partial class Frm_RegistrarPago : Form
    {
        private E_MetodoPago pago = null;
        private double montoP = 0.0;
        public Frm_RegistrarPago()
        {
            InitializeComponent();
            
        }

        public E_MetodoPago Pagar(double montoPagar)
        {
            montoP = montoPagar;
            this.ShowDialog();
            return pago;
        }

        private void Frm_RegistrarPago_Load(object sender, EventArgs e)
        {
            this.CargarMetodosPago();
            this.CboMetodoPago.SelectedIndex = -1;
            this.TxtMontoTotal.Text = montoP.ToString();
        }

        private void CargarMetodosPago()
        {
            this.CboMetodoPago.DataSource = null;
            try
            {
                N_MetodoPago nMetodoPago = new N_MetodoPago();
                List<E_MetodoPago> listado = nMetodoPago.ListadoMetodosPago();
                if(listado != null)
                {
                    this.CboMetodoPago.DataSource = listado;
                    this.CboMetodoPago.DisplayMember = "Nombre";
                    this.CboMetodoPago.ValueMember = "CodigoMetodoPago";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar los metodos de pago", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if(this.CboMetodoPago.SelectedIndex > -1)
            {
                if((int)this.CboMetodoPago.SelectedValue == 1)
                {
                    this.GbPagoTarjeta.Enabled = true;
                    this.GbPagoEfectivo.Enabled = false;
                }
                else
                {
                    this.GbPagoEfectivo.Enabled = true;
                    this.GbPagoTarjeta.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Debe elegir un método de Pago", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnRealizarPago_Click(object sender, EventArgs e)
        {
            if (this.CboMetodoPago.SelectedIndex > -1 && Convert.ToDouble(this.TxtMontoRecibido.Text) >= montoP)
            {
                this.pago = this.CboMetodoPago.SelectedItem as E_MetodoPago;
                MessageBox.Show("Pago Realizado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Faltan Datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtMontoRecibido_Leave(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(this.TxtMontoTotal.Text) || !String.IsNullOrEmpty(this.TxtMontoRecibido.Text)){
                double montoPagar = Convert.ToDouble(this.TxtMontoTotal.Text);
                double montoRecibido = Convert.ToDouble(this.TxtMontoRecibido.Text);
                if (montoRecibido >= montoPagar)
                {
                    this.TxtCambio.Text = (montoRecibido - montoPagar).ToString();
                }
                else
                {
                    MessageBox.Show("El monto recibido es menor al monto a pagar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
