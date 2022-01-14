namespace QuirogaAssat2parcial
{
    partial class FrmListarFactura
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
            this.dg_listadoClientes = new System.Windows.Forms.DataGridView();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dg_ListadoFactura = new System.Windows.Forms.DataGridView();
            this.dg_DetallesFactura = new System.Windows.Forms.DataGridView();
            this.lbl_listar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_totalFactura = new System.Windows.Forms.Label();
            this.lbl_tot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_listadoClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ListadoFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DetallesFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_listadoClientes
            // 
            this.dg_listadoClientes.AllowUserToAddRows = false;
            this.dg_listadoClientes.AllowUserToDeleteRows = false;
            this.dg_listadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_listadoClientes.Location = new System.Drawing.Point(374, 10);
            this.dg_listadoClientes.Name = "dg_listadoClientes";
            this.dg_listadoClientes.ReadOnly = true;
            this.dg_listadoClientes.Size = new System.Drawing.Size(599, 171);
            this.dg_listadoClientes.TabIndex = 4;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(293, 12);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 5;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // dg_ListadoFactura
            // 
            this.dg_ListadoFactura.AllowUserToAddRows = false;
            this.dg_ListadoFactura.AllowUserToDeleteRows = false;
            this.dg_ListadoFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ListadoFactura.Location = new System.Drawing.Point(4, 98);
            this.dg_ListadoFactura.Name = "dg_ListadoFactura";
            this.dg_ListadoFactura.ReadOnly = true;
            this.dg_ListadoFactura.Size = new System.Drawing.Size(364, 342);
            this.dg_ListadoFactura.TabIndex = 6;
            this.dg_ListadoFactura.SelectionChanged += new System.EventHandler(this.dg_ListadoFactura_SelectionChanged);
            // 
            // dg_DetallesFactura
            // 
            this.dg_DetallesFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_DetallesFactura.Location = new System.Drawing.Point(374, 187);
            this.dg_DetallesFactura.Name = "dg_DetallesFactura";
            this.dg_DetallesFactura.Size = new System.Drawing.Size(599, 208);
            this.dg_DetallesFactura.TabIndex = 7;
            // 
            // lbl_listar
            // 
            this.lbl_listar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_listar.Location = new System.Drawing.Point(12, 31);
            this.lbl_listar.Name = "lbl_listar";
            this.lbl_listar.Size = new System.Drawing.Size(275, 45);
            this.lbl_listar.TabIndex = 8;
            this.lbl_listar.Text = "Listado Facturas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // lbl_totalFactura
            // 
            this.lbl_totalFactura.AutoSize = true;
            this.lbl_totalFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalFactura.Location = new System.Drawing.Point(417, 409);
            this.lbl_totalFactura.Name = "lbl_totalFactura";
            this.lbl_totalFactura.Size = new System.Drawing.Size(231, 31);
            this.lbl_totalFactura.TabIndex = 10;
            this.lbl_totalFactura.Text = "Total de la factura";
            // 
            // lbl_tot
            // 
            this.lbl_tot.AutoSize = true;
            this.lbl_tot.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tot.Location = new System.Drawing.Point(729, 411);
            this.lbl_tot.Name = "lbl_tot";
            this.lbl_tot.Size = new System.Drawing.Size(27, 30);
            this.lbl_tot.TabIndex = 11;
            this.lbl_tot.Text = "0";
            // 
            // FrmListarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 502);
            this.Controls.Add(this.lbl_tot);
            this.Controls.Add(this.lbl_totalFactura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_listar);
            this.Controls.Add(this.dg_DetallesFactura);
            this.Controls.Add(this.dg_ListadoFactura);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.dg_listadoClientes);
            this.Name = "FrmListarFactura";
            this.Text = "FrmListarFactura";
            this.Load += new System.EventHandler(this.FrmListarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_listadoClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ListadoFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DetallesFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dg_listadoClientes;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.DataGridView dg_ListadoFactura;
        private System.Windows.Forms.DataGridView dg_DetallesFactura;
        private System.Windows.Forms.Label lbl_listar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_totalFactura;
        private System.Windows.Forms.Label lbl_tot;
    }
}