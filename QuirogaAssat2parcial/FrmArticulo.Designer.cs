namespace QuirogaAssat2parcial
{
    partial class FrmArticulo
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.dg_vista = new System.Windows.Forms.DataGridView();
            this.txt_eliminar = new System.Windows.Forms.TextBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.txt_actId = new System.Windows.Forms.TextBox();
            this.txt_actnombre = new System.Windows.Forms.TextBox();
            this.txt_actprecio = new System.Windows.Forms.TextBox();
            this.txt_actcantidad = new System.Windows.Forms.TextBox();
            this.lbl_actnombre = new System.Windows.Forms.Label();
            this.lbl_actid = new System.Windows.Forms.Label();
            this.lbl_actprecio = new System.Windows.Forms.Label();
            this.lbl_actcantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_vista)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(22, 43);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(22, 92);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(37, 13);
            this.lbl_precio.TabIndex = 1;
            this.lbl_precio.Text = "Precio";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(91, 40);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 2;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(91, 92);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 20);
            this.txt_precio.TabIndex = 3;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(22, 144);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(49, 13);
            this.lbl_cantidad.TabIndex = 4;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(91, 141);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad.TabIndex = 5;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(240, 37);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 6;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(240, 139);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 7;
            this.btn_eliminar.Text = "Borrar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(466, 179);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(75, 23);
            this.btn_listar.TabIndex = 8;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // dg_vista
            // 
            this.dg_vista.AllowUserToAddRows = false;
            this.dg_vista.AllowUserToDeleteRows = false;
            this.dg_vista.AllowUserToResizeColumns = false;
            this.dg_vista.AllowUserToResizeRows = false;
            this.dg_vista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_vista.GridColor = System.Drawing.Color.MidnightBlue;
            this.dg_vista.Location = new System.Drawing.Point(2, 220);
            this.dg_vista.Name = "dg_vista";
            this.dg_vista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dg_vista.Size = new System.Drawing.Size(776, 218);
            this.dg_vista.TabIndex = 9;
            // 
            // txt_eliminar
            // 
            this.txt_eliminar.Location = new System.Drawing.Point(361, 141);
            this.txt_eliminar.Name = "txt_eliminar";
            this.txt_eliminar.Size = new System.Drawing.Size(75, 20);
            this.txt_eliminar.TabIndex = 10;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(466, 37);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_actualizar.TabIndex = 11;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // txt_actId
            // 
            this.txt_actId.Location = new System.Drawing.Point(627, 14);
            this.txt_actId.Name = "txt_actId";
            this.txt_actId.Size = new System.Drawing.Size(75, 20);
            this.txt_actId.TabIndex = 12;
            // 
            // txt_actnombre
            // 
            this.txt_actnombre.Location = new System.Drawing.Point(627, 40);
            this.txt_actnombre.Name = "txt_actnombre";
            this.txt_actnombre.Size = new System.Drawing.Size(75, 20);
            this.txt_actnombre.TabIndex = 13;
            // 
            // txt_actprecio
            // 
            this.txt_actprecio.Location = new System.Drawing.Point(627, 66);
            this.txt_actprecio.Name = "txt_actprecio";
            this.txt_actprecio.Size = new System.Drawing.Size(75, 20);
            this.txt_actprecio.TabIndex = 14;
            // 
            // txt_actcantidad
            // 
            this.txt_actcantidad.Location = new System.Drawing.Point(627, 92);
            this.txt_actcantidad.Name = "txt_actcantidad";
            this.txt_actcantidad.Size = new System.Drawing.Size(75, 20);
            this.txt_actcantidad.TabIndex = 15;
            // 
            // lbl_actnombre
            // 
            this.lbl_actnombre.AutoSize = true;
            this.lbl_actnombre.Location = new System.Drawing.Point(577, 47);
            this.lbl_actnombre.Name = "lbl_actnombre";
            this.lbl_actnombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_actnombre.TabIndex = 16;
            this.lbl_actnombre.Text = "Nombre";
            // 
            // lbl_actid
            // 
            this.lbl_actid.AutoSize = true;
            this.lbl_actid.Location = new System.Drawing.Point(586, 21);
            this.lbl_actid.Name = "lbl_actid";
            this.lbl_actid.Size = new System.Drawing.Size(16, 13);
            this.lbl_actid.TabIndex = 17;
            this.lbl_actid.Text = "Id";
            // 
            // lbl_actprecio
            // 
            this.lbl_actprecio.AutoSize = true;
            this.lbl_actprecio.Location = new System.Drawing.Point(577, 73);
            this.lbl_actprecio.Name = "lbl_actprecio";
            this.lbl_actprecio.Size = new System.Drawing.Size(37, 13);
            this.lbl_actprecio.TabIndex = 18;
            this.lbl_actprecio.Text = "Precio";
            // 
            // lbl_actcantidad
            // 
            this.lbl_actcantidad.AutoSize = true;
            this.lbl_actcantidad.Location = new System.Drawing.Point(577, 95);
            this.lbl_actcantidad.Name = "lbl_actcantidad";
            this.lbl_actcantidad.Size = new System.Drawing.Size(49, 13);
            this.lbl_actcantidad.TabIndex = 19;
            this.lbl_actcantidad.Text = "Cantidad";
            // 
            // FrmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_actcantidad);
            this.Controls.Add(this.lbl_actprecio);
            this.Controls.Add(this.lbl_actid);
            this.Controls.Add(this.lbl_actnombre);
            this.Controls.Add(this.txt_actcantidad);
            this.Controls.Add(this.txt_actprecio);
            this.Controls.Add(this.txt_actnombre);
            this.Controls.Add(this.txt_actId);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.txt_eliminar);
            this.Controls.Add(this.dg_vista);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "FrmArticulo";
            this.Text = "FrmArticulo";
            this.Load += new System.EventHandler(this.FrmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_vista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.DataGridView dg_vista;
        private System.Windows.Forms.TextBox txt_eliminar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.TextBox txt_actId;
        private System.Windows.Forms.TextBox txt_actnombre;
        private System.Windows.Forms.TextBox txt_actprecio;
        private System.Windows.Forms.TextBox txt_actcantidad;
        private System.Windows.Forms.Label lbl_actnombre;
        private System.Windows.Forms.Label lbl_actid;
        private System.Windows.Forms.Label lbl_actprecio;
        private System.Windows.Forms.Label lbl_actcantidad;
    }
}