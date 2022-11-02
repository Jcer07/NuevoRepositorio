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

namespace ComercializacionFerroCenter.Formularios_Busqueda
{
    public partial class Frm_BuscarProveedor : Form
    {
        private E_Proveedor proveedor = null;
        public Frm_BuscarProveedor()
        {
            InitializeComponent();
        }

        public E_Proveedor Buscar()
        {
            this.ShowDialog();
            return this.proveedor;
        }

        private void ListadoProveedores()
        {
            this.DgvListado.DataSource = null;
            try
            {
                N_Proveedor n_Proveedor = new N_Proveedor();
                List<E_Proveedor> listado = n_Proveedor.ListadoProveedoresBusqueda(this.TxtProveedor.Text);

                if (listado != null)
                {
                    this.DgvListado.AutoGenerateColumns = false;
                    this.DgvListado.DataSource = listado;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar los datos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.ListadoProveedores();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.DgvListado.CurrentRow != null)
            {
                this.proveedor = this.DgvListado.CurrentRow.DataBoundItem as E_Proveedor;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar a un Proveedor", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DgvListado.Focus();
            }
        }
    }
}
