using ComercializacionFerroCenter.Formularios_Busqueda;
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

namespace ComercializacionFerroCenter.Comercializacion
{
    public partial class Frm_RealizarVenta : Form
    {
        private E_Cliente cliente;
        private E_Producto producto;
        DataTable detalleVenta = null;
        private E_MetodoPago metodoPago = null;
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
            this.TxtStock.Text = this.producto.StockActual.ToString();
        }

        private void LimpiarControlesProducto()
        {
            this.TxtCodigoProducto.Clear();
            this.TxtNombreProducto.Clear();
            this.TxtTipoProducto.Clear();
            this.TxtPrecio.Clear();
            this.NudCantidad.Value = 0;
            this.TxtStock.Clear();
            this.producto = null;
            this.ErrNotificator.Clear();
        }

        private void CalculaMontoTotal()
        {
            double montoTotal = 0.0;
            foreach(DataGridViewRow fila in this.DgvListadoProductos.Rows)
            {
                montoTotal += (double)fila.Cells["ClSubTotal"].Value;
            }
            this.TxtMontoTotal.Text = montoTotal.ToString();
        }

        private void CargarModeloTabla()
        {
            detalleVenta.Columns.Add("codigoVenta", typeof(int));
            detalleVenta.Columns.Add("codigoProducto", typeof(int));
            detalleVenta.Columns.Add("cantidad", typeof(int));
            detalleVenta.Columns.Add("precio", typeof(double));
            detalleVenta.Columns.Add("total", typeof(double));
        }

        private E_Venta CrearVenta()
        {
            E_Venta venta = new E_Venta()
            {
                CodigoCliente = this.cliente.CodigoCliente,
                CodigoMetodoPago = this.metodoPago.CodigoMetodoPago,
                CodigoPersonal = DatosLogin.CodigoPersonal,
                MontoVenta = Convert.ToDouble(this.TxtMontoTotal.Text)
            };
            return venta;
        }

        private void LimpiarControles()
        {
            this.cliente = null;
            this.producto = null;
            this.detalleVenta = null;
            this.metodoPago = null;
            this.TxtDniCliente.Clear();
            this.TxtNombreCliente.Clear();
            this.DgvListadoProductos.Rows.Clear();
            this.TxtMontoTotal.Text = "0.0";
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
            if (this.producto != null)
            {
                if (this.NudCantidad.Value > 0 && this.NudCantidad.Value <= Convert.ToInt32(this.TxtStock.Text))
                {
                    double subTotal = this.producto.Precio * (double)this.NudCantidad.Value;
                    this.DgvListadoProductos.Rows.Add(this.producto.CodigoProducto, this.producto.Nombre,
                                            this.NudCantidad.Value, this.producto.Precio, subTotal);
                    this.CalculaMontoTotal();
                    this.LimpiarControlesProducto();
                }
                else
                {
                    this.ErrNotificator.SetError(this.NudCantidad, "La cantidad debe ser mayor a Cero o menor que el stock");
                }
            }
            else
            {
                MessageBox.Show("No hay ningún producto para agregar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.TxtCodigoProducto.Focus();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarControlesProducto();
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            if (this.DgvListadoProductos.RowCount > 0)
            {
                if (this.DgvListadoProductos.CurrentRow != null)
                {
                    this.DgvListadoProductos.Rows.RemoveAt(this.DgvListadoProductos.CurrentRow.Index);
                    this.CalculaMontoTotal();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No hay ningun producto para quitar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnRegistraPago_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(this.TxtMontoTotal.Text) > 0.0)
            {
                Frm_RegistrarPago frm = new Frm_RegistrarPago();
                metodoPago = frm.Pagar(Convert.ToDouble(this.TxtMontoTotal.Text));
            }
            else
            {
                MessageBox.Show("No hay ningun produco que pagar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (this.DgvListadoProductos.RowCount > 0 && this.cliente != null)
            {
                detalleVenta = new DataTable();
                this.CargarModeloTabla();
                
                foreach(DataGridViewRow fila in this.DgvListadoProductos.Rows)
                {
                    detalleVenta.Rows.Add(0, fila.Cells["ClCodigo"].Value, fila.Cells["ClCantidad"].Value,
                                        fila.Cells["ClPrecioUnitario"].Value, fila.Cells["ClSubTotal"].Value);
                }
                E_Venta venta = this.CrearVenta();
                try
                {
                    N_Venta nVenta = new N_Venta();
                    nVenta.RegistrarVenta(venta, detalleVenta);
                    MessageBox.Show("Venta registrada con éxito", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimpiarControles();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hbo un error al registrar la venta", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Faltan datos importantes", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelarVenta_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Está seguro que desea cancelar la Venta?", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (r == DialogResult.OK)
            {
                this.Close();
            }
        }

        #endregion
    }
}
