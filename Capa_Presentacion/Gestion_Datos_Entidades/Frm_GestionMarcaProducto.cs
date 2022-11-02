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

namespace ComercializacionFerroCenter.Gestion_Datos_Entidades
{
    public partial class Frm_GestionMarcaProducto : Form
    {
        private E_MarcaProducto actual = null;
        public Frm_GestionMarcaProducto()
        {
            InitializeComponent();
        }

        private void Frm_GestionMarcaProducto_Load(object sender, EventArgs e)
        {
            this.CargarCategorias();
        }

        #region "Mis Metodos"
        private void CargarCategorias()
        {
            this.CboCategoria.DataSource = null;
            try
            {
                N_CategoriaProducto nCategoria = new N_CategoriaProducto();
                List<E_CategoriaProducto> listado = nCategoria.ListadoCategoriasCbo();
                if(listado != null)
                {
                    this.CboCategoria.DataSource = listado;
                    this.CboCategoria.DisplayMember = "Nombre";
                    this.CboCategoria.ValueMember = "CodigoCategoria";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar los datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void ActivarControles(bool estado)
        {
            this.GbMarcaProducto.Enabled = estado;
            this.GbListado.Enabled = !estado;
            if (estado)
                this.TxtNombre.Focus();
            else
                this.TxtMarca.Focus();
        }

        private void LimpiarControles()
        {
            this.CboCategoria.SelectedIndex = -1;
            this.TxtNombre.Clear();
            this.TxtDescripcion.Clear();
            this.actual = null;
            this.ErrNotificator.Clear();
        }

        private void ListadoMarcas()
        {
            this.DgvListado.DataSource = null;
            try
            {
                N_MarcaProducto nMarca = new N_MarcaProducto();
                List<E_MarcaProducto> listado = nMarca.ListadoMarcas(this.TxtMarca.Text);

                if(listado != null)
                {
                    this.DgvListado.AutoGenerateColumns = false;
                    this.DgvListado.DataSource = listado;

                    foreach (DataGridViewRow filas in DgvListado.Rows)
                    {
                        if (!(filas.DataBoundItem as E_MarcaProducto).Vigente)
                        {
                            filas.DefaultCellStyle.BackColor = Color.Yellow;
                            filas.DefaultCellStyle.ForeColor = Color.Red;
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private E_MarcaProducto CrearEntidad()
        {
            E_MarcaProducto obj = new E_MarcaProducto()
            {
                CodigoCategoria = (this.CboCategoria.SelectedItem as E_CategoriaProducto).CodigoCategoria,
                NombreMarca = this.TxtNombre.Text,
                Descripcion = this.TxtDescripcion.Text
            };

            if(this.actual != null)
            {
                obj.CodigoMarca = this.actual.CodigoMarca;
            }
            return obj;
        }

        private void PresentarDatos()
        {
            try
            {
                N_MarcaProducto nMarca = new N_MarcaProducto();
                this.actual = nMarca.LeerMarcaProducto(this.actual.CodigoMarca);
                if(this.actual != null)
                {
                    this.CboCategoria.SelectedValue = this.actual.CodigoCategoria;
                    this.TxtNombre.Text = this.actual.NombreMarca;
                    this.TxtDescripcion.Text = this.actual.Descripcion;
                }
                else
                {
                    MessageBox.Show("Marca no encontrada", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener los datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Eventos de Clic"
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.ActivarControles(true);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
            this.LimpiarControles();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                try
                {
                    E_MarcaProducto objMarca = this.CrearEntidad();
                    N_MarcaProducto nMarca = new N_MarcaProducto();
                    if(this.actual == null)
                    {
                        nMarca.Registrar(objMarca);
                        MessageBox.Show("Datos registrados con exito", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LimpiarControles();
                        this.ListadoMarcas();
                    }
                    else
                    {
                        nMarca.Actualizar(objMarca);
                        MessageBox.Show("Datos modificados con exito", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LimpiarControles();
                        this.ListadoMarcas();
                        this.ActivarControles(false);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo realizar la acción", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (this.DgvListado.CurrentRow != null)
            {
                this.actual = this.DgvListado.CurrentRow.DataBoundItem as E_MarcaProducto;
                this.PresentarDatos();
                this.ActivarControles(true);
                this.CboCategoria.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DgvListado.Focus();
            }
        }

        private void BtnDarBaja_Click(object sender, EventArgs e)
        {
            if(this.DgvListado.CurrentRow != null)
            {
                N_MarcaProducto nMarca = new N_MarcaProducto();
                nMarca.DarBajaMarca((this.DgvListado.CurrentRow.DataBoundItem as E_MarcaProducto).CodigoMarca);
                this.ListadoMarcas();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DgvListado.Focus();
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            this.ListadoMarcas();
        }

        #endregion

        #region "Eventos de Validación"
        private void CboCategoria_Validating(object sender, CancelEventArgs e)
        {
            if(this.CboCategoria.SelectedIndex > -1)
            {
                this.ErrNotificator.SetError(this.CboCategoria, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.CboCategoria, "Debe elegir una categoria");
                e.Cancel = true;
            }
        }

        private void TxtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.TxtNombre.Text))
            {
                this.ErrNotificator.SetError(this.TxtNombre, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.TxtNombre, "El nombre no debe estar vacío");
                e.Cancel = true;
            }
        }
        #endregion
    }
}
