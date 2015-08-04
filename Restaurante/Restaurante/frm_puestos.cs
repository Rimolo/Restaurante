using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Restaurante
{
    public partial class frm_puestos : Form
    {
        
        private string _accion;

        public string accion
        {
            get { return _accion; }
            set { _accion = value; }
        }

        public frm_puestos()
        {
            InitializeComponent();
        }

        private void frm_puestos_Load(object sender, EventArgs e)
        {
            if(_accion == "Editar")
            {

            }

        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
