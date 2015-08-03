namespace Restaurante
{
    partial class frm_listaComestibles
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_restaurante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombreComestible = new System.Windows.Forms.TextBox();
            this.txt_codigoComestible = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_mas = new System.Windows.Forms.Button();
            this.b_menos = new System.Windows.Forms.Button();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.b_borrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.b_refrescar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(214, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(562, 232);
            this.dataGridView1.TabIndex = 43;
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
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Restaurante";
            this.Column5.Name = "Column5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_restaurante);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_nombreComestible);
            this.groupBox1.Controls.Add(this.txt_codigoComestible);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(300, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 90);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solo Busqueda";
            // 
            // txt_restaurante
            // 
            this.txt_restaurante.Location = new System.Drawing.Point(340, 29);
            this.txt_restaurante.Name = "txt_restaurante";
            this.txt_restaurante.Size = new System.Drawing.Size(132, 20);
            this.txt_restaurante.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Restaurante";
            // 
            // txt_nombreComestible
            // 
            this.txt_nombreComestible.Location = new System.Drawing.Point(133, 57);
            this.txt_nombreComestible.Name = "txt_nombreComestible";
            this.txt_nombreComestible.Size = new System.Drawing.Size(132, 20);
            this.txt_nombreComestible.TabIndex = 3;
            // 
            // txt_codigoComestible
            // 
            this.txt_codigoComestible.Location = new System.Drawing.Point(133, 26);
            this.txt_codigoComestible.Name = "txt_codigoComestible";
            this.txt_codigoComestible.Size = new System.Drawing.Size(132, 20);
            this.txt_codigoComestible.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre del comestible";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo del comestible";
            // 
            // b_mas
            // 
            this.b_mas.Location = new System.Drawing.Point(775, 32);
            this.b_mas.Name = "b_mas";
            this.b_mas.Size = new System.Drawing.Size(55, 23);
            this.b_mas.TabIndex = 43;
            this.b_mas.Text = "button5";
            this.b_mas.UseVisualStyleBackColor = true;
            // 
            // b_menos
            // 
            this.b_menos.Location = new System.Drawing.Point(775, 74);
            this.b_menos.Name = "b_menos";
            this.b_menos.Size = new System.Drawing.Size(55, 23);
            this.b_menos.TabIndex = 50;
            this.b_menos.Text = "button6";
            this.b_menos.UseVisualStyleBackColor = true;
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(252, 61);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(42, 47);
            this.b_aceptar.TabIndex = 48;
            this.b_aceptar.UseVisualStyleBackColor = true;
            // 
            // b_borrar
            // 
            this.b_borrar.Image = global::Restaurante.Properties.Resources.Eliminar12;
            this.b_borrar.Location = new System.Drawing.Point(194, 62);
            this.b_borrar.Name = "b_borrar";
            this.b_borrar.Size = new System.Drawing.Size(52, 47);
            this.b_borrar.TabIndex = 47;
            this.b_borrar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.button1.Location = new System.Drawing.Point(252, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 43);
            this.button1.TabIndex = 46;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // b_refrescar
            // 
            this.b_refrescar.Image = global::Restaurante.Properties.Resources.Actualizar;
            this.b_refrescar.Location = new System.Drawing.Point(194, 11);
            this.b_refrescar.Name = "b_refrescar";
            this.b_refrescar.Size = new System.Drawing.Size(52, 44);
            this.b_refrescar.TabIndex = 44;
            this.b_refrescar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Image = global::Restaurante.Properties.Resources.French_fries;
            this.label1.Location = new System.Drawing.Point(-1, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 395);
            this.label1.TabIndex = 42;
            // 
            // frm_listaComestibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(834, 392);
            this.Controls.Add(this.b_menos);
            this.Controls.Add(this.b_mas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.b_borrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_refrescar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frm_listaComestibles";
            this.Text = "Lista de Comestibles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button b_refrescar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button b_borrar;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_restaurante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombreComestible;
        private System.Windows.Forms.TextBox txt_codigoComestible;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_mas;
        private System.Windows.Forms.Button b_menos;
    }
}