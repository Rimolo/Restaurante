namespace Restaurante
{
    partial class frm_especiales
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
            this.label7 = new System.Windows.Forms.Label();
            this.b_foto = new System.Windows.Forms.Button();
            this.b_borrar = new System.Windows.Forms.Button();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_detalle = new System.Windows.Forms.TextBox();
            this.txt_ingredientes = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Image = global::Restaurante.Properties.Resources.Menu_food;
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 368);
            this.label1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Foto del Especial";
            // 
            // b_foto
            // 
            this.b_foto.Image = global::Restaurante.Properties.Resources.Camara;
            this.b_foto.Location = new System.Drawing.Point(497, 214);
            this.b_foto.Name = "b_foto";
            this.b_foto.Size = new System.Drawing.Size(75, 64);
            this.b_foto.TabIndex = 10;
            this.b_foto.UseVisualStyleBackColor = true;
            this.b_foto.Click += new System.EventHandler(this.b_foto_Click);
            // 
            // b_borrar
            // 
            this.b_borrar.Image = global::Restaurante.Properties.Resources.Eliminar12;
            this.b_borrar.Location = new System.Drawing.Point(191, 304);
            this.b_borrar.Name = "b_borrar";
            this.b_borrar.Size = new System.Drawing.Size(52, 47);
            this.b_borrar.TabIndex = 11;
            this.b_borrar.UseVisualStyleBackColor = true;
            this.b_borrar.Click += new System.EventHandler(this.b_borrar_Click);
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(260, 304);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(52, 47);
            this.b_aceptar.TabIndex = 12;
            this.b_aceptar.UseVisualStyleBackColor = true;
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // b_cancelar
            // 
            this.b_cancelar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cancelar.Location = new System.Drawing.Point(329, 304);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(52, 47);
            this.b_cancelar.TabIndex = 13;
            this.b_cancelar.UseVisualStyleBackColor = true;
            this.b_cancelar.Click += new System.EventHandler(this.b_cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_detalle);
            this.groupBox1.Controls.Add(this.txt_ingredientes);
            this.groupBox1.Controls.Add(this.txt_precio);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(169, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 286);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de la Especialidad";
            // 
            // txt_detalle
            // 
            this.txt_detalle.Location = new System.Drawing.Point(66, 214);
            this.txt_detalle.Multiline = true;
            this.txt_detalle.Name = "txt_detalle";
            this.txt_detalle.Size = new System.Drawing.Size(166, 66);
            this.txt_detalle.TabIndex = 10;
            // 
            // txt_ingredientes
            // 
            this.txt_ingredientes.Location = new System.Drawing.Point(72, 81);
            this.txt_ingredientes.Multiline = true;
            this.txt_ingredientes.Name = "txt_ingredientes";
            this.txt_ingredientes.Size = new System.Drawing.Size(160, 59);
            this.txt_ingredientes.TabIndex = 9;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(66, 163);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(166, 20);
            this.txt_precio.TabIndex = 8;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(72, 48);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(160, 20);
            this.txt_nombre.TabIndex = 7;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Location = new System.Drawing.Point(72, 16);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.ReadOnly = true;
            this.txt_codigo.Size = new System.Drawing.Size(160, 20);
            this.txt_codigo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Detalle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingredientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 48);
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
            // pb_foto
            // 
            this.pb_foto.Location = new System.Drawing.Point(470, 61);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(123, 127);
            this.pb_foto.TabIndex = 15;
            this.pb_foto.TabStop = false;
            // 
            // frm_especiales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(605, 363);
            this.Controls.Add(this.pb_foto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b_cancelar);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.b_borrar);
            this.Controls.Add(this.b_foto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "frm_especiales";
            this.Text = "Especiales";
            this.Load += new System.EventHandler(this.frm_especiales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button b_foto;
        private System.Windows.Forms.Button b_borrar;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_detalle;
        private System.Windows.Forms.TextBox txt_ingredientes;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_foto;
    }
}