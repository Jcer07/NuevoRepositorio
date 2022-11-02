namespace ComercializacionFerroCenter
{
    partial class Frm_GestionPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GestionPersonal));
            this.CboDepartamento = new System.Windows.Forms.ComboBox();
            this.LblDepartamento = new System.Windows.Forms.Label();
            this.CboProvincia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CboDistrito = new System.Windows.Forms.ComboBox();
            this.LblDistrito = new System.Windows.Forms.Label();
            this.GbPersonal = new System.Windows.Forms.GroupBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.CboAlmacen = new System.Windows.Forms.ComboBox();
            this.CboTipoPersonal = new System.Windows.Forms.ComboBox();
            this.NudEdad = new System.Windows.Forms.NumericUpDown();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.LblAlmacen = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.LblTipoPersonal = new System.Windows.Forms.Label();
            this.LblEdad = new System.Windows.Forms.Label();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.LblNombres = new System.Windows.Forms.Label();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.LblDni = new System.Windows.Forms.Label();
            this.GbListado = new System.Windows.Forms.GroupBox();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.ClTipoPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDarBaja = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.TxtNombreBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrNotificator = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudEdad)).BeginInit();
            this.GbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificator)).BeginInit();
            this.SuspendLayout();
            // 
            // CboDepartamento
            // 
            this.CboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDepartamento.FormattingEnabled = true;
            this.CboDepartamento.Location = new System.Drawing.Point(156, 202);
            this.CboDepartamento.Name = "CboDepartamento";
            this.CboDepartamento.Size = new System.Drawing.Size(312, 28);
            this.CboDepartamento.TabIndex = 4;
            this.CboDepartamento.SelectedIndexChanged += new System.EventHandler(this.CboDepartamento_SelectedIndexChanged);
            this.CboDepartamento.Validating += new System.ComponentModel.CancelEventHandler(this.CboDepartamento_Validating);
            // 
            // LblDepartamento
            // 
            this.LblDepartamento.AutoSize = true;
            this.LblDepartamento.Location = new System.Drawing.Point(12, 205);
            this.LblDepartamento.Name = "LblDepartamento";
            this.LblDepartamento.Size = new System.Drawing.Size(115, 20);
            this.LblDepartamento.TabIndex = 0;
            this.LblDepartamento.Text = "Departamento";
            // 
            // CboProvincia
            // 
            this.CboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboProvincia.Enabled = false;
            this.CboProvincia.FormattingEnabled = true;
            this.CboProvincia.Location = new System.Drawing.Point(156, 246);
            this.CboProvincia.Name = "CboProvincia";
            this.CboProvincia.Size = new System.Drawing.Size(312, 28);
            this.CboProvincia.TabIndex = 5;
            this.CboProvincia.SelectedIndexChanged += new System.EventHandler(this.CboProvincia_SelectedIndexChanged);
            this.CboProvincia.Enter += new System.EventHandler(this.CboProvincia_Enter);
            this.CboProvincia.Validating += new System.ComponentModel.CancelEventHandler(this.CboProvincia_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Provincia";
            // 
            // CboDistrito
            // 
            this.CboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDistrito.Enabled = false;
            this.CboDistrito.FormattingEnabled = true;
            this.CboDistrito.Location = new System.Drawing.Point(156, 291);
            this.CboDistrito.Name = "CboDistrito";
            this.CboDistrito.Size = new System.Drawing.Size(312, 28);
            this.CboDistrito.TabIndex = 6;
            this.CboDistrito.Enter += new System.EventHandler(this.CboDistrito_Enter);
            this.CboDistrito.Validating += new System.ComponentModel.CancelEventHandler(this.CboDistrito_Validating);
            // 
            // LblDistrito
            // 
            this.LblDistrito.AutoSize = true;
            this.LblDistrito.Location = new System.Drawing.Point(12, 294);
            this.LblDistrito.Name = "LblDistrito";
            this.LblDistrito.Size = new System.Drawing.Size(64, 20);
            this.LblDistrito.TabIndex = 1;
            this.LblDistrito.Text = "Distrito";
            // 
            // GbPersonal
            // 
            this.GbPersonal.Controls.Add(this.BtnCancelar);
            this.GbPersonal.Controls.Add(this.BtnAceptar);
            this.GbPersonal.Controls.Add(this.CboAlmacen);
            this.GbPersonal.Controls.Add(this.CboTipoPersonal);
            this.GbPersonal.Controls.Add(this.NudEdad);
            this.GbPersonal.Controls.Add(this.TxtCorreo);
            this.GbPersonal.Controls.Add(this.LblAlmacen);
            this.GbPersonal.Controls.Add(this.TxtTelefono);
            this.GbPersonal.Controls.Add(this.LblTipoPersonal);
            this.GbPersonal.Controls.Add(this.LblEdad);
            this.GbPersonal.Controls.Add(this.LblCorreo);
            this.GbPersonal.Controls.Add(this.TxtDireccion);
            this.GbPersonal.Controls.Add(this.LblTelefono);
            this.GbPersonal.Controls.Add(this.TxtApellidos);
            this.GbPersonal.Controls.Add(this.LblDireccion);
            this.GbPersonal.Controls.Add(this.LblDistrito);
            this.GbPersonal.Controls.Add(this.LblApellidos);
            this.GbPersonal.Controls.Add(this.label1);
            this.GbPersonal.Controls.Add(this.TxtNombres);
            this.GbPersonal.Controls.Add(this.LblDepartamento);
            this.GbPersonal.Controls.Add(this.LblNombres);
            this.GbPersonal.Controls.Add(this.CboDistrito);
            this.GbPersonal.Controls.Add(this.TxtDni);
            this.GbPersonal.Controls.Add(this.CboProvincia);
            this.GbPersonal.Controls.Add(this.LblDni);
            this.GbPersonal.Controls.Add(this.CboDepartamento);
            this.GbPersonal.Enabled = false;
            this.GbPersonal.Location = new System.Drawing.Point(12, 12);
            this.GbPersonal.Name = "GbPersonal";
            this.GbPersonal.Size = new System.Drawing.Size(492, 634);
            this.GbPersonal.TabIndex = 0;
            this.GbPersonal.TabStop = false;
            this.GbPersonal.Text = "Personal";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::ComercializacionFerroCenter.Properties.Resources.IconCancel;
            this.BtnCancelar.Location = new System.Drawing.Point(318, 567);
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
            this.BtnAceptar.Location = new System.Drawing.Point(145, 567);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(150, 40);
            this.BtnAceptar.TabIndex = 11;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // CboAlmacen
            // 
            this.CboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAlmacen.FormattingEnabled = true;
            this.CboAlmacen.Location = new System.Drawing.Point(156, 511);
            this.CboAlmacen.Name = "CboAlmacen";
            this.CboAlmacen.Size = new System.Drawing.Size(312, 28);
            this.CboAlmacen.TabIndex = 0;
            this.CboAlmacen.Validating += new System.ComponentModel.CancelEventHandler(this.CboAlmacen_Validating);
            // 
            // CboTipoPersonal
            // 
            this.CboTipoPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoPersonal.FormattingEnabled = true;
            this.CboTipoPersonal.Location = new System.Drawing.Point(156, 33);
            this.CboTipoPersonal.Name = "CboTipoPersonal";
            this.CboTipoPersonal.Size = new System.Drawing.Size(312, 28);
            this.CboTipoPersonal.TabIndex = 0;
            this.CboTipoPersonal.Validating += new System.ComponentModel.CancelEventHandler(this.CboTipoPersonal_Validating);
            // 
            // NudEdad
            // 
            this.NudEdad.Location = new System.Drawing.Point(156, 464);
            this.NudEdad.Name = "NudEdad";
            this.NudEdad.Size = new System.Drawing.Size(77, 26);
            this.NudEdad.TabIndex = 10;
            this.NudEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudEdad.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.NudEdad.Validating += new System.ComponentModel.CancelEventHandler(this.NudEdad_Validating);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(156, 420);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(312, 26);
            this.TxtCorreo.TabIndex = 9;
            this.TxtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCorreo_Validating);
            // 
            // LblAlmacen
            // 
            this.LblAlmacen.AutoSize = true;
            this.LblAlmacen.Location = new System.Drawing.Point(12, 514);
            this.LblAlmacen.Name = "LblAlmacen";
            this.LblAlmacen.Size = new System.Drawing.Size(74, 20);
            this.LblAlmacen.TabIndex = 0;
            this.LblAlmacen.Text = "Almacén";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(156, 377);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(312, 26);
            this.TxtTelefono.TabIndex = 8;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            this.TxtTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTelefono_Validating);
            // 
            // LblTipoPersonal
            // 
            this.LblTipoPersonal.AutoSize = true;
            this.LblTipoPersonal.Location = new System.Drawing.Point(12, 36);
            this.LblTipoPersonal.Name = "LblTipoPersonal";
            this.LblTipoPersonal.Size = new System.Drawing.Size(135, 20);
            this.LblTipoPersonal.TabIndex = 0;
            this.LblTipoPersonal.Text = "Tipo de Personal";
            // 
            // LblEdad
            // 
            this.LblEdad.AutoSize = true;
            this.LblEdad.Location = new System.Drawing.Point(12, 467);
            this.LblEdad.Name = "LblEdad";
            this.LblEdad.Size = new System.Drawing.Size(47, 20);
            this.LblEdad.TabIndex = 1;
            this.LblEdad.Text = "Edad";
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Location = new System.Drawing.Point(12, 423);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(60, 20);
            this.LblCorreo.TabIndex = 1;
            this.LblCorreo.Text = "Correo";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(156, 335);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(312, 26);
            this.TxtDireccion.TabIndex = 7;
            this.TxtDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDireccion_Validating);
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(12, 380);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(73, 20);
            this.LblTelefono.TabIndex = 1;
            this.LblTelefono.Text = "Teléfono";
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(156, 161);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(312, 26);
            this.TxtApellidos.TabIndex = 3;
            this.TxtApellidos.Validating += new System.ComponentModel.CancelEventHandler(this.TxtApellidos_Validating);
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Location = new System.Drawing.Point(12, 338);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(81, 20);
            this.LblDireccion.TabIndex = 1;
            this.LblDireccion.Text = "Dirección";
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Location = new System.Drawing.Point(12, 164);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(77, 20);
            this.LblApellidos.TabIndex = 1;
            this.LblApellidos.Text = "Apellidos";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(156, 118);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(312, 26);
            this.TxtNombres.TabIndex = 2;
            this.TxtNombres.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombres_Validating);
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Location = new System.Drawing.Point(12, 121);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(77, 20);
            this.LblNombres.TabIndex = 1;
            this.LblNombres.Text = "Nombres";
            // 
            // TxtDni
            // 
            this.TxtDni.Location = new System.Drawing.Point(156, 78);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(312, 26);
            this.TxtDni.TabIndex = 1;
            this.TxtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDni_KeyPress);
            this.TxtDni.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDni_Validating);
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Location = new System.Drawing.Point(12, 81);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(102, 20);
            this.LblDni.TabIndex = 1;
            this.LblDni.Text = "Número DNI";
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
            this.GbListado.Size = new System.Drawing.Size(841, 634);
            this.GbListado.TabIndex = 1;
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
            this.ClTipoPersonal,
            this.ClDni,
            this.ClNombres,
            this.ClTelefono,
            this.ClCorreo});
            this.DgvListado.Location = new System.Drawing.Point(24, 87);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(797, 430);
            this.DgvListado.TabIndex = 7;
            // 
            // ClTipoPersonal
            // 
            this.ClTipoPersonal.DataPropertyName = "TiPersonal";
            this.ClTipoPersonal.HeaderText = "Tipo Personal";
            this.ClTipoPersonal.MinimumWidth = 6;
            this.ClTipoPersonal.Name = "ClTipoPersonal";
            this.ClTipoPersonal.ReadOnly = true;
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
            this.ClNombres.HeaderText = "Nombre y Apellidos";
            this.ClNombres.MinimumWidth = 6;
            this.ClNombres.Name = "ClNombres";
            this.ClNombres.ReadOnly = true;
            // 
            // ClTelefono
            // 
            this.ClTelefono.DataPropertyName = "Telefono";
            this.ClTelefono.HeaderText = "Teléfono";
            this.ClTelefono.MinimumWidth = 6;
            this.ClTelefono.Name = "ClTelefono";
            this.ClTelefono.ReadOnly = true;
            // 
            // ClCorreo
            // 
            this.ClCorreo.DataPropertyName = "Correo";
            this.ClCorreo.HeaderText = "Correo";
            this.ClCorreo.MinimumWidth = 6;
            this.ClCorreo.Name = "ClCorreo";
            this.ClCorreo.ReadOnly = true;
            // 
            // BtnDarBaja
            // 
            this.BtnDarBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDarBaja.Image = global::ComercializacionFerroCenter.Properties.Resources.IconDelete;
            this.BtnDarBaja.Location = new System.Drawing.Point(671, 567);
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
            // TxtNombreBuscar
            // 
            this.TxtNombreBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombreBuscar.Location = new System.Drawing.Point(113, 38);
            this.TxtNombreBuscar.Name = "TxtNombreBuscar";
            this.TxtNombreBuscar.Size = new System.Drawing.Size(535, 26);
            this.TxtNombreBuscar.TabIndex = 2;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar.Image = global::ComercializacionFerroCenter.Properties.Resources.IconList;
            this.BtnBuscar.Location = new System.Drawing.Point(671, 25);
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
            // Frm_GestionPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1363, 664);
            this.Controls.Add(this.GbListado);
            this.Controls.Add(this.GbPersonal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_GestionPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Personal";
            this.Load += new System.EventHandler(this.Frm_GestionPersonal_Load);
            this.GbPersonal.ResumeLayout(false);
            this.GbPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudEdad)).EndInit();
            this.GbListado.ResumeLayout(false);
            this.GbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CboDepartamento;
        private System.Windows.Forms.Label LblDepartamento;
        private System.Windows.Forms.ComboBox CboProvincia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboDistrito;
        private System.Windows.Forms.Label LblDistrito;
        private System.Windows.Forms.GroupBox GbPersonal;
        private System.Windows.Forms.NumericUpDown NudEdad;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label LblEdad;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.Label LblDni;
        private System.Windows.Forms.Label LblTipoPersonal;
        private System.Windows.Forms.ComboBox CboTipoPersonal;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.GroupBox GbListado;
        private System.Windows.Forms.TextBox TxtNombreBuscar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button BtnDarBaja;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.ErrorProvider ErrNotificator;
        private System.Windows.Forms.ComboBox CboAlmacen;
        private System.Windows.Forms.Label LblAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClTipoPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCorreo;
    }
}