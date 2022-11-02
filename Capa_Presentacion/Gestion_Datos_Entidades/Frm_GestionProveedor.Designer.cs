namespace ComercializacionFerroCenter.Gestion_Datos_Entidades
{
    partial class Frm_GestionProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GestionProveedor));
            this.GbProveedor = new System.Windows.Forms.GroupBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtSitioWeb = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.LblSitioWeb = new System.Windows.Forms.Label();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblDistrito = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.LblDepartamento = new System.Windows.Forms.Label();
            this.LblRazonSocial = new System.Windows.Forms.Label();
            this.CboDistrito = new System.Windows.Forms.ComboBox();
            this.TxtRuc = new System.Windows.Forms.TextBox();
            this.CboProvincia = new System.Windows.Forms.ComboBox();
            this.LblRuc = new System.Windows.Forms.Label();
            this.CboDepartamento = new System.Windows.Forms.ComboBox();
            this.GbListado = new System.Windows.Forms.GroupBox();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.ClCodigoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClNumeroRuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClSitioWeb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClVigente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDarBaja = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.TxtRazonSocialBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LblRazonSocialBuscar = new System.Windows.Forms.Label();
            this.ErrNotificator = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbProveedor.SuspendLayout();
            this.GbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificator)).BeginInit();
            this.SuspendLayout();
            // 
            // GbProveedor
            // 
            this.GbProveedor.Controls.Add(this.BtnCancelar);
            this.GbProveedor.Controls.Add(this.BtnAceptar);
            this.GbProveedor.Controls.Add(this.TxtSitioWeb);
            this.GbProveedor.Controls.Add(this.TxtCorreo);
            this.GbProveedor.Controls.Add(this.LblSitioWeb);
            this.GbProveedor.Controls.Add(this.LblCorreo);
            this.GbProveedor.Controls.Add(this.TxtDireccion);
            this.GbProveedor.Controls.Add(this.TxtTelefono);
            this.GbProveedor.Controls.Add(this.LblDireccion);
            this.GbProveedor.Controls.Add(this.LblDistrito);
            this.GbProveedor.Controls.Add(this.LblTelefono);
            this.GbProveedor.Controls.Add(this.label1);
            this.GbProveedor.Controls.Add(this.TxtRazonSocial);
            this.GbProveedor.Controls.Add(this.LblDepartamento);
            this.GbProveedor.Controls.Add(this.LblRazonSocial);
            this.GbProveedor.Controls.Add(this.CboDistrito);
            this.GbProveedor.Controls.Add(this.TxtRuc);
            this.GbProveedor.Controls.Add(this.CboProvincia);
            this.GbProveedor.Controls.Add(this.LblRuc);
            this.GbProveedor.Controls.Add(this.CboDepartamento);
            this.GbProveedor.Enabled = false;
            this.GbProveedor.Location = new System.Drawing.Point(12, 12);
            this.GbProveedor.Name = "GbProveedor";
            this.GbProveedor.Size = new System.Drawing.Size(492, 634);
            this.GbProveedor.TabIndex = 1;
            this.GbProveedor.TabStop = false;
            this.GbProveedor.Text = "Proveedor";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::ComercializacionFerroCenter.Properties.Resources.IconCancel;
            this.BtnCancelar.Location = new System.Drawing.Point(318, 441);
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
            this.BtnAceptar.Image = global::ComercializacionFerroCenter.Properties.Resources.IconAccept;
            this.BtnAceptar.Location = new System.Drawing.Point(145, 441);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(150, 40);
            this.BtnAceptar.TabIndex = 11;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // TxtSitioWeb
            // 
            this.TxtSitioWeb.Location = new System.Drawing.Point(156, 338);
            this.TxtSitioWeb.MaxLength = 100;
            this.TxtSitioWeb.Name = "TxtSitioWeb";
            this.TxtSitioWeb.Size = new System.Drawing.Size(312, 26);
            this.TxtSitioWeb.TabIndex = 9;
            this.TxtSitioWeb.Validating += new System.ComponentModel.CancelEventHandler(this.TxtSitioWeb_Validating);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(156, 380);
            this.TxtCorreo.MaxLength = 100;
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(312, 26);
            this.TxtCorreo.TabIndex = 9;
            this.TxtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCorreo_Validating);
            // 
            // LblSitioWeb
            // 
            this.LblSitioWeb.AutoSize = true;
            this.LblSitioWeb.Location = new System.Drawing.Point(12, 341);
            this.LblSitioWeb.Name = "LblSitioWeb";
            this.LblSitioWeb.Size = new System.Drawing.Size(81, 20);
            this.LblSitioWeb.TabIndex = 1;
            this.LblSitioWeb.Text = "Sitio Web";
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Location = new System.Drawing.Point(12, 383);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(60, 20);
            this.LblCorreo.TabIndex = 1;
            this.LblCorreo.Text = "Correo";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(156, 295);
            this.TxtDireccion.MaxLength = 150;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(312, 26);
            this.TxtDireccion.TabIndex = 7;
            this.TxtDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDireccion_Validating);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(156, 121);
            this.TxtTelefono.MaxLength = 12;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(312, 26);
            this.TxtTelefono.TabIndex = 3;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            this.TxtTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTelefono_Validating);
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Location = new System.Drawing.Point(12, 298);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(81, 20);
            this.LblDireccion.TabIndex = 1;
            this.LblDireccion.Text = "Dirección";
            // 
            // LblDistrito
            // 
            this.LblDistrito.AutoSize = true;
            this.LblDistrito.Location = new System.Drawing.Point(12, 254);
            this.LblDistrito.Name = "LblDistrito";
            this.LblDistrito.Size = new System.Drawing.Size(64, 20);
            this.LblDistrito.TabIndex = 1;
            this.LblDistrito.Text = "Distrito";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(12, 124);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(73, 20);
            this.LblTelefono.TabIndex = 1;
            this.LblTelefono.Text = "Teléfono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Provincia";
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Location = new System.Drawing.Point(156, 78);
            this.TxtRazonSocial.MaxLength = 100;
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(312, 26);
            this.TxtRazonSocial.TabIndex = 2;
            this.TxtRazonSocial.Validating += new System.ComponentModel.CancelEventHandler(this.TxtRazonSocial_Validating);
            // 
            // LblDepartamento
            // 
            this.LblDepartamento.AutoSize = true;
            this.LblDepartamento.Location = new System.Drawing.Point(12, 165);
            this.LblDepartamento.Name = "LblDepartamento";
            this.LblDepartamento.Size = new System.Drawing.Size(115, 20);
            this.LblDepartamento.TabIndex = 0;
            this.LblDepartamento.Text = "Departamento";
            // 
            // LblRazonSocial
            // 
            this.LblRazonSocial.AutoSize = true;
            this.LblRazonSocial.Location = new System.Drawing.Point(12, 81);
            this.LblRazonSocial.Name = "LblRazonSocial";
            this.LblRazonSocial.Size = new System.Drawing.Size(108, 20);
            this.LblRazonSocial.TabIndex = 1;
            this.LblRazonSocial.Text = "Razón Social";
            // 
            // CboDistrito
            // 
            this.CboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDistrito.FormattingEnabled = true;
            this.CboDistrito.Location = new System.Drawing.Point(156, 251);
            this.CboDistrito.Name = "CboDistrito";
            this.CboDistrito.Size = new System.Drawing.Size(312, 28);
            this.CboDistrito.TabIndex = 6;
            this.CboDistrito.Enter += new System.EventHandler(this.CboDistrito_Enter);
            this.CboDistrito.Validating += new System.ComponentModel.CancelEventHandler(this.CboDistrito_Validating);
            // 
            // TxtRuc
            // 
            this.TxtRuc.Location = new System.Drawing.Point(156, 38);
            this.TxtRuc.MaxLength = 11;
            this.TxtRuc.Name = "TxtRuc";
            this.TxtRuc.Size = new System.Drawing.Size(312, 26);
            this.TxtRuc.TabIndex = 1;
            this.TxtRuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRuc_KeyPress);
            this.TxtRuc.Validating += new System.ComponentModel.CancelEventHandler(this.TxtRuc_Validating);
            // 
            // CboProvincia
            // 
            this.CboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboProvincia.FormattingEnabled = true;
            this.CboProvincia.Location = new System.Drawing.Point(156, 206);
            this.CboProvincia.Name = "CboProvincia";
            this.CboProvincia.Size = new System.Drawing.Size(312, 28);
            this.CboProvincia.TabIndex = 5;
            this.CboProvincia.Enter += new System.EventHandler(this.CboProvincia_Enter);
            // 
            // LblRuc
            // 
            this.LblRuc.AutoSize = true;
            this.LblRuc.Location = new System.Drawing.Point(12, 41);
            this.LblRuc.Name = "LblRuc";
            this.LblRuc.Size = new System.Drawing.Size(109, 20);
            this.LblRuc.TabIndex = 1;
            this.LblRuc.Text = "Número RUC";
            // 
            // CboDepartamento
            // 
            this.CboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDepartamento.FormattingEnabled = true;
            this.CboDepartamento.Location = new System.Drawing.Point(156, 162);
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
            this.GbListado.Controls.Add(this.TxtRazonSocialBuscar);
            this.GbListado.Controls.Add(this.BtnBuscar);
            this.GbListado.Controls.Add(this.LblRazonSocialBuscar);
            this.GbListado.Location = new System.Drawing.Point(526, 12);
            this.GbListado.Name = "GbListado";
            this.GbListado.Size = new System.Drawing.Size(808, 634);
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
            this.ClCodigoProveedor,
            this.ClNumeroRuc,
            this.ClRazonSocial,
            this.ClTelefono,
            this.ClSitioWeb,
            this.ClCorreo,
            this.ClVigente});
            this.DgvListado.Location = new System.Drawing.Point(24, 87);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvListado.Size = new System.Drawing.Size(761, 461);
            this.DgvListado.TabIndex = 7;
            // 
            // ClCodigoProveedor
            // 
            this.ClCodigoProveedor.DataPropertyName = "CodigoProveedor";
            this.ClCodigoProveedor.HeaderText = "Codigo Proveedor";
            this.ClCodigoProveedor.MinimumWidth = 6;
            this.ClCodigoProveedor.Name = "ClCodigoProveedor";
            this.ClCodigoProveedor.ReadOnly = true;
            this.ClCodigoProveedor.Visible = false;
            // 
            // ClNumeroRuc
            // 
            this.ClNumeroRuc.DataPropertyName = "NumeroRuc";
            this.ClNumeroRuc.FillWeight = 70.18969F;
            this.ClNumeroRuc.HeaderText = "RUC";
            this.ClNumeroRuc.MinimumWidth = 6;
            this.ClNumeroRuc.Name = "ClNumeroRuc";
            this.ClNumeroRuc.ReadOnly = true;
            // 
            // ClRazonSocial
            // 
            this.ClRazonSocial.DataPropertyName = "RazonSocial";
            this.ClRazonSocial.FillWeight = 136.6956F;
            this.ClRazonSocial.HeaderText = "Razón Social";
            this.ClRazonSocial.MinimumWidth = 6;
            this.ClRazonSocial.Name = "ClRazonSocial";
            this.ClRazonSocial.ReadOnly = true;
            // 
            // ClTelefono
            // 
            this.ClTelefono.DataPropertyName = "Telefono";
            this.ClTelefono.FillWeight = 97.6069F;
            this.ClTelefono.HeaderText = "Teléfono";
            this.ClTelefono.MinimumWidth = 6;
            this.ClTelefono.Name = "ClTelefono";
            this.ClTelefono.ReadOnly = true;
            // 
            // ClSitioWeb
            // 
            this.ClSitioWeb.DataPropertyName = "SitioWeb";
            this.ClSitioWeb.FillWeight = 108.6723F;
            this.ClSitioWeb.HeaderText = "Sitio Web";
            this.ClSitioWeb.MinimumWidth = 6;
            this.ClSitioWeb.Name = "ClSitioWeb";
            this.ClSitioWeb.ReadOnly = true;
            // 
            // ClCorreo
            // 
            this.ClCorreo.DataPropertyName = "Correo";
            this.ClCorreo.FillWeight = 87.66982F;
            this.ClCorreo.HeaderText = "Correo";
            this.ClCorreo.MinimumWidth = 6;
            this.ClCorreo.Name = "ClCorreo";
            this.ClCorreo.ReadOnly = true;
            // 
            // ClVigente
            // 
            this.ClVigente.DataPropertyName = "Vigente";
            this.ClVigente.HeaderText = "Vigente";
            this.ClVigente.MinimumWidth = 6;
            this.ClVigente.Name = "ClVigente";
            this.ClVigente.ReadOnly = true;
            this.ClVigente.Visible = false;
            // 
            // BtnDarBaja
            // 
            this.BtnDarBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDarBaja.Image = global::ComercializacionFerroCenter.Properties.Resources.IconDelete;
            this.BtnDarBaja.Location = new System.Drawing.Point(635, 567);
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
            this.BtnModificar.Image = global::ComercializacionFerroCenter.Properties.Resources.IconUpdate;
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
            this.BtnNuevo.Image = global::ComercializacionFerroCenter.Properties.Resources.IconNew;
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
            // TxtRazonSocialBuscar
            // 
            this.TxtRazonSocialBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRazonSocialBuscar.Location = new System.Drawing.Point(134, 38);
            this.TxtRazonSocialBuscar.Name = "TxtRazonSocialBuscar";
            this.TxtRazonSocialBuscar.Size = new System.Drawing.Size(495, 26);
            this.TxtRazonSocialBuscar.TabIndex = 2;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar.Image = global::ComercializacionFerroCenter.Properties.Resources.IconList;
            this.BtnBuscar.Location = new System.Drawing.Point(635, 31);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(150, 40);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Listar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LblRazonSocialBuscar
            // 
            this.LblRazonSocialBuscar.AutoSize = true;
            this.LblRazonSocialBuscar.Location = new System.Drawing.Point(20, 41);
            this.LblRazonSocialBuscar.Name = "LblRazonSocialBuscar";
            this.LblRazonSocialBuscar.Size = new System.Drawing.Size(108, 20);
            this.LblRazonSocialBuscar.TabIndex = 1;
            this.LblRazonSocialBuscar.Text = "Razon Social";
            // 
            // ErrNotificator
            // 
            this.ErrNotificator.ContainerControl = this;
            // 
            // Frm_GestionProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1346, 662);
            this.Controls.Add(this.GbListado);
            this.Controls.Add(this.GbProveedor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_GestionProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Proveedor";
            this.Load += new System.EventHandler(this.Frm_GestionProveedor_Load);
            this.GbProveedor.ResumeLayout(false);
            this.GbProveedor.PerformLayout();
            this.GbListado.ResumeLayout(false);
            this.GbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbProveedor;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblDistrito;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Label LblDepartamento;
        private System.Windows.Forms.Label LblRazonSocial;
        private System.Windows.Forms.ComboBox CboDistrito;
        private System.Windows.Forms.TextBox TxtRuc;
        private System.Windows.Forms.ComboBox CboProvincia;
        private System.Windows.Forms.Label LblRuc;
        private System.Windows.Forms.ComboBox CboDepartamento;
        private System.Windows.Forms.GroupBox GbListado;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button BtnDarBaja;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.TextBox TxtRazonSocialBuscar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LblRazonSocialBuscar;
        private System.Windows.Forms.TextBox TxtSitioWeb;
        private System.Windows.Forms.Label LblSitioWeb;
        private System.Windows.Forms.ErrorProvider ErrNotificator;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCodigoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNumeroRuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClSitioWeb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClVigente;
    }
}