namespace Capa_Presentacion.Gestion_Datos_Entidades
{
    partial class Frm_GestionMarcaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GestionMarcaProducto));
            this.GbMarcaProducto = new System.Windows.Forms.GroupBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GbListado = new System.Windows.Forms.GroupBox();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.ClCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDarBaja = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.ErrNotificator = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbMarcaProducto.SuspendLayout();
            this.GbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificator)).BeginInit();
            this.SuspendLayout();
            // 
            // GbMarcaProducto
            // 
            this.GbMarcaProducto.Controls.Add(this.BtnCancelar);
            this.GbMarcaProducto.Controls.Add(this.BtnAceptar);
            this.GbMarcaProducto.Controls.Add(this.TxtDescripcion);
            this.GbMarcaProducto.Controls.Add(this.TxtNombre);
            this.GbMarcaProducto.Controls.Add(this.label3);
            this.GbMarcaProducto.Controls.Add(this.CboCategoria);
            this.GbMarcaProducto.Controls.Add(this.label2);
            this.GbMarcaProducto.Controls.Add(this.label1);
            this.GbMarcaProducto.Enabled = false;
            this.GbMarcaProducto.Location = new System.Drawing.Point(12, 12);
            this.GbMarcaProducto.Name = "GbMarcaProducto";
            this.GbMarcaProducto.Size = new System.Drawing.Size(514, 268);
            this.GbMarcaProducto.TabIndex = 0;
            this.GbMarcaProducto.TabStop = false;
            this.GbMarcaProducto.Text = "Marca de Producto";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::Capa_Presentacion.Properties.Resources.IconCancel;
            this.BtnCancelar.Location = new System.Drawing.Point(359, 212);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(120, 40);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Image = global::Capa_Presentacion.Properties.Resources.IconAccept;
            this.BtnAceptar.Location = new System.Drawing.Point(212, 212);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(120, 40);
            this.BtnAceptar.TabIndex = 3;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(128, 125);
            this.TxtDescripcion.MaxLength = 150;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(351, 26);
            this.TxtDescripcion.TabIndex = 2;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(128, 79);
            this.TxtNombre.MaxLength = 50;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(351, 26);
            this.TxtNombre.TabIndex = 2;
            this.TxtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombre_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descripción";
            // 
            // CboCategoria
            // 
            this.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(128, 34);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(351, 28);
            this.CboCategoria.TabIndex = 1;
            this.CboCategoria.Validating += new System.ComponentModel.CancelEventHandler(this.CboCategoria_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoría";
            // 
            // GbListado
            // 
            this.GbListado.Controls.Add(this.DgvListado);
            this.GbListado.Controls.Add(this.BtnDarBaja);
            this.GbListado.Controls.Add(this.BtnListar);
            this.GbListado.Controls.Add(this.TxtMarca);
            this.GbListado.Controls.Add(this.BtnModificar);
            this.GbListado.Controls.Add(this.label4);
            this.GbListado.Controls.Add(this.BtnNuevo);
            this.GbListado.Location = new System.Drawing.Point(532, 12);
            this.GbListado.Name = "GbListado";
            this.GbListado.Size = new System.Drawing.Size(648, 603);
            this.GbListado.TabIndex = 0;
            this.GbListado.TabStop = false;
            this.GbListado.Text = "Listado";
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClCategoria,
            this.ClNombre});
            this.DgvListado.Location = new System.Drawing.Point(23, 97);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.Size = new System.Drawing.Size(610, 437);
            this.DgvListado.TabIndex = 4;
            // 
            // ClCategoria
            // 
            this.ClCategoria.DataPropertyName = "NombreCategoria";
            this.ClCategoria.HeaderText = "Categoría";
            this.ClCategoria.MinimumWidth = 6;
            this.ClCategoria.Name = "ClCategoria";
            this.ClCategoria.ReadOnly = true;
            // 
            // ClNombre
            // 
            this.ClNombre.DataPropertyName = "NombreMarca";
            this.ClNombre.HeaderText = "Nombre";
            this.ClNombre.MinimumWidth = 6;
            this.ClNombre.Name = "ClNombre";
            this.ClNombre.ReadOnly = true;
            // 
            // BtnDarBaja
            // 
            this.BtnDarBaja.Image = global::Capa_Presentacion.Properties.Resources.IconDelete;
            this.BtnDarBaja.Location = new System.Drawing.Point(493, 549);
            this.BtnDarBaja.Name = "BtnDarBaja";
            this.BtnDarBaja.Size = new System.Drawing.Size(140, 40);
            this.BtnDarBaja.TabIndex = 3;
            this.BtnDarBaja.Text = "Dar de Baja";
            this.BtnDarBaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDarBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDarBaja.UseVisualStyleBackColor = true;
            this.BtnDarBaja.Click += new System.EventHandler(this.BtnDarBaja_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.Image = global::Capa_Presentacion.Properties.Resources.IconList;
            this.BtnListar.Location = new System.Drawing.Point(513, 34);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(120, 40);
            this.BtnListar.TabIndex = 3;
            this.BtnListar.Text = "Listar";
            this.BtnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(81, 41);
            this.TxtMarca.MaxLength = 50;
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(394, 26);
            this.TxtMarca.TabIndex = 2;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Image = global::Capa_Presentacion.Properties.Resources.IconUpdate;
            this.BtnModificar.Location = new System.Drawing.Point(170, 549);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(120, 40);
            this.BtnModificar.TabIndex = 3;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Marca";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Image = global::Capa_Presentacion.Properties.Resources.IconNew;
            this.BtnNuevo.Location = new System.Drawing.Point(23, 549);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(120, 40);
            this.BtnNuevo.TabIndex = 3;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // ErrNotificator
            // 
            this.ErrNotificator.ContainerControl = this;
            // 
            // Frm_GestionMarcaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1192, 631);
            this.Controls.Add(this.GbListado);
            this.Controls.Add(this.GbMarcaProducto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_GestionMarcaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Marca de Producto";
            this.Load += new System.EventHandler(this.Frm_GestionMarcaProducto_Load);
            this.GbMarcaProducto.ResumeLayout(false);
            this.GbMarcaProducto.PerformLayout();
            this.GbListado.ResumeLayout(false);
            this.GbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbMarcaProducto;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbListado;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnDarBaja;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.ErrorProvider ErrNotificator;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombre;
    }
}