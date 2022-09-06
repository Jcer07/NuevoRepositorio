namespace Capa_Presentacion.Gestion_Datos_Entidades
{
    partial class Frm_GestionProducto
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
            this.GbProducto = new System.Windows.Forms.GroupBox();
            this.GbListado = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NudPrecio = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CboMarcaProducto = new System.Windows.Forms.ComboBox();
            this.CboCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNombreBuscar = new System.Windows.Forms.TextBox();
            this.BtnListarProducto = new System.Windows.Forms.Button();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnDarBaja = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.ClCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbProducto.SuspendLayout();
            this.GbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // GbProducto
            // 
            this.GbProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GbProducto.Controls.Add(this.CboCategoriaProducto);
            this.GbProducto.Controls.Add(this.BtnCancelar);
            this.GbProducto.Controls.Add(this.BtnAceptar);
            this.GbProducto.Controls.Add(this.CboMarcaProducto);
            this.GbProducto.Controls.Add(this.NudPrecio);
            this.GbProducto.Controls.Add(this.TxtDescripcion);
            this.GbProducto.Controls.Add(this.TxtNombreProducto);
            this.GbProducto.Controls.Add(this.label1);
            this.GbProducto.Controls.Add(this.label3);
            this.GbProducto.Controls.Add(this.label5);
            this.GbProducto.Controls.Add(this.label4);
            this.GbProducto.Controls.Add(this.label2);
            this.GbProducto.Enabled = false;
            this.GbProducto.Location = new System.Drawing.Point(12, 12);
            this.GbProducto.Name = "GbProducto";
            this.GbProducto.Size = new System.Drawing.Size(460, 633);
            this.GbProducto.TabIndex = 0;
            this.GbProducto.TabStop = false;
            this.GbProducto.Text = "Datos del Producto";
            // 
            // GbListado
            // 
            this.GbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbListado.Controls.Add(this.BtnDarBaja);
            this.GbListado.Controls.Add(this.BtnModificar);
            this.GbListado.Controls.Add(this.BtnNuevo);
            this.GbListado.Controls.Add(this.DgvListado);
            this.GbListado.Controls.Add(this.BtnListarProducto);
            this.GbListado.Controls.Add(this.TxtNombreBuscar);
            this.GbListado.Controls.Add(this.label6);
            this.GbListado.Location = new System.Drawing.Point(478, 12);
            this.GbListado.Name = "GbListado";
            this.GbListado.Size = new System.Drawing.Size(788, 633);
            this.GbListado.TabIndex = 0;
            this.GbListado.TabStop = false;
            this.GbListado.Text = "Listado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Location = new System.Drawing.Point(126, 126);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(288, 26);
            this.TxtNombreProducto.TabIndex = 2;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(126, 174);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(288, 63);
            this.TxtDescripcion.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Precio";
            // 
            // NudPrecio
            // 
            this.NudPrecio.DecimalPlaces = 2;
            this.NudPrecio.Location = new System.Drawing.Point(126, 262);
            this.NudPrecio.Name = "NudPrecio";
            this.NudPrecio.Size = new System.Drawing.Size(120, 26);
            this.NudPrecio.TabIndex = 3;
            this.NudPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Categoría";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Marca";
            // 
            // CboMarcaProducto
            // 
            this.CboMarcaProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboMarcaProducto.FormattingEnabled = true;
            this.CboMarcaProducto.Location = new System.Drawing.Point(126, 78);
            this.CboMarcaProducto.Name = "CboMarcaProducto";
            this.CboMarcaProducto.Size = new System.Drawing.Size(288, 28);
            this.CboMarcaProducto.TabIndex = 4;
            // 
            // CboCategoriaProducto
            // 
            this.CboCategoriaProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategoriaProducto.FormattingEnabled = true;
            this.CboCategoriaProducto.Location = new System.Drawing.Point(126, 36);
            this.CboCategoriaProducto.Name = "CboCategoriaProducto";
            this.CboCategoriaProducto.Size = new System.Drawing.Size(288, 28);
            this.CboCategoriaProducto.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Producto";
            // 
            // TxtNombreBuscar
            // 
            this.TxtNombreBuscar.Location = new System.Drawing.Point(97, 29);
            this.TxtNombreBuscar.Name = "TxtNombreBuscar";
            this.TxtNombreBuscar.Size = new System.Drawing.Size(513, 26);
            this.TxtNombreBuscar.TabIndex = 2;
            // 
            // BtnListarProducto
            // 
            this.BtnListarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListarProducto.Location = new System.Drawing.Point(632, 22);
            this.BtnListarProducto.Name = "BtnListarProducto";
            this.BtnListarProducto.Size = new System.Drawing.Size(114, 41);
            this.BtnListarProducto.TabIndex = 3;
            this.BtnListarProducto.Text = "Listar";
            this.BtnListarProducto.UseVisualStyleBackColor = true;
            this.BtnListarProducto.Click += new System.EventHandler(this.BtnListarProducto_Click);
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClCodigo,
            this.ClNombre,
            this.ClTipo,
            this.ClCantidad});
            this.DgvListado.Location = new System.Drawing.Point(19, 78);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.Size = new System.Drawing.Size(754, 460);
            this.DgvListado.TabIndex = 4;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevo.Location = new System.Drawing.Point(19, 569);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(150, 40);
            this.BtnNuevo.TabIndex = 5;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificar.Location = new System.Drawing.Point(187, 569);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(150, 40);
            this.BtnModificar.TabIndex = 5;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnDarBaja
            // 
            this.BtnDarBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDarBaja.Location = new System.Drawing.Point(623, 569);
            this.BtnDarBaja.Name = "BtnDarBaja";
            this.BtnDarBaja.Size = new System.Drawing.Size(150, 40);
            this.BtnDarBaja.TabIndex = 5;
            this.BtnDarBaja.Text = "Dar de Baja";
            this.BtnDarBaja.UseVisualStyleBackColor = true;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAceptar.Location = new System.Drawing.Point(99, 569);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(150, 40);
            this.BtnAceptar.TabIndex = 5;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Location = new System.Drawing.Point(264, 569);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(150, 40);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // ClCodigo
            // 
            this.ClCodigo.DataPropertyName = "CodigoProducto";
            this.ClCodigo.HeaderText = "Codigo";
            this.ClCodigo.MinimumWidth = 6;
            this.ClCodigo.Name = "ClCodigo";
            this.ClCodigo.ReadOnly = true;
            this.ClCodigo.Width = 125;
            // 
            // ClNombre
            // 
            this.ClNombre.DataPropertyName = "Nombre";
            this.ClNombre.HeaderText = "Nombre";
            this.ClNombre.MinimumWidth = 6;
            this.ClNombre.Name = "ClNombre";
            this.ClNombre.ReadOnly = true;
            this.ClNombre.Width = 175;
            // 
            // ClTipo
            // 
            this.ClTipo.DataPropertyName = "NombreCategoria";
            this.ClTipo.HeaderText = "Tipo";
            this.ClTipo.MinimumWidth = 6;
            this.ClTipo.Name = "ClTipo";
            this.ClTipo.ReadOnly = true;
            this.ClTipo.Width = 150;
            // 
            // ClCantidad
            // 
            this.ClCantidad.HeaderText = "Cantidad";
            this.ClCantidad.MinimumWidth = 6;
            this.ClCantidad.Name = "ClCantidad";
            this.ClCantidad.ReadOnly = true;
            this.ClCantidad.Width = 125;
            // 
            // Frm_GestionProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 657);
            this.Controls.Add(this.GbListado);
            this.Controls.Add(this.GbProducto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_GestionProducto";
            this.Text = "Gestión de Producto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_GestionProducto_Load);
            this.GbProducto.ResumeLayout(false);
            this.GbProducto.PerformLayout();
            this.GbListado.ResumeLayout(false);
            this.GbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbProducto;
        private System.Windows.Forms.GroupBox GbListado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.NumericUpDown NudPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboCategoriaProducto;
        private System.Windows.Forms.ComboBox CboMarcaProducto;
        private System.Windows.Forms.TextBox TxtNombreBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnListarProducto;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnDarBaja;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCantidad;
    }
}