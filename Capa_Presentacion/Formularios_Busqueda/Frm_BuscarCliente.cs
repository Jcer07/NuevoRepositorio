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
    public partial class Frm_BuscarCliente : Form
    {
        private E_Cliente cliente = null;
        public Frm_BuscarCliente()
        {
            InitializeComponent();
        }

        public E_Cliente Buscar()
        {
            this.ShowDialog();
            return cliente;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if(this.DgvListado.CurrentRow != null)
            {
                this.cliente = this.DgvListado.CurrentRow.DataBoundItem as E_Cliente;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar a un cliente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DgvListado.Focus();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.ListadoClientes();
        }

        private void ListadoClientes()
        {
            this.DgvListado.DataSource = null;
            try
            {
                N_Cliente n_Cliente = new N_Cliente();
                List<E_Cliente> listado = n_Cliente.Listado(this.TxtCliente.Text);

                if(listado != null)
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
    }
}
