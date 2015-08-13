using System;
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

        private int _privilegio;

        public int privilegio
        {
            get { return _privilegio; }
            set { _privilegio = value; }
        }
        public frm_ventanaSeguridad()
        {
            InitializeComponent();
        }
         
        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (rb_cajas.Checked)
            {
                frm_listaCajas cajas = new frm_listaCajas();
                cajas.Tag = this;
                cajas.Show(this);
                this.Hide();
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
                frm_ListaPaises paises = new frm_ListaPaises();
                paises.Tag = this;
                paises.Show(this);
                this.Hide();
            }
            else if (rb_usuarios.Checked) {
                frm_listaUsuarios usuarios = new frm_listaUsuarios();
                usuarios.Tag = this;
                usuarios.Show(this);
                this.Hide();
            }
            else if (rb_unidadesMedida.Checked)
            {
                frm_listaUnidadesMedida unidades = new frm_listaUnidadesMedida();
                unidades.Tag = this;
                unidades.Show(this);
                this.Hide();
            }
            else if (rb_rolesEventos.Checked)
            {
                frm_listaRoles roles = new frm_listaRoles();
                roles.Tag = this;
                roles.Show(this);
                this.Hide();
            }
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ventanaSeguridad_Load(object sender, EventArgs e)
        {
            if (_privilegio == 1) {
                rb_usuarios.Enabled = false;
                rb_unidadesMedida.Enabled = false;
                rb_rolesEventos.Enabled = false;
                rb_paises.Enabled = false;
                rb_consecutivos.Enabled = false;
               

            }
        }
    }
}
