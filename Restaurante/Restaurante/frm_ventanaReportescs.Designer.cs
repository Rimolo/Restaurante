namespace Restaurante
{
    partial class frm_ventanaReportescs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_bitacora = new System.Windows.Forms.RadioButton();
            this.rb_clientes = new System.Windows.Forms.RadioButton();
            this.rb_facturacion = new System.Windows.Forms.RadioButton();
            this.b_cerrar = new System.Windows.Forms.Button();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_facturacion);
            this.groupBox1.Controls.Add(this.rb_clientes);
            this.groupBox1.Controls.Add(this.rb_bitacora);
            this.groupBox1.Location = new System.Drawing.Point(196, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 232);
            this.panel1.TabIndex = 1;
            // 
            // rb_bitacora
            // 
            this.rb_bitacora.AutoSize = true;
            this.rb_bitacora.Location = new System.Drawing.Point(27, 39);
            this.rb_bitacora.Name = "rb_bitacora";
            this.rb_bitacora.Size = new System.Drawing.Size(64, 17);
            this.rb_bitacora.TabIndex = 0;
            this.rb_bitacora.TabStop = true;
            this.rb_bitacora.Text = "Bitacora";
            this.rb_bitacora.UseVisualStyleBackColor = true;
            // 
            // rb_clientes
            // 
            this.rb_clientes.AutoSize = true;
            this.rb_clientes.Location = new System.Drawing.Point(29, 89);
            this.rb_clientes.Name = "rb_clientes";
            this.rb_clientes.Size = new System.Drawing.Size(62, 17);
            this.rb_clientes.TabIndex = 1;
            this.rb_clientes.TabStop = true;
            this.rb_clientes.Text = "Clientes";
            this.rb_clientes.UseVisualStyleBackColor = true;
            // 
            // rb_facturacion
            // 
            this.rb_facturacion.AutoSize = true;
            this.rb_facturacion.Location = new System.Drawing.Point(27, 149);
            this.rb_facturacion.Name = "rb_facturacion";
            this.rb_facturacion.Size = new System.Drawing.Size(81, 17);
            this.rb_facturacion.TabIndex = 2;
            this.rb_facturacion.TabStop = true;
            this.rb_facturacion.Text = "Facturacion";
            this.rb_facturacion.UseVisualStyleBackColor = true;
            // 
            // b_cerrar
            // 
            this.b_cerrar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cerrar.Location = new System.Drawing.Point(402, 119);
            this.b_cerrar.Name = "b_cerrar";
            this.b_cerrar.Size = new System.Drawing.Size(54, 48);
            this.b_cerrar.TabIndex = 68;
            this.b_cerrar.UseVisualStyleBackColor = true;
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(402, 33);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(54, 53);
            this.b_aceptar.TabIndex = 67;
            this.b_aceptar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurante.Properties.Resources.Reportes1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_ventanaReportescs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(468, 231);
            this.Controls.Add(this.b_cerrar);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_ventanaReportescs";
            this.Text = "Ventana de Reportes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rb_facturacion;
        private System.Windows.Forms.RadioButton rb_clientes;
        private System.Windows.Forms.RadioButton rb_bitacora;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Button b_cerrar;
    }
}