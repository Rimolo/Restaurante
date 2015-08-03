namespace Restaurante
{
    partial class frm_listaMesascs
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_restaurante = new System.Windows.Forms.TextBox();
            this.txt_sillas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombreMesa = new System.Windows.Forms.TextBox();
            this.txt_codigoMesa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_mas = new System.Windows.Forms.Button();
            this.b_menos = new System.Windows.Forms.Button();
            this.b_refrescar = new System.Windows.Forms.Button();
            this.b_borrar = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Image = global::Restaurante.Properties.Resources.People;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 354);
            this.label1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_restaurante);
            this.groupBox1.Controls.Add(this.txt_sillas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_nombreMesa);
            this.groupBox1.Controls.Add(this.txt_codigoMesa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(335, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 89);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solo Busqueda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cantidad de sillas\r\n";
            // 
            // txt_restaurante
            // 
            this.txt_restaurante.Location = new System.Drawing.Point(322, 22);
            this.txt_restaurante.Name = "txt_restaurante";
            this.txt_restaurante.Size = new System.Drawing.Size(115, 20);
            this.txt_restaurante.TabIndex = 22;
            // 
            // txt_sillas
            // 
            this.txt_sillas.Location = new System.Drawing.Point(322, 56);
            this.txt_sillas.Name = "txt_sillas";
            this.txt_sillas.Size = new System.Drawing.Size(115, 20);
            this.txt_sillas.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Restaurante\r\n";
            // 
            // txt_nombreMesa
            // 
            this.txt_nombreMesa.Location = new System.Drawing.Point(109, 56);
            this.txt_nombreMesa.Name = "txt_nombreMesa";
            this.txt_nombreMesa.Size = new System.Drawing.Size(121, 20);
            this.txt_nombreMesa.TabIndex = 3;
            // 
            // txt_codigoMesa
            // 
            this.txt_codigoMesa.Location = new System.Drawing.Point(109, 23);
            this.txt_codigoMesa.Name = "txt_codigoMesa";
            this.txt_codigoMesa.Size = new System.Drawing.Size(121, 20);
            this.txt_codigoMesa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre de la mesa\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo de la mesa";
            // 
            // b_mas
            // 
            this.b_mas.Location = new System.Drawing.Point(787, 28);
            this.b_mas.Name = "b_mas";
            this.b_mas.Size = new System.Drawing.Size(46, 23);
            this.b_mas.TabIndex = 31;
            this.b_mas.Text = "button5";
            this.b_mas.UseVisualStyleBackColor = true;
            // 
            // b_menos
            // 
            this.b_menos.Location = new System.Drawing.Point(787, 57);
            this.b_menos.Name = "b_menos";
            this.b_menos.Size = new System.Drawing.Size(46, 21);
            this.b_menos.TabIndex = 32;
            this.b_menos.Text = "button6";
            this.b_menos.UseVisualStyleBackColor = true;
            // 
            // b_refrescar
            // 
            this.b_refrescar.Image = global::Restaurante.Properties.Resources.Actualizar;
            this.b_refrescar.Location = new System.Drawing.Point(221, 10);
            this.b_refrescar.Name = "b_refrescar";
            this.b_refrescar.Size = new System.Drawing.Size(52, 44);
            this.b_refrescar.TabIndex = 24;
            this.b_refrescar.UseVisualStyleBackColor = true;
            // 
            // b_borrar
            // 
            this.b_borrar.Image = global::Restaurante.Properties.Resources.Eliminar12;
            this.b_borrar.Location = new System.Drawing.Point(221, 57);
            this.b_borrar.Name = "b_borrar";
            this.b_borrar.Size = new System.Drawing.Size(52, 47);
            this.b_borrar.TabIndex = 33;
            this.b_borrar.UseVisualStyleBackColor = true;
            // 
            // b_cancelar
            // 
            this.b_cancelar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cancelar.Location = new System.Drawing.Point(277, 12);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(52, 43);
            this.b_cancelar.TabIndex = 34;
            this.b_cancelar.UseVisualStyleBackColor = true;
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(277, 60);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(52, 47);
            this.b_aceptar.TabIndex = 30;
            this.b_aceptar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(250, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 232);
            this.dataGridView1.TabIndex = 35;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Numero";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad de sillas";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Restaurante";
            this.Column5.Name = "Column5";
            // 
            // frm_listaMesascs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(840, 352);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.b_cancelar);
            this.Controls.Add(this.b_borrar);
            this.Controls.Add(this.b_refrescar);
            this.Controls.Add(this.b_mas);
            this.Controls.Add(this.b_menos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_listaMesascs";
            this.Text = "Lista de Mesas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_restaurante;
        private System.Windows.Forms.TextBox txt_sillas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombreMesa;
        private System.Windows.Forms.TextBox txt_codigoMesa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_mas;
        private System.Windows.Forms.Button b_menos;
        private System.Windows.Forms.Button b_refrescar;
        private System.Windows.Forms.Button b_borrar;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}