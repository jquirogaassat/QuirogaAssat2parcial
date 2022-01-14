namespace QuirogaAssat2parcial
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMCToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listByIDFactuOrCustToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByIdFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.facturaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.buscarPorNombreToolStripMenuItem});
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.addUserToolStripMenuItem.Text = "Cliente";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "ABMC";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMCToolStripMenuItem});
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.productoToolStripMenuItem.Text = "Producto";
            // 
            // aBMCToolStripMenuItem
            // 
            this.aBMCToolStripMenuItem.Name = "aBMCToolStripMenuItem";
            this.aBMCToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.aBMCToolStripMenuItem.Text = "ABMC";
            this.aBMCToolStripMenuItem.Click += new System.EventHandler(this.aBMCToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMCToolStripMenuItem1,
            this.listByIDFactuOrCustToolStripMenuItem,
            this.searchByIdFacturaToolStripMenuItem});
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.facturaToolStripMenuItem.Text = "Factura";
            // 
            // aBMCToolStripMenuItem1
            // 
            this.aBMCToolStripMenuItem1.Name = "aBMCToolStripMenuItem1";
            this.aBMCToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.aBMCToolStripMenuItem1.Text = "ABMC";
            this.aBMCToolStripMenuItem1.Click += new System.EventHandler(this.aBMCToolStripMenuItem1_Click);
            // 
            // listByIDFactuOrCustToolStripMenuItem
            // 
            this.listByIDFactuOrCustToolStripMenuItem.Name = "listByIDFactuOrCustToolStripMenuItem";
            this.listByIDFactuOrCustToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.listByIDFactuOrCustToolStripMenuItem.Text = "ListByIDFactuOrCust";
            this.listByIDFactuOrCustToolStripMenuItem.Click += new System.EventHandler(this.listByIDFactuOrCustToolStripMenuItem_Click);
            // 
            // searchByIdFacturaToolStripMenuItem
            // 
            this.searchByIdFacturaToolStripMenuItem.Name = "searchByIdFacturaToolStripMenuItem";
            this.searchByIdFacturaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.searchByIdFacturaToolStripMenuItem.Text = "SearchByIdFactura";
            this.searchByIdFacturaToolStripMenuItem.Click += new System.EventHandler(this.searchByIdFacturaToolStripMenuItem_Click);
            // 
            // buscarPorNombreToolStripMenuItem
            // 
            this.buscarPorNombreToolStripMenuItem.Name = "buscarPorNombreToolStripMenuItem";
            this.buscarPorNombreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarPorNombreToolStripMenuItem.Text = "Buscar por Nombre";
            this.buscarPorNombreToolStripMenuItem.Click += new System.EventHandler(this.buscarPorNombreToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMCToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listByIDFactuOrCustToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByIdFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorNombreToolStripMenuItem;
    }
}

