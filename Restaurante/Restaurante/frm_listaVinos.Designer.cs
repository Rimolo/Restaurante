namespace Restaurante
{
    partial class frm_listaVinos
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_año = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_restaurante = new System.Windows.Forms.TextBox();
            this.txt_nacionalidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombreBebidaV = new System.Windows.Forms.TextBox();
            this.txt_codigoBebidaV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_refrescar = new System.Windows.Forms.Button();
            this.b_borrar = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.b_mas = new System.Windows.Forms.Button();
            this.b_menos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Image = global::Restaurante.Properties.Resources.Wine__2_1;
            this.label1.Location = new System.Drawing.Point(-1, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 380);
            this.label1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_precio);
            this.groupBox1.Controls.Add(this.txt_año);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_restaurante);
            this.groupBox1.Controls.Add(this.txt_nacionalidad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_nombreBebidaV);
            this.groupBox1.Controls.Add(this.txt_codigoBebidaV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(278, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 112);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solo Busqueda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Precio";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(284, 86);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(115, 20);
            this.txt_precio.TabIndex = 26;
            // 
            // txt_año
            // 
            this.txt_año.Location = new System.Drawing.Point(87, 86);
            this.txt_año.Name = "txt_año";
            this.txt_año.Size = new System.Drawing.Size(121, 20);
            this.txt_año.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Año\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Restaurante";
            // 
            // txt_restaurante
            // 
            this.txt_restaurante.Location = new System.Drawing.Point(284, 53);
            this.txt_restaurante.Name = "txt_restaurante";
            this.txt_restaurante.Size = new System.Drawing.Size(115, 20);
            this.txt_restaurante.TabIndex = 22;
            // 
            // txt_nacionalidad
            // 
            this.txt_nacionalidad.Location = new System.Drawing.Point(284, 22);
            this.txt_nacionalidad.Name = "txt_nacionalidad";
            this.txt_nacionalidad.Size = new System.Drawing.Size(115, 20);
            this.txt_nacionalidad.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nacionalidad";
            // 
            // txt_nombreBebidaV
            // 
            this.txt_nombreBebidaV.Location = new System.Drawing.Point(87, 56);
            this.txt_nombreBebidaV.Name = "txt_nombreBebidaV";
            this.txt_nombreBebidaV.Size = new System.Drawing.Size(121, 20);
            this.txt_nombreBebidaV.TabIndex = 3;
            // 
            // txt_codigoBebidaV
            // 
            this.txt_codigoBebidaV.Location = new System.Drawing.Point(87, 26);
            this.txt_codigoBebidaV.Name = "txt_codigoBebidaV";
            this.txt_codigoBebidaV.Size = new System.Drawing.Size(121, 20);
            this.txt_codigoBebidaV.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre del Vino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo del Vino";
            // 
            // b_refrescar
            // 
            this.b_refrescar.Image = global::Restaurante.Properties.Resources.Actualizar;
            this.b_refrescar.Location = new System.Drawing.Point(160, 10);
            this.b_refrescar.Name = "b_refrescar";
            this.b_refrescar.Size = new System.Drawing.Size(52, 44);
            this.b_refrescar.TabIndex = 17;
            this.b_refrescar.UseVisualStyleBackColor = true;
            this.b_refrescar.Click += new System.EventHandler(this.b_refrescar_Click);
            // 
            // b_borrar
            // 
            this.b_borrar.Image = global::Restaurante.Properties.Resources.Eliminar12;
            this.b_borrar.Location = new System.Drawing.Point(160, 60);
            this.b_borrar.Name = "b_borrar";
            this.b_borrar.Size = new System.Drawing.Size(52, 47);
            this.b_borrar.TabIndex = 18;
            this.b_borrar.UseVisualStyleBackColor = true;
            this.b_borrar.Click += new System.EventHandler(this.b_borrar_Click);
            // 
            // b_cancelar
            // 
            this.b_cancelar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cancelar.Location = new System.Drawing.Point(218, 12);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(52, 43);
            this.b_cancelar.TabIndex = 28;
            this.b_cancelar.UseVisualStyleBackColor = true;
            this.b_cancelar.Click += new System.EventHandler(this.b_cancelar_Click);
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(220, 60);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(52, 47);
            this.b_aceptar.TabIndex = 29;
            this.b_aceptar.UseVisualStyleBackColor = true;
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // b_mas
            // 
            this.b_mas.Image = global::Restaurante.Properties.Resources.green_add_icon1;
            this.b_mas.Location = new System.Drawing.Point(689, 29);
            this.b_mas.Name = "b_mas";
            this.b_mas.Size = new System.Drawing.Size(46, 35);
            this.b_mas.TabIndex = 30;
            this.b_mas.UseVisualStyleBackColor = true;
            this.b_mas.Click += new System.EventHandler(this.b_mas_Click);
            // 
            // b_menos
            // 
            this.b_menos.Image = global::Restaurante.Properties.Resources.refurl;
            this.b_menos.Location = new System.Drawing.Point(689, 72);
            this.b_menos.Name = "b_menos";
            this.b_menos.Size = new System.Drawing.Size(46, 40);
            this.b_menos.TabIndex = 31;
            this.b_menos.UseVisualStyleBackColor = true;
            this.b_menos.Click += new System.EventHandler(this.b_menos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(162, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(571, 232);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "codVino";
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
            this.Column3.DataPropertyName = "precioUnitario";
            this.Column3.HeaderText = "Precio Unitario";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "precioBotella";
            this.Column4.HeaderText = "Precio Botella";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "nomPais";
            this.Column5.HeaderText = "Nacionalidad";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "añoCosecha";
            this.Column6.HeaderText = "Año";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // frm_listaVinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(745, 376);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_menos);
            this.Controls.Add(this.b_mas);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.b_cancelar);
            this.Controls.Add(this.b_borrar);
            this.Controls.Add(this.b_refrescar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_listaVinos";
            this.Text = "Lista de Vinos";
            this.Load += new System.EventHandler(this.frm_listaVinos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_año;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_restaurante;
        private System.Windows.Forms.TextBox txt_nacionalidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombreBebidaV;
        private System.Windows.Forms.TextBox txt_codigoBebidaV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_refrescar;
        private System.Windows.Forms.Button b_borrar;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Button b_mas;
        private System.Windows.Forms.Button b_menos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}