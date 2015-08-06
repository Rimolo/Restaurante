namespace Restaurante
{
    partial class frm_ventanaSeguridad
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
            this.rb_unidadesMedida = new System.Windows.Forms.RadioButton();
            this.rb_rolesEventos = new System.Windows.Forms.RadioButton();
            this.rb_cajas = new System.Windows.Forms.RadioButton();
            this.rb_paises = new System.Windows.Forms.RadioButton();
            this.rb_consecutivos = new System.Windows.Forms.RadioButton();
            this.rb_usuarios = new System.Windows.Forms.RadioButton();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.b_cerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 197);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurante.Properties.Resources.Lock;
            this.pictureBox1.Location = new System.Drawing.Point(33, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 118);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_unidadesMedida);
            this.groupBox1.Controls.Add(this.rb_rolesEventos);
            this.groupBox1.Controls.Add(this.rb_cajas);
            this.groupBox1.Controls.Add(this.rb_paises);
            this.groupBox1.Controls.Add(this.rb_consecutivos);
            this.groupBox1.Controls.Add(this.rb_usuarios);
            this.groupBox1.Location = new System.Drawing.Point(207, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 173);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // rb_unidadesMedida
            // 
            this.rb_unidadesMedida.AutoSize = true;
            this.rb_unidadesMedida.Location = new System.Drawing.Point(145, 139);
            this.rb_unidadesMedida.Name = "rb_unidadesMedida";
            this.rb_unidadesMedida.Size = new System.Drawing.Size(123, 17);
            this.rb_unidadesMedida.TabIndex = 5;
            this.rb_unidadesMedida.TabStop = true;
            this.rb_unidadesMedida.Text = "Unidades de Medida";
            this.rb_unidadesMedida.UseVisualStyleBackColor = true;
            // 
            // rb_rolesEventos
            // 
            this.rb_rolesEventos.AutoSize = true;
            this.rb_rolesEventos.Location = new System.Drawing.Point(145, 89);
            this.rb_rolesEventos.Name = "rb_rolesEventos";
            this.rb_rolesEventos.Size = new System.Drawing.Size(103, 17);
            this.rb_rolesEventos.TabIndex = 4;
            this.rb_rolesEventos.TabStop = true;
            this.rb_rolesEventos.Text = "Roles o Eventos";
            this.rb_rolesEventos.UseVisualStyleBackColor = true;
            // 
            // rb_cajas
            // 
            this.rb_cajas.AutoSize = true;
            this.rb_cajas.Location = new System.Drawing.Point(145, 39);
            this.rb_cajas.Name = "rb_cajas";
            this.rb_cajas.Size = new System.Drawing.Size(51, 17);
            this.rb_cajas.TabIndex = 3;
            this.rb_cajas.TabStop = true;
            this.rb_cajas.Text = "Cajas";
            this.rb_cajas.UseVisualStyleBackColor = true;
            // 
            // rb_paises
            // 
            this.rb_paises.AutoSize = true;
            this.rb_paises.Location = new System.Drawing.Point(29, 140);
            this.rb_paises.Name = "rb_paises";
            this.rb_paises.Size = new System.Drawing.Size(56, 17);
            this.rb_paises.TabIndex = 2;
            this.rb_paises.TabStop = true;
            this.rb_paises.Text = "Paises";
            this.rb_paises.UseVisualStyleBackColor = true;
            // 
            // rb_consecutivos
            // 
            this.rb_consecutivos.AutoSize = true;
            this.rb_consecutivos.Location = new System.Drawing.Point(29, 89);
            this.rb_consecutivos.Name = "rb_consecutivos";
            this.rb_consecutivos.Size = new System.Drawing.Size(89, 17);
            this.rb_consecutivos.TabIndex = 1;
            this.rb_consecutivos.TabStop = true;
            this.rb_consecutivos.Text = "Consecutivos";
            this.rb_consecutivos.UseVisualStyleBackColor = true;
            // 
            // rb_usuarios
            // 
            this.rb_usuarios.AutoSize = true;
            this.rb_usuarios.Location = new System.Drawing.Point(29, 39);
            this.rb_usuarios.Name = "rb_usuarios";
            this.rb_usuarios.Size = new System.Drawing.Size(66, 17);
            this.rb_usuarios.TabIndex = 0;
            this.rb_usuarios.TabStop = true;
            this.rb_usuarios.Text = "Usuarios\r\n";
            this.rb_usuarios.UseVisualStyleBackColor = true;
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(485, 33);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(54, 53);
            this.b_aceptar.TabIndex = 68;
            this.b_aceptar.UseVisualStyleBackColor = true;
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // b_cerrar
            // 
            this.b_cerrar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cerrar.Location = new System.Drawing.Point(485, 101);
            this.b_cerrar.Name = "b_cerrar";
            this.b_cerrar.Size = new System.Drawing.Size(54, 48);
            this.b_cerrar.TabIndex = 69;
            this.b_cerrar.UseVisualStyleBackColor = true;
            this.b_cerrar.Click += new System.EventHandler(this.b_cerrar_Click);
            // 
            // frm_ventanaSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(543, 196);
            this.Controls.Add(this.b_cerrar);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_ventanaSeguridad";
            this.Text = "Ventana de Seguridad";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_unidadesMedida;
        private System.Windows.Forms.RadioButton rb_rolesEventos;
        private System.Windows.Forms.RadioButton rb_cajas;
        private System.Windows.Forms.RadioButton rb_paises;
        private System.Windows.Forms.RadioButton rb_consecutivos;
        private System.Windows.Forms.RadioButton rb_usuarios;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Button b_cerrar;
    }
}