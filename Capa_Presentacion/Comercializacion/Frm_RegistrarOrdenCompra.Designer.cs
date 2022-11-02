namespace ComercializacionFerroCenter
{
    partial class Frm_RegistrarOrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RegistrarOrdenCompra));
            this.GbListadoProductos = new System.Windows.Forms.GroupBox();
            this.DgvListadoProductos = new System.Windows.Forms.DataGridView();
            this.ClNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnListarProductos = new System.Windows.Forms.Button();
            this.CboTipoProducto = new System.Windows.Forms.ComboBox();
            this.LblTipoProducto = new System.Windows.Forms.Label();
            this.GbDetallePedido = new System.Windows.Forms.GroupBox();
            this.DgvDetallePedido = new System.Windows.Forms.DataGridView();
            this.ClNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCantidadCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnQuitar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.GbListadoOrdenesCompra = new System.Windows.Forms.GroupBox();
            this.DgvListadoOrdenesCompra = new System.Windows.Forms.DataGridView();
            this.ClNroCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnListarOrdenesCompra = new System.Windows.Forms.Button();
            this.GbListadoProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoProductos)).BeginInit();
            this.GbDetallePedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetallePedido)).BeginInit();
            this.GbListadoOrdenesCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoOrdenesCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // GbListadoProductos
            // 
            this.GbListadoProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GbListadoProductos.Controls.Add(this.DgvListadoProductos);
            this.GbListadoProductos.Controls.Add(this.BtnAgregar);
            this.GbListadoProductos.Controls.Add(this.BtnListarProductos);
            this.GbListadoProductos.Controls.Add(this.CboTipoProducto);
            this.GbListadoProductos.Controls.Add(this.LblTipoProducto);
            this.GbListadoProductos.Location = new System.Drawing.Point(13, 13);
            this.GbListadoProductos.Name = "GbListadoProductos";
            this.GbListadoProductos.Size = new System.Drawing.Size(449, 559);
            this.GbListadoProductos.TabIndex = 0;
            this.GbListadoProductos.TabStop = false;
            this.GbListadoProductos.Text = "Listado de Productos";
            // 
            // DgvListadoProductos
            // 
            this.DgvListadoProductos.AllowUserToAddRows = false;
            this.DgvListadoProductos.AllowUserToDeleteRows = false;
            this.DgvListadoProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListadoProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClNombre,
            this.ClTipo,
            this.ClCantidad});
            this.DgvListadoProductos.Location = new System.Drawing.Point(21, 74);
            this.DgvListadoProductos.MultiSelect = false;
            this.DgvListadoProductos.Name = "DgvListadoProductos";
            this.DgvListadoProductos.ReadOnly = true;
            this.DgvListadoProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DgvListadoProductos.RowTemplate.Height = 24;
            this.DgvListadoProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvListadoProductos.Size = new System.Drawing.Size(413, 422);
            this.DgvListadoProductos.TabIndex = 3;
            // 
            // ClNombre
            // 
            this.ClNombre.DataPropertyName = "Nombre";
            this.ClNombre.HeaderText = "Nombre";
            this.ClNombre.MinimumWidth = 6;
            this.ClNombre.Name = "ClNombre";
            this.ClNombre.ReadOnly = true;
            // 
            // ClTipo
            // 
            this.ClTipo.DataPropertyName = "NombreCategoria";
            this.ClTipo.HeaderText = "Tipo";
            this.ClTipo.MinimumWidth = 6;
            this.ClTipo.Name = "ClTipo";
            this.ClTipo.ReadOnly = true;
            // 
            // ClCantidad
            // 
            this.ClCantidad.DataPropertyName = "StockActual";
            this.ClCantidad.HeaderText = "Cantidad";
            this.ClCantidad.MinimumWidth = 6;
            this.ClCantidad.Name = "ClCantidad";
            this.ClCantidad.ReadOnly = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.Image = global::ComercializacionFerroCenter.Properties.Resources.IconNew;
            this.BtnAgregar.Location = new System.Drawing.Point(304, 502);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(130, 40);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnListarProductos
            // 
            this.BtnListarProductos.Image = global::ComercializacionFerroCenter.Properties.Resources.IconList;
            this.BtnListarProductos.Location = new System.Drawing.Point(324, 23);
            this.BtnListarProductos.Name = "BtnListarProductos";
            this.BtnListarProductos.Size = new System.Drawing.Size(110, 40);
            this.BtnListarProductos.TabIndex = 2;
            this.BtnListarProductos.Text = "Listar";
            this.BtnListarProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnListarProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnListarProductos.UseVisualStyleBackColor = true;
            this.BtnListarProductos.Click += new System.EventHandler(this.BtnListarProductos_Click);
            // 
            // CboTipoProducto
            // 
            this.CboTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoProducto.FormattingEnabled = true;
            this.CboTipoProducto.Location = new System.Drawing.Point(64, 30);
            this.CboTipoProducto.Name = "CboTipoProducto";
            this.CboTipoProducto.Size = new System.Drawing.Size(254, 28);
            this.CboTipoProducto.TabIndex = 1;
            // 
            // LblTipoProducto
            // 
            this.LblTipoProducto.AutoSize = true;
            this.LblTipoProducto.Location = new System.Drawing.Point(17, 35);
            this.LblTipoProducto.Name = "LblTipoProducto";
            this.LblTipoProducto.Size = new System.Drawing.Size(41, 20);
            this.LblTipoProducto.TabIndex = 0;
            this.LblTipoProducto.Text = "Tipo";
            // 
            // GbDetallePedido
            // 
            this.GbDetallePedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GbDetallePedido.Controls.Add(this.DgvDetallePedido);
            this.GbDetallePedido.Controls.Add(this.BtnQuitar);
            this.GbDetallePedido.Controls.Add(this.BtnAceptar);
            this.GbDetallePedido.Controls.Add(this.BtnCancelar);
            this.GbDetallePedido.Location = new System.Drawing.Point(468, 13);
            this.GbDetallePedido.Name = "GbDetallePedido";
            this.GbDetallePedido.Size = new System.Drawing.Size(435, 559);
            this.GbDetallePedido.TabIndex = 0;
            this.GbDetallePedido.TabStop = false;
            this.GbDetallePedido.Text = "Detalles del Pedido";
            // 
            // DgvDetallePedido
            // 
            this.DgvDetallePedido.AllowUserToAddRows = false;
            this.DgvDetallePedido.AllowUserToDeleteRows = false;
            this.DgvDetallePedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDetallePedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetallePedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClNombreProducto,
            this.ClCantidadCompra});
            this.DgvDetallePedido.Location = new System.Drawing.Point(15, 35);
            this.DgvDetallePedido.MultiSelect = false;
            this.DgvDetallePedido.Name = "DgvDetallePedido";
            this.DgvDetallePedido.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DgvDetallePedido.RowTemplate.Height = 24;
            this.DgvDetallePedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvDetallePedido.Size = new System.Drawing.Size(401, 461);
            this.DgvDetallePedido.TabIndex = 3;
            // 
            // ClNombreProducto
            // 
            this.ClNombreProducto.DataPropertyName = "Nombre";
            this.ClNombreProducto.HeaderText = "Nombre";
            this.ClNombreProducto.MinimumWidth = 6;
            this.ClNombreProducto.Name = "ClNombreProducto";
            this.ClNombreProducto.ReadOnly = true;
            // 
            // ClCantidadCompra
            // 
            this.ClCantidadCompra.DataPropertyName = "StockActual";
            this.ClCantidadCompra.HeaderText = "Cantidad";
            this.ClCantidadCompra.MinimumWidth = 6;
            this.ClCantidadCompra.Name = "ClCantidadCompra";
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnQuitar.Image = global::ComercializacionFerroCenter.Properties.Resources.IconQuitar;
            this.BtnQuitar.Location = new System.Drawing.Point(15, 502);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(120, 40);
            this.BtnQuitar.TabIndex = 2;
            this.BtnQuitar.Text = "Quitar";
            this.BtnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnQuitar.UseVisualStyleBackColor = true;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAceptar.Image = global::ComercializacionFerroCenter.Properties.Resources.IconAccept;
            this.BtnAceptar.Location = new System.Drawing.Point(170, 502);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(120, 40);
            this.BtnAceptar.TabIndex = 2;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancelar.Image = global::ComercializacionFerroCenter.Properties.Resources.IconCancel;
            this.BtnCancelar.Location = new System.Drawing.Point(296, 502);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(120, 40);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // GbListadoOrdenesCompra
            // 
            this.GbListadoOrdenesCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GbListadoOrdenesCompra.Controls.Add(this.DgvListadoOrdenesCompra);
            this.GbListadoOrdenesCompra.Controls.Add(this.BtnNuevo);
            this.GbListadoOrdenesCompra.Controls.Add(this.BtnListarOrdenesCompra);
            this.GbListadoOrdenesCompra.Location = new System.Drawing.Point(909, 13);
            this.GbListadoOrdenesCompra.Name = "GbListadoOrdenesCompra";
            this.GbListadoOrdenesCompra.Size = new System.Drawing.Size(371, 559);
            this.GbListadoOrdenesCompra.TabIndex = 0;
            this.GbListadoOrdenesCompra.TabStop = false;
            this.GbListadoOrdenesCompra.Text = "Listado de Ordenes de Compra";
            // 
            // DgvListadoOrdenesCompra
            // 
            this.DgvListadoOrdenesCompra.AllowUserToAddRows = false;
            this.DgvListadoOrdenesCompra.AllowUserToDeleteRows = false;
            this.DgvListadoOrdenesCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListadoOrdenesCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListadoOrdenesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoOrdenesCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClNroCompra,
            this.ClFecha});
            this.DgvListadoOrdenesCompra.Location = new System.Drawing.Point(20, 74);
            this.DgvListadoOrdenesCompra.MultiSelect = false;
            this.DgvListadoOrdenesCompra.Name = "DgvListadoOrdenesCompra";
            this.DgvListadoOrdenesCompra.ReadOnly = true;
            this.DgvListadoOrdenesCompra.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DgvListadoOrdenesCompra.RowTemplate.Height = 24;
            this.DgvListadoOrdenesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvListadoOrdenesCompra.Size = new System.Drawing.Size(332, 422);
            this.DgvListadoOrdenesCompra.TabIndex = 3;
            // 
            // ClNroCompra
            // 
            this.ClNroCompra.DataPropertyName = "CodigoOrdenCompra";
            this.ClNroCompra.HeaderText = "Nro. Compra";
            this.ClNroCompra.MinimumWidth = 6;
            this.ClNroCompra.Name = "ClNroCompra";
            this.ClNroCompra.ReadOnly = true;
            // 
            // ClFecha
            // 
            this.ClFecha.DataPropertyName = "FechaCompra";
            this.ClFecha.HeaderText = "Fecha";
            this.ClFecha.MinimumWidth = 6;
            this.ClFecha.Name = "ClFecha";
            this.ClFecha.ReadOnly = true;
            this.ClFecha.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevo.Image = global::ComercializacionFerroCenter.Properties.Resources.IconNew;
            this.BtnNuevo.Location = new System.Drawing.Point(20, 502);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(140, 40);
            this.BtnNuevo.TabIndex = 2;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnListarOrdenesCompra
            // 
            this.BtnListarOrdenesCompra.Image = global::ComercializacionFerroCenter.Properties.Resources.IconList;
            this.BtnListarOrdenesCompra.Location = new System.Drawing.Point(242, 22);
            this.BtnListarOrdenesCompra.Name = "BtnListarOrdenesCompra";
            this.BtnListarOrdenesCompra.Size = new System.Drawing.Size(110, 40);
            this.BtnListarOrdenesCompra.TabIndex = 2;
            this.BtnListarOrdenesCompra.Text = "Listar";
            this.BtnListarOrdenesCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnListarOrdenesCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnListarOrdenesCompra.UseVisualStyleBackColor = true;
            this.BtnListarOrdenesCompra.Click += new System.EventHandler(this.BtnListarOrdenesCompra_Click);
            // 
            // Frm_RegistrarOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 588);
            this.Controls.Add(this.GbListadoOrdenesCompra);
            this.Controls.Add(this.GbDetallePedido);
            this.Controls.Add(this.GbListadoProductos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_RegistrarOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Orden de Compra";
            this.Load += new System.EventHandler(this.Frm_RegistrarOrdenCompra_Load);
            this.GbListadoProductos.ResumeLayout(false);
            this.GbListadoProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoProductos)).EndInit();
            this.GbDetallePedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetallePedido)).EndInit();
            this.GbListadoOrdenesCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoOrdenesCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbListadoProductos;
        private System.Windows.Forms.GroupBox GbDetallePedido;
        private System.Windows.Forms.Button BtnListarProductos;
        private System.Windows.Forms.ComboBox CboTipoProducto;
        private System.Windows.Forms.Label LblTipoProducto;
        private System.Windows.Forms.DataGridView DgvListadoProductos;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DgvDetallePedido;
        private System.Windows.Forms.Button BtnQuitar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.GroupBox GbListadoOrdenesCompra;
        private System.Windows.Forms.DataGridView DgvListadoOrdenesCompra;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCantidad;
        private System.Windows.Forms.Button BtnListarOrdenesCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCantidadCompra;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNroCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClFecha;
    }
}