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
    public partial class frm_PiccollaStella : Form
    {
        private string _nick;
        

        public string nick
        {
            get { return _nick; }
            set { _nick = value; }
        }

        private string _codRest;


        public string codRest
        {
            get { return _codRest; }
            set { _codRest = value; }
        }

        public frm_PiccollaStella()
        {
            InitializeComponent();
        }

        private void frm_PiccollaStella_Load(object sender, EventArgs e)
        {
       //     tmr_hora.Start();
            toolStripStatusLabel2.Text = _nick;
                      
        }

        private void tmr_hora_Tick(object sender, EventArgs e)
        {
            DateTime hora = DateTime.Now;
            toolStripStatusLabel4.Text = hora.ToString();
        }

        private void b_mesas_Click(object sender, EventArgs e)
        {

        }

        private void b_reservaciones_Click(object sender, EventArgs e)
        {

        }

        private void b_clientes_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void b_salirMenu_Click(object sender, EventArgs e)
        {

        }

        private void b_mesa1_Click(object sender, EventArgs e)
        {
            frm_clientes clientes = new frm_clientes();
            clientes.nombreR = "Piccola Stella";
            clientes.codR = _codRest;
            clientes.cantSillas = 2;
            clientes.numeroMesa = 1;
            clientes.accion = "Insertar";
            clientes.Show(this);
            
        }

        private void b_mesa7_Click(object sender, EventArgs e)
        {

        }

        private void reiniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rb_barraAbierta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_barraCerrada_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_barraAbierta2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_barraCerrada2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void b_barras_Click(object sender, EventArgs e)
        {

        }

        private void dgv_prod_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void b_mesa2_Click(object sender, EventArgs e)
        {

        }

        private void b_mesa3_Click(object sender, EventArgs e)
        {

        }

        private void b_mesa4_Click(object sender, EventArgs e)
        {

        }

        private void b_mesa5_Click(object sender, EventArgs e)
        {

        }

        private void b_mesa6_Click(object sender, EventArgs e)
        {

        }

        private void b_mesa8_Click(object sender, EventArgs e)
        {

        }

        private void b_mesa9_Click(object sender, EventArgs e)
        {

        }

        private void b_mesa10_Click(object sender, EventArgs e)
        {

        }

        private void b_mesa11_Click(object sender, EventArgs e)
        {

        }

        private void b_mesa12_Click(object sender, EventArgs e)
        {

        }

        private void b_mesa13_Click(object sender, EventArgs e)
        {

        }

        private void b_mesa14_Click(object sender, EventArgs e)
        {

        }

        private void b_mesa15_Click(object sender, EventArgs e)
        {

        }

        private void b_mesa16_Click(object sender, EventArgs e)
        {

        }

        private void b_mesa17_Click(object sender, EventArgs e)
        {

        }

        private void b_mesa18_Click(object sender, EventArgs e)
        {

        }

        private void b_mesa19_Click(object sender, EventArgs e)
        {

        }

        private void b_mesa20_Click(object sender, EventArgs e)
        {

        }

        private void b_mesa21_Click(object sender, EventArgs e)
        {

        }

        private void b_mesa22_Click(object sender, EventArgs e)
        {

        }

        private void b_mesa23_Click(object sender, EventArgs e)
        {

        }
    }
}
