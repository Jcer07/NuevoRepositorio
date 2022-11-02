using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Capa_Entidades;
using Capa_Negocio;

namespace ComercializacionFerroCenter.Gestion_Datos_Entidades
{
    public partial class Frm_GestionTipoPersonal : Form
    {
        private E_TipoPersonal actual = null;
        public Frm_GestionTipoPersonal()
        {
            InitializeComponent();
        }

        #region "Mis métodos"
        private void ActivarControles(bool estado)
        {
            this.GbTipoPersonal.Enabled = estado;
            this.GbListado.Enabled = !estado;
            if (estado)
                this.TxtNombre.Focus();
            else
                this.BtnListar.Focus();
        }

        private void LimpiarControles()
        {
            this.TxtNombre.Clear();
            this.TxtDescripcion.Clear();
            this.actual = null;
            this.ErrNotificator.Clear();
        }

        private E_TipoPersonal CrearEntidad()
        {
            E_TipoPersonal obj = new E_TipoPersonal()
            {
                NombreTipo = this.TxtNombre.Text,
                Descripcion = this.TxtDescripcion.Text
            };
            if(this.actual != null)
            {
                obj.CodigoTipoPersonal = this.actual.CodigoTipoPersonal;
            }
            return obj;
        }

        private void ListadoTipoPersonal()
        {
            this.DgvListado.DataSource = null;
            try
            {
                N_TipoPersonal nTipoPersonal = new N_TipoPersonal();
                List<E_TipoPersonal> listado = nTipoPersonal.ListadoTipoPersonal();
                if(listado != null)
                {
                    this.DgvListado.AutoGenerateColumns = false;
                    this.DgvListado.DataSource = listado;

                    foreach (DataGridViewRow filas in DgvListado.Rows)
                    {
                        if (!(filas.DataBoundItem as E_TipoPersonal).Vigente)
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

        private void PresentarDatos()
        {
            try
            {
                N_TipoPersonal nTipoPersonal = new N_TipoPersonal();
                this.actual = nTipoPersonal.LeerTipoPersonal(this.actual.CodigoTipoPersonal);
                if(this.actual != null)
                {
                    this.TxtNombre.Text = this.actual.NombreTipo;
                    this.TxtDescripcion.Text = this.actual.Descripcion;
                }
                else
                {
                    MessageBox.Show("No se encontró resultados", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo recuperar los datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    E_TipoPersonal objTipoPersonal = this.CrearEntidad();
                    N_TipoPersonal nTipoPersonal = new N_TipoPersonal();
                    if(this.actual == null)
                    {
                        nTipoPersonal.Registrar(objTipoPersonal);
                        MessageBox.Show("Datos registrado con éxito", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LimpiarControles();
                        this.ListadoTipoPersonal();
                    }
                    else
                    {
                        nTipoPersonal.Actualizar(objTipoPersonal);
                        MessageBox.Show("Datos modificados con éxito", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LimpiarControles();
                        this.ListadoTipoPersonal();
                        this.ActivarControles(false);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo realiza la accción", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (this.DgvListado.CurrentRow != null)
            {
                this.actual = this.DgvListado.CurrentRow.DataBoundItem as E_TipoPersonal;
                this.PresentarDatos();
                this.ActivarControles(true);
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
                N_TipoPersonal nTipoPersonal = new N_TipoPersonal();
                nTipoPersonal.DarBajaTipoPersonal((this.DgvListado.CurrentRow.DataBoundItem as E_TipoPersonal).CodigoTipoPersonal);
                this.ListadoTipoPersonal();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DgvListado.Focus();
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            this.ListadoTipoPersonal();
        }
        #endregion

        #region "Eventos de Validación"
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

        private void Frm_GestionTipoPersonal_Load(object sender, EventArgs e)
        {

        }
    }
}
