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
using System.IO;

namespace Restaurante
{
    public partial class frm_PiccollaStella : Form
    {
        InfoRestaurantes objRestaurantes = new InfoRestaurantes();
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
            tmr_hora.Start();
            toolStripStatusLabel2.Text = _nick;
            objRestaurantes.codRest = _codRest;
            objRestaurantes.fecha = DateTime.Today.ToString("dd/MM/yyyy");          
        }

        private void tmr_hora_Tick(object sender, EventArgs e)
        {
            DateTime hora = DateTime.Now;
            toolStripStatusLabel4.Text = hora.ToString();
        }

        private void b_mesas_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            int oc = objRestaurantes.cargar_mesasOcupadas();
            label27.Text = oc.ToString();
            label30.Text = (23 - oc).ToString();
        }

        private void b_reservaciones_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            int res = objRestaurantes.cargar_reservadas();
            label33.Text = res.ToString();
            label35.Text = (23 - res).ToString();
        }

        private void b_clientes_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            int barra = objRestaurantes.cargar_barra();
            int mesas = objRestaurantes.cargar_mesasOcupadas();
            int res = objRestaurantes.cargar_reservadas();
            label39.Text = barra.ToString();
            label41.Text = mesas.ToString();
            label43.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            dgv_prod.AutoGenerateColumns = false;
            dgv_prod.DataSource = objRestaurantes.carga_especiales().Tables[0];
            
        }

        private void b_salirMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void b_mesa1_Click(object sender, EventArgs e)
        {
            frm_clientes clientes = new frm_clientes();
            clientes.nombreR = "Piccola Stella";
            clientes.codR = _codRest;
            clientes.cantSillas = 2;
            clientes.numeroMesa = 1;
            clientes.accion = "Insertar";
            clientes.Show();
            
        }

        private void b_mesa7_Click(object sender, EventArgs e)
        {
            frm_clientes clientes = new frm_clientes();
            clientes.nombreR = "Piccola Stella";
            clientes.codR = _codRest;
            clientes.cantSillas = 4;
            clientes.numeroMesa = 7;
            clientes.accion = "Insertar";
            clientes.Show();
        }

        private void reiniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cierreCaja caja = new frm_cierreCaja();
            caja.nick = _nick;
            caja.accion = "Reiniciar";
            caja.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cierreCaja caja = new frm_cierreCaja();
            caja.nick = _nick;
            caja.accion = "Salir";
            caja.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listaPagoClientes clientes = new frm_listaPagoClientes();
            clientes.codR = _codRest;
            clientes.Show();
        }

        private void rb_barraAbierta_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_barraAbierta.Checked) {
                label_estado.Visible = true;
                label_estado.Text = "Abierta";
                b_barras.Visible = true;
            }
            
        }

        private void rb_barraCerrada_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_barraCerrada.Checked)
            {
                label_estado.Visible = true;
                label_estado.Text = "Cerrada";
                b_barras.Visible = false;
            }
        }

        private void rb_barraAbierta2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_barraAbierta2.Checked)
            {
                label44.Visible = true;
                label44.Text = "Abierta";
                b_barras2.Visible = true;
            }
        }

        private void rb_barraCerrada2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_barraCerrada2.Checked)
            {
                label44.Visible = true;
                label44.Text = "Cerrada";
                b_barras2.Visible = false;
            }
        }

        private void b_barras2_Click(object sender, EventArgs e)
        {
            frmListaBarras barra = new frmListaBarras();
            barra.nombreR = "Piccola Stella";
            barra.codR = _codRest;
            barra.Show();
        }

        private void b_barras_Click(object sender, EventArgs e)
        {
            frmListaBarras barra = new frmListaBarras();
            barra.nombreR = "Piccola Stella";
            barra.codR = _codRest;
            barra.Show();
        }

        private void dgv_prod_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            objRestaurantes.nombreEspecial = dgv_prod.Rows[e.RowIndex].Cells[0].Value.ToString();
            objRestaurantes.cargar_imagen();
            if (objRestaurantes.imagen!=null)
            {
                MemoryStream ms = new MemoryStream(objRestaurantes.imagen);
                pic_producto.Image = Image.FromStream(ms);
                pic_producto.SizeMode = PictureBoxSizeMode.StretchImage;
                ms.Close();
            }
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
