﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class frm_ventanaSeguridad : Form
    {
        public frm_ventanaSeguridad()
        {
            InitializeComponent();
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (rb_cajas.Checked)
            {

            }
            else if (rb_consecutivos.Checked)
            {
                frm_listaConsecutivos consecutivos = new frm_listaConsecutivos();
                consecutivos.Tag = this;
                consecutivos.Show(this);
                this.Hide();
            }
            else if (rb_paises.Checked)
            {

            }
            else if (rb_usuarios.Checked) {
                frm_listaUsuarios usuarios = new frm_listaUsuarios();
                usuarios.Tag = this;
                usuarios.Show(this);
                this.Hide();
            }
            else if (rb_unidadesMedida.Checked)
            {

            }
            else if (rb_rolesEventos.Checked)
            {
                
            }
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
