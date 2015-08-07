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
    public partial class frm_administracion : Form
    {
        private string _nick;

        public string nick
        {
            get { return _nick; }
            set { _nick = value; }
        }

        public frm_administracion()
        {
            InitializeComponent();
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (rb_puestos.Checked == true)
            {
                frm_listaPuestos puestos = new frm_listaPuestos();
                puestos.Show();
            }
            else
            {
                if (rb_Empleados.Checked == true)
                {
                    frm_listaEmpleados empleados = new frm_listaEmpleados();
                    empleados.Show();
                }
                else
                {
                    if (rb_mesas.Checked == true)
                    {
                        frm_listaMesas mesas = new frm_listaMesas();
                        mesas.Show();
                    }
                    else
                    {
                        if (rb_especiales.Checked == true)
                        {
                            frm_Especialidades especial = new frm_Especialidades();
                            especial.nick = _nick;
                            especial.Show();
                        }
                    }
                }
            }
        }

        private void frm_administracion_Load(object sender, EventArgs e)
        {

        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
