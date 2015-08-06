namespace Restaurante
{
    partial class frm_tipoBebida
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
            this.rb_licores = new System.Windows.Forms.RadioButton();
            this.rb_gaseosas = new System.Windows.Forms.RadioButton();
            this.rb_vinos = new System.Windows.Forms.RadioButton();
            this.rb_heladas = new System.Windows.Forms.RadioButton();
            this.rb_calientes = new System.Windows.Forms.RadioButton();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_licores);
            this.groupBox1.Controls.Add(this.rb_gaseosas);
            this.groupBox1.Controls.Add(this.rb_vinos);
            this.groupBox1.Controls.Add(this.rb_heladas);
            this.groupBox1.Controls.Add(this.rb_calientes);
            this.groupBox1.Location = new System.Drawing.Point(157, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 206);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // rb_licores
            // 
            this.rb_licores.AutoSize = true;
            this.rb_licores.Location = new System.Drawing.Point(40, 183);
            this.rb_licores.Name = "rb_licores";
            this.rb_licores.Size = new System.Drawing.Size(59, 17);
            this.rb_licores.TabIndex = 4;
            this.rb_licores.TabStop = true;
            this.rb_licores.Text = "Licores";
            this.rb_licores.UseVisualStyleBackColor = true;
            // 
            // rb_gaseosas
            // 
            this.rb_gaseosas.AutoSize = true;
            this.rb_gaseosas.Location = new System.Drawing.Point(40, 143);
            this.rb_gaseosas.Name = "rb_gaseosas";
            this.rb_gaseosas.Size = new System.Drawing.Size(72, 17);
            this.rb_gaseosas.TabIndex = 3;
            this.rb_gaseosas.TabStop = true;
            this.rb_gaseosas.Text = "Gaseosas";
            this.rb_gaseosas.UseVisualStyleBackColor = true;
            // 
            // rb_vinos
            // 
            this.rb_vinos.AutoSize = true;
            this.rb_vinos.Location = new System.Drawing.Point(40, 105);
            this.rb_vinos.Name = "rb_vinos";
            this.rb_vinos.Size = new System.Drawing.Size(51, 17);
            this.rb_vinos.TabIndex = 2;
            this.rb_vinos.TabStop = true;
            this.rb_vinos.Text = "Vinos";
            this.rb_vinos.UseVisualStyleBackColor = true;
            // 
            // rb_heladas
            // 
            this.rb_heladas.AutoSize = true;
            this.rb_heladas.Location = new System.Drawing.Point(40, 70);
            this.rb_heladas.Name = "rb_heladas";
            this.rb_heladas.Size = new System.Drawing.Size(64, 17);
            this.rb_heladas.TabIndex = 1;
            this.rb_heladas.TabStop = true;
            this.rb_heladas.Text = "Heladas";
            this.rb_heladas.UseVisualStyleBackColor = true;
            // 
            // rb_calientes
            // 
            this.rb_calientes.AutoSize = true;
            this.rb_calientes.Location = new System.Drawing.Point(40, 31);
            this.rb_calientes.Name = "rb_calientes";
            this.rb_calientes.Size = new System.Drawing.Size(68, 17);
            this.rb_calientes.TabIndex = 0;
            this.rb_calientes.TabStop = true;
            this.rb_calientes.Text = "Calientes";
            this.rb_calientes.UseVisualStyleBackColor = true;
            // 
            // b_cancelar
            // 
            this.b_cancelar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cancelar.Location = new System.Drawing.Point(360, 125);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(63, 47);
            this.b_cancelar.TabIndex = 7;
            this.b_cancelar.UseVisualStyleBackColor = true;
            this.b_cancelar.Click += new System.EventHandler(this.b_cancelar_Click);
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(360, 43);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(63, 47);
            this.b_aceptar.TabIndex = 5;
            this.b_aceptar.UseVisualStyleBackColor = true;
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Image = global::Restaurante.Properties.Resources.Wine_folder;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 230);
            this.label1.TabIndex = 1;
            // 
            // frm_tipoBebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(444, 230);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b_cancelar);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.label1);
            this.Name = "frm_tipoBebida";
            this.Text = "Tipos de Bebidas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_licores;
        private System.Windows.Forms.RadioButton rb_gaseosas;
        private System.Windows.Forms.RadioButton rb_vinos;
        private System.Windows.Forms.RadioButton rb_heladas;
        private System.Windows.Forms.RadioButton rb_calientes;
    }
}