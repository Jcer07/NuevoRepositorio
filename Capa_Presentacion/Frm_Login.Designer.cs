namespace Capa_Presentacion
{
    partial class Frm_Login
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
            this.LblUsuario = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LkLblRecuperacion = new System.Windows.Forms.LinkLabel();
            this.LblClave = new System.Windows.Forms.Label();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblMsgRecuperacion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(23, 42);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(67, 20);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Usuario";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(27, 68);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(317, 26);
            this.TxtUsuario.TabIndex = 1;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(60, 264);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(129, 35);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Iniciar Sesión";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LkLblRecuperacion
            // 
            this.LkLblRecuperacion.AutoSize = true;
            this.LkLblRecuperacion.Location = new System.Drawing.Point(223, 204);
            this.LkLblRecuperacion.Name = "LkLblRecuperacion";
            this.LkLblRecuperacion.Size = new System.Drawing.Size(82, 20);
            this.LkLblRecuperacion.TabIndex = 3;
            this.LkLblRecuperacion.TabStop = true;
            this.LkLblRecuperacion.Text = "Click aquí";
            this.LkLblRecuperacion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LkLblRecuperacion_LinkClicked);
            // 
            // LblClave
            // 
            this.LblClave.AutoSize = true;
            this.LblClave.Location = new System.Drawing.Point(23, 131);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(95, 20);
            this.LblClave.TabIndex = 0;
            this.LblClave.Text = "Contraseña";
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(27, 156);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(317, 26);
            this.TxtClave.TabIndex = 2;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(216, 264);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 35);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblMsgRecuperacion
            // 
            this.LblMsgRecuperacion.AutoSize = true;
            this.LblMsgRecuperacion.Location = new System.Drawing.Point(23, 204);
            this.LblMsgRecuperacion.Name = "LblMsgRecuperacion";
            this.LblMsgRecuperacion.Size = new System.Drawing.Size(205, 20);
            this.LblMsgRecuperacion.TabIndex = 0;
            this.LblMsgRecuperacion.Text = "¿Olvidaste tu contraseña?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblUsuario);
            this.panel1.Controls.Add(this.LkLblRecuperacion);
            this.panel1.Controls.Add(this.LblClave);
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Controls.Add(this.LblMsgRecuperacion);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Controls.Add(this.TxtUsuario);
            this.panel1.Controls.Add(this.TxtClave);
            this.panel1.Location = new System.Drawing.Point(401, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 364);
            this.panel1.TabIndex = 6;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 390);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.LinkLabel LkLblRecuperacion;
        private System.Windows.Forms.Label LblClave;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblMsgRecuperacion;
        private System.Windows.Forms.Panel panel1;
    }
}