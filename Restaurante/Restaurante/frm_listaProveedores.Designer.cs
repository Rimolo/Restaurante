namespace Restaurante
{
    partial class frm_listaProveedores
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
            this.dgv_proveedores = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombreProveedor = new System.Windows.Forms.TextBox();
            this.txt_codigoProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_eliminar = new System.Windows.Forms.Button();
            this.b_agregar = new System.Windows.Forms.Button();
            this.b_refrescar = new System.Windows.Forms.Button();
            this.b_borrar = new System.Windows.Forms.Button();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.b_cerrar = new System.Windows.Forms.Button();
            this.mtb_cedula = new System.Windows.Forms.MaskedTextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_proveedores
            // 
            this.dgv_proveedores.AllowUserToAddRows = false;
            this.dgv_proveedores.AllowUserToDeleteRows = false;
            this.dgv_proveedores.BackgroundColor = System.Drawing.Color.White;
            this.dgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column3,
            this.Column6,
            this.Column7});
            this.dgv_proveedores.Location = new System.Drawing.Point(173, 137);
            this.dgv_proveedores.MultiSelect = false;
            this.dgv_proveedores.Name = "dgv_proveedores";
            this.dgv_proveedores.ReadOnly = true;
            this.dgv_proveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_proveedores.Size = new System.Drawing.Size(710, 232);
            this.dgv_proveedores.TabIndex = 48;
            this.dgv_proveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_proveedores_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtb_cedula);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_direccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_nombreProveedor);
            this.groupBox1.Controls.Add(this.txt_codigoProveedor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(271, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 90);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solo Busqueda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cedula";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(343, 26);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(132, 20);
            this.txt_direccion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Direccion";
            // 
            // txt_nombreProveedor
            // 
            this.txt_nombreProveedor.Location = new System.Drawing.Point(125, 57);
            this.txt_nombreProveedor.Name = "txt_nombreProveedor";
            this.txt_nombreProveedor.Size = new System.Drawing.Size(132, 20);
            this.txt_nombreProveedor.TabIndex = 3;
            // 
            // txt_codigoProveedor
            // 
            this.txt_codigoProveedor.Location = new System.Drawing.Point(125, 26);
            this.txt_codigoProveedor.Name = "txt_codigoProveedor";
            this.txt_codigoProveedor.Size = new System.Drawing.Size(132, 20);
            this.txt_codigoProveedor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre del Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo del Proveedor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 381);
            this.panel1.TabIndex = 73;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurante.Properties.Resources.icono_proveedores;
            this.pictureBox1.Location = new System.Drawing.Point(21, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 125);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // b_eliminar
            // 
            this.b_eliminar.Image = global::Restaurante.Properties.Resources.refurl;
            this.b_eliminar.Location = new System.Drawing.Point(784, 71);
            this.b_eliminar.Name = "b_eliminar";
            this.b_eliminar.Size = new System.Drawing.Size(51, 39);
            this.b_eliminar.TabIndex = 72;
            this.b_eliminar.UseVisualStyleBackColor = true;
            this.b_eliminar.Click += new System.EventHandler(this.b_eliminar_Click);
            // 
            // b_agregar
            // 
            this.b_agregar.Image = global::Restaurante.Properties.Resources.green_add_icon;
            this.b_agregar.Location = new System.Drawing.Point(784, 23);
            this.b_agregar.Name = "b_agregar";
            this.b_agregar.Size = new System.Drawing.Size(51, 42);
            this.b_agregar.TabIndex = 71;
            this.b_agregar.UseVisualStyleBackColor = true;
            this.b_agregar.Click += new System.EventHandler(this.b_agregar_Click);
            // 
            // b_refrescar
            // 
            this.b_refrescar.Image = global::Restaurante.Properties.Resources.refrescar;
            this.b_refrescar.Location = new System.Drawing.Point(178, 12);
            this.b_refrescar.Name = "b_refrescar";
            this.b_refrescar.Size = new System.Drawing.Size(39, 43);
            this.b_refrescar.TabIndex = 70;
            this.b_refrescar.Text = "\r\n";
            this.b_refrescar.UseVisualStyleBackColor = true;
            this.b_refrescar.Click += new System.EventHandler(this.b_refrescar_Click);
            // 
            // b_borrar
            // 
            this.b_borrar.Image = global::Restaurante.Properties.Resources.clean1;
            this.b_borrar.Location = new System.Drawing.Point(178, 62);
            this.b_borrar.Name = "b_borrar";
            this.b_borrar.Size = new System.Drawing.Size(39, 47);
            this.b_borrar.TabIndex = 69;
            this.b_borrar.UseVisualStyleBackColor = true;
            this.b_borrar.Click += new System.EventHandler(this.b_borrar_Click);
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(223, 62);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(42, 47);
            this.b_aceptar.TabIndex = 65;
            this.b_aceptar.UseVisualStyleBackColor = true;
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // b_cerrar
            // 
            this.b_cerrar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cerrar.Location = new System.Drawing.Point(223, 13);
            this.b_cerrar.Name = "b_cerrar";
            this.b_cerrar.Size = new System.Drawing.Size(42, 43);
            this.b_cerrar.TabIndex = 62;
            this.b_cerrar.UseVisualStyleBackColor = true;
            this.b_cerrar.Click += new System.EventHandler(this.b_cerrar_Click);
            // 
            // mtb_cedula
            // 
            this.mtb_cedula.Location = new System.Drawing.Point(343, 64);
            this.mtb_cedula.Mask = "0-0000-0000";
            this.mtb_cedula.Name = "mtb_cedula";
            this.mtb_cedula.Size = new System.Drawing.Size(132, 20);
            this.mtb_cedula.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "codProveedor";
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nombreProveedor";
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "primerApellido";
            this.Column4.HeaderText = "Primer Apellido";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "segundoApellido";
            this.Column5.HeaderText = "Segundo Apellido";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "oficina";
            this.Column3.HeaderText = "Tel Oficina";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "fax";
            this.Column6.HeaderText = "Fax";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "celular";
            this.Column7.HeaderText = "Celular";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // frm_listaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(888, 381);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.b_eliminar);
            this.Controls.Add(this.b_agregar);
            this.Controls.Add(this.b_refrescar);
            this.Controls.Add(this.b_borrar);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.b_cerrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_proveedores);
            this.Name = "frm_listaProveedores";
            this.Text = "Lista de Proveedores";
            this.Load += new System.EventHandler(this.frm_listaProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_proveedores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombreProveedor;
        private System.Windows.Forms.TextBox txt_codigoProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_cerrar;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button b_borrar;
        private System.Windows.Forms.Button b_refrescar;
        private System.Windows.Forms.Button b_agregar;
        private System.Windows.Forms.Button b_eliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox mtb_cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}