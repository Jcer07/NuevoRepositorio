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
    public partial class Frm_GestionCategorias : Form
    {
        private E_CategoriaProducto actual = null;
        public Frm_GestionCategorias()
        {
            InitializeComponent();
        }

        #region "Mis Eventos"
        private void ActivarControles(bool estado)
        {
            this.GbCategoria.Enabled = estado;
            this.GbListado.Enabled = !estado;
            if (estado)
                this.TxtNombre.Focus();
            else
                this.BtnListar.Focus();
        }

        private void Limpiar()
        {
            this.TxtNombre.Clear();
            this.TxtDescripcion.Clear();
            this.actual = null;
            this.ErrNotificator.Clear();
        }

        private void ListarCategorias()
        {
            this.DgvListado.DataSource = null;
            try
            {
                N_CategoriaProducto cat = new N_CategoriaProducto();
                List<E_CategoriaProducto> listado = cat.ListadoCategorias();
                
                if(listado.Count > 0)
                {
                    this.DgvListado.AutoGenerateColumns = false;
                    this.DgvListado.DataSource = listado;

                    foreach (DataGridViewRow filas in DgvListado.Rows)
                    {
                        if (!(filas.DataBoundItem as E_CategoriaProducto).Vigente)
                        {
                            filas.DefaultCellStyle.BackColor = Color.Yellow;
                            filas.DefaultCellStyle.ForeColor = Color.Red;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar los datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private E_CategoriaProducto CrearEntidad()
        {
            E_CategoriaProducto categoria = new E_CategoriaProducto()
            {
                Nombre = this.TxtNombre.Text,
                Descripcion = this.TxtDescripcion.Text
            };

            if(this.actual != null)
            {
                categoria.CodigoCategoria = this.actual.CodigoCategoria;
            }
            return categoria;
        }

        private void PresentarDatos()
        {
            try
            {
                N_CategoriaProducto nCategoria = new N_CategoriaProducto();
                this.actual = nCategoria.LeerCategoria(this.actual.CodigoCategoria);
                if(this.actual != null)
                {
                    this.TxtNombre.Text = this.actual.Nombre;
                    this.TxtDescripcion.Text = this.actual.Descripcion;
                }
                else
                {
                    MessageBox.Show("No se encontró los datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar los datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Eventos de Clic"
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                try
                {
                    E_CategoriaProducto categoria = this.CrearEntidad();
                    N_CategoriaProducto nCategoria = new N_CategoriaProducto();
                    if(this.actual == null)
                    {
                        nCategoria.Registrar(categoria);
                        MessageBox.Show("Datos registrados con Éxito", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Limpiar();
                        this.ListarCategorias();
                    }
                    else
                    {
                        nCategoria.Actualizar(categoria);
                        MessageBox.Show("Datos modificados con Éxito", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Limpiar();
                        this.ListarCategorias();
                        this.ActivarControles(false);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo realizar la accción", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
            this.Limpiar();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.ActivarControles(true);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (this.DgvListado.CurrentRow != null)
            {
                this.actual = this.DgvListado.CurrentRow.DataBoundItem as E_CategoriaProducto;
                this.PresentarDatos();
                this.ActivarControles(true);
                this.TxtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DgvListado.Focus();
            }
        }

        private void BtnDarDeBaja_Click(object sender, EventArgs e)
        {
            if (this.DgvListado.CurrentRow != null)
            {
                int codCategoria = (this.DgvListado.CurrentRow.DataBoundItem as E_CategoriaProducto).CodigoCategoria;
                N_CategoriaProducto nCategoria = new N_CategoriaProducto();
                nCategoria.DarBajaCategoria(codCategoria);
                this.ListarCategorias();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DgvListado.Focus();
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            this.ListarCategorias();
        }
        #endregion

        private void TxtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.TxtNombre.Text))
            {
                this.ErrNotificator.SetError(this.TxtNombre, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.TxtNombre, "El campo no debe estar vacío");
                e.Cancel = true;
            }
        }
    }
}
