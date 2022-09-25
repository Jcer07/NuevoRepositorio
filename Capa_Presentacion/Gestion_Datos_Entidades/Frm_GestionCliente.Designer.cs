namespace Capa_Presentacion.Gestion_Datos_Entidades
{
    partial class Frm_GestionCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GestionCliente));
            this.GbCliente = new System.Windows.Forms.GroupBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblDistrito = new System.Windows.Forms.Label();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.LblDepartamento = new System.Windows.Forms.Label();
            this.LblNombres = new System.Windows.Forms.Label();
            this.CboDistrito = new System.Windows.Forms.ComboBox();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.CboProvincia = new System.Windows.Forms.ComboBox();
            this.LblDni = new System.Windows.Forms.Label();
            this.CboDepartamento = new System.Windows.Forms.ComboBox();
            this.GbListado = new System.Windows.Forms.GroupBox();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.ClDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDarBaja = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.TxtNombreBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrNotificator = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbCliente.SuspendLayout();
            this.GbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificator)).BeginInit();
            this.SuspendLayout();
            // 
            // GbCliente
            // 
            this.GbCliente.Controls.Add(this.BtnCancelar);
            this.GbCliente.Controls.Add(this.BtnAceptar);
            this.GbCliente.Controls.Add(this.TxtCorreo);
            this.GbCliente.Controls.Add(this.TxtTelefono);
            this.GbCliente.Controls.Add(this.LblCorreo);
            this.GbCliente.Controls.Add(this.TxtDireccion);
            this.GbCliente.Controls.Add(this.LblTelefono);
            this.GbCliente.Controls.Add(this.TxtApellidos);
            this.GbCliente.Controls.Add(this.LblDireccion);
            this.GbCliente.Controls.Add(this.LblDistrito);
            this.GbCliente.Controls.Add(this.LblApellidos);
            this.GbCliente.Controls.Add(this.label1);
            this.GbCliente.Controls.Add(this.TxtNombres);
            this.GbCliente.Controls.Add(this.LblDepartamento);
            this.GbCliente.Controls.Add(this.LblNombres);
            this.GbCliente.Controls.Add(this.CboDistrito);
            this.GbCliente.Controls.Add(this.TxtDni);
            this.GbCliente.Controls.Add(this.CboProvincia);
            this.GbCliente.Controls.Add(this.LblDni);
            this.GbCliente.Controls.Add(this.CboDepartamento);
            this.GbCliente.Location = new System.Drawing.Point(12, 12);
            this.GbCliente.Name = "GbCliente";
            this.GbCliente.Size = new System.Drawing.Size(492, 499);
            this.GbCliente.TabIndex = 1;
            this.GbCliente.TabStop = false;
            this.GbCliente.Text = "Cliente";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::Capa_Presentacion.Properties.Resources.IconCancel;
            this.BtnCancelar.Location = new System.Drawing.Point(318, 437);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(150, 40);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Image = global::Capa_Presentacion.Properties.Resources.IconAccept;
            this.BtnAceptar.Location = new System.Drawing.Point(145, 437);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(150, 40);
            this.BtnAceptar.TabIndex = 11;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(156, 381);
            this.TxtCorreo.MaxLength = 100;
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(312, 26);
            this.TxtCorreo.TabIndex = 9;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(156, 338);
            this.TxtTelefono.MaxLength = 12;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(312, 26);
            this.TxtTelefono.TabIndex = 8;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Location = new System.Drawing.Point(12, 384);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(60, 20);
            this.LblCorreo.TabIndex = 1;
            this.LblCorreo.Text = "Correo";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(156, 296);
            this.TxtDireccion.MaxLength = 150;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(312, 26);
            this.TxtDireccion.TabIndex = 7;
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(12, 341);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(73, 20);
            this.LblTelefono.TabIndex = 1;
            this.LblTelefono.Text = "Teléfono";
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(156, 122);
            this.TxtApellidos.MaxLength = 50;
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(312, 26);
            this.TxtApellidos.TabIndex = 3;
            this.TxtApellidos.Validating += new System.ComponentModel.CancelEventHandler(this.TxtApellidos_Validating);
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Location = new System.Drawing.Point(12, 299);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(81, 20);
            this.LblDireccion.TabIndex = 1;
            this.LblDireccion.Text = "Dirección";
            // 
            // LblDistrito
            // 
            this.LblDistrito.AutoSize = true;
            this.LblDistrito.Location = new System.Drawing.Point(12, 255);
            this.LblDistrito.Name = "LblDistrito";
            this.LblDistrito.Size = new System.Drawing.Size(64, 20);
            this.LblDistrito.TabIndex = 1;
            this.LblDistrito.Text = "Distrito";
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Location = new System.Drawing.Point(12, 125);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(77, 20);
            this.LblApellidos.TabIndex = 1;
            this.LblApellidos.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Provincia";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(156, 79);
            this.TxtNombres.MaxLength = 50;
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(312, 26);
            this.TxtNombres.TabIndex = 2;
            this.TxtNombres.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombres_Validating);
            // 
            // LblDepartamento
            // 
            this.LblDepartamento.AutoSize = true;
            this.LblDepartamento.Location = new System.Drawing.Point(12, 166);
            this.LblDepartamento.Name = "LblDepartamento";
            this.LblDepartamento.Size = new System.Drawing.Size(115, 20);
            this.LblDepartamento.TabIndex = 0;
            this.LblDepartamento.Text = "Departamento";
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Location = new System.Drawing.Point(12, 82);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(77, 20);
            this.LblNombres.TabIndex = 1;
            this.LblNombres.Text = "Nombres";
            // 
            // CboDistrito
            // 
            this.CboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDistrito.FormattingEnabled = true;
            this.CboDistrito.Location = new System.Drawing.Point(156, 252);
            this.CboDistrito.Name = "CboDistrito";
            this.CboDistrito.Size = new System.Drawing.Size(312, 28);
            this.CboDistrito.TabIndex = 6;
            this.CboDistrito.Enter += new System.EventHandler(this.CboDistrito_Enter);
            // 
            // TxtDni
            // 
            this.TxtDni.Location = new System.Drawing.Point(156, 39);
            this.TxtDni.MaxLength = 8;
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(312, 26);
            this.TxtDni.TabIndex = 1;
            this.TxtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDni_KeyPress);
            this.TxtDni.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDni_Validating);
            // 
            // CboProvincia
            // 
            this.CboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboProvincia.FormattingEnabled = true;
            this.CboProvincia.Location = new System.Drawing.Point(156, 207);
            this.CboProvincia.Name = "CboProvincia";
            this.CboProvincia.Size = new System.Drawing.Size(312, 28);
            this.CboProvincia.TabIndex = 5;
            this.CboProvincia.Enter += new System.EventHandler(this.CboProvincia_Enter);
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Location = new System.Drawing.Point(12, 42);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(102, 20);
            this.LblDni.TabIndex = 1;
            this.LblDni.Text = "Número DNI";
            // 
            // CboDepartamento
            // 
            this.CboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDepartamento.FormattingEnabled = true;
            this.CboDepartamento.Location = new System.Drawing.Point(156, 163);
            this.CboDepartamento.Name = "CboDepartamento";
            this.CboDepartamento.Size = new System.Drawing.Size(312, 28);
            this.CboDepartamento.TabIndex = 4;
            // 
            // GbListado
            // 
            this.GbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbListado.Controls.Add(this.DgvListado);
            this.GbListado.Controls.Add(this.BtnDarBaja);
            this.GbListado.Controls.Add(this.BtnModificar);
            this.GbListado.Controls.Add(this.BtnNuevo);
            this.GbListado.Controls.Add(this.TxtNombreBuscar);
            this.GbListado.Controls.Add(this.BtnBuscar);
            this.GbListado.Controls.Add(this.label2);
            this.GbListado.Location = new System.Drawing.Point(510, 12);
            this.GbListado.Name = "GbListado";
            this.GbListado.Size = new System.Drawing.Size(755, 634);
            this.GbListado.TabIndex = 2;
            this.GbListado.TabStop = false;
            this.GbListado.Text = "Listado";
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
            this.ClDni,
            this.ClNombres,
            this.ClDireccion,
            this.ClTelefono});
            this.DgvListado.Location = new System.Drawing.Point(24, 87);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvListado.Size = new System.Drawing.Size(711, 455);
            this.DgvListado.TabIndex = 7;
            // 
            // ClDni
            // 
            this.ClDni.DataPropertyName = "NumeroDni";
            this.ClDni.HeaderText = "DNI";
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
            // BtnDarBaja
            // 
            this.BtnDarBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDarBaja.Image = global::Capa_Presentacion.Properties.Resources.IconDelete;
            this.BtnDarBaja.Location = new System.Drawing.Point(585, 567);
            this.BtnDarBaja.Name = "BtnDarBaja";
            this.BtnDarBaja.Size = new System.Drawing.Size(150, 40);
            this.BtnDarBaja.TabIndex = 6;
            this.BtnDarBaja.Text = "Dar de baja";
            this.BtnDarBaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDarBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDarBaja.UseVisualStyleBackColor = true;
            this.BtnDarBaja.Click += new System.EventHandler(this.BtnDarBaja_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificar.Image = global::Capa_Presentacion.Properties.Resources.IconUpdate;
            this.BtnModificar.Location = new System.Drawing.Point(193, 567);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(150, 40);
            this.BtnModificar.TabIndex = 5;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevo.Image = global::Capa_Presentacion.Properties.Resources.IconNew;
            this.BtnNuevo.Location = new System.Drawing.Point(24, 567);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(150, 40);
            this.BtnNuevo.TabIndex = 4;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // TxtNombreBuscar
            // 
            this.TxtNombreBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombreBuscar.Location = new System.Drawing.Point(113, 38);
            this.TxtNombreBuscar.MaxLength = 50;
            this.TxtNombreBuscar.Name = "TxtNombreBuscar";
            this.TxtNombreBuscar.Size = new System.Drawing.Size(449, 26);
            this.TxtNombreBuscar.TabIndex = 2;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar.Image = global::Capa_Presentacion.Properties.Resources.IconList;
            this.BtnBuscar.Location = new System.Drawing.Point(585, 25);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(150, 40);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Listar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // ErrNotificator
            // 
            this.ErrNotificator.ContainerControl = this;
            // 
            // Frm_GestionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1277, 664);
            this.Controls.Add(this.GbListado);
            this.Controls.Add(this.GbCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_GestionCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Cliente";
            this.Load += new System.EventHandler(this.Frm_GestionCliente_Load);
            this.GbCliente.ResumeLayout(false);
            this.GbCliente.PerformLayout();
            this.GbListado.ResumeLayout(false);
            this.GbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbCliente;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblDistrito;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label LblDepartamento;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.ComboBox CboDistrito;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.ComboBox CboProvincia;
        private System.Windows.Forms.Label LblDni;
        private System.Windows.Forms.ComboBox CboDepartamento;
        private System.Windows.Forms.GroupBox GbListado;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button BtnDarBaja;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.TextBox TxtNombreBuscar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClTelefono;
        private System.Windows.Forms.ErrorProvider ErrNotificator;
    }
}