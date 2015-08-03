namespace Restaurante
{
    partial class frm_ayudaLicores
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AyudaLicores = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_atras = new System.Windows.Forms.Button();
            this.b_adelante = new System.Windows.Forms.Button();
            this.b_cerrar = new System.Windows.Forms.Button();
            this.b_vistaPrevia = new System.Windows.Forms.Button();
            this.b_imprimir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ayuda para los tipos de Licores";
            // 
            // txt_AyudaLicores
            // 
            this.txt_AyudaLicores.Location = new System.Drawing.Point(174, 30);
            this.txt_AyudaLicores.Multiline = true;
            this.txt_AyudaLicores.Name = "txt_AyudaLicores";
            this.txt_AyudaLicores.Size = new System.Drawing.Size(427, 404);
            this.txt_AyudaLicores.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 493);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurante.Properties.Resources.bar_beer3;
            this.pictureBox1.Location = new System.Drawing.Point(12, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 154);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // b_atras
            // 
            this.b_atras.Image = global::Restaurante.Properties.Resources.left_arrow;
            this.b_atras.Location = new System.Drawing.Point(187, 440);
            this.b_atras.Name = "b_atras";
            this.b_atras.Size = new System.Drawing.Size(60, 47);
            this.b_atras.TabIndex = 15;
            this.b_atras.UseVisualStyleBackColor = true;
            // 
            // b_adelante
            // 
            this.b_adelante.Image = global::Restaurante.Properties.Resources.yesil_ok_isareti;
            this.b_adelante.Location = new System.Drawing.Point(263, 440);
            this.b_adelante.Name = "b_adelante";
            this.b_adelante.Size = new System.Drawing.Size(61, 47);
            this.b_adelante.TabIndex = 16;
            this.b_adelante.UseVisualStyleBackColor = true;
            // 
            // b_cerrar
            // 
            this.b_cerrar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cerrar.Location = new System.Drawing.Point(345, 440);
            this.b_cerrar.Name = "b_cerrar";
            this.b_cerrar.Size = new System.Drawing.Size(56, 47);
            this.b_cerrar.TabIndex = 74;
            this.b_cerrar.UseVisualStyleBackColor = true;
            // 
            // b_vistaPrevia
            // 
            this.b_vistaPrevia.Image = global::Restaurante.Properties.Resources.print_preview_icone_7826_48;
            this.b_vistaPrevia.Location = new System.Drawing.Point(419, 440);
            this.b_vistaPrevia.Name = "b_vistaPrevia";
            this.b_vistaPrevia.Size = new System.Drawing.Size(55, 47);
            this.b_vistaPrevia.TabIndex = 75;
            this.b_vistaPrevia.Text = "\r\n";
            this.b_vistaPrevia.UseVisualStyleBackColor = true;
            // 
            // b_imprimir
            // 
            this.b_imprimir.Image = global::Restaurante.Properties.Resources.print1;
            this.b_imprimir.Location = new System.Drawing.Point(494, 440);
            this.b_imprimir.Name = "b_imprimir";
            this.b_imprimir.Size = new System.Drawing.Size(55, 47);
            this.b_imprimir.TabIndex = 76;
            this.b_imprimir.UseVisualStyleBackColor = true;
            // 
            // frm_ayudaLicores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(621, 493);
            this.Controls.Add(this.b_imprimir);
            this.Controls.Add(this.b_vistaPrevia);
            this.Controls.Add(this.b_cerrar);
            this.Controls.Add(this.b_adelante);
            this.Controls.Add(this.b_atras);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_AyudaLicores);
            this.Controls.Add(this.label2);
            this.Name = "frm_ayudaLicores";
            this.Text = "Ayuda Licores";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AyudaLicores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b_atras;
        private System.Windows.Forms.Button b_adelante;
        private System.Windows.Forms.Button b_cerrar;
        private System.Windows.Forms.Button b_vistaPrevia;
        private System.Windows.Forms.Button b_imprimir;
    }
}