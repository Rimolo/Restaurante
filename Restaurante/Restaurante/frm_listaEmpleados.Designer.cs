﻿namespace Restaurante
{
    partial class frm_listaEmpleados
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nombreEmpleado = new System.Windows.Forms.TextBox();
            this.txt_codigoEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_mas = new System.Windows.Forms.Button();
            this.b_menos = new System.Windows.Forms.Button();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.b_borrar = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.b_refrescar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(206, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 232);
            this.dataGridView1.TabIndex = 36;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cedula";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Primer Apellido";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Segundo Apellido";
            this.Column5.Name = "Column5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nombreEmpleado);
            this.groupBox1.Controls.Add(this.txt_codigoEmpleado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(364, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 90);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solo Busqueda";
            // 
            // txt_nombreEmpleado
            // 
            this.txt_nombreEmpleado.Location = new System.Drawing.Point(143, 59);
            this.txt_nombreEmpleado.Name = "txt_nombreEmpleado";
            this.txt_nombreEmpleado.Size = new System.Drawing.Size(132, 20);
            this.txt_nombreEmpleado.TabIndex = 3;
            // 
            // txt_codigoEmpleado
            // 
            this.txt_codigoEmpleado.Location = new System.Drawing.Point(143, 26);
            this.txt_codigoEmpleado.Name = "txt_codigoEmpleado";
            this.txt_codigoEmpleado.Size = new System.Drawing.Size(132, 20);
            this.txt_codigoEmpleado.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre del Empleado\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo del Empleado\r\n";
            // 
            // b_mas
            // 
            this.b_mas.Location = new System.Drawing.Point(673, 21);
            this.b_mas.Name = "b_mas";
            this.b_mas.Size = new System.Drawing.Size(55, 23);
            this.b_mas.TabIndex = 41;
            this.b_mas.Text = "button5";
            this.b_mas.UseVisualStyleBackColor = true;
            // 
            // b_menos
            // 
            this.b_menos.Location = new System.Drawing.Point(673, 60);
            this.b_menos.Name = "b_menos";
            this.b_menos.Size = new System.Drawing.Size(55, 23);
            this.b_menos.TabIndex = 42;
            this.b_menos.Text = "button6";
            this.b_menos.UseVisualStyleBackColor = true;
            // 
            // b_aceptar
            // 
            this.b_aceptar.Image = global::Restaurante.Properties.Resources.Aceptar4;
            this.b_aceptar.Location = new System.Drawing.Point(292, 60);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(52, 47);
            this.b_aceptar.TabIndex = 40;
            this.b_aceptar.UseVisualStyleBackColor = true;
            // 
            // b_borrar
            // 
            this.b_borrar.Image = global::Restaurante.Properties.Resources.Eliminar12;
            this.b_borrar.Location = new System.Drawing.Point(234, 60);
            this.b_borrar.Name = "b_borrar";
            this.b_borrar.Size = new System.Drawing.Size(52, 47);
            this.b_borrar.TabIndex = 39;
            this.b_borrar.UseVisualStyleBackColor = true;
            // 
            // b_cancelar
            // 
            this.b_cancelar.Image = global::Restaurante.Properties.Resources.Cancelar4;
            this.b_cancelar.Location = new System.Drawing.Point(292, 11);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(52, 43);
            this.b_cancelar.TabIndex = 38;
            this.b_cancelar.UseVisualStyleBackColor = true;
            // 
            // b_refrescar
            // 
            this.b_refrescar.Image = global::Restaurante.Properties.Resources.Actualizar;
            this.b_refrescar.Location = new System.Drawing.Point(234, 10);
            this.b_refrescar.Name = "b_refrescar";
            this.b_refrescar.Size = new System.Drawing.Size(52, 44);
            this.b_refrescar.TabIndex = 5;
            this.b_refrescar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Image = global::Restaurante.Properties.Resources.Crear2;
            this.label1.Location = new System.Drawing.Point(-1, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 363);
            this.label1.TabIndex = 3;
            // 
            // frm_listaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(766, 360);
            this.Controls.Add(this.b_menos);
            this.Controls.Add(this.b_mas);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.b_borrar);
            this.Controls.Add(this.b_cancelar);
            this.Controls.Add(this.b_refrescar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frm_listaEmpleados";
            this.Text = "Lista de Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nombreEmpleado;
        private System.Windows.Forms.TextBox txt_codigoEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_refrescar;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.Button b_borrar;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Button b_mas;
        private System.Windows.Forms.Button b_menos;
    }
}