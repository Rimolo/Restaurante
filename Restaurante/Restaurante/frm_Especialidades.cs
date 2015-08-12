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
    public partial class frm_Especialidades : Form
    {
        private string _nick;

        public string nick
        {
            get { return _nick; }
            set { _nick = value; }
        }

        public frm_Especialidades()
        {
            InitializeComponent();
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (rb_buffet.Checked == true)
            {
                frm_Listabuffet buffet = new frm_Listabuffet();
                buffet.nick = _nick;
                buffet.Show();
            }
            else
            {
                if (rb_bebidas.Checked == true)
                {
                    frm_tipoBebida bebidas = new frm_tipoBebida();
                    bebidas.nick = _nick;
                    bebidas.Show();
                }
                else
                {
                    if (rb_especialidades.Checked == true)
                    {
                        frm_listaEspecialidades especiales = new frm_listaEspecialidades();
                        especiales.nick = _nick;
                        especiales.Show();
                    }
                }
            }
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Especialidades_Load(object sender, EventArgs e)
        {

        }
    }
}
