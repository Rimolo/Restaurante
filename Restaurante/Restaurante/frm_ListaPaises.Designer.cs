namespace Restaurante
{
    partial class frm_ListaPaises
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
            this.txt_nombrePais = new System.Windows.Forms.TextBox();
            this.txt_codigoPais = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_paises = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.b_borrar = new System.Windows.Forms.Button();
            this.b_cerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_refrescar = new System.Windows.Forms.Button();
            this.b_eliminar = new System.Windows.Forms.Button();
            this.b_agregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nombrePais);
            this.groupBox1.Controls.Add(this.txt_codigoPais);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(255, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 90);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solo Busqueda";
            // 
            // txt_nombrePais
            // 
            this.txt_nombrePais.Location = new System.Drawing.Point(105, 57);
            this.txt_nombrePais.Name = "txt_nombrePais";
            this.txt_nombrePais.Size = new System.Drawing.Size(165, 20);
            this.txt_nombrePais.TabIndex = 3;
            // 
            // txt_codigoPais
            // 
            this.txt_codigoPais.Location = new System.Drawing.Point(105, 26);
            this.txt_codigoPais.Name = "txt_codigoPais";
            this.txt_codigoPais.Size = new System.Drawing.Size(165, 20);
            this.txt_codigoPais.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre del Pais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo del Pais\r\n\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 369);
            this.panel1.TabIndex = 74;
            // 
            // dgv_paises
            // 
            this.dgv_paises.BackgroundColor = System.Drawing.Color.White;
            this.dgv_paises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_paises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_paises.Location = new System.Drawing.Point(176, 124);
            this.dgv_paises.Name = "dgv_paises";
            this.dgv_paises.Size = new System.Drawing.Size(421, 232);
            this.dgv_paises.TabIndex = 78;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Pais";
            this.Column2.Name = "Column2";
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(207, 54);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(42, 47);
            this.b_aceptar.TabIndex = 77;
            this.b_aceptar.UseVisualStyleBackColor = true;
            // 
            // b_borrar
            // 
            this.b_borrar.Image = global::Restaurante.Properties.Resources.clean1;
            this.b_borrar.Location = new System.Drawing.Point(162, 55);
            this.b_borrar.Name = "b_borrar";
            this.b_borrar.Size = new System.Drawing.Size(39, 46);
            this.b_borrar.TabIndex = 76;
            this.b_borrar.UseVisualStyleBackColor = true;
            // 
            // b_cerrar
            // 
            this.b_cerrar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cerrar.Location = new System.Drawing.Point(207, 10);
            this.b_cerrar.Name = "b_cerrar";
            this.b_cerrar.Size = new System.Drawing.Size(42, 43);
            this.b_cerrar.TabIndex = 75;
            this.b_cerrar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurante.Properties.Resources.images2;
            this.pictureBox1.Location = new System.Drawing.Point(6, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 208);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // b_refrescar
            // 
            this.b_refrescar.Image = global::Restaurante.Properties.Resources.refrescar;
            this.b_refrescar.Location = new System.Drawing.Point(162, 10);
            this.b_refrescar.Name = "b_refrescar";
            this.b_refrescar.Size = new System.Drawing.Size(39, 43);
            this.b_refrescar.TabIndex = 73;
            this.b_refrescar.Text = "\r\n";
            this.b_refrescar.UseVisualStyleBackColor = true;
            // 
            // b_eliminar
            // 
            this.b_eliminar.Image = global::Restaurante.Properties.Resources.refurl;
            this.b_eliminar.Location = new System.Drawing.Point(557, 58);
            this.b_eliminar.Name = "b_eliminar";
            this.b_eliminar.Size = new System.Drawing.Size(51, 39);
            this.b_eliminar.TabIndex = 72;
            this.b_eliminar.UseVisualStyleBackColor = true;
            // 
            // b_agregar
            // 
            this.b_agregar.Image = global::Restaurante.Properties.Resources.green_add_icon;
            this.b_agregar.Location = new System.Drawing.Point(557, 11);
            this.b_agregar.Name = "b_agregar";
            this.b_agregar.Size = new System.Drawing.Size(51, 42);
            this.b_agregar.TabIndex = 71;
            this.b_agregar.UseVisualStyleBackColor = true;
            // 
            // frm_ListaPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(615, 368);
            this.Controls.Add(this.dgv_paises);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.b_borrar);
            this.Controls.Add(this.b_cerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.b_refrescar);
            this.Controls.Add(this.b_eliminar);
            this.Controls.Add(this.b_agregar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_ListaPaises";
            this.Text = "Lista de Paises";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nombrePais;
        private System.Windows.Forms.TextBox txt_codigoPais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_agregar;
        private System.Windows.Forms.Button b_eliminar;
        private System.Windows.Forms.Button b_refrescar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_cerrar;
        private System.Windows.Forms.Button b_borrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.DataGridView dgv_paises;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}