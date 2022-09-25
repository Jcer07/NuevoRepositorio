using System;
using System.Linq;
using System.Windows.Forms;
using Capa_Entidades;
using Capa_Presentacion.Comercializacion;
using Capa_Presentacion.Gestion_Datos_Entidades;

namespace Capa_Presentacion
{
    public partial class FrmPrincipal2 : Form
    {
        private bool CerrarSesionClic = false;
        public FrmPrincipal2()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.BtnIconUsuario.Width = 70;
            this.PnlMenuIzquierdo.Width = 230;
            this.OcultarPanel();

            this.LblTipoUsuario.Text = DatosLogin.TipoUsuario;
            this.LblNombreUsuario.Text = DatosLogin.NombrePersonal;
            this.LblApellidosUsuario.Text = DatosLogin.ApellidoUsuario;
            /*
            if(UserLoginData.TipoUsuario == "Limitado")
            {
                this.BtnGestionDatos.Visible = false;
                this.PnlSubMenuDatos.Visible = false;
            }
            else
            {
                this.BtnCaja.Visible = false;
                this.PnlSubMenuGestionCaja.Visible = false;
                this.BtnTransacciones.Visible = false;
                this.PnlSubMenuTransacciones.Visible = false;
            }*/
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            this.LblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy") + "   " + DateTime.Now.ToLongTimeString();
        }

        private void OcultarPanel()
        {
            this.PnlSubMenuGestionDatos.Visible = false;
            this.PnlSubMenuVentas.Visible = false;
            this.PnlSubMenuGestionAlmacen.Visible = false;
            this.PnlSubMenuCompras.Visible = false;
        }

        private void OcultarSubMenu()
        {
            if (this.PnlSubMenuGestionDatos.Visible)
            {
                this.PnlSubMenuGestionDatos.Visible = false;
            }
            if (this.PnlSubMenuVentas.Visible)
            {
                this.PnlSubMenuVentas.Visible = false;
            }
            if (this.PnlSubMenuGestionAlmacen.Visible)
            {
                this.PnlSubMenuGestionAlmacen.Visible = false;
            }
            if (this.PnlSubMenuCompras.Visible)
            {
                this.PnlSubMenuCompras.Visible = false;
            }
        }

        private void MostrarSubMenu(Panel p)
        {
            if (!p.Visible)
            {
                this.OcultarSubMenu();
                p.Visible = true;
            }
            else
            {
                p.Visible = false;
            }
        }

        public void AbrirFormularios<MiForm>() where MiForm : Form, new()
        {
            Form form;
            form = this.PnlContenedor.Controls.OfType<MiForm>().FirstOrDefault();

            if (form == null)
            {
                form = new MiForm
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };

                this.PnlContenedor.Controls.Add(form);
                this.PnlContenedor.Tag = form;
                form.Show();
                form.BringToFront();
            }
            else
            {
                form.BringToFront();
            }
        }

        private void BtnAdministracion_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PnlSubMenuGestionDatos);
        }

        private void BtnGestionProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularios<Frm_GestionProducto>();
            OcultarSubMenu();
        }

        private void BtnGestionProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormularios<Frm_GestionProveedor>();
            OcultarSubMenu();
        }

        private void BtnGestionClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularios<Frm_GestionCliente>();
            OcultarSubMenu();
        }

        private void BtnGestionPersonal_Click(object sender, EventArgs e)
        {
            AbrirFormularios<Frm_GestionPersonal>();
            OcultarSubMenu();
        }

        private void BtnGestionUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularios<Frm_GestionUsuario>();
            OcultarSubMenu();
        }

        private void BtnGenerarNotaCredito_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.CerrarSesionClic = true;
            this.Close();
        }

        private void FrmPrincipal2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!CerrarSesionClic)
            {
                Application.Exit();
            }
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PnlSubMenuVentas);
        }

        private void BtnRegistrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormularios<Frm_RealizarVenta>();
            OcultarSubMenu();
        }

        private void BtnRegistrarDevolucion_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            /*Caja c;
            RnCaja rn;
            try
            {
                rn = new RnCaja();
                c = rn.CajaAbierta();
                if(c != null && c.Estado == 'A')
                {
                    AbrirFormularios<FrmRegistrarPago>();
                }
                else
                {
                    MessageBox.Show("No hay ninguna caja abierta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo abrir la ventana", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        private void BtnAlmacen_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PnlSubMenuGestionAlmacen);
        }

        private void BtnAbrirCaja_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            /*RnCaja rn = new RnCaja();
            Caja c;
            try
            {
                c = rn.CajaAbierta();
                if(c == null)
                {
                    FrmAbrirCaja frm = new FrmAbrirCaja();
                    frm.ShowDialog();
                }
                else if(c != null && c.Estado == 'A')
                {
                    MessageBox.Show("Caja Abierta desde: " + c.FechaInicio, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar abrir una caja", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void BtnRegistrarEntrada_Click(object sender, EventArgs e)
        {
            AbrirFormularios<Frm_RegistrarIngresoMercaderia>();
            OcultarSubMenu();
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(this.PnlSubMenuCompras);
        }

        private void BtnOrdenCompra_Click(object sender, EventArgs e)
        {
            AbrirFormularios<Frm_RegistrarOrdenCompra>();
            OcultarSubMenu();
        }

        private void BtnRegistraCotizacion_Click(object sender, EventArgs e)
        {
            AbrirFormularios<Frm_RegistraCotizacion>();
            OcultarSubMenu();
        }
    }
}
