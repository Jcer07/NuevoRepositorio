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
    public partial class Frm_BuscarProducto : Form
    {
        private E_Producto producto = null;
        public Frm_BuscarProducto()
        {
            InitializeComponent();
        }

        public E_Producto Buscar()
        {
            this.ShowDialog();
            return producto;
        }

        private void ListadoProductos()
        {
            this.DgvListado.DataSource = null;
            try
            {
                N_Producto n_Producto = new N_Producto();
                List<E_Producto> listado = n_Producto.ListadoProductosBusqueda(this.TxtProducto.Text);

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
            this.ListadoProductos();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.DgvListado.CurrentRow != null)
            {
                this.producto = this.DgvListado.CurrentRow.DataBoundItem as E_Producto;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar a un Producto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DgvListado.Focus();
            }
        }
    }
}
