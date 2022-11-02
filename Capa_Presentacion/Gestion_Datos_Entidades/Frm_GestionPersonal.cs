using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Entidades;
using System.Text.RegularExpressions;

namespace ComercializacionFerroCenter
{
    public partial class Frm_GestionPersonal : Form
    {
        private E_Personal actual = null;
        public Frm_GestionPersonal()
        {
            InitializeComponent();
        }

        private void Frm_GestionPersonal_Load(object sender, EventArgs e)
        {
            this.TxtNombreBuscar.Focus();
            this.CargarDepartamentos();
            this.CargarTipoPersonal();
            this.CargarAlmacen();
            this.Limpiar();
        }

        #region Funciones

        private void CargarAlmacen()
        {
            N_Almacen datos;
            List<E_Almacen> listado;

            try
            {
                datos = new N_Almacen(); 
                listado = datos.ListadoAlmacen();
                this.CboAlmacen.DataSource = null;
                if (listado.Count > 0)
                {
                    this.CboAlmacen.DataSource = listado;
                    this.CboAlmacen.DisplayMember = "Descripcion";
                    this.CboAlmacen.ValueMember = "CodigoAlmacen";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar los tipos de Personal", "Sistema");
            }
        }
        private void CargarTipoPersonal()
        {
            N_TipoPersonal tp;
            List<E_TipoPersonal> listado;

            try
            {
                tp = new N_TipoPersonal();
                listado = tp.ListadoTipoPersonalCbo();
                this.CboTipoPersonal.DataSource = null;
                if(listado.Count > 0)
                {
                    this.CboTipoPersonal.DataSource = listado;
                    this.CboTipoPersonal.DisplayMember = "NombreTipo";
                    this.CboTipoPersonal.ValueMember = "CodigoTipoPersonal";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar el listado de tipos de Personal", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            this.ErrNotificator.Clear();
            this.TxtNombres.Text = "";
            this.TxtApellidos.Text = "";
            this.TxtDni.Text = "";
            this.TxtDireccion.Text = "";
            this.TxtCorreo.Text = "";
            this.TxtTelefono.Text = "";
            this.NudEdad.Value = 18;
            this.CboDepartamento.SelectedIndex = -1;
            this.CboTipoPersonal.SelectedIndex = -1;
            this.CboAlmacen.SelectedIndex = -1;
            this.actual = null;
        }

        private void HabilitaControles(bool v)
        {
            this.GbPersonal.Enabled = v;
            this.GbListado.Enabled = !v;
            if (v)
            {
                this.TxtDni.Focus();
            }
            else
            {
                this.TxtNombreBuscar.Focus();
            }
        }

        private void CargarDepartamentos()
        {
            N_UbigeoPeru ubigeo;
            List<E_Departamento> listado;

            try
            {
                ubigeo = new N_UbigeoPeru();
                listado = ubigeo.ListadoDepartamentos();
                CboDepartamento.DataSource = null;
                if(listado.Count > 0)
                {
                    this.CboDepartamento.DataSource = listado;
                    this.CboDepartamento.DisplayMember = "NombreDepartamento";
                    this.CboDepartamento.ValueMember = "CodigoDepartamento";
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No se pudo cargar los departamentos", "Sistema");
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

        private void ListarPersonal()
        {
            try
            {
                N_Personal datos = new N_Personal();
                List<E_Personal> listado = datos.ListadoPersonal(this.TxtNombreBuscar.Text);
                this.DgvListado.DataSource = null;
                if (listado.Count > 0)
                {
                    this.DgvListado.AutoGenerateColumns = false;
                    this.DgvListado.DataSource = listado;
                    foreach (DataGridViewRow filas in DgvListado.Rows)
                    {
                        if (!(filas.DataBoundItem as E_Personal).Vigente)
                        {
                            filas.DefaultCellStyle.BackColor = Color.Yellow;
                            filas.DefaultCellStyle.ForeColor = Color.Red;
                        }
                    }
                }

                
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar el listado de Personal", "Sistema");
            }
        }

        private E_Personal CrearEntidad()
        {
            E_Personal datos = new E_Personal()
            {
                NumeroDni = this.TxtDni.Text,
                Nombres = this.TxtNombres.Text,
                Apellidos = this.TxtApellidos.Text,
                CodigoDistrito = ((E_Distrito)this.CboDistrito.SelectedItem).CodigoDistrito,
                Direccion = this.TxtDireccion.Text,
                Telefono = this.TxtTelefono.Text,
                Correo = this.TxtCorreo.Text,
                Edad = (int)this.NudEdad.Value,
                TipoPersonal = (E_TipoPersonal)this.CboTipoPersonal.SelectedItem,
                CodigoAlmacen = ((E_Almacen)this.CboAlmacen.SelectedItem).CodigoAlmacen
            };

            if (this.actual != null)
            {
                datos.CodigoPersonal = this.actual.CodigoPersonal;
            }

            return datos;
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

        private void PresentarDatos()
        {
            N_Personal datos = new N_Personal();
            int codPro, codDep;
            N_UbigeoPeru ubigeo = new N_UbigeoPeru();
            try
            {
                this.actual = datos.LeerPersonal(this.actual.CodigoPersonal);
                if (this.actual != null)
                {
                    codPro = ubigeo.GetCodigoProvincia(this.actual.CodigoDistrito);
                    codDep = ubigeo.GetCodigoDepartamento(codPro);
                    this.CboTipoPersonal.SelectedValue = this.actual.TipoPersonal.CodigoTipoPersonal;
                    this.TxtDni.Text = this.actual.NumeroDni;
                    this.TxtNombres.Text = this.actual.Nombres;
                    this.TxtApellidos.Text = this.actual.Apellidos;
                    this.CargarDepartamentos();
                    this.CboDepartamento.SelectedValue = codDep;
                    this.CargarProvincias();
                    this.CboProvincia.SelectedValue = codPro;
                    this.CargarDistritos();
                    this.CboDistrito.SelectedValue = this.actual.CodigoDistrito;
                    this.TxtDireccion.Text = this.actual.Direccion;
                    this.TxtTelefono.Text = this.actual.Telefono;
                    this.TxtCorreo.Text = this.actual.Correo;
                    this.NudEdad.Value = this.actual.Edad;
                    this.CboAlmacen.SelectedValue = this.actual.CodigoAlmacen;
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

        private void CboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.CboDepartamento.SelectedIndex > -1)
            {
                this.CboProvincia.Enabled = true;
                this.CboProvincia.DataSource = null;
            }
            else
            {
                this.CboProvincia.DataSource = null;
                this.CboProvincia.Enabled = false;
            }
        }

        private void CboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CboProvincia.SelectedIndex > -1)
            {
                this.CboDistrito.Enabled = true;
                this.CboDistrito.DataSource = null;
            }
            else
            {
                this.CboDistrito.DataSource = null;
                this.CboDistrito.Enabled = false;
            }
        }

        private void CboProvincia_Enter(object sender, EventArgs e)
        {
            if (this.CboDepartamento.SelectedIndex > -1)
            {
                this.CargarProvincias();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Departamento", this.Text);
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
                MessageBox.Show("Debe seleccionar una Provincia", this.Text);
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.HabilitaControles(true);
            this.CboTipoPersonal.Focus();
            this.Limpiar();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.HabilitaControles(false);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.ListarPersonal();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                E_Personal objPersonal = this.CrearEntidad();
                N_Personal nPersonal = new N_Personal();
                try
                {
                    if (actual == null)
                    {
                        nPersonal.RegistrarPersonal(objPersonal);
                        MessageBox.Show("Datos registrados con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        ListarPersonal();
                    }
                    else
                    {
                        nPersonal.ModificarPersonal(objPersonal);
                        MessageBox.Show("Datos modificados con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        ListarPersonal();
                        this.HabilitaControles(false);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo realizar la acción", "Sistema");
                }
            }
        }

        private void CboTipoPersonal_Validating(object sender, CancelEventArgs e)
        {
            if(this.CboTipoPersonal.SelectedIndex > -1)
            {
                this.ErrNotificator.SetError(this.CboTipoPersonal, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.CboTipoPersonal, "Debe elegir un tipo de Personal");
                e.Cancel = true;
            }
        }

        private void TxtDni_Validating(object sender, CancelEventArgs e)
        {
            if(this.TxtDni.Text.Length == 8)
            {
                this.ErrNotificator.SetError(this.TxtDni, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.TxtDni, "El número de DNI debe tener 8 dígitos");
                e.Cancel= true;
            }
        }

        private void TxtNombres_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.TxtNombres.Text))
            {
                this.ErrNotificator.SetError(this.TxtNombres, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.TxtNombres, "El Nombre no debe estar vacío");
                e.Cancel = true;
            }
        }

        private void TxtApellidos_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.TxtApellidos.Text))
            {
                this.ErrNotificator.SetError(this.TxtApellidos, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.TxtApellidos, "El Apellido no debe estar vacío");
                e.Cancel = true;
            }
        }

        private void CboDepartamento_Validating(object sender, CancelEventArgs e)
        {
            if (this.CboDepartamento.SelectedIndex > -1)
            {
                this.ErrNotificator.SetError(this.CboDepartamento, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.CboDepartamento, "Debe elegir un Departamento");
                e.Cancel = true;
            }
        }

        private void CboProvincia_Validating(object sender, CancelEventArgs e)
        {
            if (this.CboProvincia.SelectedIndex > -1)
            {
                this.ErrNotificator.SetError(this.CboProvincia, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.CboProvincia, "Debe elegir una Provincia");
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

        private void TxtDireccion_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.TxtDireccion.Text))
            {
                this.ErrNotificator.SetError(this.TxtDireccion, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.TxtDireccion, "Debe ingresar una dirección");
                e.Cancel = true;
            }
        }

        private void TxtTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (this.TxtTelefono.Text.Length == 9)
            {
                this.ErrNotificator.SetError(this.TxtTelefono, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.TxtTelefono, "El número de telefono debe tener 9 dígitos");
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

        private void NudEdad_Validating(object sender, CancelEventArgs e)
        {
            if(this.NudEdad.Value >= 18)
            {
                this.ErrNotificator.SetError(this.NudEdad, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.NudEdad, "La edad debe ser mayor o igual a 18");
                e.Cancel = true;
            }
        }

        private void CboAlmacen_Validating(object sender, CancelEventArgs e)
        {
            if (this.CboAlmacen.SelectedIndex > -1)
            {
                this.ErrNotificator.SetError(this.CboAlmacen, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.CboAlmacen, "Debe elegir un Almacén");
                e.Cancel = true;
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidaSoloNumeros(e);
        }

        private void TxtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidaSoloNumeros(e);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if(this.DgvListado.CurrentRow != null)
            {
                this.actual = (E_Personal)this.DgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
                this.HabilitaControles(true);
                this.CboTipoPersonal.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DgvListado.Focus();
            }
        }

        private void BtnDarBaja_Click(object sender, EventArgs e)
        {
            N_Personal baja;
            if(this.DgvListado.CurrentRow != null)
            {
                E_Personal p = (E_Personal)this.DgvListado.CurrentRow.DataBoundItem;
                baja = new N_Personal();
                baja.DarDeBaja(p);
                this.ListarPersonal();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DgvListado.Focus();
            }
        }
    }
}
