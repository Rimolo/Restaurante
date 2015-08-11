namespace Restaurante
{
    partial class frm_Especialidades
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
            this.rb_especialidades = new System.Windows.Forms.RadioButton();
            this.rb_bebidas = new System.Windows.Forms.RadioButton();
            this.rb_buffet = new System.Windows.Forms.RadioButton();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_especialidades);
            this.groupBox1.Controls.Add(this.rb_bebidas);
            this.groupBox1.Controls.Add(this.rb_buffet);
            this.groupBox1.Location = new System.Drawing.Point(232, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // rb_especialidades
            // 
            this.rb_especialidades.AutoSize = true;
            this.rb_especialidades.Location = new System.Drawing.Point(40, 117);
            this.rb_especialidades.Name = "rb_especialidades";
            this.rb_especialidades.Size = new System.Drawing.Size(96, 17);
            this.rb_especialidades.TabIndex = 2;
            this.rb_especialidades.TabStop = true;
            this.rb_especialidades.Text = "Especialidades";
            this.rb_especialidades.UseVisualStyleBackColor = true;
            // 
            // rb_bebidas
            // 
            this.rb_bebidas.AutoSize = true;
            this.rb_bebidas.Location = new System.Drawing.Point(40, 75);
            this.rb_bebidas.Name = "rb_bebidas";
            this.rb_bebidas.Size = new System.Drawing.Size(63, 17);
            this.rb_bebidas.TabIndex = 1;
            this.rb_bebidas.TabStop = true;
            this.rb_bebidas.Text = "Bebidas";
            this.rb_bebidas.UseVisualStyleBackColor = true;
            // 
            // rb_buffet
            // 
            this.rb_buffet.AutoSize = true;
            this.rb_buffet.Location = new System.Drawing.Point(40, 31);
            this.rb_buffet.Name = "rb_buffet";
            this.rb_buffet.Size = new System.Drawing.Size(53, 17);
            this.rb_buffet.TabIndex = 0;
            this.rb_buffet.TabStop = true;
            this.rb_buffet.Text = "Buffet";
            this.rb_buffet.UseVisualStyleBackColor = true;
            // 
            // b_cancelar
            // 
            this.b_cancelar.Image = global::Restaurante.Properties.Resources.Cancelar;
            this.b_cancelar.Location = new System.Drawing.Point(457, 107);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(56, 39);
            this.b_cancelar.TabIndex = 3;
            this.b_cancelar.UseVisualStyleBackColor = true;
            this.b_cancelar.Click += new System.EventHandler(this.b_cancelar_Click);
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar3;
            this.b_aceptar.Location = new System.Drawing.Point(457, 43);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(56, 40);
            this.b_aceptar.TabIndex = 2;
            this.b_aceptar.UseVisualStyleBackColor = true;
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Image = global::Restaurante.Properties.Resources.Espaghetti1;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 183);
            this.label1.TabIndex = 0;
            this.label1.Text = "\r\n";
            // 
            // frm_Especialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(525, 182);
            this.Controls.Add(this.b_cancelar);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_Especialidades";
            this.Text = "Especialidades";
            this.Load += new System.EventHandler(this.frm_Especialidades_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_especialidades;
        private System.Windows.Forms.RadioButton rb_bebidas;
        private System.Windows.Forms.RadioButton rb_buffet;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Button b_cancelar;
    }
}