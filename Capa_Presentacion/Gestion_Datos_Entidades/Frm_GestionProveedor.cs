using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Entidades;
using System.Text.RegularExpressions;

namespace ComercializacionFerroCenter.Gestion_Datos_Entidades
{
    public partial class Frm_GestionProveedor : Form
    {
        private E_Proveedor actual = null;
        public Frm_GestionProveedor()
        {
            InitializeComponent();
        }

        private void Frm_GestionProveedor_Load(object sender, EventArgs e)
        {
            this.LimpiarControles();
            this.CargarDepartamentos();
        }

        #region Mis Métodos

        private void CargarDepartamentos()
        {
            N_UbigeoPeru ubigeo;
            List<E_Departamento> listado;

            try
            {
                ubigeo = new N_UbigeoPeru();
                listado = ubigeo.ListadoDepartamentos();
                CboDepartamento.DataSource = null;
                if (listado.Count > 0)
                {
                    this.CboDepartamento.DataSource = listado;
                    this.CboDepartamento.DisplayMember = "NombreDepartamento";
                    this.CboDepartamento.ValueMember = "CodigoDepartamento";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar los departamentos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProvincias()
        {
            N_UbigeoPeru ubigeo;
            List<E_Provincia> listado;
            int cod = ((E_Departamento)this.CboDepartamento.SelectedItem).CodigoDepartamento;

            try
            {
                ubigeo = new N_UbigeoPeru();
                listado = ubigeo.ListadoProvincias(cod);
                CboProvincia.DataSource = null;
                if (listado.Count > 0)
                {
                    this.CboProvincia.DataSource = listado;
                    this.CboProvincia.DisplayMember = "NombreProvincia";
                    this.CboProvincia.ValueMember = "CodigoProvincia";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar los Provincias", "Sistema");
            }
        }

        private void CargarDistritos()
        {
            N_UbigeoPeru ubigeo;
            List<E_Distrito> listado;
            int cod = ((E_Provincia)this.CboProvincia.SelectedItem).CodigoProvincia;

            try
            {
                ubigeo = new N_UbigeoPeru();
                listado = ubigeo.ListadoDistritos(cod);
                CboDistrito.DataSource = null;
                if (listado.Count > 0)
                {
                    this.CboDistrito.DataSource = listado;
                    this.CboDistrito.DisplayMember = "NombreDistrito";
                    this.CboDistrito.ValueMember = "CodigoDistrito";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar los Distritos", "Sistema");
            }
        }

        private void ValidaSoloNumeros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private bool ValidaCorreo(string correo)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo, expresion))
            {
                if (Regex.Replace(correo, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void ActivaControles(bool estado)
        {
            this.GbProveedor.Enabled = estado;
            this.GbListado.Enabled = !estado;

            if (estado)
                this.TxtRuc.Focus();
            else
                this.BtnBuscar.Focus();
        }

        private void LimpiarControles()
        {
            this.TxtRuc.Clear();
            this.TxtRazonSocial.Clear();
            this.TxtTelefono.Clear();
            this.CboDepartamento.SelectedIndex = -1;
            this.CboProvincia.DataSource = null;
            this.CboDistrito.DataSource = null;
            this.TxtDireccion.Clear();
            this.TxtSitioWeb.Clear();
            this.TxtCorreo.Clear();
            this.actual = null;
            this.ErrNotificator.Clear();
        }

        private E_Proveedor CrearEntidad()
        {
            E_Proveedor obj = new E_Proveedor()
            {
                NumeroRuc = this.TxtRuc.Text,
                RazonSocial = this.TxtRazonSocial.Text,
                Telefono = this.TxtTelefono.Text,
                Distrito = this.CboDistrito.SelectedItem as E_Distrito,
                Direccion = this.TxtDireccion.Text,
                SitioWeb = this.TxtSitioWeb.Text,
                Correo = this.TxtCorreo.Text
            };
            if (this.actual != null)
            {
                obj.CodigoProveedor = this.actual.CodigoProveedor;
            }
            return obj;
        }

        private void ListarProveedores()
        {
            this.DgvListado.DataSource = null;
            try
            {
                N_Proveedor n_Proveedor = new N_Proveedor();

                List<E_Proveedor> listado = n_Proveedor.Listado(this.TxtRazonSocialBuscar.Text);
                if (listado.Count > 0)
                {
                    this.DgvListado.AutoGenerateColumns = false;
                    this.DgvListado.DataSource = listado;

                    foreach (DataGridViewRow filas in DgvListado.Rows)
                    {
                        if (!(filas.DataBoundItem as E_Proveedor).Vigente)
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
            N_Proveedor datos = new N_Proveedor();
            int codPro, codDep;
            N_UbigeoPeru ubigeo = new N_UbigeoPeru();
            try
            {
                this.actual = datos.LeerProveedor(this.actual.CodigoProveedor);
                if (this.actual != null)
                {
                    codPro = ubigeo.GetCodigoProvincia(this.actual.CodigoDistrito);
                    codDep = ubigeo.GetCodigoDepartamento(codPro);
                    this.TxtRuc.Text = this.actual.NumeroRuc;
                    this.TxtRazonSocial.Text = this.actual.RazonSocial;
                    this.TxtTelefono.Text = this.actual.Telefono;
                    this.CargarDepartamentos();
                    this.CboDepartamento.SelectedValue = codDep;
                    this.CargarProvincias();
                    this.CboProvincia.SelectedValue = codPro;
                    this.CargarDistritos();
                    this.CboDistrito.SelectedValue = this.actual.CodigoDistrito;
                    this.TxtDireccion.Text = this.actual.Direccion;
                    this.TxtSitioWeb.Text = this.actual.SitioWeb;
                    this.TxtCorreo.Text = this.actual.Correo;
                }
                else
                {
                    MessageBox.Show("Datos no encontrados", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Enventos Click
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.LimpiarControles();
            this.ActivaControles(true);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarControles();
            this.ActivaControles(false);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                E_Proveedor objProveedor = this.CrearEntidad();
                N_Proveedor n_Proveedor = new N_Proveedor();
                try
                {
                    if(this.actual == null)
                    {
                        n_Proveedor.Registrar(objProveedor);
                        MessageBox.Show("Datos registrados con Éxito", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LimpiarControles();
                        this.ListarProveedores();
                    }
                    else
                    {
                        n_Proveedor.Actualizar(objProveedor);
                        MessageBox.Show("Datos Actualizados con Éxito", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LimpiarControles();
                        this.ListarProveedores();
                        this.ActivaControles(false);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo realizar la accción", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (this.DgvListado.CurrentRow != null)
            {
                this.actual = (E_Proveedor)this.DgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
                this.ActivaControles(true);
                this.TxtRuc.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DgvListado.Focus();
            }
        }

        private void BtnDarBaja_Click(object sender, EventArgs e)
        {
            N_Proveedor baja;
            if (this.DgvListado.CurrentRow != null)
            {
                int codProveedor = ((E_Proveedor)this.DgvListado.CurrentRow.DataBoundItem).CodigoProveedor;
                baja = new N_Proveedor();
                baja.DarBajaProveedor(codProveedor);
                this.ListarProveedores();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DgvListado.Focus();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.ListarProveedores();
        }
        #endregion

        #region Eventos de Validación

        private void TxtRuc_Validating(object sender, CancelEventArgs e)
        {
            if (this.TxtRuc.Text.Length == 11)
            {
                this.ErrNotificator.SetError(this.TxtRuc, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.TxtRuc, "El número de RUC debe tener 11 dígitos");
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
                this.ErrNotificator.SetError(this.TxtRazonSocial, "La Razón Social no debe estar vacía");
                e.Cancel = true;
            }
        }

        private void TxtTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.TxtTelefono.Text))
            {
                this.ErrNotificator.SetError(this.TxtTelefono, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.TxtTelefono, "El número de telefono no debe estar vacío");
                e.Cancel = true;
            }
        }

        private void TxtDireccion_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.TxtDireccion.Text))
            {
                this.ErrNotificator.SetError(this.TxtDireccion, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.TxtDireccion, "La Dirección no debe estar vacía");
                e.Cancel = true;
            }
        }

        private void TxtSitioWeb_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.TxtSitioWeb.Text))
            {
                this.ErrNotificator.SetError(this.TxtSitioWeb, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.TxtSitioWeb, "Debe ingresar un sitio web");
                e.Cancel = true;
            }
        }

        private void TxtCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (ValidaCorreo(this.TxtCorreo.Text))
            {
                this.ErrNotificator.SetError(this.TxtCorreo, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.TxtCorreo, "El formato de correo es Inválido");
                e.Cancel = true;
            }
        }

        private void CboDistrito_Validating(object sender, CancelEventArgs e)
        {
            if (this.CboDistrito.SelectedIndex > -1)
            {
                this.ErrNotificator.SetError(this.CboDistrito, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.CboDistrito, "Debe elegir un Distrito");
                e.Cancel = true;
            }
        }
        #endregion

        #region Otros Eventos

        private void CboProvincia_Enter(object sender, EventArgs e)
        {
            if (this.CboDepartamento.SelectedIndex > -1)
            {
                this.CargarProvincias();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Departamento", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.CboDepartamento.Focus();
            }
        }

        private void CboDistrito_Enter(object sender, EventArgs e)
        {
            if (this.CboProvincia.SelectedIndex > -1)
            {
                this.CargarDistritos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Provincia", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.CboProvincia.Focus();
            }
        }

        private void TxtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidaSoloNumeros(e);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidaSoloNumeros(e);
        }

        #endregion

    }
}
