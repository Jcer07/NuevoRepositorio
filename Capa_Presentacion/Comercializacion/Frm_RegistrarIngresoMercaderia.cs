using Capa_Entidades;
using Capa_Negocio;
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
    public partial class Frm_RegistrarIngresoMercaderia : Form
    {
        private E_OrdenCompra ordenCompra = null;
        
        public Frm_RegistrarIngresoMercaderia()
        {
            InitializeComponent();
        }

        private void LimpiarControles()
        {
            this.TxtNumOrdenCompra.Clear();
            this.TxtRazonSocialProveedor.Clear();
            this.TxtCotizacion.Clear();
            this.DgvListadoDetalle.DataSource = null;
        }

        private void CargarListadoDetalle()
        {
            this.DgvListadoDetalle.DataSource = null;
            try
            {
                N_OrdenCompra nOrdenCompra = new N_OrdenCompra();
                List<E_Producto> listado = nOrdenCompra.ListadoDetalleCompra(this.ordenCompra.CodigoOrdenCompra);
                if(listado.Count > 0)
                {
                    this.DgvListadoDetalle.AutoGenerateColumns = false;
                    this.DgvListadoDetalle.DataSource = listado;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener los datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PresentaDatos()
        {
            this.TxtNumOrdenCompra.Text = this.ordenCompra.CodigoOrdenCompra.ToString();
            this.TxtRazonSocialProveedor.Text = this.ordenCompra.RazonSocialProveedor;
            this.TxtCotizacion.Text = this.ordenCompra.MontoCotizacion.ToString();
            this.CargarListadoDetalle();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.ordenCompra = null;
            try
            {
                N_OrdenCompra nOrdenCompra = new N_OrdenCompra();
                this.ordenCompra = nOrdenCompra.LeerOrdenCompra(Convert.ToInt32(this.TxtNumOrdenCompra.Text));
                if(this.ordenCompra != null)
                {
                    this.PresentaDatos();
                }
                else
                {
                    MessageBox.Show("Número de Orden de Compra no encontrado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.TxtNumOrdenCompra.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener los datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            this.ordenCompra = null;
            Frm_BuscarOrdenCompra frm = new Frm_BuscarOrdenCompra();
            this.ordenCompra = frm.Buscar();
            if(this.ordenCompra != null)
            {
                this.PresentaDatos();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarControles();
        }

        private void BtnRegistrarIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable listadoDetalle = new DataTable();
                listadoDetalle.Columns.Add("codigoIngresoProducto", typeof(int));
                listadoDetalle.Columns.Add("codigoProducto", typeof(int));
                listadoDetalle.Columns.Add("cantidad", typeof(int));

                foreach(DataGridViewRow fila in this.DgvListadoDetalle.Rows)
                {
                    E_Producto obj = fila.DataBoundItem as E_Producto;
                    listadoDetalle.Rows.Add(0, obj.CodigoProducto, obj.StockActual);
                }

                N_IngresoProducto nIngreso = new N_IngresoProducto();
                nIngreso.RegistrarIngreso(this.ordenCompra.CodigoOrdenCompra, listadoDetalle);
                MessageBox.Show("Registro exitoso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LimpiarControles();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo registrar los datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
