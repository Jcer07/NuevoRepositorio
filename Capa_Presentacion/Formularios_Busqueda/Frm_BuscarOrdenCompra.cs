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

namespace Capa_Presentacion.Formularios_Busqueda
{
    public partial class Frm_BuscarOrdenCompra : Form
    {
        private E_OrdenCompra ordenCompra = null;
        public Frm_BuscarOrdenCompra()
        {
            InitializeComponent();
        }

        public E_OrdenCompra Buscar()
        {
            this.ShowDialog();
            return ordenCompra;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.DgvListado.DataSource = null;
            try
            {
                N_OrdenCompra nOrdenCompra = new N_OrdenCompra();
                List<E_OrdenCompra> listado = nOrdenCompra.ListadoOrdenCompraBusqueda(this.TxtRazonSocial.Text);
                if(listado.Count > 0)
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

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if(this.DgvListado.CurrentRow != null)
            {
                this.ordenCompra = this.DgvListado.CurrentRow.DataBoundItem as E_OrdenCompra;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe elegir una fila", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DgvListado.Focus();
            }
        }
    }
}
