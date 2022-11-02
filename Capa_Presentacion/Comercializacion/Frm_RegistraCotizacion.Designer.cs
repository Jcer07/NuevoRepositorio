namespace ComercializacionFerroCenter.Comercializacion
{
    partial class Frm_RegistraCotizacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RegistraCotizacion));
            this.GbListadoCompras = new System.Windows.Forms.GroupBox();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.ClCodigoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCantidadProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbDetalleCompra = new System.Windows.Forms.GroupBox();
            this.DgvListadoDetalle = new System.Windows.Forms.DataGridView();
            this.ClCodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbDatosProveedor = new System.Windows.Forms.GroupBox();
            this.BtnBusquedaAvanzada = new System.Windows.Forms.Button();
            this.BtnBuscarProveedor = new System.Windows.Forms.Button();
            this.NudCotizacion = new System.Windows.Forms.NumericUpDown();
            this.DtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.TxtNumeroRuc = new System.Windows.Forms.TextBox();
            this.LblNumeroRuc = new System.Windows.Forms.Label();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblCotizacion = new System.Windows.Forms.Label();
            this.LblRazonSocial = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.ErrNotificator = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbListadoCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.GbDetalleCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoDetalle)).BeginInit();
            this.GbDatosProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificator)).BeginInit();
            this.SuspendLayout();
            // 
            // GbListadoCompras
            // 
            this.GbListadoCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbListadoCompras.Controls.Add(this.BtnSeleccionar);
            this.GbListadoCompras.Controls.Add(this.BtnListar);
            this.GbListadoCompras.Controls.Add(this.DgvListado);
            this.GbListadoCompras.Location = new System.Drawing.Point(13, 13);
            this.GbListadoCompras.Name = "GbListadoCompras";
            this.GbListadoCompras.Size = new System.Drawing.Size(607, 645);
            this.GbListadoCompras.TabIndex = 0;
            this.GbListadoCompras.TabStop = false;
            this.GbListadoCompras.Text = "Listado de Ordenes de Compra";
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSeleccionar.Image = global::ComercializacionFerroCenter.Properties.Resources.IconSelect;
            this.BtnSeleccionar.Location = new System.Drawing.Point(446, 584);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(140, 40);
            this.BtnSeleccionar.TabIndex = 4;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListar.Image = global::ComercializacionFerroCenter.Properties.Resources.IconList;
            this.BtnListar.Location = new System.Drawing.Point(456, 25);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(130, 40);
            this.BtnListar.TabIndex = 4;
            this.BtnListar.Text = "Listar";
            this.BtnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClCodigoCompra,
            this.ClFecha,
            this.ClCantidadProductos});
            this.DgvListado.Location = new System.Drawing.Point(15, 87);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.Size = new System.Drawing.Size(571, 487);
            this.DgvListado.TabIndex = 0;
            // 
            // ClCodigoCompra
            // 
            this.ClCodigoCompra.DataPropertyName = "CodigoOrdenCompra";
            this.ClCodigoCompra.HeaderText = "Nro. Orden";
            this.ClCodigoCompra.MinimumWidth = 6;
            this.ClCodigoCompra.Name = "ClCodigoCompra";
            this.ClCodigoCompra.ReadOnly = true;
            // 
            // ClFecha
            // 
            this.ClFecha.DataPropertyName = "FechaCompra";
            this.ClFecha.HeaderText = "Fecha";
            this.ClFecha.MinimumWidth = 6;
            this.ClFecha.Name = "ClFecha";
            this.ClFecha.ReadOnly = true;
            // 
            // ClCantidadProductos
            // 
            this.ClCantidadProductos.DataPropertyName = "CantProductos";
            this.ClCantidadProductos.HeaderText = "Nro. Productos";
            this.ClCantidadProductos.MinimumWidth = 6;
            this.ClCantidadProductos.Name = "ClCantidadProductos";
            this.ClCantidadProductos.ReadOnly = true;
            // 
            // GbDetalleCompra
            // 
            this.GbDetalleCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbDetalleCompra.Controls.Add(this.DgvListadoDetalle);
            this.GbDetalleCompra.Location = new System.Drawing.Point(626, 13);
            this.GbDetalleCompra.Name = "GbDetalleCompra";
            this.GbDetalleCompra.Size = new System.Drawing.Size(534, 290);
            this.GbDetalleCompra.TabIndex = 0;
            this.GbDetalleCompra.TabStop = false;
            this.GbDetalleCompra.Text = "Detalle de Compra";
            // 
            // DgvListadoDetalle
            // 
            this.DgvListadoDetalle.AllowUserToAddRows = false;
            this.DgvListadoDetalle.AllowUserToDeleteRows = false;
            this.DgvListadoDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListadoDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListadoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClCodigoProducto,
            this.ClProducto,
            this.ClCantidad});
            this.DgvListadoDetalle.Location = new System.Drawing.Point(14, 25);
            this.DgvListadoDetalle.Name = "DgvListadoDetalle";
            this.DgvListadoDetalle.ReadOnly = true;
            this.DgvListadoDetalle.RowHeadersWidth = 51;
            this.DgvListadoDetalle.RowTemplate.Height = 24;
            this.DgvListadoDetalle.Size = new System.Drawing.Size(505, 247);
            this.DgvListadoDetalle.TabIndex = 0;
            // 
            // ClCodigoProducto
            // 
            this.ClCodigoProducto.DataPropertyName = "CodigoProducto";
            this.ClCodigoProducto.HeaderText = "Codigo";
            this.ClCodigoProducto.MinimumWidth = 6;
            this.ClCodigoProducto.Name = "ClCodigoProducto";
            this.ClCodigoProducto.ReadOnly = true;
            // 
            // ClProducto
            // 
            this.ClProducto.DataPropertyName = "Nombre";
            this.ClProducto.HeaderText = "Producto";
            this.ClProducto.MinimumWidth = 6;
            this.ClProducto.Name = "ClProducto";
            this.ClProducto.ReadOnly = true;
            // 
            // ClCantidad
            // 
            this.ClCantidad.DataPropertyName = "StockActual";
            this.ClCantidad.HeaderText = "Cantidad";
            this.ClCantidad.MinimumWidth = 6;
            this.ClCantidad.Name = "ClCantidad";
            this.ClCantidad.ReadOnly = true;
            // 
            // GbDatosProveedor
            // 
            this.GbDatosProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbDatosProveedor.Controls.Add(this.BtnBusquedaAvanzada);
            this.GbDatosProveedor.Controls.Add(this.BtnBuscarProveedor);
            this.GbDatosProveedor.Controls.Add(this.NudCotizacion);
            this.GbDatosProveedor.Controls.Add(this.DtpFechaEntrega);
            this.GbDatosProveedor.Controls.Add(this.TxtNumeroRuc);
            this.GbDatosProveedor.Controls.Add(this.LblNumeroRuc);
            this.GbDatosProveedor.Controls.Add(this.TxtRazonSocial);
            this.GbDatosProveedor.Controls.Add(this.label3);
            this.GbDatosProveedor.Controls.Add(this.LblCotizacion);
            this.GbDatosProveedor.Controls.Add(this.LblRazonSocial);
            this.GbDatosProveedor.Location = new System.Drawing.Point(626, 309);
            this.GbDatosProveedor.Name = "GbDatosProveedor";
            this.GbDatosProveedor.Size = new System.Drawing.Size(534, 300);
            this.GbDatosProveedor.TabIndex = 0;
            this.GbDatosProveedor.TabStop = false;
            // 
            // BtnBusquedaAvanzada
            // 
            this.BtnBusquedaAvanzada.Image = global::ComercializacionFerroCenter.Properties.Resources.IconSearch;
            this.BtnBusquedaAvanzada.Location = new System.Drawing.Point(205, 82);
            this.BtnBusquedaAvanzada.Name = "BtnBusquedaAvanzada";
            this.BtnBusquedaAvanzada.Size = new System.Drawing.Size(306, 30);
            this.BtnBusquedaAvanzada.TabIndex = 13;
            this.BtnBusquedaAvanzada.Text = "Búsqueda Avanzada";
            this.BtnBusquedaAvanzada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBusquedaAvanzada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.BtnBusquedaAvanzada.Click += new System.EventHandler(this.BtnBusquedaAvanzada_Click);
            // 
            // BtnBuscarProveedor
            // 
            this.BtnBuscarProveedor.Image = global::ComercializacionFerroCenter.Properties.Resources.IconSearch;
            this.BtnBuscarProveedor.Location = new System.Drawing.Point(401, 46);
            this.BtnBuscarProveedor.Name = "BtnBuscarProveedor";
            this.BtnBuscarProveedor.Size = new System.Drawing.Size(110, 30);
            this.BtnBuscarProveedor.TabIndex = 14;
            this.BtnBuscarProveedor.Text = "Buscar";
            this.BtnBuscarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscarProveedor.UseVisualStyleBackColor = true;
            this.BtnBuscarProveedor.Click += new System.EventHandler(this.BtnBuscarProveedor_Click);
            // 
            // NudCotizacion
            // 
            this.NudCotizacion.DecimalPlaces = 2;
            this.NudCotizacion.Location = new System.Drawing.Point(175, 175);
            this.NudCotizacion.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.NudCotizacion.Name = "NudCotizacion";
            this.NudCotizacion.Size = new System.Drawing.Size(336, 26);
            this.NudCotizacion.TabIndex = 12;
            this.NudCotizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudCotizacion.Validating += new System.ComponentModel.CancelEventHandler(this.NudCotizacion_Validating);
            // 
            // DtpFechaEntrega
            // 
            this.DtpFechaEntrega.Location = new System.Drawing.Point(175, 229);
            this.DtpFechaEntrega.Name = "DtpFechaEntrega";
            this.DtpFechaEntrega.Size = new System.Drawing.Size(336, 26);
            this.DtpFechaEntrega.TabIndex = 11;
            // 
            // TxtNumeroRuc
            // 
            this.TxtNumeroRuc.Location = new System.Drawing.Point(175, 48);
            this.TxtNumeroRuc.Name = "TxtNumeroRuc";
            this.TxtNumeroRuc.Size = new System.Drawing.Size(220, 26);
            this.TxtNumeroRuc.TabIndex = 9;
            // 
            // LblNumeroRuc
            // 
            this.LblNumeroRuc.AutoSize = true;
            this.LblNumeroRuc.Location = new System.Drawing.Point(22, 51);
            this.LblNumeroRuc.Name = "LblNumeroRuc";
            this.LblNumeroRuc.Size = new System.Drawing.Size(132, 20);
            this.LblNumeroRuc.TabIndex = 5;
            this.LblNumeroRuc.Text = "Número de RUC";
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Location = new System.Drawing.Point(175, 125);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(336, 26);
            this.TxtRazonSocial.TabIndex = 10;
            this.TxtRazonSocial.Validating += new System.ComponentModel.CancelEventHandler(this.TxtRazonSocial_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de Entrega";
            // 
            // LblCotizacion
            // 
            this.LblCotizacion.AutoSize = true;
            this.LblCotizacion.Location = new System.Drawing.Point(22, 177);
            this.LblCotizacion.Name = "LblCotizacion";
            this.LblCotizacion.Size = new System.Drawing.Size(88, 20);
            this.LblCotizacion.TabIndex = 7;
            this.LblCotizacion.Text = "Cotización";
            // 
            // LblRazonSocial
            // 
            this.LblRazonSocial.AutoSize = true;
            this.LblRazonSocial.Location = new System.Drawing.Point(22, 128);
            this.LblRazonSocial.Name = "LblRazonSocial";
            this.LblRazonSocial.Size = new System.Drawing.Size(108, 20);
            this.LblRazonSocial.TabIndex = 8;
            this.LblRazonSocial.Text = "Razon Social";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAceptar.Image = global::ComercializacionFerroCenter.Properties.Resources.IconAccept;
            this.BtnAceptar.Location = new System.Drawing.Point(891, 618);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(130, 40);
            this.BtnAceptar.TabIndex = 4;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Image = global::ComercializacionFerroCenter.Properties.Resources.IconCancel;
            this.BtnCancelar.Location = new System.Drawing.Point(1029, 618);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(130, 40);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // ErrNotificator
            // 
            this.ErrNotificator.ContainerControl = this;
            // 
            // Frm_RegistraCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1172, 668);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.GbDatosProveedor);
            this.Controls.Add(this.GbDetalleCompra);
            this.Controls.Add(this.GbListadoCompras);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_RegistraCotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Cotizacion";
            this.GbListadoCompras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.GbDetalleCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoDetalle)).EndInit();
            this.GbDatosProveedor.ResumeLayout(false);
            this.GbDatosProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbListadoCompras;
        private System.Windows.Forms.GroupBox GbDetalleCompra;
        private System.Windows.Forms.GroupBox GbDatosProveedor;
        private System.Windows.Forms.DataGridView DgvListadoDetalle;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnBusquedaAvanzada;
        private System.Windows.Forms.Button BtnBuscarProveedor;
        private System.Windows.Forms.NumericUpDown NudCotizacion;
        private System.Windows.Forms.DateTimePicker DtpFechaEntrega;
        private System.Windows.Forms.TextBox TxtNumeroRuc;
        private System.Windows.Forms.Label LblNumeroRuc;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblCotizacion;
        private System.Windows.Forms.Label LblRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCodigoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCantidadProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCantidad;
        private System.Windows.Forms.ErrorProvider ErrNotificator;
    }
}