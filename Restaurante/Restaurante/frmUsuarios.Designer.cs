namespace Restaurante
{
    partial class frmUsuarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_cambiarContraseña = new System.Windows.Forms.CheckBox();
            this.msk_telefonocelular = new System.Windows.Forms.MaskedTextBox();
            this.msk_telfFijo = new System.Windows.Forms.MaskedTextBox();
            this.txt_apellido2 = new System.Windows.Forms.TextBox();
            this.txt_apellido1 = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_confirmarContraseña = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_administradorCuentas = new System.Windows.Forms.CheckBox();
            this.chk_administradorRestaurante = new System.Windows.Forms.CheckBox();
            this.chk_administradorSeguridad = new System.Windows.Forms.CheckBox();
            this.chk_administradorSistema = new System.Windows.Forms.CheckBox();
            this.b_cambioContraseña = new System.Windows.Forms.Button();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.b_cerrar = new System.Windows.Forms.Button();
            this.b_borrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 400);
            this.panel1.TabIndex = 62;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurante.Properties.Resources.User_female;
            this.pictureBox1.Location = new System.Drawing.Point(24, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 164);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_cambiarContraseña);
            this.groupBox1.Controls.Add(this.msk_telefonocelular);
            this.groupBox1.Controls.Add(this.msk_telfFijo);
            this.groupBox1.Controls.Add(this.txt_apellido2);
            this.groupBox1.Controls.Add(this.txt_apellido1);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(172, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 326);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales del usuario";
            // 
            // chk_cambiarContraseña
            // 
            this.chk_cambiarContraseña.AutoSize = true;
            this.chk_cambiarContraseña.Location = new System.Drawing.Point(261, 177);
            this.chk_cambiarContraseña.Name = "chk_cambiarContraseña";
            this.chk_cambiarContraseña.Size = new System.Drawing.Size(121, 17);
            this.chk_cambiarContraseña.TabIndex = 14;
            this.chk_cambiarContraseña.Text = "Cambiar Contraseña";
            this.chk_cambiarContraseña.UseVisualStyleBackColor = true;
            // 
            // msk_telefonocelular
            // 
            this.msk_telefonocelular.Location = new System.Drawing.Point(100, 200);
            this.msk_telefonocelular.Mask = "0000-0000";
            this.msk_telefonocelular.Name = "msk_telefonocelular";
            this.msk_telefonocelular.Size = new System.Drawing.Size(138, 20);
            this.msk_telefonocelular.TabIndex = 13;
            // 
            // msk_telfFijo
            // 
            this.msk_telfFijo.Location = new System.Drawing.Point(100, 164);
            this.msk_telfFijo.Mask = "0000-0000";
            this.msk_telfFijo.Name = "msk_telfFijo";
            this.msk_telfFijo.Size = new System.Drawing.Size(138, 20);
            this.msk_telfFijo.TabIndex = 12;
            // 
            // txt_apellido2
            // 
            this.txt_apellido2.Location = new System.Drawing.Point(100, 126);
            this.txt_apellido2.Name = "txt_apellido2";
            this.txt_apellido2.Size = new System.Drawing.Size(138, 20);
            this.txt_apellido2.TabIndex = 11;
            // 
            // txt_apellido1
            // 
            this.txt_apellido1.Location = new System.Drawing.Point(100, 88);
            this.txt_apellido1.Name = "txt_apellido1";
            this.txt_apellido1.Size = new System.Drawing.Size(138, 20);
            this.txt_apellido1.TabIndex = 10;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(100, 55);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(138, 20);
            this.txt_nombre.TabIndex = 9;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(100, 19);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(138, 20);
            this.txt_codigo.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Telefono Celular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Telefono Fijo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Segundo Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Primer Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Codigo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_confirmarContraseña);
            this.groupBox3.Controls.Add(this.txt_contraseña);
            this.groupBox3.Controls.Add(this.txt_login);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(244, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 128);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Tecnicos del Usuario";
            // 
            // txt_confirmarContraseña
            // 
            this.txt_confirmarContraseña.Location = new System.Drawing.Point(66, 94);
            this.txt_confirmarContraseña.Name = "txt_confirmarContraseña";
            this.txt_confirmarContraseña.Size = new System.Drawing.Size(128, 20);
            this.txt_confirmarContraseña.TabIndex = 5;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(66, 55);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(128, 20);
            this.txt_contraseña.TabIndex = 4;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(66, 20);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(128, 20);
            this.txt_login.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmar\r\nContraseña\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_administradorCuentas);
            this.groupBox2.Controls.Add(this.chk_administradorRestaurante);
            this.groupBox2.Controls.Add(this.chk_administradorSeguridad);
            this.groupBox2.Controls.Add(this.chk_administradorSistema);
            this.groupBox2.Location = new System.Drawing.Point(15, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 74);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Privilegios";
            // 
            // chk_administradorCuentas
            // 
            this.chk_administradorCuentas.AutoSize = true;
            this.chk_administradorCuentas.Location = new System.Drawing.Point(180, 53);
            this.chk_administradorCuentas.Name = "chk_administradorCuentas";
            this.chk_administradorCuentas.Size = new System.Drawing.Size(146, 17);
            this.chk_administradorCuentas.TabIndex = 3;
            this.chk_administradorCuentas.Text = "Administrador de Cuentas";
            this.chk_administradorCuentas.UseVisualStyleBackColor = true;
            // 
            // chk_administradorRestaurante
            // 
            this.chk_administradorRestaurante.AutoSize = true;
            this.chk_administradorRestaurante.Location = new System.Drawing.Point(180, 19);
            this.chk_administradorRestaurante.Name = "chk_administradorRestaurante";
            this.chk_administradorRestaurante.Size = new System.Drawing.Size(167, 17);
            this.chk_administradorRestaurante.TabIndex = 2;
            this.chk_administradorRestaurante.Text = "Administrador del Restaurante\r\n";
            this.chk_administradorRestaurante.UseVisualStyleBackColor = true;
            // 
            // chk_administradorSeguridad
            // 
            this.chk_administradorSeguridad.AutoSize = true;
            this.chk_administradorSeguridad.Location = new System.Drawing.Point(19, 53);
            this.chk_administradorSeguridad.Name = "chk_administradorSeguridad";
            this.chk_administradorSeguridad.Size = new System.Drawing.Size(149, 17);
            this.chk_administradorSeguridad.TabIndex = 1;
            this.chk_administradorSeguridad.Text = "Aministrador de Seguridad";
            this.chk_administradorSeguridad.UseVisualStyleBackColor = true;
            // 
            // chk_administradorSistema
            // 
            this.chk_administradorSistema.AutoSize = true;
            this.chk_administradorSistema.Location = new System.Drawing.Point(22, 21);
            this.chk_administradorSistema.Name = "chk_administradorSistema";
            this.chk_administradorSistema.Size = new System.Drawing.Size(146, 17);
            this.chk_administradorSistema.TabIndex = 0;
            this.chk_administradorSistema.Text = "Administrador del Sistema\r\n";
            this.chk_administradorSistema.UseVisualStyleBackColor = true;
            // 
            // b_cambioContraseña
            // 
            this.b_cambioContraseña.Image = global::Restaurante.Properties.Resources.images;
            this.b_cambioContraseña.Location = new System.Drawing.Point(352, 333);
            this.b_cambioContraseña.Name = "b_cambioContraseña";
            this.b_cambioContraseña.Size = new System.Drawing.Size(41, 58);
            this.b_cambioContraseña.TabIndex = 72;
            this.b_cambioContraseña.UseVisualStyleBackColor = true;
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(235, 333);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(42, 58);
            this.b_aceptar.TabIndex = 71;
            this.b_aceptar.UseVisualStyleBackColor = true;
            // 
            // b_cerrar
            // 
            this.b_cerrar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cerrar.Location = new System.Drawing.Point(292, 333);
            this.b_cerrar.Name = "b_cerrar";
            this.b_cerrar.Size = new System.Drawing.Size(42, 58);
            this.b_cerrar.TabIndex = 70;
            this.b_cerrar.UseVisualStyleBackColor = true;
            // 
            // b_borrar
            // 
            this.b_borrar.Image = global::Restaurante.Properties.Resources.clean1;
            this.b_borrar.Location = new System.Drawing.Point(181, 333);
            this.b_borrar.Name = "b_borrar";
            this.b_borrar.Size = new System.Drawing.Size(39, 58);
            this.b_borrar.TabIndex = 69;
            this.b_borrar.UseVisualStyleBackColor = true;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(644, 396);
            this.Controls.Add(this.b_cambioContraseña);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.b_cerrar);
            this.Controls.Add(this.b_borrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmUsuarios";
            this.Text = "Usuarios";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_cambiarContraseña;
        private System.Windows.Forms.MaskedTextBox msk_telefonocelular;
        private System.Windows.Forms.MaskedTextBox msk_telfFijo;
        private System.Windows.Forms.TextBox txt_apellido2;
        private System.Windows.Forms.TextBox txt_apellido1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_confirmarContraseña;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_administradorCuentas;
        private System.Windows.Forms.CheckBox chk_administradorRestaurante;
        private System.Windows.Forms.CheckBox chk_administradorSeguridad;
        private System.Windows.Forms.CheckBox chk_administradorSistema;
        private System.Windows.Forms.Button b_borrar;
        private System.Windows.Forms.Button b_cerrar;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Button b_cambioContraseña;
    }
}