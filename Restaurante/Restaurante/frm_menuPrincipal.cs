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
    public partial class frm_menuPrincipal : Form
    {
        public List<string> lista = new List<string>();


        public frm_menuPrincipal()
        {
            InitializeComponent();
        }

        private void frm_menuPrincipal_Load(object sender, EventArgs e)
        {
            tmr_hora.Start();
            toolStripStatusLabel2.Text = "";
            foreach (string item in lista)
            {
                toolStripStatusLabel2.Text += item;
                toolStripStatusLabel2.Text += " ";
                
            }
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea Cerrar la Sesión", "Inicio de Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                var form1 = (frm_login)Tag;
                form1.Show();
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
               
            }
            
        }

        private void tmr_hora_Tick(object sender, EventArgs e)
        {
            DateTime hora = DateTime.Now;
            toolStripStatusLabel3.Text = hora.ToString();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b_seguridad_Click(object sender, EventArgs e)
        {
            frm_ventanaSeguridad ventana = new frm_ventanaSeguridad();
            ventana.Show();
        }

        private void b_restaurantes_Click(object sender, EventArgs e)
        {
            frm_listaRestaurantes restaurantes = new frm_listaRestaurantes();
            restaurantes.Show();
        }

        private void b_clientes_Click(object sender, EventArgs e)
        {

        }

        private void b_proveedores_Click(object sender, EventArgs e)
        {

        }

        private void b_administracion_Click(object sender, EventArgs e)
        {

        }

        private void b_reportes_Click(object sender, EventArgs e)
        {

        }
    }
}
