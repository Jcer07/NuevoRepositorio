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

namespace ComercializacionFerroCenter.Gestion_Datos_Entidades
{
    public partial class Frm_GestionProducto : Form
    {
        private E_Producto actual = null;
        public Frm_GestionProducto()
        {
            InitializeComponent();
        }

        private void Frm_GestionProducto_Load(object sender, EventArgs e)
        {
            this.CargarCategorias();
            this.CargarUnidadesMedida();
            Limpiar();
            this.TxtNombreBuscar.Focus();
        }

        #region Mis métodos
        private void CargarMarcas()
        {
            List<E_MarcaProducto> listado;
            N_MarcaProducto datos;
            try
            {
                datos = new N_MarcaProducto();
                listado = datos.ListadoMarcasCbo((this.CboCategoriaProducto.SelectedItem as E_CategoriaProducto).CodigoCategoria);
                if (listado != null)
                {
                    this.CboMarcaProducto.DataSource = listado;
                    this.CboMarcaProducto.DisplayMember = "NombreMarca";
                    this.CboMarcaProducto.ValueMember = "CodigoMarca";
                }
                else
                {
                    MessageBox.Show("La categoria seleccionada no cuenta con marcas registradas", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.CboMarcaProducto.DataSource = null;
                    this.CboCategoriaProducto.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar los datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCategorias()
        {
            this.CboCategoriaProducto.DataSource = null;
            try
            {
                N_CategoriaProducto datos = new N_CategoriaProducto();
                List<E_CategoriaProducto>  listado = datos.ListadoCategoriasCbo();
                if (listado.Count > 0)
                {
                    this.CboCategoriaProducto.DataSource = listado;
                    this.CboCategoriaProducto.DisplayMember = "Nombre";
                    this.CboCategoriaProducto.ValueMember = "CodigoCategoria";
                }
            }
            catch (Exception)
            {

            }
        }

        private void CargarUnidadesMedida()
        {
            List<E_UnidadMedida> listado;
            N_UnidadMedida datos;
            try
            {
                datos = new N_UnidadMedida();
                listado = datos.ListadoCbo();
                this.CboUnidadMedida.DataSource = null;
                if (listado.Count > 0)
                {
                    this.CboUnidadMedida.DataSource = listado;
                    this.CboUnidadMedida.DisplayMember = "Nombre";
                    this.CboUnidadMedida.ValueMember = "CodigoUnidad";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActivaControles(bool valor)
        {
            this.GbProducto.Enabled = valor;
            this.GbListado.Enabled = !valor;
            if (valor)
            {
                this.CboCategoriaProducto.Focus();
            }
            else
            {
                this.TxtNombreBuscar.Focus();
            }
        }

        private void Limpiar()
        {
            this.CboCategoriaProducto.SelectedIndex = -1;
            this.CboMarcaProducto.SelectedIndex = -1;
            this.TxtNombreProducto.Text = "";
            this.TxtDescripcion.Text = "";
            this.NudPrecio.Value = 0;
        }

        private E_Producto CrearEntidad()
        {
            E_Producto entidad = new E_Producto()
            {
                Categoria = (E_CategoriaProducto)this.CboCategoriaProducto.SelectedItem,
                CodigoMarca = ((E_MarcaProducto)this.CboMarcaProducto.SelectedItem).CodigoMarca,
                Nombre = this.TxtNombreProducto.Text,
                Descripcion = this.TxtDescripcion.Text,
                StockMinimo = Convert.ToInt32(this.NudStockMinimo.Value),
                Precio = (double)this.NudPrecio.Value,
            };

            if(actual != null)
            {
                entidad.CodigoProducto = this.actual.CodigoProducto;
            }

            return entidad;
        }

        private void PresentarDatos()
        {
            try
            {
                N_MarcaProducto nMarca = new N_MarcaProducto();
                N_Producto n_Producto = new N_Producto();
                this.actual = n_Producto.LeerProducto(this.actual.CodigoProducto);
                if(this.actual != null)
                {
                    this.CargarCategorias();
                    this.CboCategoriaProducto.SelectedValue = this.actual.Categoria.CodigoCategoria;
                    this.CargarMarcas();
                    this.CboMarcaProducto.SelectedValue = this.actual.CodigoMarca;
                    this.TxtNombreProducto.Text = this.actual.Nombre;
                    this.TxtDescripcion.Text = this.actual.Descripcion;
                    this.NudPrecio.Value = (decimal)this.actual.Precio;
                }
                else
                {
                    MessageBox.Show("Datos no encontrados", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.ActivaControles(false);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo Cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActivaControles(false);
            }
        }

        private void ListarProductos()
        {
            try
            {
                N_Producto datos = new N_Producto();
                List<E_Producto> listado = datos.ListarProductos(this.TxtNombreBuscar.Text);

                this.DgvListado.DataSource = null;
                if (listado.Count > 0)
                {
                    this.DgvListado.AutoGenerateColumns = false;
                    this.DgvListado.DataSource = listado;

                    foreach (DataGridViewRow filas in DgvListado.Rows)
                    {
                        if (!(filas.DataBoundItem as E_Producto).Vigente)
                        {
                            filas.DefaultCellStyle.BackColor = Color.Yellow;
                            filas.DefaultCellStyle.ForeColor = Color.Red;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.ActivaControles(true);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivaControles(false);
            this.Limpiar();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                try
                {
                    E_Producto objProducto = this.CrearEntidad();
                    N_Producto p = new N_Producto();
                    if (actual == null)
                    {
                        p.RegistrarProducto(objProducto);
                        MessageBox.Show("Datos registrados con éxito", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        ListarProductos();
                    }
                    else
                    {
                        p.Actualizar(objProducto);
                        MessageBox.Show("Datos modificados con éxito", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        ListarProductos();
                        ActivaControles(false);
                    }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo realizar a acción", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnListarProducto_Click(object sender, EventArgs e)
        {
            this.ListarProductos();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (this.DgvListado.CurrentRow != null)
            {
                this.actual = this.DgvListado.CurrentRow.DataBoundItem as E_Producto;
                this.PresentarDatos();
                this.ActivaControles(true);
                this.TxtNombreProducto.Focus();
            }
            else
            {
                MessageBox.Show("Debe elegir una fila", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DgvListado.Focus();
            }
        }

        private void BtnDarBaja_Click(object sender, EventArgs e)
        {
            if (this.DgvListado.CurrentRow != null)
            {
                int cod = (this.DgvListado.CurrentRow.DataBoundItem as E_Producto).CodigoProducto;
                N_Producto n_Producto = new N_Producto();
                n_Producto.DarBajaProducto(cod);
                ListarProductos();
            }
            else
            {
                MessageBox.Show("Debe elegir una fila", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DgvListado.Focus();
            }
        }

        private void CboMarcaProducto_Enter(object sender, EventArgs e)
        {
            if(this.CboCategoriaProducto.SelectedIndex > -1)
            {
                this.CargarMarcas();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una categoria", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.CboCategoriaProducto.Focus();
            }
        }

        private void CboCategoriaProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CboMarcaProducto.DataSource = null;
        }
    }
}
