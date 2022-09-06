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
    public partial class Frm_GestionUsuario : Form
    {
        private E_Usuario actual = null;
        private E_Personal personal = null;
        private List<E_TipoPersonal> listado;
        public Frm_GestionUsuario()
        {
            InitializeComponent();
        }

        private void Frm_GestionUsuario_Load(object sender, EventArgs e)
        {
            this.TxtUsuarioBuscar.Focus();
            this.LimpiarCasillas();
            this.CargarTipoPersonal();
            //this.ListarUsuarios();
        }

        #region Mis métodos
        private void ActivaControles(bool estado, bool valor)
        {
            this.GbPersonal.Enabled = estado;
            this.GbUsuario.Enabled = estado;
            this.GbListado.Enabled = !estado;
            if (estado)
                this.TxtDni.Focus();
            else
                this.TxtUsuarioBuscar.Focus();

            if (valor)
            {
                this.TxtDni.ReadOnly = !valor;
                this.BtnBuscarPersonal.Enabled = valor;
            }
            else
            {
                this.TxtDni.ReadOnly = !valor;
                this.BtnBuscarPersonal.Enabled = valor;
            }
        }

        private void ListarUsuarios()
        {
            try
            {
                N_Usuario datos = new N_Usuario();
                List<E_Usuario> usuarios = datos.ListarUsuarios(this.TxtUsuarioBuscar.Text);
                this.DgvListado.DataSource = null;
                if(usuarios.Count > 0)
                {
                    this.DgvListado.AutoGenerateColumns = false;
                    this.DgvListado.DataSource = usuarios;

                    foreach (DataGridViewRow filas in DgvListado.Rows)
                    {
                        if (!(filas.DataBoundItem as E_Usuario).Vigente)
                        {
                            filas.DefaultCellStyle.BackColor = Color.Yellow;
                            filas.DefaultCellStyle.ForeColor = Color.Red;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar la lista de usuarios", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCasillas()
        {
            this.TxtDni.Text = "";
            this.TxtNombrePersonal.Text = "";
            this.TxtSiglasTipoUsuario.Text = "";
            this.TxtNombreUsuario.Text = "";
            this.TxtClave.Text = "";
            this.TxtRepiteClave.Text = "";
            this.actual = null;
            this.ErrNotificator.Clear();
            this.personal = null;
        }

        private void CargarTipoPersonal()
        {
            N_TipoPersonal tipos;
            try
            {
                tipos = new N_TipoPersonal();
                listado = tipos.ListadoTpCbo();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al cargar los datos");
            }
        }

        private String LeerTipoPersonal(int codigoPersonal)
        {
            String valor = "";

            foreach (E_TipoPersonal personal in listado)
            {
                if(personal.CodigoTipoPersonal == codigoPersonal)
                {
                    valor = personal.NombreTipo;
                }
            }

            return valor;
        }

        private String CargarSiglasTipoPersonal(int codigoTipoPersonal)
        {
            String valor = "";
            foreach (E_TipoPersonal personal in listado)
            {
                if(personal.CodigoTipoPersonal == codigoTipoPersonal)
                {
                    valor = personal.NombreTipo.Substring(0, 5);
                }
            }

            return valor;
        }

        private bool ValidaContraseña(String password)
        {
            bool Mayuscula = false;
            bool Minuscula = false;
            bool Numero = false;
            bool CarEspecial = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password, i))
                {
                    Mayuscula = true;
                }
                else if (Char.IsLower(password, i))
                {
                    Minuscula = true;
                }
                else if (Char.IsDigit(password, i))
                {
                    Numero = true;
                }
                else
                {
                    CarEspecial = true;
                }
            }
            if (Mayuscula && Minuscula && Numero && CarEspecial && password.Length >= 8)
            {
                return true;
            }
            return false;
        }

        private E_Usuario CrearEntidad()
        {
            E_Usuario user = new E_Usuario()
            {
                NombreUsuario = this.TxtNombreUsuario.Text,
                Clave = this.TxtClave.Text,
                TipoUsuario = this.TxtTipoUsuario.Text,
                SiglasUsuario = this.TxtSiglasTipoUsuario.Text,
                Vigente = true,
                Personal = this.personal
            };

            if(this.actual != null)
            {
                user.CodigoUsuario = this.actual.CodigoUsuario;
            }

            return user;
        }

        private void PresentaDatos()
        {
            N_Usuario datos = new N_Usuario();

            try
            {
                this.actual = datos.ObtenerUsuario(this.actual.CodigoUsuario);
                if(this.actual != null)
                {
                    this.TxtDni.Text = this.actual.Personal.NumeroDni;
                    this.TxtNombrePersonal.Text = this.actual.NombrePersonal;
                    this.TxtTipoUsuario.Text = this.actual.TipoUsuario;
                    this.TxtNombreUsuario.Text = this.actual.NombreUsuario;
                    this.TxtSiglasTipoUsuario.Text = this.actual.SiglasUsuario;
                }
                else
                {
                    MessageBox.Show("Datos no encontrados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar los datos solicitados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActivaControles(false, false);
            }
        }

        #endregion

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.ActivaControles(true, true);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivaControles(false, false);
            this.LimpiarCasillas();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            this.ListarUsuarios();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                E_Usuario user = this.CrearEntidad();
                N_Usuario n_Usuario = new N_Usuario();
                try
                {
                    if (actual == null)
                    {
                        n_Usuario.Registrar(user);
                        MessageBox.Show("Usuario Registrado con Éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCasillas();
                    }
                    else
                    {
                        n_Usuario.Actualizar(user);
                        MessageBox.Show("Usuario Modificado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.ListarUsuarios();
                        this.ActivaControles(false, true);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo realizar la acción", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnBuscarPersonal_Click(object sender, EventArgs e)
        {
            N_Personal datos;
            if (this.TxtDni.Text.Length == 8)
            {
                try
                {
                    datos = new N_Personal();
                    this.personal = datos.RetornaPersonal(this.TxtDni.Text);
                    if (this.personal != null)
                    {
                        this.TxtNombrePersonal.Text = this.personal.NombresApellidos;
                        this.TxtTipoUsuario.Text = this.LeerTipoPersonal(this.personal.TipoPersonal.CodigoTipoPersonal);
                        this.TxtSiglasTipoUsuario.Text = this.CargarSiglasTipoPersonal(this.personal.TipoPersonal.CodigoTipoPersonal);
                    }
                    else
                        MessageBox.Show("Dni no encontrado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                this.ErrNotificator.SetError(this.TxtDni, "El DNI debe tener 8 dígitos");
            }
        }

        private void TxtDni_TextChanged(object sender, EventArgs e)
        {
            if(TxtDni.Text.Length == 8)
            {
                this.ErrNotificator.SetError(this.TxtDni, "");
            }
        }

        private void TxtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtNombreUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.TxtNombreUsuario.Text))
            {
                this.ErrNotificator.SetError(this.TxtNombreUsuario, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.TxtNombreUsuario, "Debe ingresar un nombre de Usuario");
                e.Cancel = true;
            }
        }

        private void TxtClave_Validating(object sender, CancelEventArgs e)
        {
            
            if(!String.IsNullOrEmpty(this.TxtClave.Text) && ValidaContraseña(this.TxtClave.Text))
            {
                this.ErrNotificator.SetError(this.TxtClave, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.TxtClave, "La contraseña no es segura");
                e.Cancel = true;
            }
        }

        private void TxtRepiteClave_Validating(object sender, CancelEventArgs e)
        {
            if(!String.IsNullOrEmpty(this.TxtRepiteClave.Text) && this.TxtRepiteClave.Text.Equals(this.TxtClave.Text))
            {
                this.ErrNotificator.SetError(this.TxtRepiteClave, "");
            }
            else
            {
                this.ErrNotificator.SetError(this.TxtRepiteClave, "Las contraseñas no coinciden");
                e.Cancel = true;
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if(DgvListado.CurrentRow != null)
            {
                this.actual = this.DgvListado.CurrentRow.DataBoundItem as E_Usuario;
                this.PresentaDatos();
                this.ActivaControles(true, false);
                this.GbUsuario.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DgvListado.Focus();
            }
        }

        private void BtnDarBaja_Click(object sender, EventArgs e)
        {
            if(this.DgvListado.CurrentRow != null)
            {
                N_Usuario n_Usuario = new N_Usuario();
                E_Usuario objUsuario = this.DgvListado.CurrentRow.DataBoundItem as E_Usuario;
                n_Usuario.DarDeBajaUsuario(objUsuario.CodigoUsuario);
                this.ListarUsuarios();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DgvListado.Focus();
            }
        }
    }
}
