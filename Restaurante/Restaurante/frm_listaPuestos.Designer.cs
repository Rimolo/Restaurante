namespace Restaurante
{
    partial class frm_listaPuestos
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
            this.dgv_puestos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_externo = new System.Windows.Forms.RadioButton();
            this.rb_interno = new System.Windows.Forms.RadioButton();
            this.txt_nombreRestaurante = new System.Windows.Forms.TextBox();
            this.txt_codigoRestaurante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_menos = new System.Windows.Forms.Button();
            this.b_mas = new System.Windows.Forms.Button();
            this.b_borrar = new System.Windows.Forms.Button();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.b_refrescar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_puestos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_puestos
            // 
            this.dgv_puestos.AllowUserToAddRows = false;
            this.dgv_puestos.AllowUserToDeleteRows = false;
            this.dgv_puestos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_puestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_puestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_puestos.Location = new System.Drawing.Point(252, 115);
            this.dgv_puestos.Name = "dgv_puestos";
            this.dgv_puestos.ReadOnly = true;
            this.dgv_puestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_puestos.Size = new System.Drawing.Size(557, 232);
            this.dgv_puestos.TabIndex = 37;
            this.dgv_puestos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_puestos_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "codPuesto";
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
            this.Column3.DataPropertyName = "codRol";
            this.Column3.HeaderText = "Rol";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "internoRestaurante";
            this.Column4.HeaderText = "Interno al Retaurante";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "externoRestaurante";
            this.Column5.HeaderText = "Externo al Restaurante";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_externo);
            this.groupBox1.Controls.Add(this.rb_interno);
            this.groupBox1.Controls.Add(this.txt_nombreRestaurante);
            this.groupBox1.Controls.Add(this.txt_codigoRestaurante);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(355, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 90);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solo Busqueda";
            // 
            // rb_externo
            // 
            this.rb_externo.AutoSize = true;
            this.rb_externo.Location = new System.Drawing.Point(281, 48);
            this.rb_externo.Name = "rb_externo";
            this.rb_externo.Size = new System.Drawing.Size(97, 30);
            this.rb_externo.TabIndex = 45;
            this.rb_externo.TabStop = true;
            this.rb_externo.Text = "Externo\r\n al Restaurante\r\n";
            this.rb_externo.UseVisualStyleBackColor = true;
            // 
            // rb_interno
            // 
            this.rb_interno.AutoSize = true;
            this.rb_interno.Location = new System.Drawing.Point(281, 25);
            this.rb_interno.Name = "rb_interno";
            this.rb_interno.Size = new System.Drawing.Size(130, 17);
            this.rb_interno.TabIndex = 44;
            this.rb_interno.TabStop = true;
            this.rb_interno.Text = "Interno al Restaurante\r\n";
            this.rb_interno.UseVisualStyleBackColor = true;
            // 
            // txt_nombreRestaurante
            // 
            this.txt_nombreRestaurante.Location = new System.Drawing.Point(143, 59);
            this.txt_nombreRestaurante.Name = "txt_nombreRestaurante";
            this.txt_nombreRestaurante.Size = new System.Drawing.Size(132, 20);
            this.txt_nombreRestaurante.TabIndex = 3;
            // 
            // txt_codigoRestaurante
            // 
            this.txt_codigoRestaurante.Location = new System.Drawing.Point(143, 26);
            this.txt_codigoRestaurante.Name = "txt_codigoRestaurante";
            this.txt_codigoRestaurante.Size = new System.Drawing.Size(132, 20);
            this.txt_codigoRestaurante.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre del Restaurante\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo del Restaurante\r\n";
            // 
            // b_menos
            // 
            this.b_menos.Image = global::Restaurante.Properties.Resources.refurl;
            this.b_menos.Location = new System.Drawing.Point(772, 62);
            this.b_menos.Name = "b_menos";
            this.b_menos.Size = new System.Drawing.Size(54, 40);
            this.b_menos.TabIndex = 47;
            this.b_menos.UseVisualStyleBackColor = true;
            this.b_menos.Click += new System.EventHandler(this.b_menos_Click);
            // 
            // b_mas
            // 
            this.b_mas.Image = global::Restaurante.Properties.Resources.green_add_icon2;
            this.b_mas.Location = new System.Drawing.Point(772, 19);
            this.b_mas.Name = "b_mas";
            this.b_mas.Size = new System.Drawing.Size(55, 36);
            this.b_mas.TabIndex = 46;
            this.b_mas.UseVisualStyleBackColor = true;
            this.b_mas.Click += new System.EventHandler(this.b_mas_Click);
            // 
            // b_borrar
            // 
            this.b_borrar.Image = global::Restaurante.Properties.Resources.Eliminar12;
            this.b_borrar.Location = new System.Drawing.Point(239, 62);
            this.b_borrar.Name = "b_borrar";
            this.b_borrar.Size = new System.Drawing.Size(52, 47);
            this.b_borrar.TabIndex = 42;
            this.b_borrar.UseVisualStyleBackColor = true;
            this.b_borrar.Click += new System.EventHandler(this.b_borrar_Click);
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(297, 61);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(52, 47);
            this.b_aceptar.TabIndex = 41;
            this.b_aceptar.UseVisualStyleBackColor = true;
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // b_cancelar
            // 
            this.b_cancelar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cancelar.Location = new System.Drawing.Point(297, 12);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(52, 43);
            this.b_cancelar.TabIndex = 39;
            this.b_cancelar.UseVisualStyleBackColor = true;
            this.b_cancelar.Click += new System.EventHandler(this.b_cancelar_Click);
            // 
            // b_refrescar
            // 
            this.b_refrescar.Image = global::Restaurante.Properties.Resources.Actualizar;
            this.b_refrescar.Location = new System.Drawing.Point(239, 12);
            this.b_refrescar.Name = "b_refrescar";
            this.b_refrescar.Size = new System.Drawing.Size(52, 44);
            this.b_refrescar.TabIndex = 38;
            this.b_refrescar.UseVisualStyleBackColor = true;
            this.b_refrescar.Click += new System.EventHandler(this.b_refrescar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Image = global::Restaurante.Properties.Resources.Foto;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 360);
            this.label1.TabIndex = 4;
            // 
            // frm_listaPuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(838, 359);
            this.Controls.Add(this.b_menos);
            this.Controls.Add(this.b_mas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b_borrar);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.b_cancelar);
            this.Controls.Add(this.b_refrescar);
            this.Controls.Add(this.dgv_puestos);
            this.Controls.Add(this.label1);
            this.Name = "frm_listaPuestos";
            this.Text = "Lista de Puestos";
            this.Load += new System.EventHandler(this.frm_listaPuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_puestos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_puestos;
        private System.Windows.Forms.Button b_refrescar;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Button b_borrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_externo;
        private System.Windows.Forms.RadioButton rb_interno;
        private System.Windows.Forms.TextBox txt_nombreRestaurante;
        private System.Windows.Forms.TextBox txt_codigoRestaurante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_mas;
        private System.Windows.Forms.Button b_menos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}