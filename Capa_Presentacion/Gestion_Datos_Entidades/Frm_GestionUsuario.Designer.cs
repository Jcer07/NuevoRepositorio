namespace Capa_Presentacion.Gestion_Datos_Entidades
{
    partial class Frm_GestionUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GestionUsuario));
            this.GbPersonal = new System.Windows.Forms.GroupBox();
            this.BtnBuscarPersonal = new System.Windows.Forms.Button();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.TxtNombrePersonal = new System.Windows.Forms.TextBox();
            this.LblDni = new System.Windows.Forms.Label();
            this.LblNombres = new System.Windows.Forms.Label();
            this.GbUsuario = new System.Windows.Forms.GroupBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.LblRepiteClave = new System.Windows.Forms.Label();
            this.LblClave = new System.Windows.Forms.Label();
            this.LblSiglasUsuario = new System.Windows.Forms.Label();
            this.LblNombreUsuario = new System.Windows.Forms.Label();
            this.LblTipoUsuario = new System.Windows.Forms.Label();
            this.TxtRepiteClave = new System.Windows.Forms.TextBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.TxtSiglasTipoUsuario = new System.Windows.Forms.TextBox();
            this.TxtTipoUsuario = new System.Windows.Forms.TextBox();
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.GbListado = new System.Windows.Forms.GroupBox();
            this.BtnDarBaja = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.ClNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClSiglas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnListar = new System.Windows.Forms.Button();
            this.TxtUsuarioBuscar = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.ErrNotificator = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbPersonal.SuspendLayout();
            this.GbUsuario.SuspendLayout();
            this.GbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificator)).BeginInit();
            this.SuspendLayout();
            // 
            // GbPersonal
            // 
            this.GbPersonal.Controls.Add(this.BtnBuscarPersonal);
            this.GbPersonal.Controls.Add(this.TxtDni);
            this.GbPersonal.Controls.Add(this.TxtNombrePersonal);
            this.GbPersonal.Controls.Add(this.LblDni);
            this.GbPersonal.Controls.Add(this.LblNombres);
            this.GbPersonal.Location = new System.Drawing.Point(13, 13);
            this.GbPersonal.Name = "GbPersonal";
            this.GbPersonal.Size = new System.Drawing.Size(425, 192);
            this.GbPersonal.TabIndex = 0;
            this.GbPersonal.TabStop = false;
            this.GbPersonal.Text = "Datos de Personal";
            // 
            // BtnBuscarPersonal
            // 
            this.BtnBuscarPersonal.Image = global::Capa_Presentacion.Properties.Resources.IconSearch2;
            this.BtnBuscarPersonal.Location = new System.Drawing.Point(264, 66);
            this.BtnBuscarPersonal.Name = "BtnBuscarPersonal";
            this.BtnBuscarPersonal.Size = new System.Drawing.Size(120, 30);
            this.BtnBuscarPersonal.TabIndex = 1;
            this.BtnBuscarPersonal.Text = "Buscar";
            this.BtnBuscarPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscarPersonal.UseVisualStyleBackColor = true;
            this.BtnBuscarPersonal.Click += new System.EventHandler(this.BtnBuscarPersonal_Click);
            // 
            // TxtDni
            // 
            this.TxtDni.Location = new System.Drawing.Point(20, 66);
            this.TxtDni.MaxLength = 8;
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(208, 26);
            this.TxtDni.TabIndex = 0;
            this.TxtDni.TextChanged += new System.EventHandler(this.TxtDni_TextChanged);
            this.TxtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDni_KeyPress);
            // 
            // TxtNombrePersonal
            // 
            this.TxtNombrePersonal.Location = new System.Drawing.Point(20, 140);
            this.TxtNombrePersonal.Name = "TxtNombrePersonal";
            this.TxtNombrePersonal.ReadOnly = true;
            this.TxtNombrePersonal.Size = new System.Drawing.Size(365, 26);
            this.TxtNombrePersonal.TabIndex = 2;
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Location = new System.Drawing.Point(16, 36);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(35, 20);
            this.LblDni.TabIndex = 1;
            this.LblDni.Text = "Dni";
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Location = new System.Drawing.Point(16, 112);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(77, 20);
            this.LblNombres.TabIndex = 1;
            this.LblNombres.Text = "Nombres";
            // 
            // GbUsuario
            // 
            this.GbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GbUsuario.Controls.Add(this.BtnCancelar);
            this.GbUsuario.Controls.Add(this.BtnAceptar);
            this.GbUsuario.Controls.Add(this.LblRepiteClave);
            this.GbUsuario.Controls.Add(this.LblClave);
            this.GbUsuario.Controls.Add(this.LblSiglasUsuario);
            this.GbUsuario.Controls.Add(this.LblNombreUsuario);
            this.GbUsuario.Controls.Add(this.LblTipoUsuario);
            this.GbUsuario.Controls.Add(this.TxtRepiteClave);
            this.GbUsuario.Controls.Add(this.TxtClave);
            this.GbUsuario.Controls.Add(this.TxtSiglasTipoUsuario);
            this.GbUsuario.Controls.Add(this.TxtTipoUsuario);
            this.GbUsuario.Controls.Add(this.TxtNombreUsuario);
            this.GbUsuario.Location = new System.Drawing.Point(13, 211);
            this.GbUsuario.Name = "GbUsuario";
            this.GbUsuario.Size = new System.Drawing.Size(425, 433);
            this.GbUsuario.TabIndex = 1;
            this.GbUsuario.TabStop = false;
            this.GbUsuario.Text = "Datos de Usuario";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Image = global::Capa_Presentacion.Properties.Resources.IconCancel;
            this.BtnCancelar.Location = new System.Drawing.Point(235, 377);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(150, 40);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAceptar.Image = global::Capa_Presentacion.Properties.Resources.IconAccept;
            this.BtnAceptar.Location = new System.Drawing.Point(79, 377);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(150, 40);
            this.BtnAceptar.TabIndex = 5;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // LblRepiteClave
            // 
            this.LblRepiteClave.AutoSize = true;
            this.LblRepiteClave.Location = new System.Drawing.Point(16, 311);
            this.LblRepiteClave.Name = "LblRepiteClave";
            this.LblRepiteClave.Size = new System.Drawing.Size(104, 20);
            this.LblRepiteClave.TabIndex = 1;
            this.LblRepiteClave.Text = "Repita Clave";
            // 
            // LblClave
            // 
            this.LblClave.AutoSize = true;
            this.LblClave.Location = new System.Drawing.Point(16, 242);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(51, 20);
            this.LblClave.TabIndex = 1;
            this.LblClave.Text = "Clave";
            // 
            // LblSiglasUsuario
            // 
            this.LblSiglasUsuario.AutoSize = true;
            this.LblSiglasUsuario.Location = new System.Drawing.Point(16, 174);
            this.LblSiglasUsuario.Name = "LblSiglasUsuario";
            this.LblSiglasUsuario.Size = new System.Drawing.Size(145, 20);
            this.LblSiglasUsuario.TabIndex = 1;
            this.LblSiglasUsuario.Text = "SiglasTipoUsuario";
            // 
            // LblNombreUsuario
            // 
            this.LblNombreUsuario.AutoSize = true;
            this.LblNombreUsuario.Location = new System.Drawing.Point(16, 105);
            this.LblNombreUsuario.Name = "LblNombreUsuario";
            this.LblNombreUsuario.Size = new System.Drawing.Size(154, 20);
            this.LblNombreUsuario.TabIndex = 1;
            this.LblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // LblTipoUsuario
            // 
            this.LblTipoUsuario.AutoSize = true;
            this.LblTipoUsuario.Location = new System.Drawing.Point(16, 35);
            this.LblTipoUsuario.Name = "LblTipoUsuario";
            this.LblTipoUsuario.Size = new System.Drawing.Size(99, 20);
            this.LblTipoUsuario.TabIndex = 1;
            this.LblTipoUsuario.Text = "TipoUsuario";
            // 
            // TxtRepiteClave
            // 
            this.TxtRepiteClave.Location = new System.Drawing.Point(20, 337);
            this.TxtRepiteClave.Name = "TxtRepiteClave";
            this.TxtRepiteClave.Size = new System.Drawing.Size(365, 26);
            this.TxtRepiteClave.TabIndex = 4;
            this.TxtRepiteClave.UseSystemPasswordChar = true;
            this.TxtRepiteClave.Validating += new System.ComponentModel.CancelEventHandler(this.TxtRepiteClave_Validating);
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(20, 268);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(365, 26);
            this.TxtClave.TabIndex = 3;
            this.TxtClave.UseSystemPasswordChar = true;
            this.TxtClave.Validating += new System.ComponentModel.CancelEventHandler(this.TxtClave_Validating);
            // 
            // TxtSiglasTipoUsuario
            // 
            this.TxtSiglasTipoUsuario.Location = new System.Drawing.Point(20, 200);
            this.TxtSiglasTipoUsuario.Name = "TxtSiglasTipoUsuario";
            this.TxtSiglasTipoUsuario.ReadOnly = true;
            this.TxtSiglasTipoUsuario.Size = new System.Drawing.Size(365, 26);
            this.TxtSiglasTipoUsuario.TabIndex = 2;
            // 
            // TxtTipoUsuario
            // 
            this.TxtTipoUsuario.Location = new System.Drawing.Point(20, 62);
            this.TxtTipoUsuario.Name = "TxtTipoUsuario";
            this.TxtTipoUsuario.ReadOnly = true;
            this.TxtTipoUsuario.Size = new System.Drawing.Size(365, 26);
            this.TxtTipoUsuario.TabIndex = 1;
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Location = new System.Drawing.Point(20, 131);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(365, 26);
            this.TxtNombreUsuario.TabIndex = 1;
            this.TxtNombreUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombreUsuario_Validating);
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
            this.GbListado.Controls.Add(this.BtnListar);
            this.GbListado.Controls.Add(this.TxtUsuarioBuscar);
            this.GbListado.Controls.Add(this.LblUsuario);
            this.GbListado.Location = new System.Drawing.Point(458, 12);
            this.GbListado.Name = "GbListado";
            this.GbListado.Size = new System.Drawing.Size(751, 632);
            this.GbListado.TabIndex = 2;
            this.GbListado.TabStop = false;
            this.GbListado.Text = "Listado";
            // 
            // BtnDarBaja
            // 
            this.BtnDarBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDarBaja.Image = global::Capa_Presentacion.Properties.Resources.IconDelete;
            this.BtnDarBaja.Location = new System.Drawing.Point(582, 571);
            this.BtnDarBaja.Name = "BtnDarBaja";
            this.BtnDarBaja.Size = new System.Drawing.Size(150, 40);
            this.BtnDarBaja.TabIndex = 4;
            this.BtnDarBaja.Text = "Dar de Baja";
            this.BtnDarBaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDarBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDarBaja.UseVisualStyleBackColor = true;
            this.BtnDarBaja.Click += new System.EventHandler(this.BtnDarBaja_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificar.Image = global::Capa_Presentacion.Properties.Resources.IconUpdate;
            this.BtnModificar.Location = new System.Drawing.Point(183, 571);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(150, 40);
            this.BtnModificar.TabIndex = 3;
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
            this.BtnNuevo.Location = new System.Drawing.Point(27, 571);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(150, 40);
            this.BtnNuevo.TabIndex = 2;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
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
            this.ClNombres,
            this.ClUsuario,
            this.ClTipo,
            this.ClSiglas});
            this.DgvListado.Location = new System.Drawing.Point(27, 113);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.Size = new System.Drawing.Size(705, 435);
            this.DgvListado.TabIndex = 5;
            // 
            // ClNombres
            // 
            this.ClNombres.DataPropertyName = "NombrePersonal";
            this.ClNombres.HeaderText = "Nombres";
            this.ClNombres.MinimumWidth = 6;
            this.ClNombres.Name = "ClNombres";
            this.ClNombres.ReadOnly = true;
            // 
            // ClUsuario
            // 
            this.ClUsuario.DataPropertyName = "NombreUsuario";
            this.ClUsuario.HeaderText = "Usuario";
            this.ClUsuario.MinimumWidth = 6;
            this.ClUsuario.Name = "ClUsuario";
            this.ClUsuario.ReadOnly = true;
            // 
            // ClTipo
            // 
            this.ClTipo.DataPropertyName = "TipoUsuario";
            this.ClTipo.HeaderText = "Tipo";
            this.ClTipo.MinimumWidth = 6;
            this.ClTipo.Name = "ClTipo";
            this.ClTipo.ReadOnly = true;
            // 
            // ClSiglas
            // 
            this.ClSiglas.DataPropertyName = "SiglasUsuario";
            this.ClSiglas.HeaderText = "Siglas";
            this.ClSiglas.MinimumWidth = 6;
            this.ClSiglas.Name = "ClSiglas";
            this.ClSiglas.ReadOnly = true;
            // 
            // BtnListar
            // 
            this.BtnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListar.Image = global::Capa_Presentacion.Properties.Resources.IconList;
            this.BtnListar.Location = new System.Drawing.Point(611, 60);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(121, 40);
            this.BtnListar.TabIndex = 1;
            this.BtnListar.Text = "Listar";
            this.BtnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // TxtUsuarioBuscar
            // 
            this.TxtUsuarioBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUsuarioBuscar.Location = new System.Drawing.Point(96, 65);
            this.TxtUsuarioBuscar.Name = "TxtUsuarioBuscar";
            this.TxtUsuarioBuscar.Size = new System.Drawing.Size(496, 26);
            this.TxtUsuarioBuscar.TabIndex = 0;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(23, 68);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(67, 20);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "Usuario";
            // 
            // ErrNotificator
            // 
            this.ErrNotificator.ContainerControl = this;
            // 
            // Frm_GestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1221, 656);
            this.Controls.Add(this.GbListado);
            this.Controls.Add(this.GbUsuario);
            this.Controls.Add(this.GbPersonal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_GestionUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Usuario";
            this.Load += new System.EventHandler(this.Frm_GestionUsuario_Load);
            this.GbPersonal.ResumeLayout(false);
            this.GbPersonal.PerformLayout();
            this.GbUsuario.ResumeLayout(false);
            this.GbUsuario.PerformLayout();
            this.GbListado.ResumeLayout(false);
            this.GbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbPersonal;
        private System.Windows.Forms.GroupBox GbUsuario;
        private System.Windows.Forms.GroupBox GbListado;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.TextBox TxtNombrePersonal;
        private System.Windows.Forms.Label LblDni;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.Button BtnBuscarPersonal;
        private System.Windows.Forms.Label LblTipoUsuario;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label LblRepiteClave;
        private System.Windows.Forms.Label LblClave;
        private System.Windows.Forms.Label LblSiglasUsuario;
        private System.Windows.Forms.Label LblNombreUsuario;
        private System.Windows.Forms.TextBox TxtRepiteClave;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.TextBox TxtSiglasTipoUsuario;
        private System.Windows.Forms.TextBox TxtNombreUsuario;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.TextBox TxtUsuarioBuscar;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button BtnDarBaja;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.TextBox TxtTipoUsuario;
        private System.Windows.Forms.ErrorProvider ErrNotificator;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClSiglas;
    }
}