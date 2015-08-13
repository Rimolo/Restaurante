namespace Restaurante
{
    partial class frmLicores
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
            this.txt_precioBot = new System.Windows.Forms.TextBox();
            this.chk_precioBotella = new System.Windows.Forms.CheckBox();
            this.chk_precioUnitario = new System.Windows.Forms.CheckBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_restaurante = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_nacionalidad = new System.Windows.Forms.ComboBox();
            this.cb_marca = new System.Windows.Forms.ComboBox();
            this.txt_precioUni = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.b_foto = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.b_borrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pb_foto);
            this.groupBox1.Controls.Add(this.txt_precioBot);
            this.groupBox1.Controls.Add(this.chk_precioBotella);
            this.groupBox1.Controls.Add(this.chk_precioUnitario);
            this.groupBox1.Controls.Add(this.txt_cantidad);
            this.groupBox1.Controls.Add(this.txt_restaurante);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cb_nacionalidad);
            this.groupBox1.Controls.Add(this.cb_marca);
            this.groupBox1.Controls.Add(this.b_foto);
            this.groupBox1.Controls.Add(this.b_cancelar);
            this.groupBox1.Controls.Add(this.b_aceptar);
            this.groupBox1.Controls.Add(this.b_borrar);
            this.groupBox1.Controls.Add(this.txt_precioUni);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.txt_descripcion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(223, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 321);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de la bebida";
            // 
            // txt_precioBot
            // 
            this.txt_precioBot.Enabled = false;
            this.txt_precioBot.Location = new System.Drawing.Point(104, 209);
            this.txt_precioBot.Name = "txt_precioBot";
            this.txt_precioBot.Size = new System.Drawing.Size(100, 20);
            this.txt_precioBot.TabIndex = 26;
            // 
            // chk_precioBotella
            // 
            this.chk_precioBotella.AutoSize = true;
            this.chk_precioBotella.Location = new System.Drawing.Point(3, 212);
            this.chk_precioBotella.Name = "chk_precioBotella";
            this.chk_precioBotella.Size = new System.Drawing.Size(91, 17);
            this.chk_precioBotella.TabIndex = 25;
            this.chk_precioBotella.Text = "Precio Botella";
            this.chk_precioBotella.UseVisualStyleBackColor = true;
            this.chk_precioBotella.CheckedChanged += new System.EventHandler(this.chk_precioBotella_CheckedChanged);
            // 
            // chk_precioUnitario
            // 
            this.chk_precioUnitario.AutoSize = true;
            this.chk_precioUnitario.Location = new System.Drawing.Point(3, 176);
            this.chk_precioUnitario.Name = "chk_precioUnitario";
            this.chk_precioUnitario.Size = new System.Drawing.Size(95, 17);
            this.chk_precioUnitario.TabIndex = 24;
            this.chk_precioUnitario.Text = "Precio Unitario";
            this.chk_precioUnitario.UseVisualStyleBackColor = true;
            this.chk_precioUnitario.CheckedChanged += new System.EventHandler(this.chk_precioUnitario_CheckedChanged);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(330, 53);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(131, 20);
            this.txt_cantidad.TabIndex = 23;
            // 
            // txt_restaurante
            // 
            this.txt_restaurante.Enabled = false;
            this.txt_restaurante.Location = new System.Drawing.Point(330, 24);
            this.txt_restaurante.Name = "txt_restaurante";
            this.txt_restaurante.ReadOnly = true;
            this.txt_restaurante.Size = new System.Drawing.Size(131, 20);
            this.txt_restaurante.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(257, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Cantidad\r\n";
            // 
            // cb_nacionalidad
            // 
            this.cb_nacionalidad.FormattingEnabled = true;
            this.cb_nacionalidad.Location = new System.Drawing.Point(77, 131);
            this.cb_nacionalidad.Name = "cb_nacionalidad";
            this.cb_nacionalidad.Size = new System.Drawing.Size(100, 21);
            this.cb_nacionalidad.TabIndex = 19;
            // 
            // cb_marca
            // 
            this.cb_marca.FormattingEnabled = true;
            this.cb_marca.Location = new System.Drawing.Point(77, 93);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(100, 21);
            this.cb_marca.TabIndex = 18;
            // 
            // txt_precioUni
            // 
            this.txt_precioUni.Enabled = false;
            this.txt_precioUni.Location = new System.Drawing.Point(104, 176);
            this.txt_precioUni.Name = "txt_precioUni";
            this.txt_precioUni.Size = new System.Drawing.Size(100, 20);
            this.txt_precioUni.TabIndex = 12;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(77, 56);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 10;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Location = new System.Drawing.Point(77, 24);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.ReadOnly = true;
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 9;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(330, 90);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(152, 62);
            this.txt_descripcion.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Foto de la bebida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Descripcion\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Restaurante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nacionalidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Image = global::Restaurante.Properties.Resources.martini__glass;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 341);
            this.label1.TabIndex = 4;
            // 
            // pb_foto
            // 
            this.pb_foto.Image = global::Restaurante.Properties.Resources.no_thumb;
            this.pb_foto.Location = new System.Drawing.Point(351, 176);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(131, 119);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foto.TabIndex = 27;
            this.pb_foto.TabStop = false;
            // 
            // b_foto
            // 
            this.b_foto.Image = global::Restaurante.Properties.Resources.Camara;
            this.b_foto.Location = new System.Drawing.Point(229, 245);
            this.b_foto.Name = "b_foto";
            this.b_foto.Size = new System.Drawing.Size(75, 64);
            this.b_foto.TabIndex = 17;
            this.b_foto.UseVisualStyleBackColor = true;
            this.b_foto.Click += new System.EventHandler(this.b_foto_Click);
            // 
            // b_cancelar
            // 
            this.b_cancelar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cancelar.Location = new System.Drawing.Point(156, 262);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(52, 47);
            this.b_cancelar.TabIndex = 16;
            this.b_cancelar.UseVisualStyleBackColor = true;
            this.b_cancelar.Click += new System.EventHandler(this.b_cancelar_Click);
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(81, 262);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(52, 47);
            this.b_aceptar.TabIndex = 15;
            this.b_aceptar.UseVisualStyleBackColor = true;
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // b_borrar
            // 
            this.b_borrar.Image = global::Restaurante.Properties.Resources.Eliminar12;
            this.b_borrar.Location = new System.Drawing.Point(12, 262);
            this.b_borrar.Name = "b_borrar";
            this.b_borrar.Size = new System.Drawing.Size(52, 47);
            this.b_borrar.TabIndex = 14;
            this.b_borrar.UseVisualStyleBackColor = true;
            this.b_borrar.Click += new System.EventHandler(this.b_borrar_Click);
            // 
            // frmLicores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(759, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLicores";
            this.Text = "Licores";
            this.Load += new System.EventHandler(this.frmLicores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_restaurante;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_nacionalidad;
        private System.Windows.Forms.ComboBox cb_marca;
        private System.Windows.Forms.Button b_foto;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Button b_borrar;
        private System.Windows.Forms.TextBox txt_precioUni;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_precioBotella;
        private System.Windows.Forms.CheckBox chk_precioUnitario;
        private System.Windows.Forms.TextBox txt_precioBot;
        private System.Windows.Forms.PictureBox pb_foto;
    }
}