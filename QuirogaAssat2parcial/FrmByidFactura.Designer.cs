namespace QuirogaAssat2parcial
{
    partial class FrmByidFactura
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
            this.lbl_factura = new System.Windows.Forms.Label();
            this.txt_Idfactura = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dg_IdFactura = new System.Windows.Forms.DataGridView();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_totFactu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_IdFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_factura
            // 
            this.lbl_factura.AutoSize = true;
            this.lbl_factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factura.Location = new System.Drawing.Point(3, 9);
            this.lbl_factura.Name = "lbl_factura";
            this.lbl_factura.Size = new System.Drawing.Size(175, 25);
            this.lbl_factura.TabIndex = 0;
            this.lbl_factura.Text = "Ingrese Id Factura:";
            // 
            // txt_Idfactura
            // 
            this.txt_Idfactura.Location = new System.Drawing.Point(184, 14);
            this.txt_Idfactura.Name = "txt_Idfactura";
            this.txt_Idfactura.Size = new System.Drawing.Size(100, 20);
            this.txt_Idfactura.TabIndex = 1;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(313, 12);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dg_IdFactura
            // 
            this.dg_IdFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_IdFactura.Location = new System.Drawing.Point(-1, 94);
            this.dg_IdFactura.Name = "dg_IdFactura";
            this.dg_IdFactura.Size = new System.Drawing.Size(799, 248);
            this.dg_IdFactura.TabIndex = 3;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(43, 357);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(106, 25);
            this.lbl_total.TabIndex = 4;
            this.lbl_total.Text = "TOTAL $ :";
            // 
            // lbl_totFactu
            // 
            this.lbl_totFactu.AutoSize = true;
            this.lbl_totFactu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totFactu.Location = new System.Drawing.Point(168, 357);
            this.lbl_totFactu.Name = "lbl_totFactu";
            this.lbl_totFactu.Size = new System.Drawing.Size(23, 25);
            this.lbl_totFactu.TabIndex = 5;
            this.lbl_totFactu.Text = "0";
            // 
            // FrmByidFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_totFactu);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.dg_IdFactura);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_Idfactura);
            this.Controls.Add(this.lbl_factura);
            this.Name = "FrmByidFactura";
            this.Text = "FrmByidFactura";
            ((System.ComponentModel.ISupportInitialize)(this.dg_IdFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_factura;
        private System.Windows.Forms.TextBox txt_Idfactura;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dg_IdFactura;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_totFactu;
    }
}