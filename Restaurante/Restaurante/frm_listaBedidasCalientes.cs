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
    public partial class frm_listaBedidasCalientes : Form
    {
        Calientes obj_calientes = new Calientes();

        private string _nick;

        public string nick
        {
            get { return _nick; }
            set { _nick = value; }
        }

        public frm_listaBedidasCalientes()
        {
            InitializeComponent();
        }

        private void frm_listaBedidasCalientes_Load(object sender, EventArgs e)
        {
            this.carga_lista_calientes();
        }

        private void b_refrescar_Click(object sender, EventArgs e)
        {
            this.carga_lista_calientes();
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigoBebidaC.Text = "";
            txt_nombreBebidaC.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            obj_calientes.codBebidaCal = null;
            obj_calientes.nombre = null;
            if (txt_codigoBebidaC.Text != "")
            {
                obj_calientes.codBebidaCal = txt_codigoBebidaC.Text;

            }
            else if (txt_nombreBebidaC.Text != "")
            {
                obj_calientes.nombre = txt_nombreBebidaC.Text;
            }

            try
            {
                dgv_bebidas_calientes.AutoGenerateColumns = false;
                dgv_bebidas_calientes.DataSource = obj_calientes.carga_calientes_especificos().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void b_agregar_Click(object sender, EventArgs e)
        {
            frm_bebidasCalientes calientes = new frm_bebidasCalientes();
            calientes.accion = "Insertar";
            calientes.nick = _nick;
            calientes.Show();
        }

        private void b_eliminar_Click(object sender, EventArgs e)
        {
            string codigo = dgv_bebidas_calientes.CurrentRow.Cells[0].Value.ToString().Replace(" ", "");
            obj_calientes.eliminar_Calientes(codigo);
            try
            {
                dgv_bebidas_calientes.AutoGenerateColumns = false;
                dgv_bebidas_calientes.DataSource = obj_calientes.carga_Calientes().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgv_bebidas_calientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_bebidasCalientes calientes = new frm_bebidasCalientes();
            calientes.accion = "Editar";
            calientes.nick = _nick;
            calientes.codigo = dgv_bebidas_calientes.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(" ", "");
            calientes.ShowDialog();
        }

        private void carga_lista_calientes()
        {
            try
            {
                dgv_bebidas_calientes.AutoGenerateColumns = false;
                dgv_bebidas_calientes.DataSource = obj_calientes.carga_Calientes().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
