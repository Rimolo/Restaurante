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
    public partial class frm_catalogoProductos : Form
    {
        
        public frm_catalogoProductos()
        {
            InitializeComponent();
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (rb_comestibles.Checked == true)
            {
                frm_listaComestibles comestibles = new frm_listaComestibles();
                comestibles.Show();
            }
            else
            {
                if (rb_desechablesEmpaques.Checked == true)
                {
                    frm_listaEmpaques empaques = new frm_listaEmpaques();
                    empaques.Show();
                }
                else
                {
                    if (rb_limpieza.Checked == true)
                    {
                        frm_listaLimpieza limpieza = new frm_listaLimpieza();
                        limpieza.Show();
                    }
                    else
                    {
                        if (rb_tecnologia.Checked == true)
                        {
                            frm_listaTecnologia tecnologia = new frm_listaTecnologia();
                            tecnologia.Show();
                        }
                        else
                        {
                            if (rb_EquiposUtencilios.Checked == true)
                            {
                                frm_listaEquiposUtencilios utencilios = new frm_listaEquiposUtencilios();
                                utencilios.Show();
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

        private void frm_catalogoProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
