namespace Restaurante
{
    partial class frm_catalogoProductos
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
            this.rb_comestibles = new System.Windows.Forms.RadioButton();
            this.rb_desechablesEmpaques = new System.Windows.Forms.RadioButton();
            this.rb_limpieza = new System.Windows.Forms.RadioButton();
            this.rb_tecnologia = new System.Windows.Forms.RadioButton();
            this.rb_EquiposUtencilios = new System.Windows.Forms.RadioButton();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Image = global::Restaurante.Properties.Resources.Bitacora;
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 201);
            this.label1.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_EquiposUtencilios);
            this.groupBox1.Controls.Add(this.rb_tecnologia);
            this.groupBox1.Controls.Add(this.rb_limpieza);
            this.groupBox1.Controls.Add(this.rb_desechablesEmpaques);
            this.groupBox1.Controls.Add(this.rb_comestibles);
            this.groupBox1.Location = new System.Drawing.Point(194, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 164);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // rb_comestibles
            // 
            this.rb_comestibles.AutoSize = true;
            this.rb_comestibles.Location = new System.Drawing.Point(20, 28);
            this.rb_comestibles.Name = "rb_comestibles";
            this.rb_comestibles.Size = new System.Drawing.Size(81, 17);
            this.rb_comestibles.TabIndex = 0;
            this.rb_comestibles.TabStop = true;
            this.rb_comestibles.Text = "Comestibles";
            this.rb_comestibles.UseVisualStyleBackColor = true;
            // 
            // rb_desechablesEmpaques
            // 
            this.rb_desechablesEmpaques.AutoSize = true;
            this.rb_desechablesEmpaques.Location = new System.Drawing.Point(20, 71);
            this.rb_desechablesEmpaques.Name = "rb_desechablesEmpaques";
            this.rb_desechablesEmpaques.Size = new System.Drawing.Size(148, 17);
            this.rb_desechablesEmpaques.TabIndex = 1;
            this.rb_desechablesEmpaques.TabStop = true;
            this.rb_desechablesEmpaques.Text = "Desechables y Empaques";
            this.rb_desechablesEmpaques.UseVisualStyleBackColor = true;
            // 
            // rb_limpieza
            // 
            this.rb_limpieza.AutoSize = true;
            this.rb_limpieza.Location = new System.Drawing.Point(20, 121);
            this.rb_limpieza.Name = "rb_limpieza";
            this.rb_limpieza.Size = new System.Drawing.Size(114, 17);
            this.rb_limpieza.TabIndex = 2;
            this.rb_limpieza.TabStop = true;
            this.rb_limpieza.Text = "Limpieza e Higiene";
            this.rb_limpieza.UseVisualStyleBackColor = true;
            // 
            // rb_tecnologia
            // 
            this.rb_tecnologia.AutoSize = true;
            this.rb_tecnologia.Location = new System.Drawing.Point(204, 28);
            this.rb_tecnologia.Name = "rb_tecnologia";
            this.rb_tecnologia.Size = new System.Drawing.Size(78, 17);
            this.rb_tecnologia.TabIndex = 3;
            this.rb_tecnologia.TabStop = true;
            this.rb_tecnologia.Text = "Tecnologia";
            this.rb_tecnologia.UseVisualStyleBackColor = true;
            // 
            // rb_EquiposUtencilios
            // 
            this.rb_EquiposUtencilios.AutoSize = true;
            this.rb_EquiposUtencilios.Location = new System.Drawing.Point(204, 71);
            this.rb_EquiposUtencilios.Name = "rb_EquiposUtencilios";
            this.rb_EquiposUtencilios.Size = new System.Drawing.Size(123, 17);
            this.rb_EquiposUtencilios.TabIndex = 4;
            this.rb_EquiposUtencilios.TabStop = true;
            this.rb_EquiposUtencilios.Text = "Equipos y Utencilios ";
            this.rb_EquiposUtencilios.UseVisualStyleBackColor = true;
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(534, 40);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(52, 47);
            this.b_aceptar.TabIndex = 46;
            this.b_aceptar.UseVisualStyleBackColor = true;
            // 
            // b_cancelar
            // 
            this.b_cancelar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cancelar.Location = new System.Drawing.Point(534, 107);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(52, 43);
            this.b_cancelar.TabIndex = 47;
            this.b_cancelar.UseVisualStyleBackColor = true;
            // 
            // frm_catalogoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(598, 197);
            this.Controls.Add(this.b_cancelar);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_catalogoProductos";
            this.Text = "Catalogo de Productos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_comestibles;
        private System.Windows.Forms.RadioButton rb_EquiposUtencilios;
        private System.Windows.Forms.RadioButton rb_tecnologia;
        private System.Windows.Forms.RadioButton rb_limpieza;
        private System.Windows.Forms.RadioButton rb_desechablesEmpaques;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Button b_cancelar;
    }
}