namespace Capa_Presentacion
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRegistrarVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRegistrarDevolucion = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRegistrarSalidaMercaderia = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLogistica = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRegistrarEntradaMercaderia = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRegistrarOrdenCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRegistrarCotizacion = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRegistrarNotaCredito = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGestionarPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGestionarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGestionarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGestionarProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGestionarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGestionarCategoriaProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGestionarTipoPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGestionarMarcaProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGestionarUnidadTransporte = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReporteVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReporteCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReporteProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlHoraFecha = new System.Windows.Forms.Panel();
            this.LblFecha = new System.Windows.Forms.Label();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.PnlHoraFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuVentas,
            this.MnuLogistica,
            this.MnuGestion,
            this.MnuReportes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1277, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuVentas
            // 
            this.MnuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuRegistrarVenta,
            this.MnuRegistrarDevolucion,
            this.MnuRegistrarSalidaMercaderia});
            this.MnuVentas.Image = global::Capa_Presentacion.Properties.Resources.IconSell;
            this.MnuVentas.Name = "MnuVentas";
            this.MnuVentas.Size = new System.Drawing.Size(86, 24);
            this.MnuVentas.Text = "Ventas";
            // 
            // MnuRegistrarVenta
            // 
            this.MnuRegistrarVenta.Name = "MnuRegistrarVenta";
            this.MnuRegistrarVenta.Size = new System.Drawing.Size(275, 26);
            this.MnuRegistrarVenta.Text = "Registrar Venta";
            this.MnuRegistrarVenta.Click += new System.EventHandler(this.MnuRegistrarVenta_Click);
            // 
            // MnuRegistrarDevolucion
            // 
            this.MnuRegistrarDevolucion.Name = "MnuRegistrarDevolucion";
            this.MnuRegistrarDevolucion.Size = new System.Drawing.Size(275, 26);
            this.MnuRegistrarDevolucion.Text = "Registrar Devolución";
            this.MnuRegistrarDevolucion.Click += new System.EventHandler(this.MnuRegistrarDevolucion_Click);
            // 
            // MnuRegistrarSalidaMercaderia
            // 
            this.MnuRegistrarSalidaMercaderia.Name = "MnuRegistrarSalidaMercaderia";
            this.MnuRegistrarSalidaMercaderia.Size = new System.Drawing.Size(275, 26);
            this.MnuRegistrarSalidaMercaderia.Text = "Registrar Salida Mercadería";
            this.MnuRegistrarSalidaMercaderia.Click += new System.EventHandler(this.MnuRegistrarSalidaMercaderia_Click);
            // 
            // MnuLogistica
            // 
            this.MnuLogistica.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuRegistrarEntradaMercaderia,
            this.MnuRegistrarOrdenCompra,
            this.MnuRegistrarCotizacion,
            this.MnuRegistrarNotaCredito});
            this.MnuLogistica.Image = global::Capa_Presentacion.Properties.Resources.IconLogistcs;
            this.MnuLogistica.Name = "MnuLogistica";
            this.MnuLogistica.Size = new System.Drawing.Size(102, 24);
            this.MnuLogistica.Text = "Logística";
            // 
            // MnuRegistrarEntradaMercaderia
            // 
            this.MnuRegistrarEntradaMercaderia.Name = "MnuRegistrarEntradaMercaderia";
            this.MnuRegistrarEntradaMercaderia.Size = new System.Drawing.Size(306, 26);
            this.MnuRegistrarEntradaMercaderia.Text = "Registrar Entrada de Mercadería";
            this.MnuRegistrarEntradaMercaderia.Click += new System.EventHandler(this.MnuRegistrarEntradaMercaderia_Click);
            // 
            // MnuRegistrarOrdenCompra
            // 
            this.MnuRegistrarOrdenCompra.Name = "MnuRegistrarOrdenCompra";
            this.MnuRegistrarOrdenCompra.Size = new System.Drawing.Size(306, 26);
            this.MnuRegistrarOrdenCompra.Text = "Registrar Orden de Compra";
            this.MnuRegistrarOrdenCompra.Click += new System.EventHandler(this.MnuRegistrarOrdenCompra_Click);
            // 
            // MnuRegistrarCotizacion
            // 
            this.MnuRegistrarCotizacion.Name = "MnuRegistrarCotizacion";
            this.MnuRegistrarCotizacion.Size = new System.Drawing.Size(306, 26);
            this.MnuRegistrarCotizacion.Text = "Registrar Cotización";
            this.MnuRegistrarCotizacion.Click += new System.EventHandler(this.MnuRegistrarCotizacion_Click);
            // 
            // MnuRegistrarNotaCredito
            // 
            this.MnuRegistrarNotaCredito.Name = "MnuRegistrarNotaCredito";
            this.MnuRegistrarNotaCredito.Size = new System.Drawing.Size(306, 26);
            this.MnuRegistrarNotaCredito.Text = "Registrar Nota de Crédito";
            this.MnuRegistrarNotaCredito.Click += new System.EventHandler(this.MnuRegistrarNotaCredito_Click);
            // 
            // MnuGestion
            // 
            this.MnuGestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuGestionarPersonal,
            this.MnuGestionarUsuario,
            this.MnuGestionarProducto,
            this.MnuGestionarProveedor,
            this.MnuGestionarCliente,
            this.MnuGestionarCategoriaProducto,
            this.MnuGestionarTipoPersonal,
            this.MnuGestionarMarcaProducto,
            this.MnuGestionarUnidadTransporte});
            this.MnuGestion.Image = global::Capa_Presentacion.Properties.Resources.IconAdministrator;
            this.MnuGestion.Name = "MnuGestion";
            this.MnuGestion.Size = new System.Drawing.Size(93, 24);
            this.MnuGestion.Text = "Gestión";
            // 
            // MnuGestionarPersonal
            // 
            this.MnuGestionarPersonal.Name = "MnuGestionarPersonal";
            this.MnuGestionarPersonal.Size = new System.Drawing.Size(316, 26);
            this.MnuGestionarPersonal.Text = "Gestión de Personal";
            this.MnuGestionarPersonal.Click += new System.EventHandler(this.MnuGestionarPersonal_Click);
            // 
            // MnuGestionarUsuario
            // 
            this.MnuGestionarUsuario.Name = "MnuGestionarUsuario";
            this.MnuGestionarUsuario.Size = new System.Drawing.Size(316, 26);
            this.MnuGestionarUsuario.Text = "Gestión de Usuarios";
            this.MnuGestionarUsuario.Click += new System.EventHandler(this.MnuGestionarUsuario_Click);
            // 
            // MnuGestionarProducto
            // 
            this.MnuGestionarProducto.Name = "MnuGestionarProducto";
            this.MnuGestionarProducto.Size = new System.Drawing.Size(316, 26);
            this.MnuGestionarProducto.Text = "Gestionar Producto";
            this.MnuGestionarProducto.Click += new System.EventHandler(this.MnuGestionarProducto_Click);
            // 
            // MnuGestionarProveedor
            // 
            this.MnuGestionarProveedor.Name = "MnuGestionarProveedor";
            this.MnuGestionarProveedor.Size = new System.Drawing.Size(316, 26);
            this.MnuGestionarProveedor.Text = "Gestionar Proveedor";
            this.MnuGestionarProveedor.Click += new System.EventHandler(this.MnuGestionarProveedor_Click);
            // 
            // MnuGestionarCliente
            // 
            this.MnuGestionarCliente.Name = "MnuGestionarCliente";
            this.MnuGestionarCliente.Size = new System.Drawing.Size(316, 26);
            this.MnuGestionarCliente.Text = "Gestionar Cliente";
            this.MnuGestionarCliente.Click += new System.EventHandler(this.MnuGestionarCliente_Click);
            // 
            // MnuGestionarCategoriaProducto
            // 
            this.MnuGestionarCategoriaProducto.Name = "MnuGestionarCategoriaProducto";
            this.MnuGestionarCategoriaProducto.Size = new System.Drawing.Size(316, 26);
            this.MnuGestionarCategoriaProducto.Text = "Gestionar Categoría de Producto";
            this.MnuGestionarCategoriaProducto.Click += new System.EventHandler(this.MnuGestionarCategoriaProducto_Click);
            // 
            // MnuGestionarTipoPersonal
            // 
            this.MnuGestionarTipoPersonal.Name = "MnuGestionarTipoPersonal";
            this.MnuGestionarTipoPersonal.Size = new System.Drawing.Size(316, 26);
            this.MnuGestionarTipoPersonal.Text = "Gestionar Tipo de Personal";
            this.MnuGestionarTipoPersonal.Click += new System.EventHandler(this.MnuGestionarTipoPersonal_Click);
            // 
            // MnuGestionarMarcaProducto
            // 
            this.MnuGestionarMarcaProducto.Name = "MnuGestionarMarcaProducto";
            this.MnuGestionarMarcaProducto.Size = new System.Drawing.Size(316, 26);
            this.MnuGestionarMarcaProducto.Text = "Gestionar Marcas de Productos";
            this.MnuGestionarMarcaProducto.Click += new System.EventHandler(this.MnuGestionarMarcaProducto_Click);
            // 
            // MnuGestionarUnidadTransporte
            // 
            this.MnuGestionarUnidadTransporte.Name = "MnuGestionarUnidadTransporte";
            this.MnuGestionarUnidadTransporte.Size = new System.Drawing.Size(316, 26);
            this.MnuGestionarUnidadTransporte.Text = "Gestionar Unidades de Transporte";
            this.MnuGestionarUnidadTransporte.Click += new System.EventHandler(this.MnuGestionarUnidadTransporte_Click);
            // 
            // MnuReportes
            // 
            this.MnuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuReporteVentas,
            this.MnuReporteCompras,
            this.MnuReporteProductos});
            this.MnuReportes.Image = global::Capa_Presentacion.Properties.Resources.IconReport;
            this.MnuReportes.Name = "MnuReportes";
            this.MnuReportes.Size = new System.Drawing.Size(102, 24);
            this.MnuReportes.Text = "Reportes";
            // 
            // MnuReporteVentas
            // 
            this.MnuReporteVentas.Name = "MnuReporteVentas";
            this.MnuReporteVentas.Size = new System.Drawing.Size(236, 26);
            this.MnuReporteVentas.Text = "Reporte de Ventas";
            this.MnuReporteVentas.Click += new System.EventHandler(this.MnuReporteVentas_Click);
            // 
            // MnuReporteCompras
            // 
            this.MnuReporteCompras.Name = "MnuReporteCompras";
            this.MnuReporteCompras.Size = new System.Drawing.Size(236, 26);
            this.MnuReporteCompras.Text = "Reporte de Compras";
            this.MnuReporteCompras.Click += new System.EventHandler(this.MnuReporteCompras_Click);
            // 
            // MnuReporteProductos
            // 
            this.MnuReporteProductos.Name = "MnuReporteProductos";
            this.MnuReporteProductos.Size = new System.Drawing.Size(236, 26);
            this.MnuReporteProductos.Text = "Reporte de Productos";
            this.MnuReporteProductos.Click += new System.EventHandler(this.MnuReporteProductos_Click);
            // 
            // PnlHoraFecha
            // 
            this.PnlHoraFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PnlHoraFecha.Controls.Add(this.LblFecha);
            this.PnlHoraFecha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlHoraFecha.Location = new System.Drawing.Point(0, 598);
            this.PnlHoraFecha.Name = "PnlHoraFecha";
            this.PnlHoraFecha.Size = new System.Drawing.Size(1277, 35);
            this.PnlHoraFecha.TabIndex = 4;
            // 
            // LblFecha
            // 
            this.LblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.Color.Transparent;
            this.LblFecha.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.White;
            this.LblFecha.Location = new System.Drawing.Point(522, 2);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(101, 34);
            this.LblFecha.TabIndex = 1;
            this.LblFecha.Text = "Fecha";
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 633);
            this.Controls.Add(this.PnlHoraFecha);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo FerroCenter SAC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Principal_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PnlHoraFecha.ResumeLayout(false);
            this.PnlHoraFecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuGestion;
        private System.Windows.Forms.ToolStripMenuItem MnuGestionarPersonal;
        private System.Windows.Forms.ToolStripMenuItem MnuGestionarUsuario;
        private System.Windows.Forms.ToolStripMenuItem MnuVentas;
        private System.Windows.Forms.ToolStripMenuItem MnuRegistrarVenta;
        private System.Windows.Forms.ToolStripMenuItem MnuRegistrarDevolucion;
        private System.Windows.Forms.ToolStripMenuItem MnuLogistica;
        private System.Windows.Forms.ToolStripMenuItem MnuRegistrarEntradaMercaderia;
        private System.Windows.Forms.ToolStripMenuItem MnuReportes;
        private System.Windows.Forms.ToolStripMenuItem MnuReporteVentas;
        private System.Windows.Forms.ToolStripMenuItem MnuReporteCompras;
        private System.Windows.Forms.ToolStripMenuItem MnuReporteProductos;
        private System.Windows.Forms.ToolStripMenuItem MnuRegistrarSalidaMercaderia;
        private System.Windows.Forms.ToolStripMenuItem MnuRegistrarOrdenCompra;
        private System.Windows.Forms.ToolStripMenuItem MnuRegistrarCotizacion;
        private System.Windows.Forms.ToolStripMenuItem MnuGestionarProducto;
        private System.Windows.Forms.ToolStripMenuItem MnuGestionarProveedor;
        private System.Windows.Forms.ToolStripMenuItem MnuGestionarCliente;
        private System.Windows.Forms.ToolStripMenuItem MnuGestionarCategoriaProducto;
        private System.Windows.Forms.ToolStripMenuItem MnuGestionarTipoPersonal;
        private System.Windows.Forms.ToolStripMenuItem MnuGestionarMarcaProducto;
        private System.Windows.Forms.Panel PnlHoraFecha;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.ToolStripMenuItem MnuRegistrarNotaCredito;
        private System.Windows.Forms.ToolStripMenuItem MnuGestionarUnidadTransporte;
    }
}