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
        public frm_tipoBebida()
        {
            InitializeComponent();
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (rb_calientes.Checked == true)
            {
                frm_listaBedidasCalientes calientes = new frm_listaBedidasCalientes();
                calientes.Show();
            }
            else
            {
                if (rb_heladas.Checked == true)
                {
                    frm_listaBebidaHelada heladas = new frm_listaBebidaHelada();
                    heladas.Show();
                }
                else
                {
                    if (rb_gaseosas.Checked == true)
                    {
                        frm_listaBebidasGaseosas gaseosas = new frm_listaBebidasGaseosas();
                        gaseosas.Show();
                    }
                    else
                    {
                        if (rb_licores.Checked == true)
                        {
                            frmListaLicores licores = new frmListaLicores();
                            licores.Show();
                        }
                        else
                        {
                            if (rb_vinos.Checked == true)
                            {
                                frm_listaVinos vinos = new frm_listaVinos();
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
    }
}
