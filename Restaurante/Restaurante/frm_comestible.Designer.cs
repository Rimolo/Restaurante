namespace Restaurante
{
    partial class frm_comestible
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
            this.label8 = new System.Windows.Forms.Label();
            this.cb_tipoComestible = new System.Windows.Forms.ComboBox();
            this.cb_restaurante = new System.Windows.Forms.ComboBox();
            this.cb_unidadMedida = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_lineaComestible = new System.Windows.Forms.ComboBox();
            this.cb_claseComestible = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_marcaComestible = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.b_limpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Image = global::Restaurante.Properties.Resources.French_fries;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 346);
            this.label1.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cb_tipoComestible);
            this.groupBox1.Controls.Add(this.cb_restaurante);
            this.groupBox1.Controls.Add(this.cb_unidadMedida);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_lineaComestible);
            this.groupBox1.Controls.Add(this.cb_claseComestible);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_marcaComestible);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_cantidad);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(205, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 250);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del Comestible";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Tipo de Comestible";
            // 
            // cb_tipoComestible
            // 
            this.cb_tipoComestible.FormattingEnabled = true;
            this.cb_tipoComestible.Items.AddRange(new object[] {
            "Frutas",
            "Cacao",
            "Carnes",
            "Aceites",
            "Cereales",
            "Vegetales",
            "Legumbres",
            "Frutos Secos"});
            this.cb_tipoComestible.Location = new System.Drawing.Point(109, 161);
            this.cb_tipoComestible.Name = "cb_tipoComestible";
            this.cb_tipoComestible.Size = new System.Drawing.Size(121, 21);
            this.cb_tipoComestible.TabIndex = 32;
            // 
            // cb_restaurante
            // 
            this.cb_restaurante.FormattingEnabled = true;
            this.cb_restaurante.Location = new System.Drawing.Point(109, 217);
            this.cb_restaurante.Name = "cb_restaurante";
            this.cb_restaurante.Size = new System.Drawing.Size(121, 21);
            this.cb_restaurante.TabIndex = 31;
            // 
            // cb_unidadMedida
            // 
            this.cb_unidadMedida.FormattingEnabled = true;
            this.cb_unidadMedida.Location = new System.Drawing.Point(428, 169);
            this.cb_unidadMedida.Name = "cb_unidadMedida";
            this.cb_unidadMedida.Size = new System.Drawing.Size(121, 21);
            this.cb_unidadMedida.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Unidad de Medida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Linea de comestible";
            // 
            // cb_lineaComestible
            // 
            this.cb_lineaComestible.FormattingEnabled = true;
            this.cb_lineaComestible.Items.AddRange(new object[] {
            "Secos",
            "Congelados",
            "Refrigerados"});
            this.cb_lineaComestible.Location = new System.Drawing.Point(428, 113);
            this.cb_lineaComestible.Name = "cb_lineaComestible";
            this.cb_lineaComestible.Size = new System.Drawing.Size(121, 21);
            this.cb_lineaComestible.TabIndex = 27;
            // 
            // cb_claseComestible
            // 
            this.cb_claseComestible.FormattingEnabled = true;
            this.cb_claseComestible.Items.AddRange(new object[] {
            "Fibra",
            "Grasas",
            "Proteínas",
            "Vitaminas",
            "Minerales",
            "Carbohidratos"});
            this.cb_claseComestible.Location = new System.Drawing.Point(428, 63);
            this.cb_claseComestible.Name = "cb_claseComestible";
            this.cb_claseComestible.Size = new System.Drawing.Size(121, 21);
            this.cb_claseComestible.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Clase de Comestible";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Marca";
            // 
            // cb_marcaComestible
            // 
            this.cb_marcaComestible.FormattingEnabled = true;
            this.cb_marcaComestible.Location = new System.Drawing.Point(428, 19);
            this.cb_marcaComestible.Name = "cb_marcaComestible";
            this.cb_marcaComestible.Size = new System.Drawing.Size(121, 21);
            this.cb_marcaComestible.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Restaurante";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(107, 114);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(160, 20);
            this.txt_cantidad.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Cantidad";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(107, 71);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(160, 20);
            this.txt_nombre.TabIndex = 7;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Location = new System.Drawing.Point(107, 19);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.ReadOnly = true;
            this.txt_codigo.Size = new System.Drawing.Size(160, 20);
            this.txt_codigo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo";
            // 
            // button1
            // 
            this.button1.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.button1.Location = new System.Drawing.Point(351, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 47);
            this.button1.TabIndex = 47;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(288, 287);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(45, 47);
            this.b_aceptar.TabIndex = 49;
            this.b_aceptar.UseVisualStyleBackColor = true;
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // b_limpiar
            // 
            this.b_limpiar.Image = global::Restaurante.Properties.Resources.clean1;
            this.b_limpiar.Location = new System.Drawing.Point(221, 287);
            this.b_limpiar.Name = "b_limpiar";
            this.b_limpiar.Size = new System.Drawing.Size(55, 47);
            this.b_limpiar.TabIndex = 50;
            this.b_limpiar.UseVisualStyleBackColor = true;
            this.b_limpiar.Click += new System.EventHandler(this.b_limpiar_Click);
            // 
            // frm_comestible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(782, 346);
            this.Controls.Add(this.b_limpiar);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_comestible";
            this.Text = "Comestibles";
            this.Load += new System.EventHandler(this.frm_comestible_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_marcaComestible;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_tipoComestible;
        private System.Windows.Forms.ComboBox cb_restaurante;
        private System.Windows.Forms.ComboBox cb_unidadMedida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_lineaComestible;
        private System.Windows.Forms.ComboBox cb_claseComestible;
        private System.Windows.Forms.Button b_limpiar;
    }
}