namespace QuirogaAssat2parcial
{
    partial class FrmDetalleFactura
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
            this.dg_detalleFac = new System.Windows.Forms.DataGridView();
            this.Productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_articulo = new System.Windows.Forms.DataGridView();
            this.dg_cliente = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.btn_cargarArticulo = new System.Windows.Forms.Button();
            this.btn_generarFactura = new System.Windows.Forms.Button();
            this.lbl_prueba = new System.Windows.Forms.Label();
            this.lbl_totApagar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_detalleFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_articulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_detalleFac
            // 
            this.dg_detalleFac.AllowUserToAddRows = false;
            this.dg_detalleFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_detalleFac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Productos,
            this.Cantidad,
            this.PrecioUnitario,
            this.SubTotal});
            this.dg_detalleFac.Location = new System.Drawing.Point(11, 22);
            this.dg_detalleFac.Margin = new System.Windows.Forms.Padding(2);
            this.dg_detalleFac.Name = "dg_detalleFac";
            this.dg_detalleFac.RowHeadersWidth = 51;
            this.dg_detalleFac.RowTemplate.Height = 24;
            this.dg_detalleFac.Size = new System.Drawing.Size(579, 198);
            this.dg_detalleFac.TabIndex = 8;
            // 
            // Productos
            // 
            this.Productos.HeaderText = "Productos";
            this.Productos.MinimumWidth = 6;
            this.Productos.Name = "Productos";
            this.Productos.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.MinimumWidth = 6;
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.Width = 150;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Width = 125;
            // 
            // dg_articulo
            // 
            this.dg_articulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_articulo.Location = new System.Drawing.Point(11, 257);
            this.dg_articulo.Margin = new System.Windows.Forms.Padding(2);
            this.dg_articulo.Name = "dg_articulo";
            this.dg_articulo.RowHeadersWidth = 51;
            this.dg_articulo.RowTemplate.Height = 24;
            this.dg_articulo.Size = new System.Drawing.Size(490, 230);
            this.dg_articulo.TabIndex = 17;
            // 
            // dg_cliente
            // 
            this.dg_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cliente.Location = new System.Drawing.Point(553, 257);
            this.dg_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.dg_cliente.Name = "dg_cliente";
            this.dg_cliente.RowHeadersWidth = 51;
            this.dg_cliente.RowTemplate.Height = 24;
            this.dg_cliente.Size = new System.Drawing.Size(478, 230);
            this.dg_cliente.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(619, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cantidad";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(672, 167);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(76, 20);
            this.txt_cantidad.TabIndex = 20;
            // 
            // btn_cargarArticulo
            // 
            this.btn_cargarArticulo.Location = new System.Drawing.Point(632, 205);
            this.btn_cargarArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cargarArticulo.Name = "btn_cargarArticulo";
            this.btn_cargarArticulo.Size = new System.Drawing.Size(116, 29);
            this.btn_cargarArticulo.TabIndex = 21;
            this.btn_cargarArticulo.Text = "Cargar Articulo";
            this.btn_cargarArticulo.UseVisualStyleBackColor = true;
            this.btn_cargarArticulo.Click += new System.EventHandler(this.btn_cargarArticulo_Click);
            // 
            // btn_generarFactura
            // 
            this.btn_generarFactura.Location = new System.Drawing.Point(801, 182);
            this.btn_generarFactura.Margin = new System.Windows.Forms.Padding(2);
            this.btn_generarFactura.Name = "btn_generarFactura";
            this.btn_generarFactura.Size = new System.Drawing.Size(174, 38);
            this.btn_generarFactura.TabIndex = 22;
            this.btn_generarFactura.Text = "Generar Factura";
            this.btn_generarFactura.UseVisualStyleBackColor = true;
            this.btn_generarFactura.Click += new System.EventHandler(this.btn_generarFactura_Click);
            // 
            // lbl_prueba
            // 
            this.lbl_prueba.AutoSize = true;
            this.lbl_prueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prueba.Location = new System.Drawing.Point(898, 63);
            this.lbl_prueba.Name = "lbl_prueba";
            this.lbl_prueba.Size = new System.Drawing.Size(26, 29);
            this.lbl_prueba.TabIndex = 23;
            this.lbl_prueba.Text = "0";
            // 
            // lbl_totApagar
            // 
            this.lbl_totApagar.AutoSize = true;
            this.lbl_totApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totApagar.Location = new System.Drawing.Point(711, 62);
            this.lbl_totApagar.Name = "lbl_totApagar";
            this.lbl_totApagar.Size = new System.Drawing.Size(163, 30);
            this.lbl_totApagar.TabIndex = 24;
            this.lbl_totApagar.Text = "Total a pagar";
            // 
            // FrmDetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 498);
            this.Controls.Add(this.lbl_totApagar);
            this.Controls.Add(this.lbl_prueba);
            this.Controls.Add(this.btn_generarFactura);
            this.Controls.Add(this.btn_cargarArticulo);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dg_cliente);
            this.Controls.Add(this.dg_articulo);
            this.Controls.Add(this.dg_detalleFac);
            this.Name = "FrmDetalleFactura";
            this.Text = "FrmDetalleFactura";
            this.Load += new System.EventHandler(this.FrmDetalleFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_detalleFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_articulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_detalleFac;
        private System.Windows.Forms.DataGridView dg_articulo;
        private System.Windows.Forms.DataGridView dg_cliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Button btn_cargarArticulo;
        private System.Windows.Forms.Button btn_generarFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Label lbl_prueba;
        private System.Windows.Forms.Label lbl_totApagar;
    }
}