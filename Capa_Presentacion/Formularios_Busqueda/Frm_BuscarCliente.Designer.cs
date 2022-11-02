namespace ComercializacionFerroCenter.Formularios_Busqueda
{
    partial class Frm_BuscarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BuscarCliente));
            this.LblCliente = new System.Windows.Forms.Label();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.ClDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.GbBusqueda = new System.Windows.Forms.GroupBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.GbBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(14, 39);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(61, 20);
            this.LblCliente.TabIndex = 0;
            this.LblCliente.Text = "Cliente";
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(92, 36);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(401, 26);
            this.TxtCliente.TabIndex = 1;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = global::ComercializacionFerroCenter.Properties.Resources.IconSearch;
            this.BtnBuscar.Location = new System.Drawing.Point(499, 34);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(140, 30);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClDni,
            this.ClNombres,
            this.ClDireccion,
            this.ClTelefono});
            this.DgvListado.Location = new System.Drawing.Point(12, 124);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvListado.Size = new System.Drawing.Size(658, 404);
            this.DgvListado.TabIndex = 3;
            // 
            // ClDni
            // 
            this.ClDni.DataPropertyName = "NumeroDni";
            this.ClDni.HeaderText = "Dni";
            this.ClDni.MinimumWidth = 6;
            this.ClDni.Name = "ClDni";
            this.ClDni.ReadOnly = true;
            // 
            // ClNombres
            // 
            this.ClNombres.DataPropertyName = "NombresApellidos";
            this.ClNombres.HeaderText = "Nombres";
            this.ClNombres.MinimumWidth = 6;
            this.ClNombres.Name = "ClNombres";
            this.ClNombres.ReadOnly = true;
            // 
            // ClDireccion
            // 
            this.ClDireccion.DataPropertyName = "Direccion";
            this.ClDireccion.HeaderText = "Dirección";
            this.ClDireccion.MinimumWidth = 6;
            this.ClDireccion.Name = "ClDireccion";
            this.ClDireccion.ReadOnly = true;
            // 
            // ClTelefono
            // 
            this.ClTelefono.DataPropertyName = "Telefono";
            this.ClTelefono.HeaderText = "Teléfono";
            this.ClTelefono.MinimumWidth = 6;
            this.ClTelefono.Name = "ClTelefono";
            this.ClTelefono.ReadOnly = true;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Image = global::ComercializacionFerroCenter.Properties.Resources.IconSelect;
            this.BtnSeleccionar.Location = new System.Drawing.Point(355, 551);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(150, 40);
            this.BtnSeleccionar.TabIndex = 4;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // GbBusqueda
            // 
            this.GbBusqueda.Controls.Add(this.TxtCliente);
            this.GbBusqueda.Controls.Add(this.LblCliente);
            this.GbBusqueda.Controls.Add(this.BtnBuscar);
            this.GbBusqueda.Location = new System.Drawing.Point(12, 12);
            this.GbBusqueda.Name = "GbBusqueda";
            this.GbBusqueda.Size = new System.Drawing.Size(658, 106);
            this.GbBusqueda.TabIndex = 5;
            this.GbBusqueda.TabStop = false;
            this.GbBusqueda.Text = "Búsqueda";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::ComercializacionFerroCenter.Properties.Resources.IconCancel;
            this.BtnCancelar.Location = new System.Drawing.Point(520, 551);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(150, 40);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Frm_BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 603);
            this.Controls.Add(this.GbBusqueda);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.DgvListado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_BuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.GbBusqueda.ResumeLayout(false);
            this.GbBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.GroupBox GbBusqueda;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClTelefono;
    }
}