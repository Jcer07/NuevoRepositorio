namespace ComercializacionFerroCenter.Formularios_Busqueda
{
    partial class Frm_BuscarOrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BuscarOrdenCompra));
            this.GbBusqueda = new System.Windows.Forms.GroupBox();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.LblRazonSocial = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.ClCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.GbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // GbBusqueda
            // 
            this.GbBusqueda.Controls.Add(this.TxtRazonSocial);
            this.GbBusqueda.Controls.Add(this.LblRazonSocial);
            this.GbBusqueda.Controls.Add(this.BtnBuscar);
            this.GbBusqueda.Location = new System.Drawing.Point(13, 11);
            this.GbBusqueda.Name = "GbBusqueda";
            this.GbBusqueda.Size = new System.Drawing.Size(657, 106);
            this.GbBusqueda.TabIndex = 13;
            this.GbBusqueda.TabStop = false;
            this.GbBusqueda.Text = "Búsqueda";
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Location = new System.Drawing.Point(105, 36);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(391, 26);
            this.TxtRazonSocial.TabIndex = 1;
            // 
            // LblRazonSocial
            // 
            this.LblRazonSocial.AutoSize = true;
            this.LblRazonSocial.Location = new System.Drawing.Point(14, 39);
            this.LblRazonSocial.Name = "LblRazonSocial";
            this.LblRazonSocial.Size = new System.Drawing.Size(85, 20);
            this.LblRazonSocial.TabIndex = 0;
            this.LblRazonSocial.Text = "Proveedor";
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClCodigo,
            this.ClNombre,
            this.ClTipo,
            this.ClPrecio});
            this.DgvListado.Location = new System.Drawing.Point(13, 123);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvListado.Size = new System.Drawing.Size(657, 423);
            this.DgvListado.TabIndex = 10;
            // 
            // ClCodigo
            // 
            this.ClCodigo.DataPropertyName = "CodigoOrdenCompra";
            this.ClCodigo.HeaderText = "Nro Orden Compra";
            this.ClCodigo.MinimumWidth = 6;
            this.ClCodigo.Name = "ClCodigo";
            this.ClCodigo.ReadOnly = true;
            // 
            // ClNombre
            // 
            this.ClNombre.DataPropertyName = "RazonSocialProveedor";
            this.ClNombre.HeaderText = "Proveedor";
            this.ClNombre.MinimumWidth = 6;
            this.ClNombre.Name = "ClNombre";
            this.ClNombre.ReadOnly = true;
            // 
            // ClTipo
            // 
            this.ClTipo.DataPropertyName = "FechaCompra";
            this.ClTipo.HeaderText = "Fecha Compra";
            this.ClTipo.MinimumWidth = 6;
            this.ClTipo.Name = "ClTipo";
            this.ClTipo.ReadOnly = true;
            // 
            // ClPrecio
            // 
            this.ClPrecio.DataPropertyName = "CantProductos";
            this.ClPrecio.HeaderText = "Cant Productos";
            this.ClPrecio.MinimumWidth = 6;
            this.ClPrecio.Name = "ClPrecio";
            this.ClPrecio.ReadOnly = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = global::ComercializacionFerroCenter.Properties.Resources.IconSearch;
            this.BtnBuscar.Location = new System.Drawing.Point(502, 34);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(140, 30);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::ComercializacionFerroCenter.Properties.Resources.IconCancel;
            this.BtnCancelar.Location = new System.Drawing.Point(520, 552);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(150, 40);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Image = global::ComercializacionFerroCenter.Properties.Resources.IconSelect;
            this.BtnSeleccionar.Location = new System.Drawing.Point(359, 552);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(150, 40);
            this.BtnSeleccionar.TabIndex = 12;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // Frm_BuscarOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 603);
            this.Controls.Add(this.GbBusqueda);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.DgvListado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_BuscarOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Orden de Compra";
            this.GbBusqueda.ResumeLayout(false);
            this.GbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbBusqueda;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Label LblRazonSocial;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClPrecio;
    }
}