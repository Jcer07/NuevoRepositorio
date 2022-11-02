using Capa_Entidades;
using Capa_Negocio;
using ComercializacionFerroCenter.Formularios_Busqueda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercializacionFerroCenter
{
    public partial class Frm_RegistrarOrdenCompra : Form
    {
        private DataTable listadoDetalleCompra = null;
        private List<E_Producto> listaProductosCompra = null;
        public Frm_RegistrarOrdenCompra()
        {
            InitializeComponent();
        }

        private void Frm_RegistrarOrdenCompra_Load(object sender, EventArgs e)
        {
            this.CargarCategoriaProductos();
            this.CargarFormatoTabla();
            this.listaProductosCompra = new List<E_Producto>();
            this.Limpiar();
        }

        #region "Mis métodos"
        
        private void Limpiar()
        {
            this.CboTipoProducto.SelectedIndex = -1;
            this.listadoDetalleCompra.Rows.Clear();
            this.listaProductosCompra.Clear();
            this.DgvDetallePedido.DataSource = null;
            this.DgvListadoProductos.DataSource = null;
        }

        private void CargarFormatoTabla()
        {
            listadoDetalleCompra = new DataTable();
            listadoDetalleCompra.Columns.Add("codigoOrdenCompra", typeof(int));
            listadoDetalleCompra.Columns.Add("codigoProducto", typeof(int));
            listadoDetalleCompra.Columns.Add("cantidad", typeof(int));
        }

        private void CargarCategoriaProductos()
        {
            this.CboTipoProducto.DataSource = null;
            try
            {
                N_CategoriaProducto cat = new N_CategoriaProducto();
                List<E_CategoriaProducto> categorias = cat.ListadoCategoriasCbo();
                if(categorias.Count > 0)
                {
                    this.CboTipoProducto.DataSource = categorias;
                    this.CboTipoProducto.ValueMember = "CodigoCategoria";
                    this.CboTipoProducto.DisplayMember = "Nombre";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar los datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListadoProductosCompras()
        {
            this.DgvListadoProductos.DataSource = null;
            try
            {
                N_Producto datos = new N_Producto();
                List<E_Producto> listado = datos.ListadoProductosCompras((int)this.CboTipoProducto.SelectedValue);
                if(listado.Count > 0)
                {
                    this.DgvListadoProductos.AutoGenerateColumns = false;
                    this.DgvListadoProductos.DataSource = listado;
                }
                else
                {
                    MessageBox.Show("La categoría seleccionada no tiene productos sin stock", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.CboTipoProducto.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar los datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActivaControles(bool estado)
        {
            this.GbListadoProductos.Enabled = estado;
            this.GbDetallePedido.Enabled = estado;
            this.GbListadoOrdenesCompra.Enabled = !estado;
        }

        private void ListarOrdenesCompra()
        {
            this.DgvListadoOrdenesCompra.DataSource = null;
            try
            {
                N_OrdenCompra nOrdenCompra = new N_OrdenCompra();
                List<E_OrdenCompra> listado = nOrdenCompra.Listado();
                if(listado.Count > 0)
                {
                    this.DgvListadoOrdenesCompra.AutoGenerateColumns = false;
                    this.DgvListadoOrdenesCompra.DataSource = listado;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar el listado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region "Evento de Click"
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (this.DgvDetallePedido.DataSource != null)
            {
                foreach (DataGridViewRow fila in DgvDetallePedido.Rows)
                {
                    listadoDetalleCompra.Rows.Add(0, (fila.DataBoundItem as E_Producto).CodigoProducto, Convert.ToInt32(fila.Cells["ClCantidadCompra"].Value));
                }

                try
                {
                    N_OrdenCompra oCompra = new N_OrdenCompra();
                    oCompra.Registrar(listadoDetalleCompra);
                    MessageBox.Show("Orden de Compra Registrada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Limpiar();
                    this.ListarOrdenesCompra();
                    this.ActivaControles(false);
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo registrar la compra", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay datos para registrar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivaControles(false);
            this.Limpiar();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.ActivaControles(true);
            this.Limpiar();
        }

        private void BtnListarProductos_Click(object sender, EventArgs e)
        {
            if(this.CboTipoProducto.SelectedIndex > -1)
            {
                this.ListadoProductosCompras();
            }
            else
            {
                MessageBox.Show("Debe elegir un tipo de Producto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.CboTipoProducto.Focus();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (this.DgvListadoProductos.CurrentRow != null)
            {
                bool band = false;
                E_Producto temp = this.DgvListadoProductos.CurrentRow.DataBoundItem as E_Producto;
                foreach(E_Producto p in listaProductosCompra)
                {
                    if(p.CodigoProducto == temp.CodigoProducto)
                        band = true;
                }
                if (!band)
                {
                    this.DgvDetallePedido.DataSource = null;
                    this.listaProductosCompra.Add(temp);
                    this.DgvDetallePedido.AutoGenerateColumns = false;
                    this.DgvDetallePedido.DataSource = listaProductosCompra;
                }
                else
                {
                    MessageBox.Show("El producto ya ha sido agregado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe elegir una fila de la lista", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DgvListadoProductos.Focus();
            }
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            if (this.DgvDetallePedido.DataSource != null)
            {
                if (this.DgvDetallePedido.CurrentRow != null)
                {
                    int cod = (this.DgvDetallePedido.CurrentRow.DataBoundItem as E_Producto).CodigoProducto;
                    int pos = -1;
                    foreach (E_Producto p in this.listaProductosCompra)
                    {
                        if (p.CodigoProducto == cod)
                        {
                            pos = listaProductosCompra.IndexOf(p);
                        }
                    }

                    listaProductosCompra.RemoveAt(pos);
                    this.DgvDetallePedido.DataSource = null;
                    this.DgvDetallePedido.AutoGenerateColumns = false;
                    this.DgvDetallePedido.DataSource = listaProductosCompra;
                }
                else
                {
                    MessageBox.Show("Debe elegir una fila de la lista", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DgvDetallePedido.Focus();
                }
            }
            else
            {
                MessageBox.Show("No hay ningún producto para quitar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DgvListadoProductos.Focus();
            }
        }
        
        #endregion

        private void BtnListarOrdenesCompra_Click(object sender, EventArgs e)
        {
            this.ListarOrdenesCompra();
        }
    }
}
