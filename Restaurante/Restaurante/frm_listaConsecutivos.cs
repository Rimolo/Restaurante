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
    public partial class frm_listaConsecutivos : Form
    {
        public frm_listaConsecutivos()
        {
            InitializeComponent();
        }

        private void b_agregar_Click(object sender, EventArgs e)
        {
            frm_consecutivos consecutivos = new frm_consecutivos();
            consecutivos.Show();
        }
    }
}
