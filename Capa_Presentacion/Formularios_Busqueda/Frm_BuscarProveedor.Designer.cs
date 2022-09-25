namespace Capa_Presentacion.Formularios_Busqueda
{
    partial class Frm_BuscarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BuscarProveedor));
            this.GbBusqueda = new System.Windows.Forms.GroupBox();
            this.TxtProveedor = new System.Windows.Forms.TextBox();
            this.LblProveedor = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.ClRuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClSitioWeb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // GbBusqueda
            // 
            this.GbBusqueda.Controls.Add(this.TxtProveedor);
            this.GbBusqueda.Controls.Add(this.LblProveedor);
            this.GbBusqueda.Controls.Add(this.BtnBuscar);
            this.GbBusqueda.Location = new System.Drawing.Point(13, 10);
            this.GbBusqueda.Name = "GbBusqueda";
            this.GbBusqueda.Size = new System.Drawing.Size(657, 106);
            this.GbBusqueda.TabIndex = 13;
            this.GbBusqueda.TabStop = false;
            this.GbBusqueda.Text = "Búsqueda";
            // 
            // TxtProveedor
            // 
            this.TxtProveedor.Location = new System.Drawing.Point(105, 36);
            this.TxtProveedor.Name = "TxtProveedor";
            this.TxtProveedor.Size = new System.Drawing.Size(396, 26);
            this.TxtProveedor.TabIndex = 1;
            // 
            // LblProveedor
            // 
            this.LblProveedor.AutoSize = true;
            this.LblProveedor.Location = new System.Drawing.Point(14, 39);
            this.LblProveedor.Name = "LblProveedor";
            this.LblProveedor.Size = new System.Drawing.Size(85, 20);
            this.LblProveedor.TabIndex = 0;
            this.LblProveedor.Text = "Proveedor";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = global::Capa_Presentacion.Properties.Resources.IconSearch2;
            this.BtnBuscar.Location = new System.Drawing.Point(507, 34);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(140, 30);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::Capa_Presentacion.Properties.Resources.IconCancel;
            this.BtnCancelar.Location = new System.Drawing.Point(520, 551);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(150, 40);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Image = global::Capa_Presentacion.Properties.Resources.IconSelect;
            this.BtnSeleccionar.Location = new System.Drawing.Point(355, 551);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(150, 40);
            this.BtnSeleccionar.TabIndex = 12;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClRuc,
            this.ClRazonSocial,
            this.ClSitioWeb});
            this.DgvListado.Location = new System.Drawing.Point(13, 122);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvListado.Size = new System.Drawing.Size(657, 423);
            this.DgvListado.TabIndex = 10;
            // 
            // ClRuc
            // 
            this.ClRuc.DataPropertyName = "NumeroRuc";
            this.ClRuc.HeaderText = "RUC";
            this.ClRuc.MinimumWidth = 6;
            this.ClRuc.Name = "ClRuc";
            this.ClRuc.ReadOnly = true;
            // 
            // ClRazonSocial
            // 
            this.ClRazonSocial.DataPropertyName = "RazonSocial";
            this.ClRazonSocial.HeaderText = "Razón Social";
            this.ClRazonSocial.MinimumWidth = 6;
            this.ClRazonSocial.Name = "ClRazonSocial";
            this.ClRazonSocial.ReadOnly = true;
            // 
            // ClSitioWeb
            // 
            this.ClSitioWeb.DataPropertyName = "SitioWeb";
            this.ClSitioWeb.HeaderText = "Sitio Web";
            this.ClSitioWeb.MinimumWidth = 6;
            this.ClSitioWeb.Name = "ClSitioWeb";
            this.ClSitioWeb.ReadOnly = true;
            // 
            // Frm_BuscarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 603);
            this.Controls.Add(this.GbBusqueda);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.DgvListado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_BuscarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Proveedor";
            this.GbBusqueda.ResumeLayout(false);
            this.GbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbBusqueda;
        private System.Windows.Forms.TextBox TxtProveedor;
        private System.Windows.Forms.Label LblProveedor;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClRuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClSitioWeb;
    }
}