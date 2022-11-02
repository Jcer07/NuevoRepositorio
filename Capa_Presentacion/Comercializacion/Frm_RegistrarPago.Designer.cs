namespace ComercializacionFerroCenter.Comercializacion
{
    partial class Frm_RegistrarPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RegistrarPago));
            this.label1 = new System.Windows.Forms.Label();
            this.CboMetodoPago = new System.Windows.Forms.ComboBox();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.BtnRealizarPago = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.GbPagoTarjeta = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GbPagoEfectivo = new System.Windows.Forms.GroupBox();
            this.TxtCambio = new System.Windows.Forms.TextBox();
            this.TxtMontoRecibido = new System.Windows.Forms.TextBox();
            this.TxtMontoTotal = new System.Windows.Forms.TextBox();
            this.LblCambio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GbPagoTarjeta.SuspendLayout();
            this.GbPagoEfectivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Método de Pago";
            // 
            // CboMetodoPago
            // 
            this.CboMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboMetodoPago.FormattingEnabled = true;
            this.CboMetodoPago.Location = new System.Drawing.Point(159, 33);
            this.CboMetodoPago.Name = "CboMetodoPago";
            this.CboMetodoPago.Size = new System.Drawing.Size(245, 28);
            this.CboMetodoPago.TabIndex = 1;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Image = global::ComercializacionFerroCenter.Properties.Resources.IconAccept;
            this.BtnSeleccionar.Location = new System.Drawing.Point(430, 26);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(140, 40);
            this.BtnSeleccionar.TabIndex = 2;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // BtnRealizarPago
            // 
            this.BtnRealizarPago.Image = global::ComercializacionFerroCenter.Properties.Resources.IconPay;
            this.BtnRealizarPago.Location = new System.Drawing.Point(264, 472);
            this.BtnRealizarPago.Name = "BtnRealizarPago";
            this.BtnRealizarPago.Size = new System.Drawing.Size(160, 40);
            this.BtnRealizarPago.TabIndex = 2;
            this.BtnRealizarPago.Text = "Realizar Pago";
            this.BtnRealizarPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRealizarPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRealizarPago.UseVisualStyleBackColor = true;
            this.BtnRealizarPago.Click += new System.EventHandler(this.BtnRealizarPago_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::ComercializacionFerroCenter.Properties.Resources.IconCancel;
            this.BtnCancelar.Location = new System.Drawing.Point(440, 472);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(130, 40);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // GbPagoTarjeta
            // 
            this.GbPagoTarjeta.Controls.Add(this.textBox4);
            this.GbPagoTarjeta.Controls.Add(this.label5);
            this.GbPagoTarjeta.Controls.Add(this.textBox3);
            this.GbPagoTarjeta.Controls.Add(this.label4);
            this.GbPagoTarjeta.Controls.Add(this.textBox2);
            this.GbPagoTarjeta.Controls.Add(this.label3);
            this.GbPagoTarjeta.Controls.Add(this.textBox1);
            this.GbPagoTarjeta.Controls.Add(this.label2);
            this.GbPagoTarjeta.Enabled = false;
            this.GbPagoTarjeta.Location = new System.Drawing.Point(12, 79);
            this.GbPagoTarjeta.Name = "GbPagoTarjeta";
            this.GbPagoTarjeta.Size = new System.Drawing.Size(558, 221);
            this.GbPagoTarjeta.TabIndex = 3;
            this.GbPagoTarjeta.TabStop = false;
            this.GbPagoTarjeta.Text = "Tarjeta";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(192, 120);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(330, 26);
            this.textBox4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fecha de Vencimiento";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(193, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(329, 26);
            this.textBox3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Número de CCV";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(192, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(330, 26);
            this.textBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Número de Tarjeta";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(330, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre de Titular";
            // 
            // GbPagoEfectivo
            // 
            this.GbPagoEfectivo.Controls.Add(this.TxtCambio);
            this.GbPagoEfectivo.Controls.Add(this.TxtMontoRecibido);
            this.GbPagoEfectivo.Controls.Add(this.TxtMontoTotal);
            this.GbPagoEfectivo.Controls.Add(this.LblCambio);
            this.GbPagoEfectivo.Controls.Add(this.label7);
            this.GbPagoEfectivo.Controls.Add(this.label6);
            this.GbPagoEfectivo.Enabled = false;
            this.GbPagoEfectivo.Location = new System.Drawing.Point(13, 307);
            this.GbPagoEfectivo.Name = "GbPagoEfectivo";
            this.GbPagoEfectivo.Size = new System.Drawing.Size(557, 142);
            this.GbPagoEfectivo.TabIndex = 4;
            this.GbPagoEfectivo.TabStop = false;
            this.GbPagoEfectivo.Text = "Efectivo";
            // 
            // TxtCambio
            // 
            this.TxtCambio.Location = new System.Drawing.Point(423, 74);
            this.TxtCambio.Name = "TxtCambio";
            this.TxtCambio.ReadOnly = true;
            this.TxtCambio.Size = new System.Drawing.Size(98, 26);
            this.TxtCambio.TabIndex = 1;
            // 
            // TxtMontoRecibido
            // 
            this.TxtMontoRecibido.Location = new System.Drawing.Point(204, 74);
            this.TxtMontoRecibido.Name = "TxtMontoRecibido";
            this.TxtMontoRecibido.Size = new System.Drawing.Size(126, 26);
            this.TxtMontoRecibido.TabIndex = 1;
            this.TxtMontoRecibido.Leave += new System.EventHandler(this.TxtMontoRecibido_Leave);
            // 
            // TxtMontoTotal
            // 
            this.TxtMontoTotal.Location = new System.Drawing.Point(19, 74);
            this.TxtMontoTotal.Name = "TxtMontoTotal";
            this.TxtMontoTotal.ReadOnly = true;
            this.TxtMontoTotal.Size = new System.Drawing.Size(98, 26);
            this.TxtMontoTotal.TabIndex = 1;
            // 
            // LblCambio
            // 
            this.LblCambio.AutoSize = true;
            this.LblCambio.Location = new System.Drawing.Point(424, 46);
            this.LblCambio.Name = "LblCambio";
            this.LblCambio.Size = new System.Drawing.Size(66, 20);
            this.LblCambio.TabIndex = 0;
            this.LblCambio.Text = "Cambio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Monto Recibido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Monto Total";
            // 
            // Frm_RegistrarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 527);
            this.Controls.Add(this.GbPagoEfectivo);
            this.Controls.Add(this.GbPagoTarjeta);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnRealizarPago);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.CboMetodoPago);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_RegistrarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Pago";
            this.Load += new System.EventHandler(this.Frm_RegistrarPago_Load);
            this.GbPagoTarjeta.ResumeLayout(false);
            this.GbPagoTarjeta.PerformLayout();
            this.GbPagoEfectivo.ResumeLayout(false);
            this.GbPagoEfectivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboMetodoPago;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.Button BtnRealizarPago;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.GroupBox GbPagoTarjeta;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GbPagoEfectivo;
        private System.Windows.Forms.TextBox TxtMontoTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCambio;
        private System.Windows.Forms.TextBox TxtMontoRecibido;
        private System.Windows.Forms.Label LblCambio;
        private System.Windows.Forms.Label label7;
    }
}