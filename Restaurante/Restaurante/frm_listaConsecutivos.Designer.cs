namespace Restaurante
{
    partial class frm_listaConsecutivos
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_descripcionConsecutivo = new System.Windows.Forms.TextBox();
            this.txt_codigoConsecutivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_consecutivos = new System.Windows.Forms.DataGridView();
            this.b_eliminar = new System.Windows.Forms.Button();
            this.b_agregar = new System.Windows.Forms.Button();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.b_borrar = new System.Windows.Forms.Button();
            this.b_cerrar = new System.Windows.Forms.Button();
            this.b_refrescar = new System.Windows.Forms.Button();
            this.restauranteDataSet = new Restaurante.RestauranteDataSet();
            this.consecutivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consecutivosTableAdapter = new Restaurante.RestauranteDataSetTableAdapters.ConsecutivosTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prefijo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consecutivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consecutivosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 386);
            this.panel1.TabIndex = 63;
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
            this.groupBox1.Controls.Add(this.txt_descripcionConsecutivo);
            this.groupBox1.Controls.Add(this.txt_codigoConsecutivo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(313, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 90);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solo Busqueda";
            // 
            // txt_descripcionConsecutivo
            // 
            this.txt_descripcionConsecutivo.Location = new System.Drawing.Point(152, 54);
            this.txt_descripcionConsecutivo.Name = "txt_descripcionConsecutivo";
            this.txt_descripcionConsecutivo.Size = new System.Drawing.Size(230, 20);
            this.txt_descripcionConsecutivo.TabIndex = 3;
            // 
            // txt_codigoConsecutivo
            // 
            this.txt_codigoConsecutivo.Location = new System.Drawing.Point(152, 26);
            this.txt_codigoConsecutivo.Name = "txt_codigoConsecutivo";
            this.txt_codigoConsecutivo.Size = new System.Drawing.Size(132, 20);
            this.txt_codigoConsecutivo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "descripcion del Consecutivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo del Consecutivo\r\n";
            // 
            // dgv_consecutivos
            // 
            this.dgv_consecutivos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_consecutivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consecutivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Prefijo});
            this.dgv_consecutivos.Location = new System.Drawing.Point(226, 133);
            this.dgv_consecutivos.Name = "dgv_consecutivos";
            this.dgv_consecutivos.ReadOnly = true;
            this.dgv_consecutivos.Size = new System.Drawing.Size(563, 232);
            this.dgv_consecutivos.TabIndex = 77;
            this.dgv_consecutivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consecutivos_CellContentClick);
            // 
            // b_eliminar
            // 
            this.b_eliminar.Image = global::Restaurante.Properties.Resources.refurl;
            this.b_eliminar.Location = new System.Drawing.Point(732, 69);
            this.b_eliminar.Name = "b_eliminar";
            this.b_eliminar.Size = new System.Drawing.Size(51, 39);
            this.b_eliminar.TabIndex = 75;
            this.b_eliminar.UseVisualStyleBackColor = true;
            this.b_eliminar.Click += new System.EventHandler(this.b_eliminar_Click);
            // 
            // b_agregar
            // 
            this.b_agregar.Image = global::Restaurante.Properties.Resources.green_add_icon;
            this.b_agregar.Location = new System.Drawing.Point(732, 22);
            this.b_agregar.Name = "b_agregar";
            this.b_agregar.Size = new System.Drawing.Size(51, 42);
            this.b_agregar.TabIndex = 74;
            this.b_agregar.UseVisualStyleBackColor = true;
            this.b_agregar.Click += new System.EventHandler(this.b_agregar_Click);
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(265, 61);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(42, 47);
            this.b_aceptar.TabIndex = 73;
            this.b_aceptar.UseVisualStyleBackColor = true;
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // b_borrar
            // 
            this.b_borrar.Image = global::Restaurante.Properties.Resources.clean1;
            this.b_borrar.Location = new System.Drawing.Point(220, 61);
            this.b_borrar.Name = "b_borrar";
            this.b_borrar.Size = new System.Drawing.Size(39, 47);
            this.b_borrar.TabIndex = 72;
            this.b_borrar.UseVisualStyleBackColor = true;
            this.b_borrar.Click += new System.EventHandler(this.b_borrar_Click);
            // 
            // b_cerrar
            // 
            this.b_cerrar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cerrar.Location = new System.Drawing.Point(265, 12);
            this.b_cerrar.Name = "b_cerrar";
            this.b_cerrar.Size = new System.Drawing.Size(42, 43);
            this.b_cerrar.TabIndex = 71;
            this.b_cerrar.UseVisualStyleBackColor = true;
            this.b_cerrar.Click += new System.EventHandler(this.b_cerrar_Click);
            // 
            // b_refrescar
            // 
            this.b_refrescar.Image = global::Restaurante.Properties.Resources.refrescar;
            this.b_refrescar.Location = new System.Drawing.Point(220, 12);
            this.b_refrescar.Name = "b_refrescar";
            this.b_refrescar.Size = new System.Drawing.Size(39, 43);
            this.b_refrescar.TabIndex = 70;
            this.b_refrescar.Text = "\r\n";
            this.b_refrescar.UseVisualStyleBackColor = true;
            this.b_refrescar.Click += new System.EventHandler(this.b_refrescar_Click);
            // 
            // restauranteDataSet
            // 
            this.restauranteDataSet.DataSetName = "RestauranteDataSet";
            this.restauranteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consecutivosBindingSource
            // 
            this.consecutivosBindingSource.DataMember = "Consecutivos";
            this.consecutivosBindingSource.DataSource = this.restauranteDataSet;
            // 
            // consecutivosTableAdapter
            // 
            this.consecutivosTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "codConsecutivo";
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tipo";
            this.Column2.HeaderText = "Tipo";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "descripcion";
            this.Column3.HeaderText = "Descripcion";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "valor";
            this.Column4.HeaderText = "Valor del Consecutivo";
            this.Column4.Name = "Column4";
            // 
            // Prefijo
            // 
            this.Prefijo.HeaderText = "Contiene prefijo";
            this.Prefijo.Name = "Prefijo";
            // 
            // frm_listaConsecutivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(797, 386);
            this.Controls.Add(this.dgv_consecutivos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b_eliminar);
            this.Controls.Add(this.b_agregar);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.b_borrar);
            this.Controls.Add(this.b_cerrar);
            this.Controls.Add(this.b_refrescar);
            this.Controls.Add(this.panel1);
            this.Name = "frm_listaConsecutivos";
            this.Text = " Lista de Consecutivos";
            this.Load += new System.EventHandler(this.frm_listaConsecutivos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consecutivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consecutivosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b_refrescar;
        private System.Windows.Forms.Button b_cerrar;
        private System.Windows.Forms.Button b_borrar;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Button b_agregar;
        private System.Windows.Forms.Button b_eliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_descripcionConsecutivo;
        private System.Windows.Forms.TextBox txt_codigoConsecutivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_consecutivos;
        private RestauranteDataSet restauranteDataSet;
        private System.Windows.Forms.BindingSource consecutivosBindingSource;
        private RestauranteDataSetTableAdapters.ConsecutivosTableAdapter consecutivosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Prefijo;
    }
}