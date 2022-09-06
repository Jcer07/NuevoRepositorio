namespace Capa_Presentacion
{
    partial class Frm_CambiarClave
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
            this.GbValidarDatos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnValidarDatos = new System.Windows.Forms.Button();
            this.GbVerificarCodigo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BtnVerificarCodigo = new System.Windows.Forms.Button();
            this.GbCambiarClave = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.BtnCambiarClave = new System.Windows.Forms.Button();
            this.GbValidarDatos.SuspendLayout();
            this.GbVerificarCodigo.SuspendLayout();
            this.GbCambiarClave.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbValidarDatos
            // 
            this.GbValidarDatos.Controls.Add(this.BtnValidarDatos);
            this.GbValidarDatos.Controls.Add(this.textBox2);
            this.GbValidarDatos.Controls.Add(this.label2);
            this.GbValidarDatos.Controls.Add(this.textBox1);
            this.GbValidarDatos.Controls.Add(this.label1);
            this.GbValidarDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.GbValidarDatos.Location = new System.Drawing.Point(0, 0);
            this.GbValidarDatos.Name = "GbValidarDatos";
            this.GbValidarDatos.Size = new System.Drawing.Size(492, 175);
            this.GbValidarDatos.TabIndex = 0;
            this.GbValidarDatos.TabStop = false;
            this.GbValidarDatos.Text = "Validación de Datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de DNI";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Correo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(312, 26);
            this.textBox2.TabIndex = 1;
            // 
            // BtnValidarDatos
            // 
            this.BtnValidarDatos.Location = new System.Drawing.Point(170, 125);
            this.BtnValidarDatos.Name = "BtnValidarDatos";
            this.BtnValidarDatos.Size = new System.Drawing.Size(143, 37);
            this.BtnValidarDatos.TabIndex = 2;
            this.BtnValidarDatos.Text = "Validar";
            this.BtnValidarDatos.UseVisualStyleBackColor = true;
            this.BtnValidarDatos.Click += new System.EventHandler(this.BtnValidarDatos_Click);
            // 
            // GbVerificarCodigo
            // 
            this.GbVerificarCodigo.Controls.Add(this.BtnVerificarCodigo);
            this.GbVerificarCodigo.Controls.Add(this.textBox3);
            this.GbVerificarCodigo.Controls.Add(this.label3);
            this.GbVerificarCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.GbVerificarCodigo.Location = new System.Drawing.Point(0, 175);
            this.GbVerificarCodigo.Name = "GbVerificarCodigo";
            this.GbVerificarCodigo.Size = new System.Drawing.Size(492, 175);
            this.GbVerificarCodigo.TabIndex = 1;
            this.GbVerificarCodigo.TabStop = false;
            this.GbVerificarCodigo.Text = "Verificar Código";
            this.GbVerificarCodigo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código enviado al Correo";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(219, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 26);
            this.textBox3.TabIndex = 1;
            // 
            // BtnVerificarCodigo
            // 
            this.BtnVerificarCodigo.Location = new System.Drawing.Point(170, 87);
            this.BtnVerificarCodigo.Name = "BtnVerificarCodigo";
            this.BtnVerificarCodigo.Size = new System.Drawing.Size(143, 37);
            this.BtnVerificarCodigo.TabIndex = 2;
            this.BtnVerificarCodigo.Text = "Verificar Código";
            this.BtnVerificarCodigo.UseVisualStyleBackColor = true;
            this.BtnVerificarCodigo.Click += new System.EventHandler(this.BtnVerificarCodigo_Click);
            // 
            // GbCambiarClave
            // 
            this.GbCambiarClave.Controls.Add(this.BtnCambiarClave);
            this.GbCambiarClave.Controls.Add(this.textBox4);
            this.GbCambiarClave.Controls.Add(this.textBox5);
            this.GbCambiarClave.Controls.Add(this.label4);
            this.GbCambiarClave.Controls.Add(this.label5);
            this.GbCambiarClave.Dock = System.Windows.Forms.DockStyle.Top;
            this.GbCambiarClave.Location = new System.Drawing.Point(0, 350);
            this.GbCambiarClave.Name = "GbCambiarClave";
            this.GbCambiarClave.Size = new System.Drawing.Size(492, 175);
            this.GbCambiarClave.TabIndex = 2;
            this.GbCambiarClave.TabStop = false;
            this.GbCambiarClave.Text = "Cambiar Contraseña";
            this.GbCambiarClave.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nueva Clave";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(156, 33);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(312, 26);
            this.textBox4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Confirmar Clave";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(156, 74);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(312, 26);
            this.textBox5.TabIndex = 1;
            // 
            // BtnCambiarClave
            // 
            this.BtnCambiarClave.Location = new System.Drawing.Point(170, 119);
            this.BtnCambiarClave.Name = "BtnCambiarClave";
            this.BtnCambiarClave.Size = new System.Drawing.Size(194, 37);
            this.BtnCambiarClave.TabIndex = 2;
            this.BtnCambiarClave.Text = "Cambiar Contraseña";
            this.BtnCambiarClave.UseVisualStyleBackColor = true;
            // 
            // Frm_CambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 531);
            this.Controls.Add(this.GbCambiarClave);
            this.Controls.Add(this.GbVerificarCodigo);
            this.Controls.Add(this.GbValidarDatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_CambiarClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña";
            this.Load += new System.EventHandler(this.Frm_CambiarClave_Load);
            this.GbValidarDatos.ResumeLayout(false);
            this.GbValidarDatos.PerformLayout();
            this.GbVerificarCodigo.ResumeLayout(false);
            this.GbVerificarCodigo.PerformLayout();
            this.GbCambiarClave.ResumeLayout(false);
            this.GbCambiarClave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbValidarDatos;
        private System.Windows.Forms.Button BtnValidarDatos;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbVerificarCodigo;
        private System.Windows.Forms.Button BtnVerificarCodigo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GbCambiarClave;
        private System.Windows.Forms.Button BtnCambiarClave;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}