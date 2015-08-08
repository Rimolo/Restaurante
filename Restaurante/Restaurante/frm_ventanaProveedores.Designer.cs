namespace Restaurante
{
    partial class frm_ventanaProveedores
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_proveedores = new System.Windows.Forms.RadioButton();
            this.rb_productos = new System.Windows.Forms.RadioButton();
            this.rb_marcas = new System.Windows.Forms.RadioButton();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Image = global::Restaurante.Properties.Resources.Usuario2;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 200);
            this.label1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_proveedores);
            this.groupBox1.Controls.Add(this.rb_productos);
            this.groupBox1.Controls.Add(this.rb_marcas);
            this.groupBox1.Location = new System.Drawing.Point(221, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 136);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // rb_proveedores
            // 
            this.rb_proveedores.AutoSize = true;
            this.rb_proveedores.Location = new System.Drawing.Point(40, 105);
            this.rb_proveedores.Name = "rb_proveedores";
            this.rb_proveedores.Size = new System.Drawing.Size(85, 17);
            this.rb_proveedores.TabIndex = 2;
            this.rb_proveedores.TabStop = true;
            this.rb_proveedores.Text = "Proveedores";
            this.rb_proveedores.UseVisualStyleBackColor = true;
            // 
            // rb_productos
            // 
            this.rb_productos.AutoSize = true;
            this.rb_productos.Location = new System.Drawing.Point(40, 70);
            this.rb_productos.Name = "rb_productos";
            this.rb_productos.Size = new System.Drawing.Size(73, 17);
            this.rb_productos.TabIndex = 1;
            this.rb_productos.TabStop = true;
            this.rb_productos.Text = "Productos";
            this.rb_productos.UseVisualStyleBackColor = true;
            // 
            // rb_marcas
            // 
            this.rb_marcas.AutoSize = true;
            this.rb_marcas.Location = new System.Drawing.Point(40, 31);
            this.rb_marcas.Name = "rb_marcas";
            this.rb_marcas.Size = new System.Drawing.Size(60, 17);
            this.rb_marcas.TabIndex = 0;
            this.rb_marcas.TabStop = true;
            this.rb_marcas.Text = "Marcas";
            this.rb_marcas.UseVisualStyleBackColor = true;
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(422, 28);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(63, 47);
            this.b_aceptar.TabIndex = 10;
            this.b_aceptar.UseVisualStyleBackColor = true;
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // b_cancelar
            // 
            this.b_cancelar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cancelar.Location = new System.Drawing.Point(422, 101);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(63, 47);
            this.b_cancelar.TabIndex = 11;
            this.b_cancelar.UseVisualStyleBackColor = true;
            this.b_cancelar.Click += new System.EventHandler(this.b_cancelar_Click);
            // 
            // frm_ventanaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(522, 199);
            this.Controls.Add(this.b_cancelar);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_ventanaProveedores";
            this.Text = "frm_ventanaProveedores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_proveedores;
        private System.Windows.Forms.RadioButton rb_productos;
        private System.Windows.Forms.RadioButton rb_marcas;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Button b_cancelar;
    }
}