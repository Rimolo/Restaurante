namespace Restaurante
{
    partial class frm_bitacora
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
            this.b_cerrar = new System.Windows.Forms.Button();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.cb_usuario = new System.Windows.Forms.ComboBox();
            this.cb_fechaFinal = new System.Windows.Forms.ComboBox();
            this.cb_fechaInicial = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_consultaUsuario = new System.Windows.Forms.RadioButton();
            this.rb_consultaGeneral = new System.Windows.Forms.RadioButton();
            this.rb_consultaFecha = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_bitacora = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bitacora)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_cerrar);
            this.groupBox1.Controls.Add(this.b_aceptar);
            this.groupBox1.Controls.Add(this.cb_usuario);
            this.groupBox1.Controls.Add(this.cb_fechaFinal);
            this.groupBox1.Controls.Add(this.cb_fechaInicial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rb_consultaUsuario);
            this.groupBox1.Controls.Add(this.rb_consultaGeneral);
            this.groupBox1.Controls.Add(this.rb_consultaFecha);
            this.groupBox1.Location = new System.Drawing.Point(174, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de la Bitacora";
            // 
            // b_cerrar
            // 
            this.b_cerrar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cerrar.Location = new System.Drawing.Point(558, 77);
            this.b_cerrar.Name = "b_cerrar";
            this.b_cerrar.Size = new System.Drawing.Size(54, 48);
            this.b_cerrar.TabIndex = 69;
            this.b_cerrar.UseVisualStyleBackColor = true;
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(498, 77);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(54, 48);
            this.b_aceptar.TabIndex = 68;
            this.b_aceptar.UseVisualStyleBackColor = true;
            // 
            // cb_usuario
            // 
            this.cb_usuario.FormattingEnabled = true;
            this.cb_usuario.Location = new System.Drawing.Point(104, 109);
            this.cb_usuario.Name = "cb_usuario";
            this.cb_usuario.Size = new System.Drawing.Size(196, 21);
            this.cb_usuario.TabIndex = 8;
            // 
            // cb_fechaFinal
            // 
            this.cb_fechaFinal.FormattingEnabled = true;
            this.cb_fechaFinal.Location = new System.Drawing.Point(328, 64);
            this.cb_fechaFinal.Name = "cb_fechaFinal";
            this.cb_fechaFinal.Size = new System.Drawing.Size(145, 21);
            this.cb_fechaFinal.TabIndex = 7;
            // 
            // cb_fechaInicial
            // 
            this.cb_fechaInicial.FormattingEnabled = true;
            this.cb_fechaInicial.Location = new System.Drawing.Point(88, 65);
            this.cb_fechaInicial.Name = "cb_fechaInicial";
            this.cb_fechaInicial.Size = new System.Drawing.Size(136, 21);
            this.cb_fechaInicial.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Inicial";
            // 
            // rb_consultaUsuario
            // 
            this.rb_consultaUsuario.AutoSize = true;
            this.rb_consultaUsuario.Location = new System.Drawing.Point(350, 20);
            this.rb_consultaUsuario.Name = "rb_consultaUsuario";
            this.rb_consultaUsuario.Size = new System.Drawing.Size(123, 17);
            this.rb_consultaUsuario.TabIndex = 2;
            this.rb_consultaUsuario.TabStop = true;
            this.rb_consultaUsuario.Text = "Consulta por Usuario";
            this.rb_consultaUsuario.UseVisualStyleBackColor = true;
            // 
            // rb_consultaGeneral
            // 
            this.rb_consultaGeneral.AutoSize = true;
            this.rb_consultaGeneral.Location = new System.Drawing.Point(210, 19);
            this.rb_consultaGeneral.Name = "rb_consultaGeneral";
            this.rb_consultaGeneral.Size = new System.Drawing.Size(106, 17);
            this.rb_consultaGeneral.TabIndex = 1;
            this.rb_consultaGeneral.TabStop = true;
            this.rb_consultaGeneral.Text = "Consulta General";
            this.rb_consultaGeneral.UseVisualStyleBackColor = true;
            // 
            // rb_consultaFecha
            // 
            this.rb_consultaFecha.AutoSize = true;
            this.rb_consultaFecha.Location = new System.Drawing.Point(15, 20);
            this.rb_consultaFecha.Name = "rb_consultaFecha";
            this.rb_consultaFecha.Size = new System.Drawing.Size(170, 17);
            this.rb_consultaFecha.TabIndex = 0;
            this.rb_consultaFecha.TabStop = true;
            this.rb_consultaFecha.Text = "Consultar por Rango de Fecha";
            this.rb_consultaFecha.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_bitacora);
            this.groupBox2.Location = new System.Drawing.Point(174, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 276);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Despliegue de Informacion";
            // 
            // dgv_bitacora
            // 
            this.dgv_bitacora.BackgroundColor = System.Drawing.Color.White;
            this.dgv_bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column3});
            this.dgv_bitacora.Location = new System.Drawing.Point(15, 19);
            this.dgv_bitacora.Name = "dgv_bitacora";
            this.dgv_bitacora.Size = new System.Drawing.Size(597, 248);
            this.dgv_bitacora.TabIndex = 49;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo del registro";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Usuario";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha y Hora";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Descripcion";
            this.Column5.Name = "Column5";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 459);
            this.panel1.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurante.Properties.Resources.Bitacora1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 164);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Detalle";
            this.Column3.Name = "Column3";
            // 
            // frm_bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(818, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_bitacora";
            this.Text = "Bitacora";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bitacora)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cb_usuario;
        private System.Windows.Forms.ComboBox cb_fechaFinal;
        private System.Windows.Forms.ComboBox cb_fechaInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_consultaUsuario;
        private System.Windows.Forms.RadioButton rb_consultaGeneral;
        private System.Windows.Forms.RadioButton rb_consultaFecha;
        private System.Windows.Forms.DataGridView dgv_bitacora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Button b_cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}