namespace Restaurante
{
    partial class frm_ayudaRestaurante
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
            this.txt_AyudaRestaurante = new System.Windows.Forms.TextBox();
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
            this.label2.Location = new System.Drawing.Point(244, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ayuda para el Modulo del Restaurante";
            // 
            // txt_AyudaRestaurante
            // 
            this.txt_AyudaRestaurante.Location = new System.Drawing.Point(160, 30);
            this.txt_AyudaRestaurante.Multiline = true;
            this.txt_AyudaRestaurante.Name = "txt_AyudaRestaurante";
            this.txt_AyudaRestaurante.Size = new System.Drawing.Size(447, 359);
            this.txt_AyudaRestaurante.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 470);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurante.Properties.Resources.ICONA_CHEF;
            this.pictureBox1.Location = new System.Drawing.Point(12, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // b_atras
            // 
            this.b_atras.Image = global::Restaurante.Properties.Resources.left_arrow;
            this.b_atras.Location = new System.Drawing.Point(178, 410);
            this.b_atras.Name = "b_atras";
            this.b_atras.Size = new System.Drawing.Size(60, 47);
            this.b_atras.TabIndex = 14;
            this.b_atras.UseVisualStyleBackColor = true;
            // 
            // b_adelante
            // 
            this.b_adelante.Image = global::Restaurante.Properties.Resources.yesil_ok_isareti;
            this.b_adelante.Location = new System.Drawing.Point(256, 410);
            this.b_adelante.Name = "b_adelante";
            this.b_adelante.Size = new System.Drawing.Size(61, 47);
            this.b_adelante.TabIndex = 15;
            this.b_adelante.UseVisualStyleBackColor = true;
            // 
            // b_cerrar
            // 
            this.b_cerrar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cerrar.Location = new System.Drawing.Point(335, 410);
            this.b_cerrar.Name = "b_cerrar";
            this.b_cerrar.Size = new System.Drawing.Size(56, 47);
            this.b_cerrar.TabIndex = 73;
            this.b_cerrar.UseVisualStyleBackColor = true;
            // 
            // b_vistaPrevia
            // 
            this.b_vistaPrevia.Image = global::Restaurante.Properties.Resources.print_preview_icone_7826_48;
            this.b_vistaPrevia.Location = new System.Drawing.Point(410, 410);
            this.b_vistaPrevia.Name = "b_vistaPrevia";
            this.b_vistaPrevia.Size = new System.Drawing.Size(55, 47);
            this.b_vistaPrevia.TabIndex = 74;
            this.b_vistaPrevia.Text = "\r\n";
            this.b_vistaPrevia.UseVisualStyleBackColor = true;
            // 
            // b_imprimir
            // 
            this.b_imprimir.Image = global::Restaurante.Properties.Resources.print1;
            this.b_imprimir.Location = new System.Drawing.Point(482, 410);
            this.b_imprimir.Name = "b_imprimir";
            this.b_imprimir.Size = new System.Drawing.Size(55, 47);
            this.b_imprimir.TabIndex = 75;
            this.b_imprimir.UseVisualStyleBackColor = true;
            // 
            // frm_ayudaRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(619, 469);
            this.Controls.Add(this.b_imprimir);
            this.Controls.Add(this.b_vistaPrevia);
            this.Controls.Add(this.b_cerrar);
            this.Controls.Add(this.b_adelante);
            this.Controls.Add(this.b_atras);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_AyudaRestaurante);
            this.Controls.Add(this.label2);
            this.Name = "frm_ayudaRestaurante";
            this.Text = "Ayuda Restaurante";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AyudaRestaurante;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b_atras;
        private System.Windows.Forms.Button b_adelante;
        private System.Windows.Forms.Button b_cerrar;
        private System.Windows.Forms.Button b_vistaPrevia;
        private System.Windows.Forms.Button b_imprimir;
    }
}