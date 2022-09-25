namespace Capa_Presentacion.Formularios_Busqueda
{
    partial class Frm_BuscarUnidadTransporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BuscarUnidadTransporte));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.LblRazonSocial = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClNumeroUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClConductor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtRazonSocial);
            this.groupBox1.Controls.Add(this.LblRazonSocial);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Location = new System.Drawing.Point(111, 53);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(391, 26);
            this.TxtRazonSocial.TabIndex = 4;
            // 
            // LblRazonSocial
            // 
            this.LblRazonSocial.AutoSize = true;
            this.LblRazonSocial.Location = new System.Drawing.Point(20, 56);
            this.LblRazonSocial.Name = "LblRazonSocial";
            this.LblRazonSocial.Size = new System.Drawing.Size(86, 20);
            this.LblRazonSocial.TabIndex = 3;
            this.LblRazonSocial.Text = "Conductor";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = global::Capa_Presentacion.Properties.Resources.IconSearch2;
            this.BtnBuscar.Location = new System.Drawing.Point(508, 51);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(140, 30);
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClNumeroUnidad,
            this.ClConductor,
            this.ClPlaca});
            this.dataGridView1.Location = new System.Drawing.Point(12, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(663, 370);
            this.dataGridView1.TabIndex = 1;
            // 
            // ClNumeroUnidad
            // 
            this.ClNumeroUnidad.HeaderText = "Nro. Unidad";
            this.ClNumeroUnidad.MinimumWidth = 6;
            this.ClNumeroUnidad.Name = "ClNumeroUnidad";
            this.ClNumeroUnidad.ReadOnly = true;
            // 
            // ClConductor
            // 
            this.ClConductor.HeaderText = "Conductor";
            this.ClConductor.MinimumWidth = 6;
            this.ClConductor.Name = "ClConductor";
            this.ClConductor.ReadOnly = true;
            // 
            // ClPlaca
            // 
            this.ClPlaca.HeaderText = "Placa";
            this.ClPlaca.MinimumWidth = 6;
            this.ClPlaca.Name = "ClPlaca";
            this.ClPlaca.ReadOnly = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::Capa_Presentacion.Properties.Resources.IconCancel;
            this.BtnCancelar.Location = new System.Drawing.Point(525, 535);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(150, 40);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Image = global::Capa_Presentacion.Properties.Resources.IconSelect;
            this.BtnSeleccionar.Location = new System.Drawing.Point(364, 535);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(150, 40);
            this.BtnSeleccionar.TabIndex = 14;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // Frm_BuscarUnidadTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 587);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_BuscarUnidadTransporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Unidad de Transporte";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Label LblRazonSocial;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNumeroUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClConductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClPlaca;
    }
}