namespace ProyectoAplicadoPC
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntoDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaACreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaAlContadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaDeVentasToolStripMenuItem,
            this.puntoDeVentasToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaDeVentasToolStripMenuItem
            // 
            this.sistemaDeVentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cobroToolStripMenuItem,
            this.registroDeClienteToolStripMenuItem});
            this.sistemaDeVentasToolStripMenuItem.Name = "sistemaDeVentasToolStripMenuItem";
            this.sistemaDeVentasToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.sistemaDeVentasToolStripMenuItem.Text = "&Sistema de Ventas";
            // 
            // cobroToolStripMenuItem
            // 
            this.cobroToolStripMenuItem.Name = "cobroToolStripMenuItem";
            this.cobroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cobroToolStripMenuItem.Text = "&Cobro";
            // 
            // registroDeClienteToolStripMenuItem
            // 
            this.registroDeClienteToolStripMenuItem.Name = "registroDeClienteToolStripMenuItem";
            this.registroDeClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroDeClienteToolStripMenuItem.Text = "&Registro de Cliente";
            this.registroDeClienteToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeClienteToolStripMenuItem_Click);
            // 
            // puntoDeVentasToolStripMenuItem
            // 
            this.puntoDeVentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaACreditoToolStripMenuItem,
            this.facturaAlContadoToolStripMenuItem});
            this.puntoDeVentasToolStripMenuItem.Name = "puntoDeVentasToolStripMenuItem";
            this.puntoDeVentasToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.puntoDeVentasToolStripMenuItem.Text = "&Punto de Venta";
            // 
            // facturaACreditoToolStripMenuItem
            // 
            this.facturaACreditoToolStripMenuItem.Name = "facturaACreditoToolStripMenuItem";
            this.facturaACreditoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facturaACreditoToolStripMenuItem.Text = "&Factura a Credito";
            // 
            // facturaAlContadoToolStripMenuItem
            // 
            this.facturaAlContadoToolStripMenuItem.Name = "facturaAlContadoToolStripMenuItem";
            this.facturaAlContadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facturaAlContadoToolStripMenuItem.Text = "&Factura al Contado";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registarProductoToolStripMenuItem,
            this.inventarioToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "&Productos";
            // 
            // registarProductoToolStripMenuItem
            // 
            this.registarProductoToolStripMenuItem.Name = "registarProductoToolStripMenuItem";
            this.registarProductoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registarProductoToolStripMenuItem.Text = "&Registar Producto";
            this.registarProductoToolStripMenuItem.Click += new System.EventHandler(this.RegistarProductoToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inventarioToolStripMenuItem.Text = "&Inventario";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 370);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntoDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaACreditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaAlContadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
    }
}

