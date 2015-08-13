namespace Restaurante
{
    partial class frm_comidaBuffet
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
            this.cbo_unidadMedida = new System.Windows.Forms.ComboBox();
            this.cbo_tipoBuffet = new System.Windows.Forms.ComboBox();
            this.txt_precioBuffet = new System.Windows.Forms.TextBox();
            this.txt_nombreBuffet = new System.Windows.Forms.TextBox();
            this.txt_codigoBuffet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.b_buscaFoto = new System.Windows.Forms.Button();
            this.b_borrar = new System.Windows.Forms.Button();
            this.pic_foto = new System.Windows.Forms.PictureBox();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_unidadMedida);
            this.groupBox1.Controls.Add(this.cbo_tipoBuffet);
            this.groupBox1.Controls.Add(this.txt_precioBuffet);
            this.groupBox1.Controls.Add(this.txt_nombreBuffet);
            this.groupBox1.Controls.Add(this.txt_codigoBuffet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(147, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de la comida tipo buffet";
            // 
            // cbo_unidadMedida
            // 
            this.cbo_unidadMedida.FormattingEnabled = true;
            this.cbo_unidadMedida.Items.AddRange(new object[] {
            "Capacidad ",
            "Densidad ",
            "Energía ",
            "Fuerza ",
            "Longitud",
            "Masa ",
            "Peso ",
            " Potencia ",
            "Superficie ",
            "Temperatura ",
            "Tiempo ",
            "Velocidad "});
            this.cbo_unidadMedida.Location = new System.Drawing.Point(97, 138);
            this.cbo_unidadMedida.Name = "cbo_unidadMedida";
            this.cbo_unidadMedida.Size = new System.Drawing.Size(121, 21);
            this.cbo_unidadMedida.TabIndex = 10;
            // 
            // cbo_tipoBuffet
            // 
            this.cbo_tipoBuffet.FormattingEnabled = true;
            this.cbo_tipoBuffet.Items.AddRange(new object[] {
            "Marina",
            "Vegetal",
            "Frutas",
            "Comida Mediterráne"});
            this.cbo_tipoBuffet.Location = new System.Drawing.Point(72, 108);
            this.cbo_tipoBuffet.Name = "cbo_tipoBuffet";
            this.cbo_tipoBuffet.Size = new System.Drawing.Size(146, 21);
            this.cbo_tipoBuffet.TabIndex = 9;
            // 
            // txt_precioBuffet
            // 
            this.txt_precioBuffet.Location = new System.Drawing.Point(72, 78);
            this.txt_precioBuffet.Name = "txt_precioBuffet";
            this.txt_precioBuffet.Size = new System.Drawing.Size(146, 20);
            this.txt_precioBuffet.TabIndex = 8;
            // 
            // txt_nombreBuffet
            // 
            this.txt_nombreBuffet.Location = new System.Drawing.Point(72, 45);
            this.txt_nombreBuffet.Name = "txt_nombreBuffet";
            this.txt_nombreBuffet.Size = new System.Drawing.Size(146, 20);
            this.txt_nombreBuffet.TabIndex = 7;
            // 
            // txt_codigoBuffet
            // 
            this.txt_codigoBuffet.Enabled = false;
            this.txt_codigoBuffet.Location = new System.Drawing.Point(72, 16);
            this.txt_codigoBuffet.Name = "txt_codigoBuffet";
            this.txt_codigoBuffet.ReadOnly = true;
            this.txt_codigoBuffet.Size = new System.Drawing.Size(146, 20);
            this.txt_codigoBuffet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Unidad de Medida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Foto del Platillo";
            // 
            // b_buscaFoto
            // 
            this.b_buscaFoto.Image = global::Restaurante.Properties.Resources._40px_Examine_copyright_icon;
            this.b_buscaFoto.Location = new System.Drawing.Point(365, 205);
            this.b_buscaFoto.Name = "b_buscaFoto";
            this.b_buscaFoto.Size = new System.Drawing.Size(49, 44);
            this.b_buscaFoto.TabIndex = 80;
            this.b_buscaFoto.UseVisualStyleBackColor = true;
            this.b_buscaFoto.Click += new System.EventHandler(this.b_buscaFoto_Click);
            // 
            // b_borrar
            // 
            this.b_borrar.Image = global::Restaurante.Properties.Resources.clean1;
            this.b_borrar.Location = new System.Drawing.Point(156, 202);
            this.b_borrar.Name = "b_borrar";
            this.b_borrar.Size = new System.Drawing.Size(56, 47);
            this.b_borrar.TabIndex = 70;
            this.b_borrar.UseVisualStyleBackColor = true;
            this.b_borrar.Click += new System.EventHandler(this.b_borrar_Click);
            // 
            // pic_foto
            // 
            this.pic_foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_foto.Image = global::Restaurante.Properties.Resources.no_thumb;
            this.pic_foto.Location = new System.Drawing.Point(392, 61);
            this.pic_foto.Name = "pic_foto";
            this.pic_foto.Size = new System.Drawing.Size(110, 110);
            this.pic_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_foto.TabIndex = 8;
            this.pic_foto.TabStop = false;
            // 
            // b_cancelar
            // 
            this.b_cancelar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cancelar.Location = new System.Drawing.Point(296, 202);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(52, 47);
            this.b_cancelar.TabIndex = 6;
            this.b_cancelar.UseVisualStyleBackColor = true;
            this.b_cancelar.Click += new System.EventHandler(this.b_cancelar_Click);
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(228, 202);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(52, 47);
            this.b_aceptar.TabIndex = 4;
            this.b_aceptar.UseVisualStyleBackColor = true;
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 262);
            this.panel1.TabIndex = 81;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurante.Properties.Resources._110_F_26375790_DzvzkfzvicMOdvwoHEpNppbiv4TiQ0yU;
            this.pictureBox1.Location = new System.Drawing.Point(21, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 107);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_comidaBuffet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(514, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.b_buscaFoto);
            this.Controls.Add(this.b_borrar);
            this.Controls.Add(this.pic_foto);
            this.Controls.Add(this.b_cancelar);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_comidaBuffet";
            this.Text = "Comida Buffet";
            this.Load += new System.EventHandler(this.frm_comidaBuffet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_tipoBuffet;
        private System.Windows.Forms.TextBox txt_precioBuffet;
        private System.Windows.Forms.TextBox txt_nombreBuffet;
        private System.Windows.Forms.TextBox txt_codigoBuffet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_unidadMedida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.PictureBox pic_foto;
        private System.Windows.Forms.Button b_borrar;
        private System.Windows.Forms.Button b_buscaFoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}