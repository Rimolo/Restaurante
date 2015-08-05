namespace Restaurante
{
    partial class frm_consecutivos
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
            this.cb_tipoConsecutivo = new System.Windows.Forms.ComboBox();
            this.txt_valorConsecutivo = new System.Windows.Forms.TextBox();
            this.txt_prefijo = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.chk_prefijo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.b_cerrar = new System.Windows.Forms.Button();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.b_borrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 374);
            this.panel1.TabIndex = 64;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurante.Properties.Resources.Config2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 242);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_tipoConsecutivo);
            this.groupBox1.Controls.Add(this.txt_valorConsecutivo);
            this.groupBox1.Controls.Add(this.txt_prefijo);
            this.groupBox1.Controls.Add(this.txt_descripcion);
            this.groupBox1.Controls.Add(this.chk_prefijo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(230, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 290);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del Consecutivo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cb_tipoConsecutivo
            // 
            this.cb_tipoConsecutivo.FormattingEnabled = true;
            this.cb_tipoConsecutivo.Items.AddRange(new object[] {
            "Clientes",
            "Personal",
            "Proveedor",
            "Puestos",
            "Eventos o Roles",
            "Usuarios",
            "Unidades de Medida",
            "Paises",
            "Marcas",
            "Comestibles",
            "Desechables y Empaques",
            "Equipos y Utensilios",
            "Limpieza e Higiene",
            "Tecnologia",
            "Restaurante",
            "Buffet",
            "Especiales",
            "Bebidas Calientes",
            "Bebidas Heladas",
            "Bebidas Gaseosas ",
            "Licores",
            "Vinos",
            "Empleados",
            "Mesas",
            "Bitacora",
            "Facturas"});
            this.cb_tipoConsecutivo.Location = new System.Drawing.Point(132, 22);
            this.cb_tipoConsecutivo.Name = "cb_tipoConsecutivo";
            this.cb_tipoConsecutivo.Size = new System.Drawing.Size(184, 21);
            this.cb_tipoConsecutivo.TabIndex = 8;
            this.cb_tipoConsecutivo.SelectedIndexChanged += new System.EventHandler(this.cb_tipoConsecutivo_SelectedIndexChanged);
            // 
            // txt_valorConsecutivo
            // 
            this.txt_valorConsecutivo.Location = new System.Drawing.Point(132, 121);
            this.txt_valorConsecutivo.Name = "txt_valorConsecutivo";
            this.txt_valorConsecutivo.Size = new System.Drawing.Size(184, 20);
            this.txt_valorConsecutivo.TabIndex = 7;
            // 
            // txt_prefijo
            // 
            this.txt_prefijo.Enabled = false;
            this.txt_prefijo.Location = new System.Drawing.Point(135, 203);
            this.txt_prefijo.Name = "txt_prefijo";
            this.txt_prefijo.Size = new System.Drawing.Size(181, 20);
            this.txt_prefijo.TabIndex = 6;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(135, 68);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(181, 20);
            this.txt_descripcion.TabIndex = 5;
            // 
            // chk_prefijo
            // 
            this.chk_prefijo.AutoSize = true;
            this.chk_prefijo.Location = new System.Drawing.Point(86, 170);
            this.chk_prefijo.Name = "chk_prefijo";
            this.chk_prefijo.Size = new System.Drawing.Size(159, 17);
            this.chk_prefijo.TabIndex = 4;
            this.chk_prefijo.Text = "El consecutivo posee prefijo";
            this.chk_prefijo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prefijo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor del Consectivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de consecutivo";
            // 
            // b_cerrar
            // 
            this.b_cerrar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cerrar.Location = new System.Drawing.Point(348, 309);
            this.b_cerrar.Name = "b_cerrar";
            this.b_cerrar.Size = new System.Drawing.Size(42, 47);
            this.b_cerrar.TabIndex = 75;
            this.b_cerrar.UseVisualStyleBackColor = true;
            this.b_cerrar.Click += new System.EventHandler(this.b_cerrar_Click);
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(286, 309);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(42, 47);
            this.b_aceptar.TabIndex = 74;
            this.b_aceptar.UseVisualStyleBackColor = true;
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // b_borrar
            // 
            this.b_borrar.Image = global::Restaurante.Properties.Resources.clean1;
            this.b_borrar.Location = new System.Drawing.Point(230, 309);
            this.b_borrar.Name = "b_borrar";
            this.b_borrar.Size = new System.Drawing.Size(39, 47);
            this.b_borrar.TabIndex = 69;
            this.b_borrar.UseVisualStyleBackColor = true;
            this.b_borrar.Click += new System.EventHandler(this.b_borrar_Click);
            // 
            // frm_consecutivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(576, 371);
            this.Controls.Add(this.b_cerrar);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.b_borrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_consecutivos";
            this.Text = "Consecutivos";
            this.Load += new System.EventHandler(this.frm_consecutivos_Load);
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
        private System.Windows.Forms.ComboBox cb_tipoConsecutivo;
        private System.Windows.Forms.TextBox txt_valorConsecutivo;
        private System.Windows.Forms.TextBox txt_prefijo;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.CheckBox chk_prefijo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_borrar;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Button b_cerrar;
    }
}