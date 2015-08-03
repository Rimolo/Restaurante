namespace Restaurante
{
    partial class frm_roles
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_codigoRol = new System.Windows.Forms.TextBox();
            this.txt_nombreRol = new System.Windows.Forms.TextBox();
            this.txt_descripcionRol = new System.Windows.Forms.TextBox();
            this.b_borrar = new System.Windows.Forms.Button();
            this.b_cerrar = new System.Windows.Forms.Button();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 268);
            this.panel1.TabIndex = 77;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurante.Properties.Resources.Usuario4;
            this.pictureBox1.Location = new System.Drawing.Point(0, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 206);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_descripcionRol);
            this.groupBox1.Controls.Add(this.txt_nombreRol);
            this.groupBox1.Controls.Add(this.txt_codigoRol);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(176, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 196);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de los Roles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion";
            // 
            // txt_codigoRol
            // 
            this.txt_codigoRol.Location = new System.Drawing.Point(88, 20);
            this.txt_codigoRol.Name = "txt_codigoRol";
            this.txt_codigoRol.Size = new System.Drawing.Size(177, 20);
            this.txt_codigoRol.TabIndex = 3;
            // 
            // txt_nombreRol
            // 
            this.txt_nombreRol.Location = new System.Drawing.Point(88, 57);
            this.txt_nombreRol.Name = "txt_nombreRol";
            this.txt_nombreRol.Size = new System.Drawing.Size(177, 20);
            this.txt_nombreRol.TabIndex = 4;
            // 
            // txt_descripcionRol
            // 
            this.txt_descripcionRol.Location = new System.Drawing.Point(88, 110);
            this.txt_descripcionRol.Multiline = true;
            this.txt_descripcionRol.Name = "txt_descripcionRol";
            this.txt_descripcionRol.Size = new System.Drawing.Size(177, 80);
            this.txt_descripcionRol.TabIndex = 5;
            // 
            // b_borrar
            // 
            this.b_borrar.Image = global::Restaurante.Properties.Resources.clean1;
            this.b_borrar.Location = new System.Drawing.Point(186, 215);
            this.b_borrar.Name = "b_borrar";
            this.b_borrar.Size = new System.Drawing.Size(48, 46);
            this.b_borrar.TabIndex = 83;
            this.b_borrar.UseVisualStyleBackColor = true;
            // 
            // b_cerrar
            // 
            this.b_cerrar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cerrar.Location = new System.Drawing.Point(295, 215);
            this.b_cerrar.Name = "b_cerrar";
            this.b_cerrar.Size = new System.Drawing.Size(51, 46);
            this.b_cerrar.TabIndex = 84;
            this.b_cerrar.UseVisualStyleBackColor = true;
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(240, 215);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(49, 46);
            this.b_aceptar.TabIndex = 85;
            this.b_aceptar.UseVisualStyleBackColor = true;
            // 
            // frm_roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(455, 269);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.b_cerrar);
            this.Controls.Add(this.b_borrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_roles";
            this.Text = "Roles";
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
        private System.Windows.Forms.TextBox txt_descripcionRol;
        private System.Windows.Forms.TextBox txt_nombreRol;
        private System.Windows.Forms.TextBox txt_codigoRol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_borrar;
        private System.Windows.Forms.Button b_cerrar;
        private System.Windows.Forms.Button b_aceptar;
    }
}