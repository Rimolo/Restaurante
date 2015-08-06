namespace Restaurante
{
    partial class frm_menuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restauranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restauranteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.licoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_seguridad = new System.Windows.Forms.Button();
            this.b_reportes = new System.Windows.Forms.Button();
            this.b_proveedores = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_clientes = new System.Windows.Forms.Button();
            this.b_administracion = new System.Windows.Forms.Button();
            this.b_restaurantes = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmr_hora = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionToolStripMenuItem,
            this.reiniciarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.informacionToolStripMenuItem.Text = "Informacion";
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.reiniciarToolStripMenuItem.Text = "Reiniciar Sesion";
            this.reiniciarToolStripMenuItem.Click += new System.EventHandler(this.reiniciarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem1,
            this.seguridadToolStripMenuItem,
            this.restauranteToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // sistemaToolStripMenuItem1
            // 
            this.sistemaToolStripMenuItem1.Name = "sistemaToolStripMenuItem1";
            this.sistemaToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.sistemaToolStripMenuItem1.Text = "Sistema";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // restauranteToolStripMenuItem
            // 
            this.restauranteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restauranteToolStripMenuItem1,
            this.licoresToolStripMenuItem,
            this.vinosToolStripMenuItem});
            this.restauranteToolStripMenuItem.Name = "restauranteToolStripMenuItem";
            this.restauranteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.restauranteToolStripMenuItem.Text = "Restaurante";
            // 
            // restauranteToolStripMenuItem1
            // 
            this.restauranteToolStripMenuItem1.Name = "restauranteToolStripMenuItem1";
            this.restauranteToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.restauranteToolStripMenuItem1.Text = "Restaurante";
            // 
            // licoresToolStripMenuItem
            // 
            this.licoresToolStripMenuItem.Name = "licoresToolStripMenuItem";
            this.licoresToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.licoresToolStripMenuItem.Text = "Licores";
            // 
            // vinosToolStripMenuItem
            // 
            this.vinosToolStripMenuItem.Name = "vinosToolStripMenuItem";
            this.vinosToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.vinosToolStripMenuItem.Text = "Vinos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_seguridad);
            this.groupBox1.Controls.Add(this.b_reportes);
            this.groupBox1.Controls.Add(this.b_proveedores);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.b_clientes);
            this.groupBox1.Controls.Add(this.b_administracion);
            this.groupBox1.Controls.Add(this.b_restaurantes);
            this.groupBox1.Location = new System.Drawing.Point(81, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 349);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // b_seguridad
            // 
            this.b_seguridad.Image = global::Restaurante.Properties.Resources.icono_seguridad;
            this.b_seguridad.Location = new System.Drawing.Point(51, 32);
            this.b_seguridad.Name = "b_seguridad";
            this.b_seguridad.Size = new System.Drawing.Size(133, 133);
            this.b_seguridad.TabIndex = 16;
            this.b_seguridad.UseVisualStyleBackColor = true;
            this.b_seguridad.Click += new System.EventHandler(this.b_seguridad_Click);
            // 
            // b_reportes
            // 
            this.b_reportes.Image = global::Restaurante.Properties.Resources.blacklist_folder_icon;
            this.b_reportes.Location = new System.Drawing.Point(469, 198);
            this.b_reportes.Name = "b_reportes";
            this.b_reportes.Size = new System.Drawing.Size(142, 142);
            this.b_reportes.TabIndex = 15;
            this.b_reportes.UseVisualStyleBackColor = true;
            this.b_reportes.Click += new System.EventHandler(this.b_reportes_Click);
            // 
            // b_proveedores
            // 
            this.b_proveedores.Image = global::Restaurante.Properties.Resources.icono_proveedores1;
            this.b_proveedores.Location = new System.Drawing.Point(51, 198);
            this.b_proveedores.Name = "b_proveedores";
            this.b_proveedores.Size = new System.Drawing.Size(133, 128);
            this.b_proveedores.TabIndex = 14;
            this.b_proveedores.UseVisualStyleBackColor = true;
            this.b_proveedores.Click += new System.EventHandler(this.b_proveedores_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Seguridad ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Reportes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Administracion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Proveedores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Restaurantes";
            // 
            // b_clientes
            // 
            this.b_clientes.Image = global::Restaurante.Properties.Resources.users;
            this.b_clientes.Location = new System.Drawing.Point(469, 32);
            this.b_clientes.Name = "b_clientes";
            this.b_clientes.Size = new System.Drawing.Size(142, 133);
            this.b_clientes.TabIndex = 5;
            this.b_clientes.UseVisualStyleBackColor = true;
            this.b_clientes.Click += new System.EventHandler(this.b_clientes_Click);
            // 
            // b_administracion
            // 
            this.b_administracion.Image = global::Restaurante.Properties.Resources.Cambio_de_Contraseña;
            this.b_administracion.Location = new System.Drawing.Point(261, 198);
            this.b_administracion.Name = "b_administracion";
            this.b_administracion.Size = new System.Drawing.Size(144, 142);
            this.b_administracion.TabIndex = 6;
            this.b_administracion.UseVisualStyleBackColor = true;
            this.b_administracion.Click += new System.EventHandler(this.b_administracion_Click);
            // 
            // b_restaurantes
            // 
            this.b_restaurantes.Image = global::Restaurante.Properties.Resources.Cubiertos;
            this.b_restaurantes.Location = new System.Drawing.Point(261, 32);
            this.b_restaurantes.Name = "b_restaurantes";
            this.b_restaurantes.Size = new System.Drawing.Size(144, 133);
            this.b_restaurantes.TabIndex = 1;
            this.b_restaurantes.UseVisualStyleBackColor = true;
            this.b_restaurantes.Click += new System.EventHandler(this.b_restaurantes_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 421);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(807, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "Usuario";
            // 
            // tmr_hora
            // 
            this.tmr_hora.Tick += new System.EventHandler(this.tmr_hora_Tick);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // frm_menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(807, 443);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_menuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frm_menuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restauranteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restauranteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem licoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vinosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_clientes;
        private System.Windows.Forms.Button b_administracion;
        private System.Windows.Forms.Button b_restaurantes;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer tmr_hora;
        private System.Windows.Forms.Button b_proveedores;
        private System.Windows.Forms.Button b_reportes;
        private System.Windows.Forms.Button b_seguridad;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}