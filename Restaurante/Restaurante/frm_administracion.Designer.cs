namespace Restaurante
{
    partial class frm_administracion
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
            this.b_cancelar = new System.Windows.Forms.Button();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_especiales = new System.Windows.Forms.RadioButton();
            this.rb_Empleados = new System.Windows.Forms.RadioButton();
            this.rb_mesas = new System.Windows.Forms.RadioButton();
            this.rb_puestos = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_puestos);
            this.groupBox1.Controls.Add(this.rb_mesas);
            this.groupBox1.Controls.Add(this.rb_Empleados);
            this.groupBox1.Controls.Add(this.rb_especiales);
            this.groupBox1.Location = new System.Drawing.Point(186, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 149);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // b_cancelar
            // 
            this.b_cancelar.Image = global::Restaurante.Properties.Resources.Cancelar3;
            this.b_cancelar.Location = new System.Drawing.Point(402, 190);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(57, 38);
            this.b_cancelar.TabIndex = 3;
            this.b_cancelar.UseVisualStyleBackColor = true;
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar2;
            this.b_aceptar.Location = new System.Drawing.Point(316, 190);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(58, 38);
            this.b_aceptar.TabIndex = 2;
            this.b_aceptar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Image = global::Restaurante.Properties.Resources.Config1;
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 260);
            this.label1.TabIndex = 0;
            // 
            // rb_especiales
            // 
            this.rb_especiales.AutoSize = true;
            this.rb_especiales.Location = new System.Drawing.Point(17, 30);
            this.rb_especiales.Name = "rb_especiales";
            this.rb_especiales.Size = new System.Drawing.Size(76, 17);
            this.rb_especiales.TabIndex = 4;
            this.rb_especiales.TabStop = true;
            this.rb_especiales.Text = "Especiales";
            this.rb_especiales.UseVisualStyleBackColor = true;
            // 
            // rb_Empleados
            // 
            this.rb_Empleados.AutoSize = true;
            this.rb_Empleados.Location = new System.Drawing.Point(17, 96);
            this.rb_Empleados.Name = "rb_Empleados";
            this.rb_Empleados.Size = new System.Drawing.Size(77, 17);
            this.rb_Empleados.TabIndex = 5;
            this.rb_Empleados.TabStop = true;
            this.rb_Empleados.Text = "Empleados\r\n";
            this.rb_Empleados.UseVisualStyleBackColor = true;
            // 
            // rb_mesas
            // 
            this.rb_mesas.AutoSize = true;
            this.rb_mesas.Location = new System.Drawing.Point(144, 30);
            this.rb_mesas.Name = "rb_mesas";
            this.rb_mesas.Size = new System.Drawing.Size(56, 17);
            this.rb_mesas.TabIndex = 6;
            this.rb_mesas.TabStop = true;
            this.rb_mesas.Text = "Mesas";
            this.rb_mesas.UseVisualStyleBackColor = true;
            // 
            // rb_puestos
            // 
            this.rb_puestos.AutoSize = true;
            this.rb_puestos.Location = new System.Drawing.Point(144, 96);
            this.rb_puestos.Name = "rb_puestos";
            this.rb_puestos.Size = new System.Drawing.Size(63, 17);
            this.rb_puestos.TabIndex = 7;
            this.rb_puestos.TabStop = true;
            this.rb_puestos.Text = "Puestos";
            this.rb_puestos.UseVisualStyleBackColor = true;
            // 
            // frm_administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(471, 240);
            this.Controls.Add(this.b_cancelar);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_administracion";
            this.Text = "Ventana de Administracion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.RadioButton rb_puestos;
        private System.Windows.Forms.RadioButton rb_mesas;
        private System.Windows.Forms.RadioButton rb_Empleados;
        private System.Windows.Forms.RadioButton rb_especiales;
    }
}