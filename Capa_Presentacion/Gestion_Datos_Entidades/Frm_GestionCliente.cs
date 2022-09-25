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
    public partial class Frm_GestionCliente : Form
    {
        private E_Cliente actual = null;
        public Frm_GestionCliente()
        {
            InitializeComponent();
        }

        private void Frm_GestionCliente_Load(object sender, EventArgs e)
        {
            this.CargarDepartamentos();
            this.LimpiarControles();
        }

        #region "Mis métodos"
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

        private void ActivaControles(bool estado)
        {
            this.GbCliente.Enabled = estado;
            this.GbListado.Enabled = !estado;

            if (estado)
                this.TxtDni.Focus();
            else
                this.BtnBuscar.Focus();
        }

        private void LimpiarControles()
        {
            this.TxtDni.Clear();
            this.TxtNombres.Clear();
            this.TxtApellidos.Clear();
            this.CboDistrito.SelectedIndex = -1;
            this.CboProvincia.SelectedIndex = -1;
            this.CboDepartamento.SelectedIndex = -1;
            this.TxtDireccion.Clear();
            this.TxtTelefono.Clear();
            this.TxtCorreo.Clear();
            this.actual = null;
            this.ErrNotificator.Clear();
        }

        private E_Cliente CrearEntidad()
        {
            E_Cliente obj = new E_Cliente()
            {
                NumeroDni = this.TxtDni.Text,
                Nombres = this.TxtNombres.Text,
                Apellidos = this.TxtApellidos.Text,
                Direccion = this.TxtDireccion.Text,
                Telefono = this.TxtTelefono.Text,
                Correo = this.TxtCorreo.Text
            };
            if(this.CboDistrito.SelectedIndex == -1)
            {
                obj.CodigoDistrito = 0;
            }
            else
            {
                obj.CodigoDistrito = (this.CboDistrito.SelectedItem as E_Distrito).CodigoDistrito;
            }
            if(this.actual != null)
            {
                obj.CodigoCliente = this.actual.CodigoCliente;
            }
            return obj;
        }

        private void ListarClientes()
        {
            this.DgvListado.DataSource = null;
            try
            {
                N_Cliente n_Cliente = new N_Cliente();
                List<E_Cliente> listado = n_Cliente.Listado(this.TxtNombreBuscar.Text);

                if(listado.Count > 0)
                {
                    this.DgvListado.AutoGenerateColumns = false;
                    this.DgvListado.DataSource = listado;

                    foreach (DataGridViewRow filas in DgvListado.Rows)
                    {
                        if (!(filas.DataBoundItem as E_Cliente).Vigente)
                        {
                            filas.DefaultCellStyle.BackColor = Color.Yellow;
                            filas.DefaultCellStyle.ForeColor = Color.Red;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo Obtener los datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PresentarDatos()
        {
            N_Cliente datos = new N_Cliente();
            int codPro, codDep;
            N_UbigeoPeru ubigeo = new N_UbigeoPeru();
            try
            {
                this.actual = datos.LeerCliente(this.actual.CodigoCliente);
                if (this.actual != null)
                {
                    if(this.actual.CodigoDistrito > 0)
                    {
                        codPro = ubigeo.GetCodigoProvincia((int)this.actual.CodigoDistrito);
                        codDep = ubigeo.GetCodigoDepartamento(codPro);
                        this.CargarDepartamentos();
                        this.CboDepartamento.SelectedValue = codDep;
                        this.CargarProvincias();
                        this.CboProvincia.SelectedValue = codPro;
                        this.CargarDistritos();
                        this.CboDistrito.SelectedValue = this.actual.CodigoDistrito;
                    }
                    
                    this.TxtDni.Text = this.actual.NumeroDni;
                    this.TxtNombres.Text = this.actual.Nombres;
                    this.TxtApellidos.Text = this.actual.Apellidos;
                    this.TxtDireccion.Text = this.actual.Direccion;
                    this.TxtTelefono.Text = this.actual.Telefono;
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
        #endregion

        #region "Eventos de Click"
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                try
                {
                    E_Cliente objCliente = this.CrearEntidad();
                    N_Cliente n_Cliente = new N_Cliente();
                    if(this.actual == null)
                    {
                        n_Cliente.Registrar(objCliente);
                        MessageBox.Show("Datos registrados con Éxito", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LimpiarControles();
                        this.ListarClientes();
                    }
                    else
                    {
                        n_Cliente.Actualizar(objCliente);
                        MessageBox.Show("Datos actualizados con Éxito", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LimpiarControles();
                        this.ListarClientes();
                        this.ActivaControles(false);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo realizar la acción", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivaControles(false);
            this.LimpiarControles();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.ActivaControles(true);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (this.DgvListado.CurrentRow != null)
            {
                this.actual = (E_Cliente)this.DgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
                this.ActivaControles(true);
                this.TxtDni.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DgvListado.Focus();
            }
        }

        private void BtnDarBaja_Click(object sender, EventArgs e)
        {
            N_Cliente baja;
            if (this.DgvListado.CurrentRow != null)
            {
                int codProveedor = ((E_Cliente)this.DgvListado.CurrentRow.DataBoundItem).CodigoCliente;
                baja = new N_Cliente();
                baja.DarBajaCliente(codProveedor);
                this.ListarClientes();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DgvListado.Focus();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.ListarClientes();
        }

        #endregion

        #region "Enventos de Validación"

        #endregion

        #region "Otros Eventos"
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

        private void TxtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidaSoloNumeros(e);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidaSoloNumeros(e);
        }

        #endregion

        private void TxtDni_Validating(object sender, CancelEventArgs e)
        {
            if(this.TxtDni.Text.Length == 8)
            {
                this.ErrNotificator.SetError(this.TxtDni, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.TxtDni, "El Dni debe tener 8 dígitos");
                e.Cancel = true;
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
                this.ErrNotificator.SetError(this.TxtNombres, "El nombre no debe estar vacío");
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
                this.ErrNotificator.SetError(this.TxtApellidos, "El apellido no debe estar vacío");
                e.Cancel = true;
            }
        }
    }
}
