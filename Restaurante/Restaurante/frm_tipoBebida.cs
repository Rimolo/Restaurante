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
    public partial class frm_tipoBebida : Form
    {
        private string _nick;

        public string nick
        {
            get { return _nick; }
            set { _nick = value; }
        }

        public frm_tipoBebida()
        {
            InitializeComponent();
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (rb_calientes.Checked == true)
            {
                frm_listaBedidasCalientes calientes = new frm_listaBedidasCalientes();
                calientes.nick = _nick;
                calientes.Show();
            }
            else
            {
                if (rb_heladas.Checked == true)
                {
                    frm_listaBebidaHelada heladas = new frm_listaBebidaHelada();
                    heladas.nick = _nick;
                    heladas.Show();
                }
                else
                {
                    if (rb_gaseosas.Checked == true)
                    {
                        frm_listaBebidasGaseosas gaseosas = new frm_listaBebidasGaseosas();
                        gaseosas.nick = _nick;
                        gaseosas.Show();
                    }
                    else
                    {
                        if (rb_licores.Checked == true)
                        {
                            frmListaLicores licores = new frmListaLicores();
                            //   licores.nick = _nick;
                            licores.Show();
                        }
                        else
                        {
                            if (rb_vinos.Checked == true)
                            {
                                frm_listaVinos vinos = new frm_listaVinos();
                                //vinos.nick = _nick;
                                vinos.Show();
                            }
                        }
                    }
                }
            }
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_tipoBebida_Load(object sender, EventArgs e)
        {

        }
    }
}
