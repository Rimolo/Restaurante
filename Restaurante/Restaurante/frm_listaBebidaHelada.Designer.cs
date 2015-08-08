namespace Restaurante
{
    partial class frm_listaBebidaHelada
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nombreBebidaH = new System.Windows.Forms.TextBox();
            this.txt_codigoBebidaH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_bebidaHelada = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.b_refrescar = new System.Windows.Forms.Button();
            this.b_borrar = new System.Windows.Forms.Button();
            this.b_agregar = new System.Windows.Forms.Button();
            this.b_eliminar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bebidaHelada)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nombreBebidaH);
            this.groupBox1.Controls.Add(this.txt_codigoBebidaH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(298, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 90);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solo Busqueda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_nombreBebidaH
            // 
            this.txt_nombreBebidaH.Location = new System.Drawing.Point(143, 56);
            this.txt_nombreBebidaH.Name = "txt_nombreBebidaH";
            this.txt_nombreBebidaH.Size = new System.Drawing.Size(132, 20);
            this.txt_nombreBebidaH.TabIndex = 3;
            // 
            // txt_codigoBebidaH
            // 
            this.txt_codigoBebidaH.Location = new System.Drawing.Point(144, 22);
            this.txt_codigoBebidaH.Name = "txt_codigoBebidaH";
            this.txt_codigoBebidaH.Size = new System.Drawing.Size(132, 20);
            this.txt_codigoBebidaH.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre de Bebida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo de Bebida";
            // 
            // dgv_bebidaHelada
            // 
            this.dgv_bebidaHelada.AllowUserToAddRows = false;
            this.dgv_bebidaHelada.AllowUserToDeleteRows = false;
            this.dgv_bebidaHelada.BackgroundColor = System.Drawing.Color.White;
            this.dgv_bebidaHelada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bebidaHelada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_bebidaHelada.Location = new System.Drawing.Point(187, 134);
            this.dgv_bebidaHelada.MultiSelect = false;
            this.dgv_bebidaHelada.Name = "dgv_bebidaHelada";
            this.dgv_bebidaHelada.ReadOnly = true;
            this.dgv_bebidaHelada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bebidaHelada.Size = new System.Drawing.Size(446, 253);
            this.dgv_bebidaHelada.TabIndex = 13;
            this.dgv_bebidaHelada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bebidaHelada_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 399);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurante.Properties.Resources._27710310_icono_del_web_bebida_fr_a;
            this.pictureBox1.Location = new System.Drawing.Point(21, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 138);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(240, 62);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(52, 47);
            this.b_aceptar.TabIndex = 9;
            this.b_aceptar.UseVisualStyleBackColor = true;
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // b_cancelar
            // 
            this.b_cancelar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cancelar.Location = new System.Drawing.Point(239, 13);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(52, 43);
            this.b_cancelar.TabIndex = 7;
            this.b_cancelar.UseVisualStyleBackColor = true;
            this.b_cancelar.Click += new System.EventHandler(this.b_cancelar_Click);
            // 
            // b_refrescar
            // 
            this.b_refrescar.Image = global::Restaurante.Properties.Resources.refrescar1;
            this.b_refrescar.Location = new System.Drawing.Point(187, 13);
            this.b_refrescar.Name = "b_refrescar";
            this.b_refrescar.Size = new System.Drawing.Size(48, 43);
            this.b_refrescar.TabIndex = 73;
            this.b_refrescar.UseVisualStyleBackColor = true;
            this.b_refrescar.Click += new System.EventHandler(this.b_refrescar_Click);
            // 
            // b_borrar
            // 
            this.b_borrar.Image = global::Restaurante.Properties.Resources.clean1;
            this.b_borrar.Location = new System.Drawing.Point(183, 67);
            this.b_borrar.Name = "b_borrar";
            this.b_borrar.Size = new System.Drawing.Size(52, 42);
            this.b_borrar.TabIndex = 74;
            this.b_borrar.UseVisualStyleBackColor = true;
            this.b_borrar.Click += new System.EventHandler(this.b_borrar_Click);
            // 
            // b_agregar
            // 
            this.b_agregar.Image = global::Restaurante.Properties.Resources.green_add_icon1;
            this.b_agregar.Location = new System.Drawing.Point(585, 15);
            this.b_agregar.Name = "b_agregar";
            this.b_agregar.Size = new System.Drawing.Size(53, 39);
            this.b_agregar.TabIndex = 75;
            this.b_agregar.UseVisualStyleBackColor = true;
            this.b_agregar.Click += new System.EventHandler(this.b_agregar_Click);
            // 
            // b_eliminar
            // 
            this.b_eliminar.Image = global::Restaurante.Properties.Resources.refurl1;
            this.b_eliminar.Location = new System.Drawing.Point(585, 56);
            this.b_eliminar.Name = "b_eliminar";
            this.b_eliminar.Size = new System.Drawing.Size(53, 42);
            this.b_eliminar.TabIndex = 76;
            this.b_eliminar.UseVisualStyleBackColor = true;
            this.b_eliminar.Click += new System.EventHandler(this.b_eliminar_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "codBebidaHel";
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nombre";
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "precio";
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "nomrest";
            this.Column4.HeaderText = "Restaurante";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frm_listaBebidaHelada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(645, 396);
            this.Controls.Add(this.b_eliminar);
            this.Controls.Add(this.b_agregar);
            this.Controls.Add(this.b_borrar);
            this.Controls.Add(this.b_refrescar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_bebidaHelada);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.b_cancelar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_listaBebidaHelada";
            this.Text = "Lista de Bebidas Heladas";
            this.Load += new System.EventHandler(this.frm_listaBebidaHelada_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bebidaHelada)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nombreBebidaH;
        private System.Windows.Forms.TextBox txt_codigoBebidaH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.DataGridView dgv_bebidaHelada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b_refrescar;
        private System.Windows.Forms.Button b_borrar;
        private System.Windows.Forms.Button b_agregar;
        private System.Windows.Forms.Button b_eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}