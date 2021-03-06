﻿namespace Restaurante
{
    partial class frm_marcas
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_foto = new System.Windows.Forms.Button();
            this.cb_nacionalidad = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mtb_Telefono = new System.Windows.Forms.MaskedTextBox();
            this.mtb_CedJuridica = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_detalleEmpresa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nombreEmpresa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.b_borrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.b_foto);
            this.groupBox1.Controls.Add(this.cb_nacionalidad);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_descripcion);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(178, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 394);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de la Marca";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurante.Properties.Resources.no_thumb;
            this.pictureBox1.Location = new System.Drawing.Point(24, 252);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // b_foto
            // 
            this.b_foto.Image = global::Restaurante.Properties.Resources.Camara;
            this.b_foto.Location = new System.Drawing.Point(169, 305);
            this.b_foto.Name = "b_foto";
            this.b_foto.Size = new System.Drawing.Size(75, 64);
            this.b_foto.TabIndex = 27;
            this.b_foto.UseVisualStyleBackColor = true;
            this.b_foto.Click += new System.EventHandler(this.b_foto_Click);
            // 
            // cb_nacionalidad
            // 
            this.cb_nacionalidad.FormattingEnabled = true;
            this.cb_nacionalidad.Location = new System.Drawing.Point(107, 97);
            this.cb_nacionalidad.Name = "cb_nacionalidad";
            this.cb_nacionalidad.Size = new System.Drawing.Size(121, 21);
            this.cb_nacionalidad.TabIndex = 23;
            this.cb_nacionalidad.SelectedIndexChanged += new System.EventHandler(this.cb_nacionalidad_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Foto de la marca";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(107, 138);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(160, 71);
            this.txt_descripcion.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Nacionalidad\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Descripcion";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.mtb_Telefono);
            this.groupBox2.Controls.Add(this.mtb_CedJuridica);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_detalleEmpresa);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_nombreEmpresa);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(467, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 410);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion del contacto";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Restaurante.Properties.Resources.no_thumb;
            this.pictureBox2.Location = new System.Drawing.Point(17, 262);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // mtb_Telefono
            // 
            this.mtb_Telefono.Location = new System.Drawing.Point(121, 196);
            this.mtb_Telefono.Mask = "0000-0000";
            this.mtb_Telefono.Name = "mtb_Telefono";
            this.mtb_Telefono.Size = new System.Drawing.Size(140, 20);
            this.mtb_Telefono.TabIndex = 31;
            // 
            // mtb_CedJuridica
            // 
            this.mtb_CedJuridica.Location = new System.Drawing.Point(121, 26);
            this.mtb_CedJuridica.Mask = "00-0000-000000";
            this.mtb_CedJuridica.Name = "mtb_CedJuridica";
            this.mtb_CedJuridica.Size = new System.Drawing.Size(148, 20);
            this.mtb_CedJuridica.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Telefono";
            // 
            // button1
            // 
            this.button1.Image = global::Restaurante.Properties.Resources.Camara;
            this.button1.Location = new System.Drawing.Point(167, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 64);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Foto de la empresa";
            // 
            // txt_detalleEmpresa
            // 
            this.txt_detalleEmpresa.Location = new System.Drawing.Point(121, 102);
            this.txt_detalleEmpresa.Multiline = true;
            this.txt_detalleEmpresa.Name = "txt_detalleEmpresa";
            this.txt_detalleEmpresa.Size = new System.Drawing.Size(146, 85);
            this.txt_detalleEmpresa.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Detalle de la empresa";
            // 
            // txt_nombreEmpresa
            // 
            this.txt_nombreEmpresa.Location = new System.Drawing.Point(121, 71);
            this.txt_nombreEmpresa.Name = "txt_nombreEmpresa";
            this.txt_nombreEmpresa.Size = new System.Drawing.Size(146, 20);
            this.txt_nombreEmpresa.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nombre de la empresa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cedula Juridica";
            // 
            // b_cancelar
            // 
            this.b_cancelar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cancelar.Location = new System.Drawing.Point(393, 441);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(52, 47);
            this.b_cancelar.TabIndex = 26;
            this.b_cancelar.UseVisualStyleBackColor = true;
            this.b_cancelar.Click += new System.EventHandler(this.b_cancelar_Click);
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(309, 441);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(52, 47);
            this.b_aceptar.TabIndex = 25;
            this.b_aceptar.UseVisualStyleBackColor = true;
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // b_borrar
            // 
            this.b_borrar.Image = global::Restaurante.Properties.Resources.Eliminar12;
            this.b_borrar.Location = new System.Drawing.Point(241, 441);
            this.b_borrar.Name = "b_borrar";
            this.b_borrar.Size = new System.Drawing.Size(52, 47);
            this.b_borrar.TabIndex = 24;
            this.b_borrar.UseVisualStyleBackColor = true;
            this.b_borrar.Click += new System.EventHandler(this.b_borrar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Image = global::Restaurante.Properties.Resources.Rubros1;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 501);
            this.label1.TabIndex = 0;
            // 
            // frm_marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(757, 500);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.b_cancelar);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.b_borrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_marcas";
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.frm_marcas_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_nacionalidad;
        private System.Windows.Forms.Button b_borrar;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.Button b_foto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_detalleEmpresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nombreEmpresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtb_Telefono;
        private System.Windows.Forms.MaskedTextBox mtb_CedJuridica;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}