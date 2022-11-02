using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Capa_Entidades;
using ComercializacionFerroCenter.Formularios_Busqueda;

namespace ComercializacionFerroCenter.Comercializacion
{
    public partial class Frm_RegistraCotizacion : Form
    {
        private E_Proveedor proveedor = null;
        public Frm_RegistraCotizacion()
        {
            InitializeComponent();
        }

        #region "Mis Métodos"

        private void PresentarDatosProveedor()
        {
            this.TxtNumeroRuc.Text = this.proveedor.NumeroRuc;
            this.TxtRazonSocial.Text = this.proveedor.RazonSocial;
        }

        private void CargarListadoCompras()
        {
            this.DgvListado.DataSource = null;
            try
            {
                N_OrdenCompra nOrdenCompra = new N_OrdenCompra();
                List<E_OrdenCompra> listado = nOrdenCompra.Listado();
                if (listado.Count > 0)
                {
                    this.DgvListado.AutoGenerateColumns = false;
                    this.DgvListado.DataSource = listado;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar el listado de datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarControles()
        {
            this.DgvListado.DataSource = null;
            this.DgvListadoDetalle.DataSource = null;
            this.TxtNumeroRuc.Clear();
            this.TxtRazonSocial.Clear();
            this.NudCotizacion.Value = 0;
            this.DtpFechaEntrega.Value = DateTime.Now;
            this.proveedor = null;
            this.ErrNotificator.Clear();
        }

        #endregion

        #region "Eventos de Click"
        private void BtnBuscarProveedor_Click(object sender, EventArgs e)
        {
            this.proveedor = null;
            if (!String.IsNullOrEmpty(this.TxtNumeroRuc.Text) && this.TxtNumeroRuc.Text.Length == 11)
            {
                try
                {
                    N_Proveedor n_Proveedor = new N_Proveedor();
                    this.proveedor = n_Proveedor.BuscarProveedor(this.TxtNumeroRuc.Text.Trim());

                    if (this.proveedor != null)
                    {
                        this.PresentarDatosProveedor();
                    }
                    else
                    {
                        MessageBox.Show("RUC de Proveedor no encontrado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.TxtNumeroRuc.Clear();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo obtener los datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número de RUC válido", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.TxtNumeroRuc.Focus();
            }
        }

        private void BtnBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            this.proveedor = null;
            Frm_BuscarProveedor frm = new Frm_BuscarProveedor();
            this.proveedor = frm.Buscar();

            if (this.proveedor != null)
            {
                this.PresentarDatosProveedor();
            }
            else
            {
                this.TxtNumeroRuc.Clear();
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            this.CargarListadoCompras();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.DgvListado.DataSource != null)
            {
                this.DgvListadoDetalle.DataSource = null;
                try
                {
                    N_OrdenCompra nOrdenCompra = new N_OrdenCompra();
                    List<E_Producto> listado = nOrdenCompra.ListadoDetalleCompra((this.DgvListado.CurrentRow.DataBoundItem as E_OrdenCompra).CodigoOrdenCompra);
                    if (listado.Count > 0)
                    {
                        this.DgvListadoDetalle.AutoGenerateColumns = false;
                        this.DgvListadoDetalle.DataSource = listado;
                        this.GbListadoCompras.Enabled = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo cargar el listado de datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna orden de compra", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                E_OrdenCompra objOrdenCompra = new E_OrdenCompra()
                {
                    CodigoOrdenCompra = (this.DgvListado.CurrentRow.DataBoundItem as E_OrdenCompra).CodigoOrdenCompra,
                    CodigoProveedor = this.proveedor.CodigoProveedor,
                    MontoCotizacion = (double)this.NudCotizacion.Value,
                    FechaEntrega = this.DtpFechaEntrega.Value
                };
                try
                {
                    N_OrdenCompra nOrdenCompra = new N_OrdenCompra();
                    nOrdenCompra.RegistrarCotizacion(objOrdenCompra);
                    MessageBox.Show("Cotización registrada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimpiarControles();
                    this.CargarListadoCompras();
                    this.GbListadoCompras.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error al guardar los datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Está seguro que desea cancelar la cotización??", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (r == DialogResult.OK)
            {
                this.Close();
            }
        }

        #endregion

        #region "Eventos de Validación de Controles"
        private void NudCotizacion_Validating(object sender, CancelEventArgs e)
        {
            if(this.NudCotizacion.Value > 0)
            {
                this.ErrNotificator.SetError(this.NudCotizacion, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.NudCotizacion, "El monto de la contizacion debe ser mayor a 0");
                e.Cancel = true;
            }
        }

        private void TxtRazonSocial_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.TxtRazonSocial.Text))
            {
                this.ErrNotificator.SetError(this.TxtRazonSocial, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.TxtRazonSocial, "Debe elegir a un proveedor");
                e.Cancel = true;
            }
        }
        #endregion
    }
}
