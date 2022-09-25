using Capa_Entidades;
using Capa_Presentacion.Comercializacion;
using Capa_Presentacion.Gestion_Datos_Entidades;
using Capa_Presentacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            this.LblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy") + "   " + DateTime.Now.ToLongTimeString();
        }

        private void MnuRegistrarDevolucion_Click(object sender, EventArgs e)
        {
            Frm_RegistrarDevolucionProducto frm = new Frm_RegistrarDevolucionProducto()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MnuRegistrarSalidaMercaderia_Click(object sender, EventArgs e)
        {
            Frm_RegistrarSalidaMercaderia frm = new Frm_RegistrarSalidaMercaderia()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MnuRegistrarVenta_Click(object sender, EventArgs e)
        {
            Frm_RealizarVenta frm = new Frm_RealizarVenta()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MnuRegistrarEntradaMercaderia_Click(object sender, EventArgs e)
        {
            Frm_RegistrarIngresoMercaderia frm = new Frm_RegistrarIngresoMercaderia()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MnuRegistrarOrdenCompra_Click(object sender, EventArgs e)
        {
            Frm_RegistrarOrdenCompra frm = new Frm_RegistrarOrdenCompra()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MnuRegistrarCotizacion_Click(object sender, EventArgs e)
        {
            Frm_RegistraCotizacion frm = new Frm_RegistraCotizacion()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MnuRegistrarNotaCredito_Click(object sender, EventArgs e)
        {
            Frm_GenerarNotaCredito frm = new Frm_GenerarNotaCredito()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MnuGestionarPersonal_Click(object sender, EventArgs e)
        {
            Frm_GestionPersonal frm = new Frm_GestionPersonal()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MnuGestionarUsuario_Click(object sender, EventArgs e)
        {
            Frm_GestionUsuario frm = new Frm_GestionUsuario()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MnuGestionarProducto_Click(object sender, EventArgs e)
        {
            Frm_GestionProducto frm = new Frm_GestionProducto()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MnuGestionarProveedor_Click(object sender, EventArgs e)
        {
            Frm_GestionProveedor frm = new Frm_GestionProveedor()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MnuGestionarCliente_Click(object sender, EventArgs e)
        {
            Frm_GestionCliente frm = new Frm_GestionCliente()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MnuGestionarCategoriaProducto_Click(object sender, EventArgs e)
        {
            Frm_GestionCategorias frm = new Frm_GestionCategorias()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MnuGestionarTipoPersonal_Click(object sender, EventArgs e)
        {
            Frm_GestionTipoPersonal frm = new Frm_GestionTipoPersonal()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MnuGestionarMarcaProducto_Click(object sender, EventArgs e)
        {
            Frm_GestionMarcaProducto frm = new Frm_GestionMarcaProducto()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MnuReporteVentas_Click(object sender, EventArgs e)
        {
            Frm_ReporteVentas frm = new Frm_ReporteVentas()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MnuReporteCompras_Click(object sender, EventArgs e)
        {
            Frm_ReporteCompras frm = new Frm_ReporteCompras()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MnuReporteProductos_Click(object sender, EventArgs e)
        {
            Frm_ReporteProductos frm = new Frm_ReporteProductos()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MnuGestionarUnidadTransporte_Click(object sender, EventArgs e)
        {
            Frm_GestionUnidadesTransporte frm = new Frm_GestionUnidadesTransporte()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            //this.RolesUsuario();
        }

        private void RolesUsuario()
        {
            if (DatosLogin.TipoUsuario.Equals("Admin"))
            {
                MnuVentas.Visible = false;
                MnuLogistica.Visible = false;
                MnuGestionarCliente.Visible = false;
                MnuGestionarProveedor.Visible = false;
                MnuGestionarProducto.Visible = false;
                MnuGestionarCategoriaProducto.Visible = false;
                MnuGestionarMarcaProducto.Visible = false;
            }
            if (DatosLogin.TipoUsuario.Equals("Venta"))
            {
                MnuRegistrarSalidaMercaderia.Visible = false;
                MnuRegistrarEntradaMercaderia.Visible = false;
                MnuRegistrarOrdenCompra.Visible = false;
                MnuRegistrarCotizacion.Visible = false;

                MnuGestionarPersonal.Visible = false;
                MnuGestionarUsuario.Visible = false;
                MnuGestionarProveedor.Visible = false;
                MnuGestionarProducto.Visible = false;
                MnuGestionarCategoriaProducto.Visible = false;
                MnuGestionarMarcaProducto.Visible = false;
                MnuGestionarTipoPersonal.Visible = false;
                MnuGestionarUnidadTransporte.Visible = false;

                MnuReportes.Visible = false;
            }
            if (DatosLogin.TipoUsuario.Equals("Almac"))
            {
                MnuRegistrarVenta.Visible = false;
                MnuRegistrarDevolucion.Visible = false;
                MnuRegistrarOrdenCompra.Visible = false;
                MnuRegistrarCotizacion.Visible = false;
                MnuRegistrarNotaCredito.Visible = false;

                MnuGestionarPersonal.Visible = false;
                MnuGestionarUsuario.Visible = false;
                MnuGestionarProveedor.Visible = false;
                MnuGestionarTipoPersonal.Visible = false;
                MnuGestionarUnidadTransporte.Visible = false;
                MnuGestionarCliente.Visible = false;
                MnuReportes.Visible = false;
            }
            if (DatosLogin.TipoUsuario.Equals("Compr"))
            {
                MnuVentas.Visible = false;
                MnuRegistrarNotaCredito.Visible = false;
                MnuRegistrarEntradaMercaderia.Visible = false;

                MnuGestionarPersonal.Visible = false;
                MnuGestionarUsuario.Visible = false;
                MnuGestionarTipoPersonal.Visible = false;
                MnuGestionarUnidadTransporte.Visible = false;
                MnuGestionarCliente.Visible = false;
                MnuGestionarProducto.Visible = false;
                MnuGestionarCategoriaProducto.Visible = false;
                MnuGestionarMarcaProducto.Visible = false;

                MnuReportes.Visible = false;
            }
        }
    }
}
