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
    public partial class frm_listaPuestos : Form
    {
        public frm_listaPuestos()
        {
            InitializeComponent();
        }

        private void frm_listaPuestos_Load(object sender, EventArgs e)
        {

        }

        private void b_mas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_puestos puestos = new frm_puestos();
            puestos.Show();
            puestos = null;
            this.Show();


        }
    }
}
