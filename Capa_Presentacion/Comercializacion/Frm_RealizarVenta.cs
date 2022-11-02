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
using Capa_Entidades;
using Capa_Negocio;

namespace Capa_Presentacion.Comercializacion
{
    public partial class Frm_RealizarVenta : Form
    {
        private E_Cliente cliente;
        private E_Producto producto;
        private List<E_Producto> listadoProductos;
        public Frm_RealizarVenta()
        {
            InitializeComponent();
        }

        #region "Mis Métodos"
        private void PresentarDatosCliente()
        {
            this.TxtDniCliente.Text = this.cliente.NumeroDni;
            this.TxtNombreCliente.Text = this.cliente.NombresApellidos;
        }

        private void PresentarDatosProducto()
        {
            this.TxtCodigoProducto.Text = this.producto.CodigoProducto.ToString();
            this.TxtNombreProducto.Text = this.producto.Nombre;
            this.TxtTipoProducto.Text = this.producto.NombreCategoria;
            this.TxtPrecio.Text = this.producto.Precio.ToString();
        }

        private void LimpiarControlesProducto()
        {
            this.TxtCodigoProducto.Clear();
            this.TxtNombreProducto.Clear();
            this.TxtTipoProducto.Clear();
            this.TxtPrecio.Clear();
            this.NudCantidad.Value = 0;
            this.producto = null;
        }

        #endregion

        #region "Eventos de Click"

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            this.cliente = null;
            if (!String.IsNullOrEmpty(this.TxtDniCliente.Text) && this.TxtDniCliente.Text.Length == 8)
            {
                try
                {
                    N_Cliente n_Cliente = new N_Cliente();
                    this.cliente = n_Cliente.BuscarCliente(this.TxtDniCliente.Text.Trim());

                    if (this.cliente != null)
                    {
                        this.PresentarDatosCliente();
                    }
                    else
                    {
                        MessageBox.Show("Dni de Cliente no encontrado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.TxtDniCliente.Clear();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo obtener los datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número de DNI válido", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.TxtDniCliente.Focus();
            }
        }

        private void BtnBusquedaAvanzadaCliente_Click(object sender, EventArgs e)
        {
            this.cliente = null;
            Frm_BuscarCliente frm = new Frm_BuscarCliente();
            this.cliente = frm.Buscar();

            if(this.cliente != null)
            {
                this.PresentarDatosCliente();
            }
            else
            {
                this.TxtDniCliente.Clear();
            }
        }

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            this.producto = null;
            if (!String.IsNullOrEmpty(this.TxtCodigoProducto.Text))
            {
                try
                {
                    N_Producto n_Producto = new N_Producto();
                    this.producto = n_Producto.BuscarProducto(Convert.ToInt32(this.TxtCodigoProducto.Text.Trim()));

                    if(this.producto != null)
                    {
                        this.PresentarDatosProducto();
                    }
                    else
                    {
                        MessageBox.Show("Código de Producto no encontrado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.TxtCodigoProducto.Focus();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo Obtener los datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un Código de Producto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.TxtCodigoProducto.Focus();
            }
        }

        private void BtnBusquedaAvanzadaProducto_Click(object sender, EventArgs e)
        {
            this.producto = null;
            Frm_BuscarProducto frm = new Frm_BuscarProducto();

            this.producto = frm.Buscar();
            if(this.producto != null)
            {
                this.PresentarDatosProducto();
            }
            else
            {
                this.TxtCodigoProducto.Focus();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            double subTotal = this.producto.Precio * (double)this.NudCantidad.Value;
            this.DgvListadoProductos.Rows.Add(this.producto.CodigoProducto, this.producto.Nombre, 
                                    this.NudCantidad.Value, this.producto.Precio, subTotal);
            this.LimpiarControlesProducto();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarControlesProducto();
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            this.DgvListadoProductos.Rows.RemoveAt(this.DgvListadoProductos.CurrentRow.Index);
        }

        private void BtnRegistraPago_Click(object sender, EventArgs e)
        {
            Frm_RegistrarPago frm = new Frm_RegistrarPago();
            frm.ShowDialog();
        }

        private void BtnRegistrarVenta_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelarVenta_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
