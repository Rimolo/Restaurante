namespace Restaurante
{
    partial class frm_proveedores
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
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.mtb_cedula = new System.Windows.Forms.MaskedTextBox();
            this.pic_foto = new System.Windows.Forms.PictureBox();
            this.b_borrar = new System.Windows.Forms.Button();
            this.b_buscaFoto = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.b_asigna = new System.Windows.Forms.Button();
            this.b_remueve = new System.Windows.Forms.Button();
            this.lst_productosProveedor = new System.Windows.Forms.ListBox();
            this.lst_productosRestaurante = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mtb_telefono = new System.Windows.Forms.MaskedTextBox();
            this.txt_direccionContacto = new System.Windows.Forms.TextBox();
            this.txt_nombreContacto = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.b_cerrar = new System.Windows.Forms.Button();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_apellido2 = new System.Windows.Forms.TextBox();
            this.txt_apellido1 = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtb_celular = new System.Windows.Forms.MaskedTextBox();
            this.mtb_fax = new System.Windows.Forms.MaskedTextBox();
            this.mtb_oficina = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_fecha);
            this.groupBox1.Controls.Add(this.mtb_cedula);
            this.groupBox1.Controls.Add(this.pic_foto);
            this.groupBox1.Controls.Add(this.b_borrar);
            this.groupBox1.Controls.Add(this.b_buscaFoto);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.b_cerrar);
            this.groupBox1.Controls.Add(this.b_aceptar);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_direccion);
            this.groupBox1.Controls.Add(this.txt_correo);
            this.groupBox1.Controls.Add(this.txt_apellido2);
            this.groupBox1.Controls.Add(this.txt_apellido1);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(173, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 462);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del Proveedor";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.CustomFormat = "dd/MM/yyyy";
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha.Location = new System.Drawing.Point(108, 115);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(157, 20);
            this.dtp_fecha.TabIndex = 74;
            // 
            // mtb_cedula
            // 
            this.mtb_cedula.Location = new System.Drawing.Point(107, 70);
            this.mtb_cedula.Mask = "00-000-0000";
            this.mtb_cedula.Name = "mtb_cedula";
            this.mtb_cedula.Size = new System.Drawing.Size(158, 20);
            this.mtb_cedula.TabIndex = 73;
            // 
            // pic_foto
            // 
            this.pic_foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_foto.Image = global::Restaurante.Properties.Resources.no_user_image_square_75d7df79d3f093e0805d3d40d16ce31d;
            this.pic_foto.Location = new System.Drawing.Point(278, 62);
            this.pic_foto.Name = "pic_foto";
            this.pic_foto.Size = new System.Drawing.Size(133, 127);
            this.pic_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_foto.TabIndex = 72;
            this.pic_foto.TabStop = false;
            // 
            // b_borrar
            // 
            this.b_borrar.Image = global::Restaurante.Properties.Resources.clean;
            this.b_borrar.Location = new System.Drawing.Point(225, 409);
            this.b_borrar.Name = "b_borrar";
            this.b_borrar.Size = new System.Drawing.Size(46, 45);
            this.b_borrar.TabIndex = 71;
            this.b_borrar.UseVisualStyleBackColor = true;
            this.b_borrar.Click += new System.EventHandler(this.b_borrar_Click);
            // 
            // b_buscaFoto
            // 
            this.b_buscaFoto.Image = global::Restaurante.Properties.Resources._40px_Examine_copyright_icon;
            this.b_buscaFoto.Location = new System.Drawing.Point(382, 409);
            this.b_buscaFoto.Name = "b_buscaFoto";
            this.b_buscaFoto.Size = new System.Drawing.Size(43, 44);
            this.b_buscaFoto.TabIndex = 70;
            this.b_buscaFoto.UseVisualStyleBackColor = true;
            this.b_buscaFoto.Click += new System.EventHandler(this.b_buscaFoto_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.b_asigna);
            this.groupBox4.Controls.Add(this.b_remueve);
            this.groupBox4.Controls.Add(this.lst_productosProveedor);
            this.groupBox4.Controls.Add(this.lst_productosRestaurante);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Location = new System.Drawing.Point(431, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(339, 302);
            this.groupBox4.TabIndex = 69;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pase de Productos";
            // 
            // b_asigna
            // 
            this.b_asigna.Image = global::Restaurante.Properties.Resources.flecha;
            this.b_asigna.Location = new System.Drawing.Point(142, 78);
            this.b_asigna.Name = "b_asigna";
            this.b_asigna.Size = new System.Drawing.Size(52, 40);
            this.b_asigna.TabIndex = 5;
            this.b_asigna.UseVisualStyleBackColor = true;
            this.b_asigna.Click += new System.EventHandler(this.b_asigna_Click);
            // 
            // b_remueve
            // 
            this.b_remueve.Image = global::Restaurante.Properties.Resources.izquierda;
            this.b_remueve.Location = new System.Drawing.Point(142, 130);
            this.b_remueve.Name = "b_remueve";
            this.b_remueve.Size = new System.Drawing.Size(52, 40);
            this.b_remueve.TabIndex = 4;
            this.b_remueve.UseVisualStyleBackColor = true;
            this.b_remueve.Click += new System.EventHandler(this.b_remueve_Click);
            // 
            // lst_productosProveedor
            // 
            this.lst_productosProveedor.FormattingEnabled = true;
            this.lst_productosProveedor.Location = new System.Drawing.Point(201, 36);
            this.lst_productosProveedor.Name = "lst_productosProveedor";
            this.lst_productosProveedor.Size = new System.Drawing.Size(132, 212);
            this.lst_productosProveedor.TabIndex = 3;
            // 
            // lst_productosRestaurante
            // 
            this.lst_productosRestaurante.FormattingEnabled = true;
            this.lst_productosRestaurante.Location = new System.Drawing.Point(13, 43);
            this.lst_productosRestaurante.Name = "lst_productosRestaurante";
            this.lst_productosRestaurante.Size = new System.Drawing.Size(126, 212);
            this.lst_productosRestaurante.TabIndex = 2;
            this.lst_productosRestaurante.SelectedIndexChanged += new System.EventHandler(this.lst_productosRestaurante_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(146, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(190, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Productos Manejados por el proveedor";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Productos del Restaurante";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mtb_telefono);
            this.groupBox3.Controls.Add(this.txt_direccionContacto);
            this.groupBox3.Controls.Add(this.txt_nombreContacto);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(453, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 114);
            this.groupBox3.TabIndex = 68;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion del Contacto";
            // 
            // mtb_telefono
            // 
            this.mtb_telefono.Location = new System.Drawing.Point(121, 50);
            this.mtb_telefono.Mask = "0000-0000";
            this.mtb_telefono.Name = "mtb_telefono";
            this.mtb_telefono.Size = new System.Drawing.Size(116, 20);
            this.mtb_telefono.TabIndex = 5;
            // 
            // txt_direccionContacto
            // 
            this.txt_direccionContacto.Location = new System.Drawing.Point(121, 88);
            this.txt_direccionContacto.Name = "txt_direccionContacto";
            this.txt_direccionContacto.Size = new System.Drawing.Size(151, 20);
            this.txt_direccionContacto.TabIndex = 4;
            // 
            // txt_nombreContacto
            // 
            this.txt_nombreContacto.Location = new System.Drawing.Point(121, 12);
            this.txt_nombreContacto.Name = "txt_nombreContacto";
            this.txt_nombreContacto.Size = new System.Drawing.Size(151, 20);
            this.txt_nombreContacto.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Direccion";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Telefono";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Nombre del Contacto";
            // 
            // b_cerrar
            // 
            this.b_cerrar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cerrar.Location = new System.Drawing.Point(334, 409);
            this.b_cerrar.Name = "b_cerrar";
            this.b_cerrar.Size = new System.Drawing.Size(42, 44);
            this.b_cerrar.TabIndex = 67;
            this.b_cerrar.UseVisualStyleBackColor = true;
            this.b_cerrar.Click += new System.EventHandler(this.b_cerrar_Click);
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(277, 409);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(43, 45);
            this.b_aceptar.TabIndex = 66;
            this.b_aceptar.UseVisualStyleBackColor = true;
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(308, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Foto del Proveedor";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(107, 308);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(289, 20);
            this.txt_direccion.TabIndex = 16;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(107, 268);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(289, 20);
            this.txt_correo.TabIndex = 15;
            // 
            // txt_apellido2
            // 
            this.txt_apellido2.Location = new System.Drawing.Point(108, 234);
            this.txt_apellido2.Name = "txt_apellido2";
            this.txt_apellido2.Size = new System.Drawing.Size(157, 20);
            this.txt_apellido2.TabIndex = 14;
            // 
            // txt_apellido1
            // 
            this.txt_apellido1.Location = new System.Drawing.Point(107, 197);
            this.txt_apellido1.Name = "txt_apellido1";
            this.txt_apellido1.Size = new System.Drawing.Size(158, 20);
            this.txt_apellido1.TabIndex = 13;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(107, 159);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(158, 20);
            this.txt_nombre.TabIndex = 12;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Location = new System.Drawing.Point(107, 32);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.ReadOnly = true;
            this.txt_codigo.Size = new System.Drawing.Size(158, 20);
            this.txt_codigo.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Direccion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Correo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Cedula";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Primer Apellido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Segundo Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Fecha de ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre Proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Codigo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtb_celular);
            this.groupBox2.Controls.Add(this.mtb_fax);
            this.groupBox2.Controls.Add(this.mtb_oficina);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 52);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Telefonos";
            // 
            // mtb_celular
            // 
            this.mtb_celular.Location = new System.Drawing.Point(328, 26);
            this.mtb_celular.Mask = "0000-0000";
            this.mtb_celular.Name = "mtb_celular";
            this.mtb_celular.Size = new System.Drawing.Size(100, 20);
            this.mtb_celular.TabIndex = 63;
            // 
            // mtb_fax
            // 
            this.mtb_fax.Location = new System.Drawing.Point(182, 28);
            this.mtb_fax.Mask = "0000-0000";
            this.mtb_fax.Name = "mtb_fax";
            this.mtb_fax.Size = new System.Drawing.Size(100, 20);
            this.mtb_fax.TabIndex = 62;
            // 
            // mtb_oficina
            // 
            this.mtb_oficina.Location = new System.Drawing.Point(46, 26);
            this.mtb_oficina.Mask = "0000-0000";
            this.mtb_oficina.Name = "mtb_oficina";
            this.mtb_oficina.Size = new System.Drawing.Size(100, 20);
            this.mtb_oficina.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Celular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Fax";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Oficina";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 487);
            this.panel1.TabIndex = 59;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurante.Properties.Resources.users1;
            this.pictureBox1.Location = new System.Drawing.Point(20, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 148);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(961, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_proveedores";
            this.Text = "frm_proveedores";
            this.Load += new System.EventHandler(this.frm_proveedores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_apellido2;
        private System.Windows.Forms.TextBox txt_apellido1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Button b_cerrar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button b_buscaFoto;
        private System.Windows.Forms.Button b_borrar;
        private System.Windows.Forms.PictureBox pic_foto;
        private System.Windows.Forms.MaskedTextBox mtb_celular;
        private System.Windows.Forms.MaskedTextBox mtb_fax;
        private System.Windows.Forms.MaskedTextBox mtb_oficina;
        private System.Windows.Forms.MaskedTextBox mtb_cedula;
        private System.Windows.Forms.Button b_asigna;
        private System.Windows.Forms.Button b_remueve;
        private System.Windows.Forms.ListBox lst_productosProveedor;
        private System.Windows.Forms.ListBox lst_productosRestaurante;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox mtb_telefono;
        private System.Windows.Forms.TextBox txt_direccionContacto;
        private System.Windows.Forms.TextBox txt_nombreContacto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
    }
}