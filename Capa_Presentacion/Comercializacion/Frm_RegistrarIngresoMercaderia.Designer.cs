namespace Capa_Presentacion.Comercializacion
{
    partial class Frm_RegistrarIngresoMercaderia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RegistrarIngresoMercaderia));
            this.GbBusquedaOrdenCompra = new System.Windows.Forms.GroupBox();
            this.BtnBusquedaAvanzada = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtCotizacion = new System.Windows.Forms.TextBox();
            this.LblCotización = new System.Windows.Forms.Label();
            this.TxtRazonSocialProveedor = new System.Windows.Forms.TextBox();
            this.LblRazonSocialProveedor = new System.Windows.Forms.Label();
            this.TxtNumOrdenCompra = new System.Windows.Forms.TextBox();
            this.LblNumOrdenCompra = new System.Windows.Forms.Label();
            this.GbDetalle = new System.Windows.Forms.GroupBox();
            this.DgvListadoDetalle = new System.Windows.Forms.DataGridView();
            this.ClCodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRegistrarIngreso = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.GbBusquedaOrdenCompra.SuspendLayout();
            this.GbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // GbBusquedaOrdenCompra
            // 
            this.GbBusquedaOrdenCompra.Controls.Add(this.BtnBusquedaAvanzada);
            this.GbBusquedaOrdenCompra.Controls.Add(this.BtnLimpiar);
            this.GbBusquedaOrdenCompra.Controls.Add(this.BtnBuscar);
            this.GbBusquedaOrdenCompra.Controls.Add(this.TxtCotizacion);
            this.GbBusquedaOrdenCompra.Controls.Add(this.LblCotización);
            this.GbBusquedaOrdenCompra.Controls.Add(this.TxtRazonSocialProveedor);
            this.GbBusquedaOrdenCompra.Controls.Add(this.LblRazonSocialProveedor);
            this.GbBusquedaOrdenCompra.Controls.Add(this.TxtNumOrdenCompra);
            this.GbBusquedaOrdenCompra.Controls.Add(this.LblNumOrdenCompra);
            this.GbBusquedaOrdenCompra.Location = new System.Drawing.Point(13, 13);
            this.GbBusquedaOrdenCompra.Name = "GbBusquedaOrdenCompra";
            this.GbBusquedaOrdenCompra.Size = new System.Drawing.Size(523, 280);
            this.GbBusquedaOrdenCompra.TabIndex = 0;
            this.GbBusquedaOrdenCompra.TabStop = false;
            this.GbBusquedaOrdenCompra.Text = "Búsqueda de Orden de Compra";
            // 
            // BtnBusquedaAvanzada
            // 
            this.BtnBusquedaAvanzada.Image = global::Capa_Presentacion.Properties.Resources.IconSearch;
            this.BtnBusquedaAvanzada.Location = new System.Drawing.Point(185, 82);
            this.BtnBusquedaAvanzada.Name = "BtnBusquedaAvanzada";
            this.BtnBusquedaAvanzada.Size = new System.Drawing.Size(315, 30);
            this.BtnBusquedaAvanzada.TabIndex = 2;
            this.BtnBusquedaAvanzada.Text = "Busqueda Avanzada";
            this.BtnBusquedaAvanzada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBusquedaAvanzada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.BtnBusquedaAvanzada.Click += new System.EventHandler(this.BtnBusquedaAvanzada_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar.Image = global::Capa_Presentacion.Properties.Resources.IconCleanUp;
            this.BtnLimpiar.Location = new System.Drawing.Point(390, 226);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(110, 40);
            this.BtnLimpiar.TabIndex = 2;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = global::Capa_Presentacion.Properties.Resources.IconSearch;
            this.BtnBuscar.Location = new System.Drawing.Point(400, 41);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(100, 30);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtCotizacion
            // 
            this.TxtCotizacion.Location = new System.Drawing.Point(123, 182);
            this.TxtCotizacion.Name = "TxtCotizacion";
            this.TxtCotizacion.ReadOnly = true;
            this.TxtCotizacion.Size = new System.Drawing.Size(377, 26);
            this.TxtCotizacion.TabIndex = 1;
            // 
            // LblCotización
            // 
            this.LblCotización.AutoSize = true;
            this.LblCotización.Location = new System.Drawing.Point(12, 185);
            this.LblCotización.Name = "LblCotización";
            this.LblCotización.Size = new System.Drawing.Size(88, 20);
            this.LblCotización.TabIndex = 0;
            this.LblCotización.Text = "Cotización";
            // 
            // TxtRazonSocialProveedor
            // 
            this.TxtRazonSocialProveedor.Location = new System.Drawing.Point(123, 135);
            this.TxtRazonSocialProveedor.Name = "TxtRazonSocialProveedor";
            this.TxtRazonSocialProveedor.ReadOnly = true;
            this.TxtRazonSocialProveedor.Size = new System.Drawing.Size(377, 26);
            this.TxtRazonSocialProveedor.TabIndex = 1;
            // 
            // LblRazonSocialProveedor
            // 
            this.LblRazonSocialProveedor.AutoSize = true;
            this.LblRazonSocialProveedor.Location = new System.Drawing.Point(12, 138);
            this.LblRazonSocialProveedor.Name = "LblRazonSocialProveedor";
            this.LblRazonSocialProveedor.Size = new System.Drawing.Size(85, 20);
            this.LblRazonSocialProveedor.TabIndex = 0;
            this.LblRazonSocialProveedor.Text = "Proveedor";
            // 
            // TxtNumOrdenCompra
            // 
            this.TxtNumOrdenCompra.Location = new System.Drawing.Point(196, 43);
            this.TxtNumOrdenCompra.Name = "TxtNumOrdenCompra";
            this.TxtNumOrdenCompra.Size = new System.Drawing.Size(198, 26);
            this.TxtNumOrdenCompra.TabIndex = 1;
            // 
            // LblNumOrdenCompra
            // 
            this.LblNumOrdenCompra.AutoSize = true;
            this.LblNumOrdenCompra.Location = new System.Drawing.Point(12, 46);
            this.LblNumOrdenCompra.Name = "LblNumOrdenCompra";
            this.LblNumOrdenCompra.Size = new System.Drawing.Size(178, 20);
            this.LblNumOrdenCompra.TabIndex = 0;
            this.LblNumOrdenCompra.Text = "Nro. Orden de Compra";
            // 
            // GbDetalle
            // 
            this.GbDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbDetalle.Controls.Add(this.DgvListadoDetalle);
            this.GbDetalle.Location = new System.Drawing.Point(542, 13);
            this.GbDetalle.Name = "GbDetalle";
            this.GbDetalle.Size = new System.Drawing.Size(613, 599);
            this.GbDetalle.TabIndex = 0;
            this.GbDetalle.TabStop = false;
            this.GbDetalle.Text = "Detalle de Orde de Compra";
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
            this.DgvListadoDetalle.Location = new System.Drawing.Point(17, 41);
            this.DgvListadoDetalle.Name = "DgvListadoDetalle";
            this.DgvListadoDetalle.ReadOnly = true;
            this.DgvListadoDetalle.RowHeadersWidth = 51;
            this.DgvListadoDetalle.RowTemplate.Height = 24;
            this.DgvListadoDetalle.Size = new System.Drawing.Size(578, 536);
            this.DgvListadoDetalle.TabIndex = 1;
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
            // BtnRegistrarIngreso
            // 
            this.BtnRegistrarIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegistrarIngreso.Image = global::Capa_Presentacion.Properties.Resources.IconAccept;
            this.BtnRegistrarIngreso.Location = new System.Drawing.Point(880, 618);
            this.BtnRegistrarIngreso.Name = "BtnRegistrarIngreso";
            this.BtnRegistrarIngreso.Size = new System.Drawing.Size(139, 40);
            this.BtnRegistrarIngreso.TabIndex = 2;
            this.BtnRegistrarIngreso.Text = "Registrar";
            this.BtnRegistrarIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistrarIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegistrarIngreso.UseVisualStyleBackColor = true;
            this.BtnRegistrarIngreso.Click += new System.EventHandler(this.BtnRegistrarIngreso_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.Image = global::Capa_Presentacion.Properties.Resources.IconCancel;
            this.BtnSalir.Location = new System.Drawing.Point(1025, 618);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(130, 40);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Frm_RegistrarIngresoMercaderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 670);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnRegistrarIngreso);
            this.Controls.Add(this.GbDetalle);
            this.Controls.Add(this.GbBusquedaOrdenCompra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_RegistrarIngresoMercaderia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Ingreso de Mercaderia";
            this.GbBusquedaOrdenCompra.ResumeLayout(false);
            this.GbBusquedaOrdenCompra.PerformLayout();
            this.GbDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbBusquedaOrdenCompra;
        private System.Windows.Forms.Button BtnBusquedaAvanzada;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtNumOrdenCompra;
        private System.Windows.Forms.Label LblNumOrdenCompra;
        private System.Windows.Forms.GroupBox GbDetalle;
        private System.Windows.Forms.Button BtnRegistrarIngreso;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.TextBox TxtRazonSocialProveedor;
        private System.Windows.Forms.Label LblRazonSocialProveedor;
        private System.Windows.Forms.DataGridView DgvListadoDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCantidad;
        private System.Windows.Forms.TextBox TxtCotizacion;
        private System.Windows.Forms.Label LblCotización;
    }
}