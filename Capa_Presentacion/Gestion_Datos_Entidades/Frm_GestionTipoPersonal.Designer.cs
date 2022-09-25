namespace Capa_Presentacion.Gestion_Datos_Entidades
{
    partial class Frm_GestionTipoPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GestionTipoPersonal));
            this.GbListado = new System.Windows.Forms.GroupBox();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.BtnDarBaja = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.GbTipoPersonal = new System.Windows.Forms.GroupBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrNotificator = new System.Windows.Forms.ErrorProvider(this.components);
            this.ClNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.GbTipoPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificator)).BeginInit();
            this.SuspendLayout();
            // 
            // GbListado
            // 
            this.GbListado.Controls.Add(this.DgvListado);
            this.GbListado.Controls.Add(this.BtnDarBaja);
            this.GbListado.Controls.Add(this.BtnListar);
            this.GbListado.Controls.Add(this.BtnModificar);
            this.GbListado.Controls.Add(this.BtnNuevo);
            this.GbListado.Location = new System.Drawing.Point(541, 12);
            this.GbListado.Name = "GbListado";
            this.GbListado.Size = new System.Drawing.Size(648, 603);
            this.GbListado.TabIndex = 3;
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
            this.ClNombre});
            this.DgvListado.Location = new System.Drawing.Point(23, 97);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.Size = new System.Drawing.Size(610, 437);
            this.DgvListado.TabIndex = 4;
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
            // GbTipoPersonal
            // 
            this.GbTipoPersonal.Controls.Add(this.BtnCancelar);
            this.GbTipoPersonal.Controls.Add(this.BtnAceptar);
            this.GbTipoPersonal.Controls.Add(this.TxtDescripcion);
            this.GbTipoPersonal.Controls.Add(this.TxtNombre);
            this.GbTipoPersonal.Controls.Add(this.label3);
            this.GbTipoPersonal.Controls.Add(this.label2);
            this.GbTipoPersonal.Enabled = false;
            this.GbTipoPersonal.Location = new System.Drawing.Point(12, 12);
            this.GbTipoPersonal.Name = "GbTipoPersonal";
            this.GbTipoPersonal.Size = new System.Drawing.Size(514, 225);
            this.GbTipoPersonal.TabIndex = 4;
            this.GbTipoPersonal.TabStop = false;
            this.GbTipoPersonal.Text = "Tipo de Personal";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::Capa_Presentacion.Properties.Resources.IconCancel;
            this.BtnCancelar.Location = new System.Drawing.Point(359, 161);
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
            this.BtnAceptar.Location = new System.Drawing.Point(212, 161);
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
            this.TxtDescripcion.Location = new System.Drawing.Point(128, 90);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(351, 26);
            this.TxtDescripcion.TabIndex = 2;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(128, 44);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(351, 26);
            this.TxtNombre.TabIndex = 2;
            this.TxtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombre_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // ErrNotificator
            // 
            this.ErrNotificator.ContainerControl = this;
            // 
            // ClNombre
            // 
            this.ClNombre.DataPropertyName = "NombreTipo";
            this.ClNombre.HeaderText = "Nombre";
            this.ClNombre.MinimumWidth = 6;
            this.ClNombre.Name = "ClNombre";
            this.ClNombre.ReadOnly = true;
            // 
            // Frm_GestionTipoPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1203, 625);
            this.Controls.Add(this.GbListado);
            this.Controls.Add(this.GbTipoPersonal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_GestionTipoPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Tipo de Personal";
            this.GbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.GbTipoPersonal.ResumeLayout(false);
            this.GbTipoPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbListado;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button BtnDarBaja;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.GroupBox GbTipoPersonal;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider ErrNotificator;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombre;
    }
}