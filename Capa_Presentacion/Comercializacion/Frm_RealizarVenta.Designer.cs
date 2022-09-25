namespace Capa_Presentacion.Comercializacion
{
    partial class Frm_RealizarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RealizarVenta));
            this.GbCliente = new System.Windows.Forms.GroupBox();
            this.BtnBusquedaAvanzadaCliente = new System.Windows.Forms.Button();
            this.BtnBuscarCliente = new System.Windows.Forms.Button();
            this.TxtNombreCliente = new System.Windows.Forms.TextBox();
            this.LblNombreCliente = new System.Windows.Forms.Label();
            this.TxtDniCliente = new System.Windows.Forms.TextBox();
            this.LblDni = new System.Windows.Forms.Label();
            this.GBListado = new System.Windows.Forms.GroupBox();
            this.BtnRegistraPago = new System.Windows.Forms.Button();
            this.BtnQuitar = new System.Windows.Forms.Button();
            this.DgvListadoProductos = new System.Windows.Forms.DataGridView();
            this.ClCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GbProducto = new System.Windows.Forms.GroupBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.CboUnidadMedida = new System.Windows.Forms.ComboBox();
            this.NudCantidad = new System.Windows.Forms.NumericUpDown();
            this.BtnBusquedaAvanzadaProducto = new System.Windows.Forms.Button();
            this.BtnBuscarProducto = new System.Windows.Forms.Button();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtTipoProducto = new System.Windows.Forms.TextBox();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.LblUnidadMedida = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblTipoProducto = new System.Windows.Forms.Label();
            this.TxtCodigoProducto = new System.Windows.Forms.TextBox();
            this.LblNombreProducto = new System.Windows.Forms.Label();
            this.BtnCancelarVenta = new System.Windows.Forms.Button();
            this.BtnRegistrarVenta = new System.Windows.Forms.Button();
            this.GbCliente.SuspendLayout();
            this.GBListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoProductos)).BeginInit();
            this.GbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // GbCliente
            // 
            this.GbCliente.Controls.Add(this.BtnBusquedaAvanzadaCliente);
            this.GbCliente.Controls.Add(this.BtnBuscarCliente);
            this.GbCliente.Controls.Add(this.TxtNombreCliente);
            this.GbCliente.Controls.Add(this.LblNombreCliente);
            this.GbCliente.Controls.Add(this.TxtDniCliente);
            this.GbCliente.Controls.Add(this.LblDni);
            this.GbCliente.Location = new System.Drawing.Point(12, 12);
            this.GbCliente.Name = "GbCliente";
            this.GbCliente.Size = new System.Drawing.Size(443, 167);
            this.GbCliente.TabIndex = 0;
            this.GbCliente.TabStop = false;
            this.GbCliente.Text = "Datos de Cliente";
            // 
            // BtnBusquedaAvanzadaCliente
            // 
            this.BtnBusquedaAvanzadaCliente.Image = global::Capa_Presentacion.Properties.Resources.IconSearch2;
            this.BtnBusquedaAvanzadaCliente.Location = new System.Drawing.Point(135, 78);
            this.BtnBusquedaAvanzadaCliente.Name = "BtnBusquedaAvanzadaCliente";
            this.BtnBusquedaAvanzadaCliente.Size = new System.Drawing.Size(280, 30);
            this.BtnBusquedaAvanzadaCliente.TabIndex = 2;
            this.BtnBusquedaAvanzadaCliente.Text = "Búsqueda Avanzada";
            this.BtnBusquedaAvanzadaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBusquedaAvanzadaCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBusquedaAvanzadaCliente.UseVisualStyleBackColor = true;
            this.BtnBusquedaAvanzadaCliente.Click += new System.EventHandler(this.BtnBusquedaAvanzadaCliente_Click);
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.Image = global::Capa_Presentacion.Properties.Resources.IconSearch2;
            this.BtnBuscarCliente.Location = new System.Drawing.Point(295, 42);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(120, 30);
            this.BtnBuscarCliente.TabIndex = 2;
            this.BtnBuscarCliente.Text = "Buscar";
            this.BtnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscarCliente.UseVisualStyleBackColor = true;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.Location = new System.Drawing.Point(92, 124);
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.ReadOnly = true;
            this.TxtNombreCliente.Size = new System.Drawing.Size(323, 26);
            this.TxtNombreCliente.TabIndex = 1;
            // 
            // LblNombreCliente
            // 
            this.LblNombreCliente.AutoSize = true;
            this.LblNombreCliente.Location = new System.Drawing.Point(9, 127);
            this.LblNombreCliente.Name = "LblNombreCliente";
            this.LblNombreCliente.Size = new System.Drawing.Size(68, 20);
            this.LblNombreCliente.TabIndex = 0;
            this.LblNombreCliente.Text = "Nombre";
            // 
            // TxtDniCliente
            // 
            this.TxtDniCliente.Location = new System.Drawing.Point(92, 44);
            this.TxtDniCliente.Name = "TxtDniCliente";
            this.TxtDniCliente.Size = new System.Drawing.Size(191, 26);
            this.TxtDniCliente.TabIndex = 1;
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Location = new System.Drawing.Point(9, 47);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(38, 20);
            this.LblDni.TabIndex = 0;
            this.LblDni.Text = "DNI";
            // 
            // GBListado
            // 
            this.GBListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBListado.Controls.Add(this.BtnRegistraPago);
            this.GBListado.Controls.Add(this.BtnQuitar);
            this.GBListado.Controls.Add(this.DgvListadoProductos);
            this.GBListado.Controls.Add(this.textBox1);
            this.GBListado.Controls.Add(this.label1);
            this.GBListado.Location = new System.Drawing.Point(461, 12);
            this.GBListado.Name = "GBListado";
            this.GBListado.Size = new System.Drawing.Size(762, 583);
            this.GBListado.TabIndex = 0;
            this.GBListado.TabStop = false;
            this.GBListado.Text = "Listado";
            // 
            // BtnRegistraPago
            // 
            this.BtnRegistraPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegistraPago.Image = global::Capa_Presentacion.Properties.Resources.IconPay;
            this.BtnRegistraPago.Location = new System.Drawing.Point(575, 521);
            this.BtnRegistraPago.Name = "BtnRegistraPago";
            this.BtnRegistraPago.Size = new System.Drawing.Size(170, 40);
            this.BtnRegistraPago.TabIndex = 1;
            this.BtnRegistraPago.Text = "RegistrarPago";
            this.BtnRegistraPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistraPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegistraPago.UseVisualStyleBackColor = true;
            this.BtnRegistraPago.Click += new System.EventHandler(this.BtnRegistraPago_Click);
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.Image = global::Capa_Presentacion.Properties.Resources.IconQuitar;
            this.BtnQuitar.Location = new System.Drawing.Point(19, 521);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(150, 40);
            this.BtnQuitar.TabIndex = 1;
            this.BtnQuitar.Text = "Quitar";
            this.BtnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnQuitar.UseVisualStyleBackColor = true;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
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
            this.ClCodigo,
            this.ClProducto,
            this.ClCantidad,
            this.ClPrecioUnitario,
            this.ClSubTotal});
            this.DgvListadoProductos.Location = new System.Drawing.Point(19, 76);
            this.DgvListadoProductos.MultiSelect = false;
            this.DgvListadoProductos.Name = "DgvListadoProductos";
            this.DgvListadoProductos.ReadOnly = true;
            this.DgvListadoProductos.RowHeadersWidth = 51;
            this.DgvListadoProductos.RowTemplate.Height = 24;
            this.DgvListadoProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvListadoProductos.Size = new System.Drawing.Size(726, 394);
            this.DgvListadoProductos.TabIndex = 0;
            // 
            // ClCodigo
            // 
            this.ClCodigo.HeaderText = "Código";
            this.ClCodigo.MinimumWidth = 6;
            this.ClCodigo.Name = "ClCodigo";
            this.ClCodigo.ReadOnly = true;
            // 
            // ClProducto
            // 
            this.ClProducto.HeaderText = "Producto";
            this.ClProducto.MinimumWidth = 6;
            this.ClProducto.Name = "ClProducto";
            this.ClProducto.ReadOnly = true;
            // 
            // ClCantidad
            // 
            this.ClCantidad.HeaderText = "Cantidad";
            this.ClCantidad.MinimumWidth = 6;
            this.ClCantidad.Name = "ClCantidad";
            this.ClCantidad.ReadOnly = true;
            // 
            // ClPrecioUnitario
            // 
            this.ClPrecioUnitario.HeaderText = "Precio Unt";
            this.ClPrecioUnitario.MinimumWidth = 6;
            this.ClPrecioUnitario.Name = "ClPrecioUnitario";
            this.ClPrecioUnitario.ReadOnly = true;
            // 
            // ClSubTotal
            // 
            this.ClSubTotal.HeaderText = "Sub Total";
            this.ClSubTotal.MinimumWidth = 6;
            this.ClSubTotal.Name = "ClSubTotal";
            this.ClSubTotal.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(585, 479);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(160, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total";
            // 
            // GbProducto
            // 
            this.GbProducto.Controls.Add(this.BtnLimpiar);
            this.GbProducto.Controls.Add(this.BtnAgregar);
            this.GbProducto.Controls.Add(this.CboUnidadMedida);
            this.GbProducto.Controls.Add(this.NudCantidad);
            this.GbProducto.Controls.Add(this.BtnBusquedaAvanzadaProducto);
            this.GbProducto.Controls.Add(this.BtnBuscarProducto);
            this.GbProducto.Controls.Add(this.LblCodigo);
            this.GbProducto.Controls.Add(this.TxtPrecio);
            this.GbProducto.Controls.Add(this.TxtTipoProducto);
            this.GbProducto.Controls.Add(this.TxtNombreProducto);
            this.GbProducto.Controls.Add(this.LblUnidadMedida);
            this.GbProducto.Controls.Add(this.LblPrecio);
            this.GbProducto.Controls.Add(this.LblCantidad);
            this.GbProducto.Controls.Add(this.LblTipoProducto);
            this.GbProducto.Controls.Add(this.TxtCodigoProducto);
            this.GbProducto.Controls.Add(this.LblNombreProducto);
            this.GbProducto.Location = new System.Drawing.Point(12, 185);
            this.GbProducto.Name = "GbProducto";
            this.GbProducto.Size = new System.Drawing.Size(443, 386);
            this.GbProducto.TabIndex = 0;
            this.GbProducto.TabStop = false;
            this.GbProducto.Text = "Datos de Producto";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar.Image = global::Capa_Presentacion.Properties.Resources.IconCleanUp;
            this.BtnLimpiar.Location = new System.Drawing.Point(265, 319);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(150, 40);
            this.BtnLimpiar.TabIndex = 1;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.Image = global::Capa_Presentacion.Properties.Resources.IconAddProduct;
            this.BtnAgregar.Location = new System.Drawing.Point(109, 319);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(150, 40);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // CboUnidadMedida
            // 
            this.CboUnidadMedida.FormattingEnabled = true;
            this.CboUnidadMedida.Location = new System.Drawing.Point(193, 267);
            this.CboUnidadMedida.Name = "CboUnidadMedida";
            this.CboUnidadMedida.Size = new System.Drawing.Size(222, 28);
            this.CboUnidadMedida.TabIndex = 4;
            // 
            // NudCantidad
            // 
            this.NudCantidad.Location = new System.Drawing.Point(19, 267);
            this.NudCantidad.Name = "NudCantidad";
            this.NudCantidad.Size = new System.Drawing.Size(109, 26);
            this.NudCantidad.TabIndex = 3;
            this.NudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnBusquedaAvanzadaProducto
            // 
            this.BtnBusquedaAvanzadaProducto.Image = ((System.Drawing.Image)(resources.GetObject("BtnBusquedaAvanzadaProducto.Image")));
            this.BtnBusquedaAvanzadaProducto.Location = new System.Drawing.Point(135, 70);
            this.BtnBusquedaAvanzadaProducto.Name = "BtnBusquedaAvanzadaProducto";
            this.BtnBusquedaAvanzadaProducto.Size = new System.Drawing.Size(280, 30);
            this.BtnBusquedaAvanzadaProducto.TabIndex = 2;
            this.BtnBusquedaAvanzadaProducto.Text = "Búsqueda Avanzada";
            this.BtnBusquedaAvanzadaProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBusquedaAvanzadaProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBusquedaAvanzadaProducto.UseVisualStyleBackColor = true;
            this.BtnBusquedaAvanzadaProducto.Click += new System.EventHandler(this.BtnBusquedaAvanzadaProducto_Click);
            // 
            // BtnBuscarProducto
            // 
            this.BtnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarProducto.Image")));
            this.BtnBuscarProducto.Location = new System.Drawing.Point(295, 34);
            this.BtnBuscarProducto.Name = "BtnBuscarProducto";
            this.BtnBuscarProducto.Size = new System.Drawing.Size(120, 30);
            this.BtnBuscarProducto.TabIndex = 2;
            this.BtnBuscarProducto.Text = "Buscar";
            this.BtnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscarProducto.UseVisualStyleBackColor = true;
            this.BtnBuscarProducto.Click += new System.EventHandler(this.BtnBuscarProducto_Click);
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Location = new System.Drawing.Point(9, 39);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(61, 20);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Codigo";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(92, 202);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.ReadOnly = true;
            this.TxtPrecio.Size = new System.Drawing.Size(323, 26);
            this.TxtPrecio.TabIndex = 1;
            // 
            // TxtTipoProducto
            // 
            this.TxtTipoProducto.Location = new System.Drawing.Point(92, 157);
            this.TxtTipoProducto.Name = "TxtTipoProducto";
            this.TxtTipoProducto.ReadOnly = true;
            this.TxtTipoProducto.Size = new System.Drawing.Size(323, 26);
            this.TxtTipoProducto.TabIndex = 1;
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Location = new System.Drawing.Point(92, 116);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.ReadOnly = true;
            this.TxtNombreProducto.Size = new System.Drawing.Size(323, 26);
            this.TxtNombreProducto.TabIndex = 1;
            // 
            // LblUnidadMedida
            // 
            this.LblUnidadMedida.AutoSize = true;
            this.LblUnidadMedida.Location = new System.Drawing.Point(189, 243);
            this.LblUnidadMedida.Name = "LblUnidadMedida";
            this.LblUnidadMedida.Size = new System.Drawing.Size(102, 20);
            this.LblUnidadMedida.TabIndex = 0;
            this.LblUnidadMedida.Text = "Und. Medida";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(9, 208);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(57, 20);
            this.LblPrecio.TabIndex = 0;
            this.LblPrecio.Text = "Precio";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Location = new System.Drawing.Point(15, 243);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(75, 20);
            this.LblCantidad.TabIndex = 0;
            this.LblCantidad.Text = "Cantidad";
            // 
            // LblTipoProducto
            // 
            this.LblTipoProducto.AutoSize = true;
            this.LblTipoProducto.Location = new System.Drawing.Point(9, 160);
            this.LblTipoProducto.Name = "LblTipoProducto";
            this.LblTipoProducto.Size = new System.Drawing.Size(41, 20);
            this.LblTipoProducto.TabIndex = 0;
            this.LblTipoProducto.Text = "Tipo";
            // 
            // TxtCodigoProducto
            // 
            this.TxtCodigoProducto.Location = new System.Drawing.Point(92, 36);
            this.TxtCodigoProducto.Name = "TxtCodigoProducto";
            this.TxtCodigoProducto.Size = new System.Drawing.Size(191, 26);
            this.TxtCodigoProducto.TabIndex = 1;
            // 
            // LblNombreProducto
            // 
            this.LblNombreProducto.AutoSize = true;
            this.LblNombreProducto.Location = new System.Drawing.Point(9, 119);
            this.LblNombreProducto.Name = "LblNombreProducto";
            this.LblNombreProducto.Size = new System.Drawing.Size(68, 20);
            this.LblNombreProducto.TabIndex = 0;
            this.LblNombreProducto.Text = "Nombre";
            // 
            // BtnCancelarVenta
            // 
            this.BtnCancelarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelarVenta.Image = global::Capa_Presentacion.Properties.Resources.IconCancel;
            this.BtnCancelarVenta.Location = new System.Drawing.Point(1073, 601);
            this.BtnCancelarVenta.Name = "BtnCancelarVenta";
            this.BtnCancelarVenta.Size = new System.Drawing.Size(150, 40);
            this.BtnCancelarVenta.TabIndex = 1;
            this.BtnCancelarVenta.Text = "Cancelar";
            this.BtnCancelarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelarVenta.UseVisualStyleBackColor = true;
            this.BtnCancelarVenta.Click += new System.EventHandler(this.BtnCancelarVenta_Click);
            // 
            // BtnRegistrarVenta
            // 
            this.BtnRegistrarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegistrarVenta.Image = global::Capa_Presentacion.Properties.Resources.IconRegisterSale;
            this.BtnRegistrarVenta.Location = new System.Drawing.Point(897, 601);
            this.BtnRegistrarVenta.Name = "BtnRegistrarVenta";
            this.BtnRegistrarVenta.Size = new System.Drawing.Size(170, 40);
            this.BtnRegistrarVenta.TabIndex = 1;
            this.BtnRegistrarVenta.Text = "Registrar Venta";
            this.BtnRegistrarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistrarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegistrarVenta.UseVisualStyleBackColor = true;
            this.BtnRegistrarVenta.Click += new System.EventHandler(this.BtnRegistrarVenta_Click);
            // 
            // Frm_RealizarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 666);
            this.Controls.Add(this.BtnCancelarVenta);
            this.Controls.Add(this.BtnRegistrarVenta);
            this.Controls.Add(this.GbProducto);
            this.Controls.Add(this.GBListado);
            this.Controls.Add(this.GbCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_RealizarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Venta";
            this.Load += new System.EventHandler(this.Frm_RealizarVenta_Load);
            this.GbCliente.ResumeLayout(false);
            this.GbCliente.PerformLayout();
            this.GBListado.ResumeLayout(false);
            this.GBListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoProductos)).EndInit();
            this.GbProducto.ResumeLayout(false);
            this.GbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbCliente;
        private System.Windows.Forms.GroupBox GBListado;
        private System.Windows.Forms.GroupBox GbProducto;
        private System.Windows.Forms.Button BtnBusquedaAvanzadaCliente;
        private System.Windows.Forms.Button BtnBuscarCliente;
        private System.Windows.Forms.TextBox TxtNombreCliente;
        private System.Windows.Forms.Label LblNombreCliente;
        private System.Windows.Forms.TextBox TxtDniCliente;
        private System.Windows.Forms.Label LblDni;
        private System.Windows.Forms.Button BtnBusquedaAvanzadaProducto;
        private System.Windows.Forms.Button BtnBuscarProducto;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.TextBox TxtCodigoProducto;
        private System.Windows.Forms.Label LblNombreProducto;
        private System.Windows.Forms.TextBox TxtTipoProducto;
        private System.Windows.Forms.Label LblTipoProducto;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.NumericUpDown NudCantidad;
        private System.Windows.Forms.ComboBox CboUnidadMedida;
        private System.Windows.Forms.Label LblUnidadMedida;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Button BtnRegistrarVenta;
        private System.Windows.Forms.Button BtnCancelarVenta;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DgvListadoProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClSubTotal;
        private System.Windows.Forms.Button BtnQuitar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRegistraPago;
    }
}