namespace Restaurante
{
    partial class frm_unidadesMedida
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
            this.cb_detalle = new System.Windows.Forms.ComboBox();
            this.cb_escala = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_simbologia = new System.Windows.Forms.TextBox();
            this.txt_simbolo = new System.Windows.Forms.TextBox();
            this.txt_unidad = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.b_borrar = new System.Windows.Forms.Button();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.b_cerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_detalle);
            this.groupBox1.Controls.Add(this.cb_escala);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_simbologia);
            this.groupBox1.Controls.Add(this.txt_simbolo);
            this.groupBox1.Controls.Add(this.txt_unidad);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(212, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de Unidades de Medida";
            // 
            // cb_detalle
            // 
            this.cb_detalle.Enabled = false;
            this.cb_detalle.FormattingEnabled = true;
            this.cb_detalle.Items.AddRange(new object[] {
            "Unidades de capacidad",
            "Unidades de densidad",
            "Unidades de energía",
            "Unidades de fuerza",
            "Unidades de longitud",
            "Unidades de masa",
            "Unidades de peso específico",
            "Unidades de potencia",
            "Unidades de superficie",
            "Unidades de temperatura",
            "Unidades de tiempo",
            "Unidades de velocidad ",
            "Unidades de viscosidad",
            "Unidades de volumen",
            "Unidades eléctricas"});
            this.cb_detalle.Location = new System.Drawing.Point(83, 139);
            this.cb_detalle.Name = "cb_detalle";
            this.cb_detalle.Size = new System.Drawing.Size(177, 21);
            this.cb_detalle.TabIndex = 11;
            this.cb_detalle.SelectedIndexChanged += new System.EventHandler(this.cb_detalle_SelectedIndexChanged);
            // 
            // cb_escala
            // 
            this.cb_escala.FormattingEnabled = true;
            this.cb_escala.Items.AddRange(new object[] {
            "UNIDAD",
            "yotta",
            "zetta",
            "exa",
            "peta",
            "tera",
            "giga",
            "mega",
            "kilo",
            "hecto",
            "deca",
            "deci",
            "centi",
            "mili",
            "micro",
            "nano",
            "pico",
            "femto",
            "atto",
            "zepto",
            "yocto"});
            this.cb_escala.Location = new System.Drawing.Point(83, 108);
            this.cb_escala.Name = "cb_escala";
            this.cb_escala.Size = new System.Drawing.Size(177, 21);
            this.cb_escala.TabIndex = 10;
            this.cb_escala.SelectedIndexChanged += new System.EventHandler(this.cb_escala_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Simbologia";
            // 
            // txt_simbologia
            // 
            this.txt_simbologia.Enabled = false;
            this.txt_simbologia.Location = new System.Drawing.Point(348, 160);
            this.txt_simbologia.Name = "txt_simbologia";
            this.txt_simbologia.Size = new System.Drawing.Size(127, 20);
            this.txt_simbologia.TabIndex = 8;
            // 
            // txt_simbolo
            // 
            this.txt_simbolo.Enabled = false;
            this.txt_simbolo.Location = new System.Drawing.Point(348, 131);
            this.txt_simbolo.Name = "txt_simbolo";
            this.txt_simbolo.Size = new System.Drawing.Size(127, 20);
            this.txt_simbolo.TabIndex = 7;
            // 
            // txt_unidad
            // 
            this.txt_unidad.Location = new System.Drawing.Point(84, 65);
            this.txt_unidad.Name = "txt_unidad";
            this.txt_unidad.Size = new System.Drawing.Size(127, 20);
            this.txt_unidad.TabIndex = 6;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Location = new System.Drawing.Point(84, 29);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(127, 20);
            this.txt_codigo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Simbolo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Detalle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Escala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 267);
            this.panel1.TabIndex = 80;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Restaurante.Properties.Resources._1e6e753;
            this.pictureBox2.Location = new System.Drawing.Point(3, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 206);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // b_borrar
            // 
            this.b_borrar.Image = global::Restaurante.Properties.Resources.clean1;
            this.b_borrar.Location = new System.Drawing.Point(222, 208);
            this.b_borrar.Name = "b_borrar";
            this.b_borrar.Size = new System.Drawing.Size(39, 47);
            this.b_borrar.TabIndex = 81;
            this.b_borrar.UseVisualStyleBackColor = true;
            this.b_borrar.Click += new System.EventHandler(this.b_borrar_Click);
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(277, 208);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(42, 47);
            this.b_aceptar.TabIndex = 82;
            this.b_aceptar.UseVisualStyleBackColor = true;
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // b_cerrar
            // 
            this.b_cerrar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cerrar.Location = new System.Drawing.Point(334, 208);
            this.b_cerrar.Name = "b_cerrar";
            this.b_cerrar.Size = new System.Drawing.Size(42, 47);
            this.b_cerrar.TabIndex = 83;
            this.b_cerrar.UseVisualStyleBackColor = true;
            this.b_cerrar.Click += new System.EventHandler(this.b_cerrar_Click);
            // 
            // frm_unidadesMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(705, 267);
            this.Controls.Add(this.b_cerrar);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.b_borrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_unidadesMedida";
            this.Text = "Unidades de Medida";
            this.Load += new System.EventHandler(this.frm_unidadesMedida_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cb_detalle;
        private System.Windows.Forms.ComboBox cb_escala;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_simbologia;
        private System.Windows.Forms.TextBox txt_simbolo;
        private System.Windows.Forms.TextBox txt_unidad;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Button b_borrar;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Button b_cerrar;
    }
}