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

namespace Capa_Presentacion.Gestion_Datos_Entidades
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
            this.CargarMarcas();
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
                listado = datos.ListadoMarcas();
                if (listado.Count > 0)
                {
                    this.CboMarcaProducto.DataSource = listado;
                    this.CboMarcaProducto.DisplayMember = "NombreMarca";
                    this.CboMarcaProducto.ValueMember = "CodigoMarca";
                }
            }
            catch (Exception)
            {

            }
        }

        private void CargarCategorias()
        {
            List<E_CategoriaProducto> listado;
            N_CategoriaProducto datos;
            try
            {
                datos = new N_CategoriaProducto();
                listado = datos.ListadoCategorias();
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
                Precio = (double)this.NudPrecio.Value,
            };

            if(actual != null)
            {
                entidad.CodigoProducto = this.actual.CodigoProducto;
            }

            return entidad;
        }

        #endregion

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.ActivaControles(true);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivaControles(false);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                try
                {
                    E_Producto producto = this.CrearEntidad();
                    N_Producto p = new N_Producto();
                    if (actual == null)
                    {
                        p.RegistrarProducto(producto);
                        MessageBox.Show("Datos registrados con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void BtnListarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                N_Producto datos = new N_Producto();
                List<E_Producto> listado = datos.ListarProductos(this.TxtNombreBuscar.Text);

                if(listado.Count > 0)
                {
                    this.DgvListado.AutoGenerateColumns = false;
                    this.DgvListado.DataSource = listado;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
