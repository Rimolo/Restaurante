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
    public partial class frm_listaBebidaHelada : Form
    {
        Heladas obj_heladas = new Heladas();

        private string _nick;

        public string nick
        {
            get { return _nick; }
            set { _nick = value; }
        }

        public frm_listaBebidaHelada()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void b_refrescar_Click(object sender, EventArgs e)
        {
            this.carga_lista_Helada();
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigoBebidaH.Text = "";
            txt_nombreBebidaH.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            obj_heladas.codBebidaHel = null;
            obj_heladas.nombre = null;

            if (txt_codigoBebidaH.Text != "")
            {
                obj_heladas.codBebidaHel = txt_codigoBebidaH.Text;
            }
            else if (txt_nombreBebidaH.Text != "")
            {
                obj_heladas.nombre = txt_nombreBebidaH.Text;
            }           

            try
            {
                dgv_bebidaHelada.AutoGenerateColumns = false;
                dgv_bebidaHelada.DataSource = obj_heladas.carga_Heladas_especificos().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void b_agregar_Click(object sender, EventArgs e)
        {
            frm_bebidasHeladas heladas = new frm_bebidasHeladas();
            heladas.accion = "Insertar";
            heladas.nick = _nick;
            heladas.Show();
        }

        private void b_eliminar_Click(object sender, EventArgs e)
        {
            string codigo = dgv_bebidaHelada.CurrentRow.Cells[0].Value.ToString().Replace(" ", "");
            obj_heladas.eliminar_Heladas(codigo);
            try
            {
                dgv_bebidaHelada.AutoGenerateColumns = false;
                dgv_bebidaHelada.DataSource = obj_heladas.carga_Heladas().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgv_bebidaHelada_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frm_bebidasHeladas heladas = new frm_bebidasHeladas();
                heladas.accion = "Editar";
                heladas.nick = _nick;
                heladas.codigo = dgv_bebidaHelada.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
                heladas.ShowDialog();
            }
        }

        private void carga_lista_Helada()
        {
            try
            {
                dgv_bebidaHelada.AutoGenerateColumns = false;
                dgv_bebidaHelada.DataSource = obj_heladas.carga_Heladas().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frm_listaBebidaHelada_Load(object sender, EventArgs e)
        {
            this.carga_lista_Helada();
        }
    }
}
