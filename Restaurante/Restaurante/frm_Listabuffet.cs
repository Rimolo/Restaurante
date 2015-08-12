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
    public partial class frm_Listabuffet : Form
    {
        Buffet obj_buffet = new Buffet();

        private string _nick;

        public string nick
        {
            get { return _nick; }
            set { _nick = value; }
        }

        public frm_Listabuffet()
        {
            InitializeComponent();
        }

        private void dgv_buffet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm_comidaBuffet buffet = new frm_comidaBuffet();
                buffet.accion = "Editar";
                buffet.nick = _nick;
                buffet.codigo = dgv_buffet.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
                buffet.ShowDialog();
            }
        }

        private void b_refrescar_Click(object sender, EventArgs e)
        {
            this.carga_lista_Buffet();
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigoComida.Text = "";
            txt_nombreComida.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            obj_buffet.codBuffet = null;
            obj_buffet.nombre = null;
            if (txt_codigoComida.Text != "")
            {
                obj_buffet.codBuffet = txt_codigoComida.Text;

            }
            else if (txt_nombreComida.Text != "")
            {
                obj_buffet.nombre = txt_nombreComida.Text;
            }

            try
            {
                dgv_buffet.AutoGenerateColumns = false;
                dgv_buffet.DataSource = obj_buffet.carga_Buffet_especificos().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void b_agregar_Click(object sender, EventArgs e)
        {
            frm_comidaBuffet buffet = new frm_comidaBuffet();
            buffet.accion = "Insertar";
            buffet.nick = _nick;
            buffet.Show();
        }

        private void b_eliminar_Click(object sender, EventArgs e)
        {
            string codigo = dgv_buffet.CurrentRow.Cells[0].Value.ToString().Replace(" ", "");
            obj_buffet.eliminar_Buffet(codigo);
            try
            {
                dgv_buffet.AutoGenerateColumns = false;
                dgv_buffet.DataSource = obj_buffet.carga_Buffet().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frm_Listabuffet_Load(object sender, EventArgs e)
        {
            this.carga_lista_Buffet();
        }

        private void carga_lista_Buffet()
        {
            try
            {
                dgv_buffet.AutoGenerateColumns = false;
                dgv_buffet.DataSource = obj_buffet.carga_Buffet().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
