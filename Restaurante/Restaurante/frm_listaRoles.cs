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
    public partial class frm_listaRoles : Form
    {
        public frm_listaRoles()
        {
            InitializeComponent();
        }

        private void b_agregar_Click(object sender, EventArgs e)
        {
            frm_roles roles = new frm_roles();
            roles.accion = "Insertar";
            roles.Tag=this;
            roles.Show(this);
            Hide();
           
        }
    }
}
